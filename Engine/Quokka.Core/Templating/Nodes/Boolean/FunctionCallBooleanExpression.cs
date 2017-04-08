﻿using System;

namespace Mindbox.Quokka
{
	internal class FunctionCallBooleanExpression : BooleanExpressionBase
	{
		private readonly FunctionCall functionCall;

		public FunctionCallBooleanExpression(FunctionCall functionCall)
		{
			this.functionCall = functionCall;
		}

		public override bool Evaluate(RenderContext renderContext)
		{
			return (bool)functionCall.GetInvocationResult(renderContext).GetPrimitiveValue();
		}

		public override void CompileVariableDefinitions(SemanticAnalysisContext context)
		{
			var function = functionCall.TryGetFunctionForSemanticAnalysis(context);
			if (function == null)
				return;

			var functionResultType = TypeDefinition.GetTypeDefinitionFromModelDefinition(function.ReturnValueDefinition);

			if (!functionResultType.IsCompatibleWithRequired(TypeDefinition.Boolean))
			{
				context.ErrorListener.AddInvalidFunctionResultTypeError(
								function.Name,
								TypeDefinition.Boolean,
								functionResultType,
								functionCall.Location);
			}

			functionCall.CompileVariableDefinitions(context);
		}
	}
}
