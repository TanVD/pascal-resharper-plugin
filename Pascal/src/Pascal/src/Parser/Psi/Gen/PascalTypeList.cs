using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalTypeList : PascalAntlrCompositeElement<GPascalParser.TypeListContext>
    {
        public PascalTypeList(GPascalParser.TypeListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.TypeList;
    }
}