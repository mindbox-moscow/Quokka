﻿using Mindbox.Quokka.Generated;

namespace Mindbox.Quokka
{
	internal class ConditionsVisitor : QuokkaBaseVisitor<ConditionBlock>
	{
		public ConditionsVisitor(VisitingContext visitingContext)
			: base(visitingContext)
		{
		}

		public override ConditionBlock VisitIfCondition(QuokkaParser.IfConditionContext context)
		{
			return new ConditionBlock(
				context.ifInstruction().booleanExpression().Accept(new BooleanExpressionVisitor(VisitingContext)),
				context.templateBlock()?.Accept(new TemplateVisitor(VisitingContext)));
		}

		public override ConditionBlock VisitElseIfCondition(QuokkaParser.ElseIfConditionContext context)
		{
			return new ConditionBlock(
				context.elseIfInstruction().booleanExpression().Accept(new BooleanExpressionVisitor(VisitingContext)),
				context.templateBlock()?.Accept(new TemplateVisitor(VisitingContext)));
		}

		public override ConditionBlock VisitElseCondition(QuokkaParser.ElseConditionContext context)
		{
			return new ConditionBlock(
				new TrueExpression(),
				context.templateBlock()?.Accept(new TemplateVisitor(VisitingContext)));
		}
	}
}
