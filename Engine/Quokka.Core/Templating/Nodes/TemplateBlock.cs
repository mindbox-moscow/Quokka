﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quokka
{
	internal class TemplateBlock : TemplateNodeBase
	{
		private readonly IReadOnlyCollection<ITemplateNode> children;

		public override bool IsConstant
		{
			get { return children.All(child => child.IsConstant); }
		}

		public TemplateBlock(IEnumerable<ITemplateNode> children)
		{
			this.children = children
				.ToList()
				.AsReadOnly();
		}

		public static TemplateBlock Empty()
		{
			return new TemplateBlock(Enumerable.Empty<ITemplateNode>());
		}

		public override void CompileVariableDefinitions(SemanticAnalysisContext context)
		{
			foreach (var child in children)
				child.CompileVariableDefinitions(context);
		}

		public override void Render(StringBuilder resultBuilder, RenderContext context)
		{
			foreach (var child in children)
				child.Render(resultBuilder, context);
		}

		public override void CompileGrammarSpecificData(GrammarSpecificDataAnalysisContext context)
		{
			foreach (var child in children)
				child.CompileGrammarSpecificData(context);
		}
	}
}
