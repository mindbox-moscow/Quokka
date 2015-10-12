﻿namespace Quokka
{
	internal class SemanticAnalysisContext
	{
		public CompilationVariableScope VariableScope { get; }
		public FunctionRegistry Functions { get; }
		public ISemanticErrorListener ErrorListener { get; }

		public SemanticAnalysisContext(
			CompilationVariableScope variableScope,
			FunctionRegistry functions,
			ISemanticErrorListener errorListener)
		{
			VariableScope = variableScope;
			Functions = functions;
			ErrorListener = errorListener;
		}
	}
}
