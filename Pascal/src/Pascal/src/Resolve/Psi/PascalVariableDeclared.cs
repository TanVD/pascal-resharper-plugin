using System.Collections.Generic;
using System.Xml;
using Antlr4.Runtime.Misc;
using ICSharpCode.NRefactory;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util.DataStructures;

namespace JetBrains.ReSharper.Plugins.Pascal.Resolve.Psi
{
    public class PascalVariableDeclared : IDeclaredElement
    {
        private readonly PascalVariableDeclaration _declaration;

        public PascalVariableDeclared(PascalVariableDeclaration declaration)
        {
            _declaration = declaration;
        }

        public IPsiServices GetPsiServices() => _declaration.GetPsiServices();

        public IList<IDeclaration> GetDeclarations()
        {
            return new ArrayList<IDeclaration> {_declaration};
        }

        public IList<IDeclaration> GetDeclarationsIn(IPsiSourceFile sourceFile)
        {
            var file = _declaration.GetSourceFile();
            if (file != null && file.Equals(sourceFile))
            {
                return new ArrayList<IDeclaration> {_declaration};
            }

            return EmptyList<IDeclaration>.Instance;
        }

        public DeclaredElementType GetElementType() => CLRDeclaredElementType.FIELD;
        public XmlNode GetXMLDoc(bool inherit) => null;

        public XmlNode GetXMLDescriptionSummary(bool inherit) => null;

        public bool IsValid() => _declaration.IsValid();

        public bool IsSynthetic() => false;

        public HybridCollection<IPsiSourceFile> GetSourceFiles()
        {
            var file = _declaration.GetSourceFile();
            if (file == null)
            {
                return HybridCollection<IPsiSourceFile>.Empty;
            }

            return new HybridCollection<IPsiSourceFile>(file);
        }

        public bool HasDeclarationsIn(IPsiSourceFile sourceFile)
        {
            return sourceFile.Equals(_declaration.GetSourceFile());
        }

        public string ShortName => _declaration.DeclaredName;
        public bool CaseSensitiveName => false;
        public PsiLanguageType PresentationLanguage => PascalLanguage.Instance;
    }
}