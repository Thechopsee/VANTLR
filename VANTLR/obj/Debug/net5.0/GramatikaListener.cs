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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="GramatikaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IGramatikaListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Multiplication</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplication([NotNull] GramatikaParser.MultiplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Multiplication</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplication([NotNull] GramatikaParser.MultiplicationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Addition</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddition([NotNull] GramatikaParser.AdditionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Addition</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddition([NotNull] GramatikaParser.AdditionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOr([NotNull] GramatikaParser.OrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOr([NotNull] GramatikaParser.OrContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegation([NotNull] GramatikaParser.NegationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Negation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegation([NotNull] GramatikaParser.NegationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] GramatikaParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] GramatikaParser.StringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Integer</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInteger([NotNull] GramatikaParser.IntegerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Integer</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInteger([NotNull] GramatikaParser.IntegerContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Assignment</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] GramatikaParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Assignment</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] GramatikaParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] GramatikaParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] GramatikaParser.FloatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesis([NotNull] GramatikaParser.ParenthesisContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesis([NotNull] GramatikaParser.ParenthesisContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Relation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelation([NotNull] GramatikaParser.RelationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Relation</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelation([NotNull] GramatikaParser.RelationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] GramatikaParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] GramatikaParser.IdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd([NotNull] GramatikaParser.AndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd([NotNull] GramatikaParser.AndContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Equality</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquality([NotNull] GramatikaParser.EqualityContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Equality</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquality([NotNull] GramatikaParser.EqualityContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Boolean</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean([NotNull] GramatikaParser.BooleanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Boolean</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean([NotNull] GramatikaParser.BooleanContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMinus([NotNull] GramatikaParser.MinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMinus([NotNull] GramatikaParser.MinusContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Read</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRead([NotNull] GramatikaParser.ReadContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Read</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRead([NotNull] GramatikaParser.ReadContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Write</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWrite([NotNull] GramatikaParser.WriteContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Write</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWrite([NotNull] GramatikaParser.WriteContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Empty</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmpty([NotNull] GramatikaParser.EmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Empty</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmpty([NotNull] GramatikaParser.EmptyContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Expression</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] GramatikaParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Expression</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] GramatikaParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Code_block</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCode_block([NotNull] GramatikaParser.Code_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Code_block</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCode_block([NotNull] GramatikaParser.Code_blockContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Declaration</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] GramatikaParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Declaration</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] GramatikaParser.DeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>While</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile([NotNull] GramatikaParser.WhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>While</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile([NotNull] GramatikaParser.WhileContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>If</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf([NotNull] GramatikaParser.IfContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>If</c>
	/// labeled alternative in <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf([NotNull] GramatikaParser.IfContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatikaParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] GramatikaParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatikaParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] GramatikaParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommand([NotNull] GramatikaParser.CommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatikaParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommand([NotNull] GramatikaParser.CommandContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] GramatikaParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramatikaParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] GramatikaParser.ExprContext context);
}
} // namespace VANTLR