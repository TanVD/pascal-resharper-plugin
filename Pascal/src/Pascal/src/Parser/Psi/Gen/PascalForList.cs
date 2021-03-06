using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalForList : PascalAntlrCompositeElement<GPascalParser.ForListContext>
    {
        public PascalForList(GPascalParser.ForListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ForList;
    }
}