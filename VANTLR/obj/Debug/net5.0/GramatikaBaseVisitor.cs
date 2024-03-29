//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\ValMe\Desktop\VANTLR\VANTLR\Gramatika.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace VANTLR {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGramatikaVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class GramatikaBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IGramatikaVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>Multiplication</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultiplication([NotNull] GramatikaParser.MultiplicationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Addition</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddition([NotNull] GramatikaParser.AdditionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOr([NotNull] GramatikaParser.OrContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNegation([NotNull] GramatikaParser.NegationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitString([NotNull] GramatikaParser.StringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Integer</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInteger([NotNull] GramatikaParser.IntegerContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Assignment</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignment([NotNull] GramatikaParser.AssignmentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloat([NotNull] GramatikaParser.FloatContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParenthesis([NotNull] GramatikaParser.ParenthesisContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Relation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRelation([NotNull] GramatikaParser.RelationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdentifier([NotNull] GramatikaParser.IdentifierContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAnd([NotNull] GramatikaParser.AndContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Equality</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEquality([NotNull] GramatikaParser.EqualityContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Boolean</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolean([NotNull] GramatikaParser.BooleanContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMinus([NotNull] GramatikaParser.MinusContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Read</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRead([NotNull] GramatikaParser.ReadContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Write</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWrite([NotNull] GramatikaParser.WriteContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Empty</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEmpty([NotNull] GramatikaParser.EmptyContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Expression</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpression([NotNull] GramatikaParser.ExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Code_block</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCode_block([NotNull] GramatikaParser.Code_blockContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Declaration</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeclaration([NotNull] GramatikaParser.DeclarationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>While</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWhile([NotNull] GramatikaParser.WhileContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>If</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIf([NotNull] GramatikaParser.IfContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatikaParser.program"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProgram([NotNull] GramatikaParser.ProgramContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatikaParser.command"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCommand([NotNull] GramatikaParser.CommandContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GramatikaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpr([NotNull] GramatikaParser.ExprContext context) { return VisitChildren(context); }
}
} // namespace VANTLR
