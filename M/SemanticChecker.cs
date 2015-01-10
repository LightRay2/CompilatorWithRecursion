using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime.Tree;

namespace MathExpr
{
    public enum IdentType
    {
        Var,
        Param,
        Function
    }

    public enum DataType
    {
        Void,
        Int,
        Double,
        Bool
    }

    public class Ident
    {
        public string Name { get; set; }
        public IdentType IdentType { get; set; }
        public DataType DataType { get; set; }

        public AstNode Node { get; set; }
        public bool IsArray { get; set; }
        public int LeftArrayBound {get;set;}
        public int RightArrayBound {get;set;}
        public Ident(string name, IdentType identType, DataType dataType, AstNode node)
        {
            Name = name;
            IdentType = identType;
            DataType = dataType;
            Node = node;
        }
        public Ident(string name, IdentType identType, DataType dataType, AstNode node, int leftArray, int rightArray)
            :this(name, identType, dataType,node)
        {
            Name = name;
            IdentType = identType;
            DataType = dataType;
            Node = node;
            IsArray=true;
            LeftArrayBound = leftArray;
            RightArrayBound = rightArray;
        }
    }


    public class Context
    {
        private Context parentContext;
        
        private Dictionary<string, Ident> idents = new Dictionary<string, Ident>();

        private List<Context> children;
        public Context(Context parentContext)
        {
            this.parentContext = parentContext;
            this.children = new List<Context>();
            if(parentContext!= null)
                parentContext.children.Add(this);
        }

        public Ident this[string name]
        {
            get
            {
                return idents.ContainsKey(name) ? idents[name] :
                           parentContext != null ? parentContext[name] : null;
            }
            set
            {
                if(!idents.ContainsKey(name))
                    idents.Add(name,value);
                else
                    idents[name] = value;
            }
        }

        private Ident function = null;

        public Ident Function
        {
            get
            {
                return function != null ? function :
                           parentContext != null ? parentContext.Function : null;
            }
            set
            {
                function = value;
            }
        }

        public Context ParentContext
        {
            get
            {
                return parentContext;
            }
        }

        public Context FirstChild { get { return children[0]; } }
        public Context NextSibling { get { return this.parentContext.children[this.parentContext.children.IndexOf(this) + 1]; } }
        public List<Context> Children { get { return this.children; } }
        public Dictionary<string,Ident> IdentDictionary { get { return this.idents; } }
        public Context CurrentChild { get; set; }

        public List<Ident> callFuncList = new List<Ident>();
    }


    public class SemanticChecker
    {
        private static DataType strToDataType(string type)
        {
            switch (type)
            {
                case "integer":
                    return DataType.Int;
                case "double":
                    return DataType.Double;
                case "bool":
                    return DataType.Bool;
                case "void":
                case "":
                    return DataType.Void;
                default:
                    throw new ApplicationException("Invalid data type");
            }
        }

        private static string dataTypeToStr(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Int:
                    return "int";
                case DataType.Double:
                    return "double";
                case DataType.Bool:
                    return "bool";
                case DataType.Void:
                    return "void";
                default:
                    return "unknown";
            }
        }

        private static void convert(AstNode node, DataType dataType)
        {
            AstNode convert = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.CALL, "CONVERT"));
            node.Parent.SetChild(node.ChildIndex, convert);
            convert.DataType = dataType;
            convert.AddChild(node);
            convert.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.IDENT, dataTypeToStr(dataType))));
        }

        static void AddFunctionIdent(AstNode node, Context context)
        {
            string name = node.GetChild(0).Text;
            DataType dataType = strToDataType(node.GetChild(2).Text);
            Ident func = new Ident(name, IdentType.Function, dataType, node);
            context[name] = func;
        }

        public static DataType Check(AstNode node, Context context)
        {
            switch (node.Type)
            {
                #region blocks and vars
                case MathExprLexer.PROGRAM:
                    {
                        //add child funcs idents
                        for (int i = 0; i < node.ChildCount; i++)
                            if (node.GetChild(i).Type == MathExprLexer.FUNCTION)
                                AddFunctionIdent((AstNode)node.GetChild(i), context);
                        //

                        bool thereWasVarDeclaration = false;

                        for (int i = 0; i < node.ChildCount; i++){
                            if(node.GetChild(i).Type == MathExprLexer.VAR_BLOCK){
                                if(thereWasVarDeclaration)
                                    throw new ApplicationException("More then one var declaration");
                                thereWasVarDeclaration=true;
                            }
                            Check((AstNode)node.GetChild(i), context);
                        }
                        return DataType.Void;
                    }
                case MathExprLexer.BLOCK:
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                            Check((AstNode)node.GetChild(i), context);
                        return DataType.Void;
                    }
                case MathExprLexer.VAR_BLOCK:
                    {
                        if (node.ChildCount == 0)
                            throw new ApplicationException("Empty var block");

                        
                        for (int j = 0; j < node.ChildCount; j++)
                        {
                            ITree varNode = node.GetChild(j) ;
                            IdentType identType =   IdentType.Var;
                            if (varNode.Text == "array")
                            {
                                DataType dataType = strToDataType(varNode.GetChild(2).Text);
                                int left = (int)(varNode.GetChild(0) as NumAstNode).Value,
                                    right = (int)(varNode.GetChild(1) as NumAstNode).Value;

                                for (int i = 3; i < varNode.ChildCount; i++)
                                {
                                    string name = varNode.GetChild(i).Text;
                                    
                                    context[name] = new Ident(name, identType, dataType, node, left, right);
                                }
                            }
                            else{
                                DataType dataType = strToDataType(varNode.Text);

                                for (int i = 0; i < varNode.ChildCount; i++)
                                {
                                    string name = varNode.GetChild(i).Text;
                                    context[name] = new Ident(name, identType, dataType,node);
                                }
                            }
                        }
                        return DataType.Void;
                    }
                

               

                #endregion

                #region Вызов переменной, функции, описание функции
                //-------------------------------
                case MathExprLexer.FUNCTION:
                    {
                        
                        string name = node.GetChild(0).Text;
                        DataType dataType = strToDataType(node.GetChild(2).Text);
                        Ident func = context[name];

                        context = new Context(context);
                        AstNode _params = (AstNode)node.GetChild(1);
                        for (int i = 0; i < _params.ChildCount; i++)
                        {
                            DataType paramDataType = strToDataType(_params.GetChild(i).Text);
                            string paramName = _params.GetChild(i).GetChild(0).Text;
                            if (paramDataType == DataType.Void)
                                throw new ApplicationException(string.Format("In function {0} void param {1}", name, paramName));
                            context[paramName] = new Ident(paramName, IdentType.Param, paramDataType, (AstNode)_params.GetChild(i));
                        }
                        context.Function = func;
                        //add child funcs idents
                        for (int i = 3; i < node.ChildCount; i++)
                            if (node.GetChild(i).Type == MathExprLexer.FUNCTION)
                                AddFunctionIdent((AstNode)node.GetChild(i), context);
                        //
                        context["result"] = new Ident("result", IdentType.Var, dataType, node);

                        //the rest children
                        for(int i =3; i < node.ChildCount;i++)
                            Check((AstNode)node.GetChild(i), context);
                        return DataType.Void;
                    }

                case MathExprLexer.CALL:
                    {
                        Ident ident = context[node.GetChild(0).Text];
                        //todo генерация встроенных функций
                        if (ident == null && node.GetChild(0).Text == "write")
                            ident = new Ident("write", IdentType.Function, DataType.Void, node);
                        else
                        {
                            if (ident == null || ident.IdentType != IdentType.Function)
                                throw new ApplicationException("Неизвестная функция");
                            if (!context.callFuncList.Contains(ident)) ;
                                context.callFuncList.Add(ident);
                        }
                        if (node.ChildCount > 1)
                        {
                            AstNode par = (AstNode)node.GetChild(1);
                            for(int i =0; i < par.ChildCount;i++)
                                Check((AstNode)par.GetChild(i), context);
                        }
                        return ident.DataType;
                    }
                case MathExprLexer.IDENT:
                    {
                        //todo как сделать bool в стиле numeric?
                        if (node.Text == "true" ||
                             node.Text == "false")
                            return DataType.Bool;
                        //--
                        //todo в грамматике не работает обращение к массиву
                        Ident ident = context[node.Text];
                        if (ident == null)
                            throw new ApplicationException(string.Format("Unknown identifier {0}", node.Text));
                        if (ident.IdentType == IdentType.Function)
                        {
                            if (ident.DataType == DataType.Void)
                                throw new ApplicationException(string.Format("Function {0} returns void", ident.Name));
                            if (ident.Node.GetChild(1).ChildCount > 0)
                                throw new ApplicationException(string.Format("No params for function {0} call", ident.Name));
                            AstNode call = new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.CALL));
                            call.AddChild(node);
                            call.AddChild(new AstNode(new Antlr.Runtime.CommonToken(MathExprLexer.PARAMS)));
                            node.Parent.SetChild(node.ChildIndex, call);
                            return ident.DataType;
                        }
                        else
                            return ident.DataType;
                    }


                #endregion

                #region operations
                case MathExprLexer.NUMBER:
                    {
                        return (node as NumAstNode).Value.ToString().Contains(".") ? DataType.Double : DataType.Int;
                    }
                case MathExprLexer.ASSIGN:
                    {
                        Ident ident = context[(node.GetChild(0).Text)];
                        if (ident == null)
                            throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
                        if (ident.IdentType == IdentType.Function)
                            throw new ApplicationException(string.Format("Assign to function {0}", node.GetChild(0).Text));
                        DataType rightDataType = Check((AstNode)node.GetChild(1), context);
                        if (ident.DataType != rightDataType)
                        {
                            if (ident.DataType == DataType.Double && rightDataType == DataType.Int)
                                convert((AstNode)node.GetChild(1), DataType.Double);
                            else
                                throw new ApplicationException(string.Format("Assign incopotible types {0} {1}", dataTypeToStr(ident.DataType), dataTypeToStr(rightDataType)));
                        }
                        return DataType.Void;
                    }

                case MathExprLexer.ADD:
                case MathExprLexer.SUB:
                case MathExprLexer.MUL:
                case MathExprLexer.MOD:
                case MathExprLexer.DIV:
                case MathExprLexer.GE:
                case MathExprLexer.LE:
                case MathExprLexer.NEQUALS:
                case MathExprLexer.EQUALS:
                case MathExprLexer.GT:
                case MathExprLexer.LT:
                    {
                        bool compareOperation = true;
                        switch (node.Type)
                        {
                            case MathExprLexer.ADD:
                            case MathExprLexer.SUB:
                            case MathExprLexer.MUL:
                            case MathExprLexer.DIV:
                            case MathExprLexer.MOD:
                                compareOperation = false;
                                break;
                        }

                        DataType leftDataType = Check((AstNode)node.GetChild(0), context);
                        DataType rightDataType = Check((AstNode)node.GetChild(1), context);

                        if (leftDataType == DataType.Void || rightDataType == DataType.Void)
                            throw new ApplicationException("Operands cannot be void");
                        else if (leftDataType == DataType.Bool)
                            if (rightDataType != DataType.Bool)
                                throw new ApplicationException("both operands must be bool");
                            else if (node.Type == MathExprLexer.EQUALS || node.Type == MathExprLexer.NEQUALS)
                                return DataType.Bool;
                            else
                                throw new ApplicationException("This operation cannon be applied to bool types");
                        else if (leftDataType == DataType.Double)
                        {
                            if (rightDataType == DataType.Bool)
                                throw new ApplicationException("both operands must be bool");
                            else
                            {
                                if (rightDataType == DataType.Int)
                                    convert((AstNode)node.GetChild(1), DataType.Double);
                                return compareOperation? DataType.Bool : DataType.Double;
                            }
                        }
                        else //left = int
                        {
                            if (rightDataType == DataType.Bool)
                                throw new ApplicationException("both operands must be bool");
                            else
                            {
                                if (rightDataType == DataType.Double)
                                    convert((AstNode)node.GetChild(0), DataType.Double);

                                return compareOperation ? DataType.Bool : rightDataType;
                            }
                        }
                    }

                case MathExprLexer.NOT:
                    {
                        DataType dataType = Check((AstNode)node.GetChild(0), context);
                        if (dataType != DataType.Bool)
                            throw new ApplicationException(string.Format("Not operator with type {0}", dataTypeToStr(dataType)));
                        return DataType.Bool;
                    }

                case MathExprLexer.AND:
                case MathExprLexer.OR:
                case MathExprLexer.XOR:
                    {
                        DataType leftDataType = Check((AstNode)node.GetChild(0), context);
                        DataType rightDataType = Check((AstNode)node.GetChild(1), context);
                        if (leftDataType != DataType.Bool || rightDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("{0} operator with type {1}, {2}", node.Text, dataTypeToStr(leftDataType), dataTypeToStr(rightDataType)));
                        return DataType.Bool;
                    }

                case MathExprLexer.BIT_AND:
                case MathExprLexer.BIT_OR:
                    {
                        DataType leftDataType = Check((AstNode)node.GetChild(0), context);
                        DataType rightDataType = Check((AstNode)node.GetChild(1), context);
                        if (leftDataType != DataType.Int || rightDataType != DataType.Int)
                            throw new ApplicationException(string.Format("{0} operator with type {1}, {2}", node.Text, dataTypeToStr(leftDataType), dataTypeToStr(rightDataType)));
                        return DataType.Int;
                    }

                #endregion

                #region loops and conditions
                case MathExprLexer.WHILE:
                    {
                        DataType condDataType = Check((AstNode)node.GetChild(0), context);
                        if (condDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("In while condition type is {0}", dataTypeToStr(condDataType)));
                        //context = new Context(context);
                        Check((AstNode)node.GetChild(1), context);
                        return DataType.Void;
                    }
                case MathExprLexer.FOR:
                    {
                        Ident iterator = context[node.GetChild(0).Text];
                        if (iterator == null || iterator.DataType != DataType.Int)
                            throw new ApplicationException("FOR wrong iterator");
                        Check((AstNode)node.GetChild(3), context);
                        return DataType.Void;
                    }
                case MathExprLexer.REPEAT:
                    {
                        DataType condDataType = Check((AstNode)node.GetChild(1), context);
                        if (condDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("In repeat condition type is {0}", dataTypeToStr(condDataType)));
                        Check((AstNode)node.GetChild(0), context);
                        return DataType.Void;
                    }
               

                case MathExprLexer.IF:
                    {
                        DataType condDataType = Check((AstNode)node.GetChild(0), context);
                        if (condDataType != DataType.Bool)
                            throw new ApplicationException(string.Format("In if condition type is {0}", dataTypeToStr(condDataType)));
                        //context = new Context(context);
                        Check((AstNode)node.GetChild(1), context);
                        if (node.ChildCount == 3)
                            Check((AstNode)node.GetChild(2), context);
                        return DataType.Void;
                    }
#endregion
                default:
                    {
                        throw new ApplicationException("Unknown token type");
                    }
                    break;
            }
        }
    }
}
