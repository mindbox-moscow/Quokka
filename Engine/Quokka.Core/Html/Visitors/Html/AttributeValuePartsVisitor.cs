﻿using Quokka.Generated;

namespace Quokka.Html
{
	internal class AttributeValuePartsVisitor : QuokkaHtmlBaseVisitor<ITemplateNode>
	{
		public AttributeValuePartsVisitor(HtmlBlockParsingContext parsingContext)
			: base(parsingContext)
		{
		}

		public override ITemplateNode VisitInsideAttributeConstant(QuokkaHtml.InsideAttributeConstantContext context)
		{
			var text = context.GetText();
			return new ConstantBlock(text, context.Start.StartIndex, text.Length);
		}

		public override ITemplateNode VisitInsideAttributeOutputBlock(QuokkaHtml.InsideAttributeOutputBlockContext context)
		{
			int offset = context.Start.StartIndex;
			return parsingContext.PreparsedOutputBlockNodes[offset];
		}
	}
}
