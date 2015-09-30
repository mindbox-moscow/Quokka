//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\code\Quokka\Grammar\Quokka\Quokka.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Quokka.Generated {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="QuokkaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface IQuokkaListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.template"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplate([NotNull] QuokkaParser.TemplateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.template"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplate([NotNull] QuokkaParser.TemplateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.templateBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateBlock([NotNull] QuokkaParser.TemplateBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.templateBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateBlock([NotNull] QuokkaParser.TemplateBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.staticBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStaticBlock([NotNull] QuokkaParser.StaticBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.staticBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStaticBlock([NotNull] QuokkaParser.StaticBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.dynamicBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDynamicBlock([NotNull] QuokkaParser.DynamicBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.dynamicBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDynamicBlock([NotNull] QuokkaParser.DynamicBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.constantBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantBlock([NotNull] QuokkaParser.ConstantBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.constantBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantBlock([NotNull] QuokkaParser.ConstantBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.outputInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputInstruction([NotNull] QuokkaParser.OutputInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.outputInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputInstruction([NotNull] QuokkaParser.OutputInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.parameterValueExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterValueExpression([NotNull] QuokkaParser.ParameterValueExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.parameterValueExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterValueExpression([NotNull] QuokkaParser.ParameterValueExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.filteredParameterValueExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilteredParameterValueExpression([NotNull] QuokkaParser.FilteredParameterValueExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.filteredParameterValueExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilteredParameterValueExpression([NotNull] QuokkaParser.FilteredParameterValueExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.filterChain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterChain([NotNull] QuokkaParser.FilterChainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.filterChain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterChain([NotNull] QuokkaParser.FilterChainContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilter([NotNull] QuokkaParser.FilterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilter([NotNull] QuokkaParser.FilterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.filterArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterArgumentList([NotNull] QuokkaParser.FilterArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.filterArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterArgumentList([NotNull] QuokkaParser.FilterArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.filterArgumentValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterArgumentValue([NotNull] QuokkaParser.FilterArgumentValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.filterArgumentValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterArgumentValue([NotNull] QuokkaParser.FilterArgumentValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.parameterExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterExpression([NotNull] QuokkaParser.ParameterExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.parameterExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterExpression([NotNull] QuokkaParser.ParameterExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.parameterMemberExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterMemberExpression([NotNull] QuokkaParser.ParameterMemberExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.parameterMemberExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterMemberExpression([NotNull] QuokkaParser.ParameterMemberExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.memberAccessExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberAccessExpression([NotNull] QuokkaParser.MemberAccessExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.memberAccessExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberAccessExpression([NotNull] QuokkaParser.MemberAccessExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] QuokkaParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] QuokkaParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfCondition([NotNull] QuokkaParser.IfConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfCondition([NotNull] QuokkaParser.IfConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.elseCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseCondition([NotNull] QuokkaParser.ElseConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.elseCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseCondition([NotNull] QuokkaParser.ElseConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.elseIfCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfCondition([NotNull] QuokkaParser.ElseIfConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.elseIfCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfCondition([NotNull] QuokkaParser.ElseIfConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.ifInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfInstruction([NotNull] QuokkaParser.IfInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.ifInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfInstruction([NotNull] QuokkaParser.IfInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.elseIfInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfInstruction([NotNull] QuokkaParser.ElseIfInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.elseIfInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfInstruction([NotNull] QuokkaParser.ElseIfInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.elseInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseInstruction([NotNull] QuokkaParser.ElseInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.elseInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseInstruction([NotNull] QuokkaParser.ElseInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.endIfInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndIfInstruction([NotNull] QuokkaParser.EndIfInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.endIfInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndIfInstruction([NotNull] QuokkaParser.EndIfInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] QuokkaParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] QuokkaParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.forInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForInstruction([NotNull] QuokkaParser.ForInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.forInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForInstruction([NotNull] QuokkaParser.ForInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.iterationVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIterationVariable([NotNull] QuokkaParser.IterationVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.iterationVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIterationVariable([NotNull] QuokkaParser.IterationVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.endForInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndForInstruction([NotNull] QuokkaParser.EndForInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.endForInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndForInstruction([NotNull] QuokkaParser.EndForInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.commentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommentBlock([NotNull] QuokkaParser.CommentBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.commentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommentBlock([NotNull] QuokkaParser.CommentBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.commentInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommentInstruction([NotNull] QuokkaParser.CommentInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.commentInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommentInstruction([NotNull] QuokkaParser.CommentInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.endCommentInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndCommentInstruction([NotNull] QuokkaParser.EndCommentInstructionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.endCommentInstruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndCommentInstruction([NotNull] QuokkaParser.EndCommentInstructionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.booleanExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] QuokkaParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.booleanExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] QuokkaParser.BooleanExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpression([NotNull] QuokkaParser.AndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpression([NotNull] QuokkaParser.AndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.notExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] QuokkaParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.notExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] QuokkaParser.NotExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.booleanAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanAtom([NotNull] QuokkaParser.BooleanAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.booleanAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanAtom([NotNull] QuokkaParser.BooleanAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.arithmeticComparisonExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticComparisonExpression([NotNull] QuokkaParser.ArithmeticComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.arithmeticComparisonExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticComparisonExpression([NotNull] QuokkaParser.ArithmeticComparisonExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.arithmeticExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpression([NotNull] QuokkaParser.ArithmeticExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.arithmeticExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpression([NotNull] QuokkaParser.ArithmeticExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationExpression([NotNull] QuokkaParser.MultiplicationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.multiplicationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationExpression([NotNull] QuokkaParser.MultiplicationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.negationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegationExpression([NotNull] QuokkaParser.NegationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.negationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegationExpression([NotNull] QuokkaParser.NegationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="QuokkaParser.arithmeticAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticAtom([NotNull] QuokkaParser.ArithmeticAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="QuokkaParser.arithmeticAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticAtom([NotNull] QuokkaParser.ArithmeticAtomContext context);
}
} // namespace Quokka.Generated
