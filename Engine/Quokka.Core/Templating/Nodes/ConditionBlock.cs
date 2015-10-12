﻿using System.Text;

namespace Quokka
{
	internal class ConditionBlock : TemplateNodeBase
	{
		private readonly IBooleanExpression conditionExpression;
		private readonly ITemplateNode block;
		
		public ConditionBlock(IBooleanExpression conditionExpression, ITemplateNode block)
		{
			this.block = block;
			this.conditionExpression = conditionExpression;
		}

		public override void CompileVariableDefinitions(SemanticAnalysisContext context)
		{
			conditionExpression.CompileVariableDefinitions(context);
			block?.CompileVariableDefinitions(context);
		}

		public override void Render(StringBuilder resultBuilder, RenderContext context)
		{
			block?.Render(resultBuilder, context);
		}

		public bool ShouldRender(RenderContext renderContext)
		{
			return conditionExpression.Evaluate(renderContext);
		}
	}
}
