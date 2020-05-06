using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalExpression : PascalAntlrCompositeElement<GPascalParser.ExpressionContext>
    {
        public PascalExpression(GPascalParser.ExpressionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Expression;
    }
}