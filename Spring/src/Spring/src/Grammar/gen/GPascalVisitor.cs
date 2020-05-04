//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/tanvd/csc/ide/pascal-lang/Spring/src/Spring/src/Grammar/GPascal.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="GPascalParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IGPascalVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] GPascalParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.programHeading"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgramHeading([NotNull] GPascalParser.ProgramHeadingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] GPascalParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] GPascalParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.usesUnitsPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsesUnitsPart([NotNull] GPascalParser.UsesUnitsPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.labelDeclarationPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabelDeclarationPart([NotNull] GPascalParser.LabelDeclarationPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] GPascalParser.LabelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.constantDefinitionPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantDefinitionPart([NotNull] GPascalParser.ConstantDefinitionPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.constantDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantDefinition([NotNull] GPascalParser.ConstantDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.constantChr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantChr([NotNull] GPascalParser.ConstantChrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] GPascalParser.ConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.unsignedNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsignedNumber([NotNull] GPascalParser.UnsignedNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.unsignedInteger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsignedInteger([NotNull] GPascalParser.UnsignedIntegerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.unsignedReal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsignedReal([NotNull] GPascalParser.UnsignedRealContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSign([NotNull] GPascalParser.SignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBool([NotNull] GPascalParser.BoolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] GPascalParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.typeDefinitionPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeDefinitionPart([NotNull] GPascalParser.TypeDefinitionPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.typeDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeDefinition([NotNull] GPascalParser.TypeDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.functionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionType([NotNull] GPascalParser.FunctionTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.procedureType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureType([NotNull] GPascalParser.ProcedureTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] GPascalParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.simpleType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleType([NotNull] GPascalParser.SimpleTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.scalarType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScalarType([NotNull] GPascalParser.ScalarTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.subrangeType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubrangeType([NotNull] GPascalParser.SubrangeTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.typeIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeIdentifier([NotNull] GPascalParser.TypeIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.structuredType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructuredType([NotNull] GPascalParser.StructuredTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.unpackedStructuredType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnpackedStructuredType([NotNull] GPascalParser.UnpackedStructuredTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.stringtype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringtype([NotNull] GPascalParser.StringtypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayType([NotNull] GPascalParser.ArrayTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.typeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeList([NotNull] GPascalParser.TypeListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.indexType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexType([NotNull] GPascalParser.IndexTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.componentType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComponentType([NotNull] GPascalParser.ComponentTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.recordType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecordType([NotNull] GPascalParser.RecordTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.fieldList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldList([NotNull] GPascalParser.FieldListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.fixedPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFixedPart([NotNull] GPascalParser.FixedPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.recordSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecordSection([NotNull] GPascalParser.RecordSectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.variantPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariantPart([NotNull] GPascalParser.VariantPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTag([NotNull] GPascalParser.TagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.variant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariant([NotNull] GPascalParser.VariantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.setType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetType([NotNull] GPascalParser.SetTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.baseType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBaseType([NotNull] GPascalParser.BaseTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.fileType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFileType([NotNull] GPascalParser.FileTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.pointerType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointerType([NotNull] GPascalParser.PointerTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.variableDeclarationPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarationPart([NotNull] GPascalParser.VariableDeclarationPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] GPascalParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.procedureAndFunctionDeclarationPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureAndFunctionDeclarationPart([NotNull] GPascalParser.ProcedureAndFunctionDeclarationPartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.procedureOrFunctionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureOrFunctionDeclaration([NotNull] GPascalParser.ProcedureOrFunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.procedureDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureDeclaration([NotNull] GPascalParser.ProcedureDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameterList([NotNull] GPascalParser.FormalParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.formalParameterSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameterSection([NotNull] GPascalParser.FormalParameterSectionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.parameterGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterGroup([NotNull] GPascalParser.ParameterGroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierList([NotNull] GPascalParser.IdentifierListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.constList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstList([NotNull] GPascalParser.ConstListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclaration([NotNull] GPascalParser.FunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.resultType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResultType([NotNull] GPascalParser.ResultTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] GPascalParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.unlabelledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnlabelledStatement([NotNull] GPascalParser.UnlabelledStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.simpleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleStatement([NotNull] GPascalParser.SimpleStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.assignmentStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentStatement([NotNull] GPascalParser.AssignmentStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] GPascalParser.VariableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] GPascalParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.relationaloperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationaloperator([NotNull] GPascalParser.RelationaloperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.simpleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleExpression([NotNull] GPascalParser.SimpleExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.additiveoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveoperator([NotNull] GPascalParser.AdditiveoperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] GPascalParser.TermContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.multiplicativeoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeoperator([NotNull] GPascalParser.MultiplicativeoperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.signedFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSignedFactor([NotNull] GPascalParser.SignedFactorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] GPascalParser.FactorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.unsignedConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsignedConstant([NotNull] GPascalParser.UnsignedConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.functionDesignator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDesignator([NotNull] GPascalParser.FunctionDesignatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] GPascalParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSet([NotNull] GPascalParser.SetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.elementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementList([NotNull] GPascalParser.ElementListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement([NotNull] GPascalParser.ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.procedureStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureStatement([NotNull] GPascalParser.ProcedureStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.actualParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitActualParameter([NotNull] GPascalParser.ActualParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.parameterwidth"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterwidth([NotNull] GPascalParser.ParameterwidthContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGotoStatement([NotNull] GPascalParser.GotoStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.emptyStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyStatement([NotNull] GPascalParser.EmptyStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.empty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmpty([NotNull] GPascalParser.EmptyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.structuredStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStructuredStatement([NotNull] GPascalParser.StructuredStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundStatement([NotNull] GPascalParser.CompoundStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatements([NotNull] GPascalParser.StatementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.conditionalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalStatement([NotNull] GPascalParser.ConditionalStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] GPascalParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.caseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseStatement([NotNull] GPascalParser.CaseStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.caseListElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCaseListElement([NotNull] GPascalParser.CaseListElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.repetetiveStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepetetiveStatement([NotNull] GPascalParser.RepetetiveStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] GPascalParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.repeatStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatStatement([NotNull] GPascalParser.RepeatStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] GPascalParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.forList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForList([NotNull] GPascalParser.ForListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.initialValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitialValue([NotNull] GPascalParser.InitialValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.finalValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFinalValue([NotNull] GPascalParser.FinalValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.withStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWithStatement([NotNull] GPascalParser.WithStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GPascalParser.recordVariableList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecordVariableList([NotNull] GPascalParser.RecordVariableListContext context);
}
