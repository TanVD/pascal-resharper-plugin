using System;
using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi;
using JetBrains.ReSharper.Plugins.Spring.Utils;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Reference.Psi
{
    public class PascalVariableReference : TreeReferenceBase<PascalVariable>
    {
        private readonly PascalVariable _owner;

        public PascalVariableReference([NotNull] PascalVariable owner) : base(owner)
        {
            _owner = owner;
        }

        public override ResolveResultWithInfo ResolveWithoutCache()
        {
            PLogger.Info("Requested resolve without a cache!");
            var file = _owner.GetContainingFile();
            if (file == null)
            {
                PLogger.Info($"Did not find file for {_owner}");
                return ResolveResultWithInfo.Unresolved;
            }

            foreach (var descendant in file.Descendants())
            {
                if (descendant is PascalVariableDeclaration declaration)
                {
                    PLogger.Info($"FOUND DECLARATION {descendant}. DECLARATION NAME {declaration.DeclaredName}, REFERENCE NAME {GetName()}");
                    if (declaration.DeclaredName == GetName())
                    {
                        return new ResolveResultWithInfo(new SimpleResolveResult(declaration.DeclaredElement), ResolveErrorType.OK);
                    }
                }
            }

            PLogger.Info("Resolve did not succeed!");


            return ResolveResultWithInfo.Unresolved;
        }

        public override string GetName() => _owner.Identifier.Name;

        public override ISymbolTable GetReferenceSymbolTable(bool useReferenceName)
        {
            throw new NotImplementedException();
        }

        public override TreeTextRange GetTreeTextRange() => _owner.Identifier.GetTreeTextRange();

        public override IReference BindTo(IDeclaredElement element)
        {
            ((PascalVariableDeclared) element).References.Add(this);
            return this;
        }

        //TODO-tanvd fix later
        public override IReference BindTo(IDeclaredElement element, ISubstitution substitution) => BindTo(element);

        //TODO check and fix
        public override IAccessContext GetAccessContext() => null;

        public override bool IsValid()
        {
            return myOwner.IsValid();
        }
    }
}