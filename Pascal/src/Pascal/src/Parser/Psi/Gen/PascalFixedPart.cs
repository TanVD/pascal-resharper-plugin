using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFixedPart : PascalAntlrCompositeElement<GPascalParser.FixedPartContext>
    {
        public PascalFixedPart(GPascalParser.FixedPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FixedPart;
    }
}