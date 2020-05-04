using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Lexer
{
    public class SpringFile : FileElementBase
    {
        public override NodeType NodeType => SpringFileNodeType.Instance;

        public override PsiLanguageType Language => SpringLanguage.Instance;
    }

    public class SpringBlock : CompositeElement
    {
        public override NodeType NodeType => SpringCompositeNodeType.BLOCK;

        public override PsiLanguageType Language => SpringLanguage.Instance;
    }

    public class SpringOther : CompositeElement
    {
        public override NodeType NodeType => SpringCompositeNodeType.OTHER;

        public override PsiLanguageType Language => SpringLanguage.Instance;
    }
}