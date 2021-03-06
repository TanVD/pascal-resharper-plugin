using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalSimpleType : PascalAntlrCompositeElement<GPascalParser.SimpleTypeContext>
    {
        public PascalSimpleType(GPascalParser.SimpleTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SimpleType;
    }
}