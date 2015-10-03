﻿using System.Collections.Generic;
using System.Linq;

namespace Quokka
{
	internal class TemplateBlock : TemplateNodeBase
	{
		private readonly IReadOnlyCollection<ITemplateNode> children;

		public TemplateBlock(IEnumerable<ITemplateNode> children)
		{
			this.children = children
				.ToList()
				.AsReadOnly();
		}

		public override void CompileVariableDefinitions(VariableCollection variableCollection, ISemanticErrorListener errorListener)
		{
			foreach (var child in children)
				child.CompileVariableDefinitions(variableCollection, errorListener);
		}
	}
}
