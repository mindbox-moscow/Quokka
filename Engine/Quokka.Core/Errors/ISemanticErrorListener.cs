using System;

namespace Quokka
{
	internal interface ISemanticErrorListener : IErrorListener
	{
		void AddInconsistentVariableTypingError(
			VariableDefinition definition,
			VariableOccurence faultyOccurence,
			TypeDefinition correctType);

		void AddUndefinedFunctionError(
			string functionName,
			Location location);

		void AddInvalidFunctionArgumentValueError(
			string functionName,
			string argumentName,
			string message,
			Location location);

		void AddInvalidFunctionResultTypeError(
			string functionName,
			TypeDefinition expectedType,
			TypeDefinition realType,
			Location location);
	}
}