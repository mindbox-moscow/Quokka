﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Quokka
{
	internal abstract class StringExpression : Expression
	{
		public sealed override TypeDefinition GetResultType(AnalysisContext context)
		{
			return TypeDefinition.String;
		}
	}
}
