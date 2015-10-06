﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quokka
{
	internal class IfBlock : TemplateNodeBase
	{
		private readonly IReadOnlyCollection<ConditionBlock> conditions;

		public IfBlock(IEnumerable<ConditionBlock> conditions)
		{
			this.conditions = conditions.ToList().AsReadOnly();
		}

		public override void CompileVariableDefinitions(Scope scope, ISemanticErrorListener errorListener)
		{
			foreach (var condition in conditions)
				condition.CompileVariableDefinitions(scope, errorListener);
		}

		public override void Render(StringBuilder resultBuilder, VariableValueStorage valueStorage)
		{
			foreach (var condition in conditions)
			{
				if (condition.ShouldRender(valueStorage))
				{
					condition.Render(resultBuilder, valueStorage);
					break;
				}
			}
		}
	}
}
