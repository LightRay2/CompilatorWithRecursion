using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

using Antlr.Runtime.Tree;

using AstNodeType = MathExpr.MathExprParser;


namespace MathExpr
{
    public class MSILGenerator
    {
        const string PROGRAM_FUNC_NAME = "Program";

        private ITree programNode = null;
        private Dictionary<Ident, int> vars = new Dictionary<Ident, int>();
        private int labIndex = 0;


        public MSILGenerator(ITree programNode)
        {
            if (programNode.Type != AstNodeType.PROGRAM)
                throw new ApplicationException("AST-дерево не является программой");

            this.programNode = programNode;
        }


        //------------------------------------------------------------------------
        //------------------------------------------------------------
        private class RecParams
        {
            public Context context;
            public FuncInfo funcInfo;
            public StringBuilder sb;
            public RecParams Clone()
            {
                return new RecParams() { context = context, funcInfo = funcInfo, sb = sb };
            }
        }

        #region Создание классов для каждой из функций
        class FuncInfo
        {
            public Context context;
            public List<Ident> outerFuncs = new List<Ident>(); //список внешних(родительских) функций, произвольный порядок
            public List<Ident> localVars = new List<Ident>(); //локальные переменные
            public List<Ident> callList = new List<Ident>(); //то, что вызывается в теле функции
            public List<Ident> args = new List<Ident>(); //аргументы
            public string className, variableName; //в формате Outer_Inner Outer_Inner_func
        }

        Dictionary<Ident, FuncInfo> funcInfoDict = new Dictionary<Ident, FuncInfo>();

        void GatherFuncInfo(Context context)
        {

            FuncInfo f = new FuncInfo();
            f.context = context;
            //
            Context current = context.ParentContext;
            while (current != null)  //поднимаемся вверх
            {
                f.outerFuncs.Add(current.Function);
                current = current.ParentContext;
            }
            f.outerFuncs.Reverse();

            f.callList = context.callFuncList;
            //
            foreach (var ident in context.IdentDictionary.Values)
            {
                /*if (ident.IdentType == IdentType.Function && !f.callList.Contains(ident)) //only unique
                    f.callList.Add(ident);
                else */
                if (ident.IdentType == IdentType.Param)
                {
                    f.args.Add(ident);
                }
                else if (ident.IdentType == IdentType.Var && !f.localVars.Contains(ident))//only unique
                {
                    f.localVars.Add(ident);
                }
            }
            //еще можно вызывать методы из родительского контекста
            /*if (context.ParentContext != null)
                foreach (var ident in context.ParentContext.IdentDictionary.Values)
                {
                    if (ident.IdentType == IdentType.Function && !f.callList.Contains(ident)) //only unique
                        f.callList.Add(ident);
                }*/

            //тут разветвление для function и program

            f.className = String.Join("_", f.outerFuncs.Select(x => x.Name)) +
                (context.Function == null ? PROGRAM_FUNC_NAME : context.Function.Name);
            f.variableName = f.className + "_func";

            if (context.Function == null)
                context.Function = new Ident(PROGRAM_FUNC_NAME, IdentType.Function, DataType.Void, (AstNode)programNode);
            funcInfoDict.Add(context.Function, f);


            //рекурсия
            foreach (var child in context.Children)
                GatherFuncInfo(child);
        }

        List<string> GenerateFunctions()
        {
            List<string> res = new List<string>();

            foreach (var func in funcInfoDict)
            {
                Ident ident = func.Key; FuncInfo info = func.Value;
                StringBuilder sb = new StringBuilder();

                //класс будет состоять из конструктора, заполняющего все его внешние контексты, 
                // метода Execute с необходимыми аргументами
                //поля класса - внешние функции-классы(public), локальные переменные(public)
                //locals - переменные классов-функций, которые вызываются внутри метода


                //0 start
                sb.AppendLine(String.Format(@".class private auto ansi beforefieldinit {0}
       extends [mscorlib]System.Object
{{", info.className));
                //1 fields
                //.field private class Name instance //example
                foreach (Ident outerIdent in info.outerFuncs)
                {
                    FuncInfo outerInfo = funcInfoDict[outerIdent];
                    sb.AppendLine(String.Format(".field private class {0} {1}", outerInfo.className, outerInfo.variableName));
                }
                foreach (Ident localVar in info.localVars)
                {
                    //todo пока только инты
                    sb.AppendLine(String.Format(".field public int32 {0}", localVar.Name));
                }

                //2 constructor
                var outerInfos = new List<FuncInfo>(info.outerFuncs.Select(x => funcInfoDict[x]));

                List<string> constructorParams = new List<string>();
                foreach (FuncInfo outerInfo in outerInfos)
                    constructorParams.Add("class " + outerInfo.className + " " + outerInfo.variableName);

                sb.AppendLine(String.Format(@".method public hidebysig specialname rtspecialname 
                        instance void  .ctor({0}) cil managed
                    {{", String.Join(",", constructorParams)));

                sb.AppendLine(".maxstack  16");

                sb.AppendLine("ldarg.0  \n   call    instance void [mscorlib]System.Object::.ctor()\n");

                for (int i = 0; i < outerInfos.Count; i++)
                {
                    sb.AppendLine(String.Format(@"ldarg.0   
                        ldarg.{0}  
                        stfld     class {1} {2}::{3}", i + 1, outerInfos[i].className, info.className, outerInfos[i].variableName));
                }

                sb.AppendLine("ret");
                sb.AppendLine("}");
                sb.AppendLine("");

                //3 method Execute
                //.method public hidebysig specialname instance int32
                //get_Number() cil managed --- example
                sb.AppendLine(String.Format(@".method public hidebysig specialname instance {1}
        Execute({0}) cil managed
{{", String.Join(",", info.args.Select(x => "int32 " + x.Name)), ident.DataType == DataType.Void ? "void" : "int32"));
                sb.AppendLine(".maxstack  16");
                //locals
                //.locals ([0] class className instance) --- example
                sb.AppendLine(".locals (");
                for (int i = 0; i < info.callList.Count; i++)
                {
                    FuncInfo call = funcInfoDict[info.callList[i]];
                    sb.AppendLine(String.Format("[{0}] class {1} {2}_local{3}", i, call.className, call.variableName, i == info.callList.Count - 1 ? "" : ",")); //приписка local к имени - чтобы не совпадало с именем поля 
                }
                sb.AppendLine(")");//locals

                Generate(ident.Node, new RecParams() { context = info.context, funcInfo = info, sb = sb });

                if (ident.DataType != DataType.Void)
                    sb.AppendLine(String.Format("ldarg.0\nldfld int32 {0}::result", info.className));
                sb.AppendLine("ret \n }"); //execute

                sb.AppendLine("}"); //class 

                res.Add(sb.ToString());
            }

            return res;
        }

        #endregion

        #region Код вызова функции, код записи и чтения в переменную
        string CallFunctionFromContext(Ident funcIdent, Context context, string parametersGenerationCode)
        {
            StringBuilder sb = new StringBuilder();

            FuncInfo to = funcInfoDict[funcIdent],
                from = funcInfoDict[funcInfoDict.Where(x => x.Value.context == context).First().Key];

            bool inDepth = to.outerFuncs.Count > from.outerFuncs.Count; //идем ли в глубину

            //создаем экземпляр класса функции и передаем в конструктор ссылки на внешние классы-функции
            //ldc.i4.1                 
            // ldstr      "Sample"             
            // newobj     instance void SampleClass::.ctor(int32, string)
            // stloc.0                         // example
            int outerFuncFromCount = inDepth ? from.outerFuncs.Count : to.outerFuncs.Count;

            for (int i = 0; i < outerFuncFromCount; i++)
                sb.AppendLine(String.Format("ldarg.0 \n ldfld  class {0} {1}::{2}",
                    funcInfoDict[from.outerFuncs[i]].className,
                    from.className,
                    funcInfoDict[from.outerFuncs[i]].variableName));
            if (inDepth)
                sb.AppendLine("ldarg.0"); //последним параметром передаем себя

            string constructorSignature = String.Join(",", to.outerFuncs.Select(x => "class " + funcInfoDict[x].className));
            sb.AppendLine(String.Format("newobj     instance void {0}::.ctor({1})", to.className, constructorSignature));

            //сейчас на вершине стека лежит экземпляр класса вызываемой функции. Сохраним его и вызовем его метод Execute
            int localVarNumber = from.callList.IndexOf(funcIdent);
            sb.AppendLine(String.Format("stloc.{0}", localVarNumber));
            sb.AppendLine(String.Format("ldloc.{0}", localVarNumber));
            sb.AppendLine(parametersGenerationCode);

            //call   instance int32 SampleClass::get_Number()
            sb.AppendLine(String.Format("call instance int32 {0}::Execute({1})", to.className, String.Join(",", to.args.Select(x => "int32 "))));
            return sb.ToString();
        }

        string LoadVariable(Ident varIdent, FuncInfo funcInfo)
        {
            string res = "";
            //тут 3 варианта - переменная является параметром функции, находится в нашем контексте или в чужом контексте
            //(глобальные переменные находятся в контексте Program, т е попадают под 3 вариант)
            if (varIdent.IdentType == IdentType.Param)
            {
                res = "ldarg." + (funcInfo.args.IndexOf(varIdent) + 1).ToString();
            }
            else
            {
                string className;
                if (funcInfo.context.IdentDictionary.Values.Contains(varIdent))
                {
                    className = funcInfo.className;
                    res = "ldarg.0\n";
                }
                else
                {
                    Ident outerFunc = funcInfo.outerFuncs.First(x => funcInfoDict[x].context.IdentDictionary.Values.Contains(varIdent));
                    className = funcInfoDict[outerFunc].className;
                    string classVar = funcInfoDict[outerFunc].variableName;
                    res = "  ldarg.0\n  ldfld class " + className + " " + funcInfo.className + "::" + classVar + "\n";
                }
                res += "ldfld int32 " + className + "::" + varIdent.Name;
            }
            return res;
        }

        string StoreVariable(Ident varIdent, FuncInfo funcInfo, string storeValueGeneratedCode)
        {
            string res = "";
            //тут 3 варианта - переменная является параметром функции, находится в нашем контексте или в чужом контексте
            //(глобальные переменные находятся в контексте Program, т е попадают под 3 вариант)
            if (varIdent.IdentType == IdentType.Param)
            {
                res += storeValueGeneratedCode;
                res += "starg " + (funcInfo.args.IndexOf(varIdent) + 1).ToString();
            }
            else
            {
                string className;
                if (funcInfo.context.IdentDictionary.Values.Contains(varIdent))
                {
                    className = funcInfo.className;
                    res = "ldarg.0\n";
                }
                else
                {
                    Ident outerFunc = funcInfo.outerFuncs.First(x => funcInfoDict[x].context.IdentDictionary.Values.Contains(varIdent));
                    className = funcInfoDict[outerFunc].className;
                    string classVar = funcInfoDict[outerFunc].variableName;
                    res = "  ldarg.0\n  ldfld class " + className + " " + funcInfo.className + "::" + classVar + "\n";
                }
                res += storeValueGeneratedCode;
                res += "stfld int32 " + className + "::" + varIdent.Name;
            }
            return res;
        }
        #endregion

        //\\\--------------------------------------------------------------------------------
        //\\\--------------------------------------------------------------------------------

        private void Generate(ITree node, RecParams p)
        {
            int tempLabIndex;

            switch (node.Type)
            {
                #region blocks, call, vars
                case AstNodeType.BLOCK:
                case AstNodeType.PROGRAM:
                    for (int i = 0; i < node.ChildCount; i++)
                        Generate(node.GetChild(i), p);
                    break;
                case AstNodeType.FUNCTION:
                    if (p.context.Function.Node == node) //т е мы зайдем сюда только, когда только что вызвали Generate
                    {
                        for (int i = 3; i < node.ChildCount; i++)
                            Generate(node.GetChild(i), p);
                    }
                    break;

                case AstNodeType.PARAMS:
                    for (int i = 0; i < node.ChildCount; i++)
                        Generate(node.GetChild(i), p);
                    break;


                case AstNodeType.IDENT:
                    //если долшли сюда, то это загрузка переменной (присваивание перехватилось бы в .EQUALS
                    p.sb.AppendLine(LoadVariable(p.context[node.Text], p.funcInfo));
                    break;
                case AstNodeType.CALL:
                    if (node.GetChild(0).Text == "write")
                    {
                        Generate(node.GetChild(1), p);
                        //todo как красиво сделать вывод double и bool
                        p.sb.Append(string.Format("    call void [mscorlib]System.Console::WriteLine(int32)\n"));
                    }
                    else
                    {
                        //сначала сгенерируем код для параметров, затем передадим его в метод
                        RecParams forArgs = p.Clone();
                        forArgs.sb = new StringBuilder();
                        Generate(node.GetChild(1), forArgs);
                        p.sb.AppendLine(CallFunctionFromContext(p.context[node.GetChild(0).Text], p.context, forArgs.sb.ToString()));
                    }
                    break;
                #endregion
                //---------------------------------------------------

                #region Operations
                case AstNodeType.NUMBER:
                    p.sb.Append(string.Format("    ldc.i4.s {0}\n", (int)((NumAstNode)node).Value));
                    break;

                case AstNodeType.ASSIGN:

                    //сначала сгенерируем код для значения, затем передадим его в метод
                    RecParams forValue = p.Clone();
                    forValue.sb = new StringBuilder();
                    Generate(node.GetChild(1), forValue);
                    p.sb.AppendLine(StoreVariable(p.context[node.GetChild(0).Text], p.funcInfo, forValue.sb.ToString()));
                    break;

                case AstNodeType.NOT:
                    Generate(node.GetChild(0), p);
                    p.sb.Append(string.Format("    {0}\n", "not"));
                    break;
                case AstNodeType.ADD:
                case AstNodeType.SUB:
                case AstNodeType.MUL:
                case AstNodeType.DIV:
                case AstNodeType.BIT_OR:
                case AstNodeType.BIT_AND:
                case AstNodeType.AND:
                case AstNodeType.OR:
                case AstNodeType.XOR:
                    string oper = node.Type == AstNodeType.ADD ? "add" :
                                  node.Type == AstNodeType.SUB ? "sub" :
                                  node.Type == AstNodeType.MUL ? "mul" :
                                  node.Type == AstNodeType.DIV ? "div" :
                                  node.Type == AstNodeType.BIT_AND ? "and" :
                                  node.Type == AstNodeType.BIT_OR ? "or" :
                                  node.Type == AstNodeType.AND ? "and" :
                                  node.Type == AstNodeType.OR ? "or" :
                                  node.Type == AstNodeType.XOR ? "xor" :
                                  "unknown";

                    Generate(node.GetChild(0), p);
                    Generate(node.GetChild(1), p);
                    p.sb.Append(string.Format("    {0}\n", oper));
                    break;

                case AstNodeType.GE:
                case AstNodeType.LE:
                case AstNodeType.EQUALS:
                case AstNodeType.NEQUALS:
                case AstNodeType.LT:
                case AstNodeType.GT:
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    Generate(node.GetChild(0), p);
                    Generate(node.GetChild(1), p);

                    //выбираем противоположные оператор, т к первой идет ветка с true, а прыгать нужно на вторую
                    string brunchType = node.Type == AstNodeType.GT ? "ble" :
                                  node.Type == AstNodeType.LT ? "bge" :
                                  node.Type == AstNodeType.GE ? "blt" :
                                  node.Type == AstNodeType.LE ? "bgt" :
                                  node.Type == AstNodeType.EQUALS ? "bne.un" :
                                  node.Type == AstNodeType.NEQUALS ? "beq" :
                                  "unknown";

                    p.sb.Append(string.Format("    {1}.s L_{0:X4}\n", tempLabIndex + 1, brunchType)); //goto false line
                    p.sb.Append(string.Format("    ldc.i4.s {0}\n", 1));
                    p.sb.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 2));

                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    p.sb.Append(string.Format("    ldc.i4.s {0}\n", 0));
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));

                    break;

                #endregion

                //--------------------------------------------------

                #region loops and conditions
                case AstNodeType.IF:
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    Generate(node.GetChild(0), p);
                    p.sb.Append(string.Format("    brfalse.s L_{0:X4}\n", tempLabIndex + 1));
                    Generate(node.GetChild(1), p);
                    p.sb.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 2));
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    if (node.ChildCount > 2)
                        Generate(node.GetChild(2), p);
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));
                    break;

                case AstNodeType.WHILE:
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    Generate(node.GetChild(0), p);
                    p.sb.Append(string.Format("    brfalse.s L_{0:X4}\n", tempLabIndex + 2));
                    Generate(node.GetChild(1), p);
                    p.sb.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 1));
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));
                    break;

                case AstNodeType.REPEAT:
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    Generate(node.GetChild(0), p);
                    Generate(node.GetChild(1), p);
                    p.sb.Append(string.Format("    brinst.s L_{0:X4}\n", tempLabIndex + 2));
                    p.sb.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 1));
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));
                    break;

                case AstNodeType.FOR:
                    throw new NotImplementedException(); //todo присваивание поменять на новое
                    tempLabIndex = labIndex;
                    labIndex += 2;
                    Generate(node.GetChild(1), p);
                    p.sb.Append(string.Format("    stloc.s {0}\n", vars[p.context[node.GetChild(0).Text]]));
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 1));
                    p.sb.Append(string.Format("    ldloc.s {0}\n", vars[p.context[node.GetChild(0).Text]]));
                    Generate(node.GetChild(2), p);
                    p.sb.Append(string.Format("    sub\n"));
                    p.sb.Append(string.Format("    ldc.i4.s {0}\n", 1));
                    p.sb.Append(string.Format("    sub\n"));
                    p.sb.Append(string.Format("    brfalse.s L_{0:X4}\n", tempLabIndex + 2));
                    Generate(node.GetChild(3), p);
                    p.sb.Append(string.Format("    ldloc.s {0}\n", vars[p.context[node.GetChild(0).Text]]));
                    p.sb.Append(string.Format("    ldc.i4.s {0}\n", 1));
                    p.sb.Append(string.Format("    add\n"));
                    p.sb.Append(string.Format("    stloc.s {0}\n", vars[p.context[node.GetChild(0).Text]]));
                    p.sb.Append(string.Format("    br.s L_{0:X4}\n", tempLabIndex + 1));
                    p.sb.Append(string.Format("  L_{0:X4}:\n", tempLabIndex + 2));
                    break;
                #endregion


                default:
                    break; //todo но лучше выкидывать ексепшн
            }
        }


        private void Generate(Context globalContext)
        {
            StringBuilder msil = new StringBuilder();
            labIndex = 0;

            msil.AppendLine(@"
.assembly program
{
}");
            GatherFuncInfo(globalContext);
            List<string> funcClasses = GenerateFunctions();
            foreach (string funcClass in funcClasses)
                msil.AppendLine(funcClass);

            msil.AppendLine(String.Format(@"
.class private auto ansi beforefieldinit PROGRAM
       extends [mscorlib]System.Object
{{


    .method public hidebysig specialname rtspecialname 
        instance void  .ctor() cil managed
    {{
        .maxstack  8
        ldarg.0
        call       instance void [mscorlib]System.Object::.ctor()
        ret
    }}


  .method private hidebysig static void  Main(string[] args)
            cil managed
    {{
    .entrypoint

        .custom instance void [mscorlib]System.
                STAThreadAttribute::.ctor() = ( 01 00 00 00 )

    .locals ([0] class {0} p)
 newobj     instance void {0}::.ctor()
        stloc.0                         // store to variable 0
        ldloc.0
        call   instance void {0}::Execute()
ret
}}
}}
", PROGRAM_FUNC_NAME));

            /*
            if (vars.Count > 0) //double bool array
            {
                msil.Append("    .locals init (\n");
                string arrayCreation = "";
                int index = 0;
                foreach (var kv in vars)
                {
                    string varType = kv.Key.DataType == DataType.Int || kv.Key.DataType == DataType.Bool ? "int32" : "float64";
                    if (kv.Key.IsArray)
                    {
                        arrayCreation += String.Format("ldc.i4.{0}\n", kv.Key.RightArrayBound - kv.Key.LeftArrayBound+1) + //размерность
                            String.Format("newarr     [mscorlib]System.{0}\n", varType == "int32"? "Int32" : "Double") + //создаем
                            String.Format("stloc.{0}\n", index); //сохраняем в переменную
                        varType += "[]";
                    }
                    msil.Append(string.Format("      [{0}] {3} {1}{2}\n", kv.Value, kv.Key.Name, ++index < vars.Count ? "," : "", varType));
                }
                msil.Append("    )\n");
                msil.Append(arrayCreation); //создание массивов
            }
            RecParams p = new RecParams();
            p.context = globalContext;
            Generate(programNode, p);
            msil.Append(string.Format("    ret"));
            msil.Append(@"
  }
}
");*/
        }

        //1 context теперь передаем
        public static string GenerateMSIL(ITree programNode, Context globalContext)
        {

            MSILGenerator g = new MSILGenerator(programNode);
            //g.vars = new Dictionary<Ident, int>();
            //g.NumVariables(globalContext);
            g.Generate(globalContext);
            return g.msil.ToString();
        }
    }
}
