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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGramatikaListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class GramatikaBaseListener : IGramatikaListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Multiplication</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplication([NotNull] GramatikaParser.MultiplicationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Multiplication</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplication([NotNull] GramatikaParser.MultiplicationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Addition</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddition([NotNull] GramatikaParser.AdditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Addition</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddition([NotNull] GramatikaParser.AdditionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOr([NotNull] GramatikaParser.OrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOr([NotNull] GramatikaParser.OrContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNegation([NotNull] GramatikaParser.NegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNegation([NotNull] GramatikaParser.NegationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] GramatikaParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] GramatikaParser.StringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Integer</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInteger([NotNull] GramatikaParser.IntegerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Integer</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInteger([NotNull] GramatikaParser.IntegerContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Assignment</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] GramatikaParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Assignment</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] GramatikaParser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloat([NotNull] GramatikaParser.FloatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloat([NotNull] GramatikaParser.FloatContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesis([NotNull] GramatikaParser.ParenthesisContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesis([NotNull] GramatikaParser.ParenthesisContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Relation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelation([NotNull] GramatikaParser.RelationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Relation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelation([NotNull] GramatikaParser.RelationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] GramatikaParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] GramatikaParser.IdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd([NotNull] GramatikaParser.AndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd([NotNull] GramatikaParser.AndContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Equality</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquality([NotNull] GramatikaParser.EqualityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Equality</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquality([NotNull] GramatikaParser.EqualityContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Boolean</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolean([NotNull] GramatikaParser.BooleanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Boolean</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolean([NotNull] GramatikaParser.BooleanContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMinus([NotNull] GramatikaParser.MinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMinus([NotNull] GramatikaParser.MinusContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Read</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRead([NotNull] GramatikaParser.ReadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Read</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRead([NotNull] GramatikaParser.ReadContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Write</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWrite([NotNull] GramatikaParser.WriteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Write</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWrite([NotNull] GramatikaParser.WriteContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Empty</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmpty([NotNull] GramatikaParser.EmptyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Empty</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmpty([NotNull] GramatikaParser.EmptyContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Expression</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] GramatikaParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Expression</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] GramatikaParser.ExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Code_block</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCode_block([NotNull] GramatikaParser.Code_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Code_block</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCode_block([NotNull] GramatikaParser.Code_blockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Declaration</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] GramatikaParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Declaration</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] GramatikaParser.DeclarationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>While</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile([NotNull] GramatikaParser.WhileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>While</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile([NotNull] GramatikaParser.WhileContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>If</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf([NotNull] GramatikaParser.IfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>If</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf([NotNull] GramatikaParser.IfContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatikaParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] GramatikaParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatikaParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] GramatikaParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommand([NotNull] GramatikaParser.CommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatikaParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommand([NotNull] GramatikaParser.CommandContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] GramatikaParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatikaParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] GramatikaParser.ExprContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace VANTLR
