using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathExpr
{
  public class Program
  {
    // "�������������������" ������ ��� ����� (� ������������ ������)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


    public static void Main(string[] args) {
        try
        {
            // � ����������� �� ������� ���������� ��������� ������ ���������
            // ���� ���� � ������, ���������� ������ ����������, ���� ����������� ����
            //ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
            //                                     : (ICharStream)new ANTLRFileStream("sample.txt");
            
            ICharStream input = (ICharStream)new ANTLRFileStream("sample.txt");
            MathExprLexer lexer = new MathExprLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            MathExprParser parser = new MathExprParser(tokens);
            parser.TreeAdaptor = new AstNodeTreeAdapter();
            ITree program = (ITree)parser.execute().Tree;
            //AstNodePrinter.Print(program);
            Console.WriteLine();

            Context context = new Context(null);
            SemanticChecker.Check((AstNode)program, context);

            AstNodePrinter.Print(program);

            string msil = MSILGenerator.GenerateMSIL(program, context);
            Console.WriteLine(msil);

            
#if DEBUG
            Console.ReadLine();
#endif
        }
        catch (NotImplementedException e) //todo ������� �� �����
        {
            Console.WriteLine("Error: {0}", e);
            Console.ReadLine();
        }
    }
  }
}
