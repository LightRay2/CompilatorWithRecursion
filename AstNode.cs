using System.Collections.Generic;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathExpr
{
  public class AstNode: CommonTree
  {
    public AstNode()
      : base() {
    }

    public AstNode(IToken t)
      : base(t) {
    }

    public AstNode(CommonTree node)
      : base(node) {
    }

    public DataType DataType { get; set; }

   
  }
  public class AstNodeTreeAdapter : CommonTreeAdaptor
  {
      public override object Create(IToken payload)
      {
          return new AstNode(payload);
      }
  }
}
