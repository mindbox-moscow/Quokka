﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.Quokka.Html
{
	internal class HtmlTemplate : Template, IHtmlTemplate
	{
		internal HtmlTemplate(
			string templateText,
			FunctionRegistry functionRegistry,
			bool throwIfErrorsEncountered = true)
			: base(
				templateText,
				functionRegistry,
				throwIfErrorsEncountered,
				context => new HtmlStaticBlockVisitor(context),
				new[] { new HtmlSemanticErrorSubListener() })
		{
		}

		public HtmlTemplate(string templateText)
			: this(
				templateText,
				new FunctionRegistry(GetStandardFunctions()))
		{
		}

		/// <summary>
		/// Get a collection of external references (links) ordered from top to bottom.
		/// </summary>
		public IReadOnlyList<Reference> GetReferences()
		{
			if (Errors.Any())
				throw new TemplateContainsErrorsException(Errors);

			var htmlContext = new HtmlDataAnalysisContext();
			CompileGrammarSpecificData(htmlContext);

			return htmlContext.GetReferences();
		}

		public override string Render(ICompositeModelValue model, CallContextContainer callContextContainer = null)
		{
			var effectiveCallContextContainer = callContextContainer ?? CallContextContainer.Empty;

			return DoRender(
				model,
				(scope, functionRegistry) => new HtmlRenderContext(
					scope,
					functionRegistry,
					null,
					null,
					effectiveCallContextContainer));
		}

		public string Render(
			ICompositeModelValue model,
			Func<Guid, string, string> redirectLinkProcessor,
			string identificationCode = null,
			CallContextContainer callContextContainer = null)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			var effectiveCallContextContainer = callContextContainer ?? CallContextContainer.Empty;

			return DoRender(
				model,
				(scope, functionRegistry) => new HtmlRenderContext(
					scope,
					functionRegistry,
					redirectLinkProcessor,
					identificationCode,
					effectiveCallContextContainer));
		}
	}
}