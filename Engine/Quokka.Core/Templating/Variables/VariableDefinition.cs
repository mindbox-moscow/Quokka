﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Quokka
{
	/// <summary>
	/// The definition of a variable that we discover from the template - its name, required type, properties etc.
	/// </summary>
	/// <remarks>
	/// This is a highly mutable representation of all the things we know about the variable.
	/// It gradually becomes more and more precise as we go through the tree. Basically, only name 
	/// is guaranteed to remain unchanged. Everything else, including type, is a subject to change
	/// as we get to know more things about variable usages.
	/// </remarks>
	internal class VariableDefinition
	{
		private readonly IList<VariableOccurence> occurences;

		/// <summary>
		/// Variables that are used to iterate over this element if it's a collection
		/// (it'll give us information about fields that we should expect every element of the collection to have).
		/// </summary>
		/// <remarks>Only relevant for collection variables.</remarks>
		private readonly IList<VariableDefinition> collectionElementVariables;

		public string Name { get; }
		public string FullName { get; }
		
		/// <summary>
		/// Own fields of the variable.
		/// </summary>
		/// <remarks>Only relevant for composite variables.</remarks>
		public VariableCollection Fields { get; }
		
		public VariableDefinition(string name, string fullName)
			: this(name, fullName, new VariableCollection(), new List<VariableOccurence>(), new List<VariableDefinition>())
		{
		}

		private VariableDefinition(
			string name,
			string fullName,
			VariableCollection fields,
			IList<VariableOccurence> occurences,
			IList<VariableDefinition> collectionElementVariables)
		{
			Name = name;
			FullName = fullName;
			Fields = fields;
			this.occurences = occurences;
			this.collectionElementVariables = collectionElementVariables;
		}

		public void AddOccurence(VariableOccurence occurence)
		{
			if (!string.Equals(occurence.Name, Name, StringComparison.InvariantCultureIgnoreCase))
				throw new InvalidOperationException("Variable occurence name doesn't match the definition");

			occurences.Add(occurence);
		}

		public void AddCollectionElementVariable(VariableDefinition collectionElementVariable)
		{
			collectionElementVariables.Add(collectionElementVariable);
		}

		public VariableType DetermineType(ISemanticErrorListener errorListener)
		{
			if (!occurences.Any())
				throw new InvalidOperationException("Variable has no occurences");

			if (occurences.Count == 1)
				return occurences.Single().RequiredType;

			var occurencesByTypePriority = occurences
				.OrderByDescending(oc => (int)oc.RequiredType);

			VariableType? resultingType = null;

			foreach (var occurence in occurencesByTypePriority)
			{
				if (resultingType == null)
				{
					resultingType = occurence.RequiredType;
				}
				else
				{
					if (occurence.RequiredType != resultingType)
					{
						if (!IsTypeCompatibleWithAnotherType(occurence.RequiredType, resultingType.Value))
						{
							errorListener.AddInconsistentVariableTypingError(
								this,
								occurence,
								resultingType.Value);
						}
					}
				}
			}

			return resultingType.Value;
		}

		private bool IsTypeCompatibleWithAnotherType(VariableType typeA, VariableType typeB)
		{
			// todo: implement the correct logic
			return typeA == VariableType.Unknown;
		}

		public IParameterDefinition ToParameterDefinition(ISemanticErrorListener errorListener)
		{
			var type = DetermineType(errorListener);
			switch (type)
			{
				case VariableType.Composite:

					return new CompositeParameterDefinition(
						Name,
						Fields.GetParameterDefinitions(errorListener));

				case VariableType.Array:
					if (!collectionElementVariables.Any())
						throw new InvalidOperationException(
							"The variable is of an array type but no collection variables found");

					var collectionElementDefinition = Merge(
						"Element",
						$"{FullName}[]",
						collectionElementVariables.ToList());
					
					return new ArrayParameterDefinition(
						Name,
						collectionElementDefinition.DetermineType(errorListener),
						collectionElementDefinition.Fields.GetParameterDefinitions(errorListener));

				default:
					return new ParameterDefinition(
						Name, 
						type);
			}
		}

		public static VariableDefinition Merge(string resultName, string resultFullName, IList<VariableDefinition> definitions)
		{
			var fields = VariableCollection.Merge(resultFullName, definitions.Select(definition => definition.Fields).ToList());
			var occurences = definitions.SelectMany(definition => definition.occurences);
			var collectionElementVariables = definitions.SelectMany(definition => definition.collectionElementVariables);

			return new VariableDefinition(
				resultName,
				resultFullName,
				fields,
				occurences.ToList(),
				collectionElementVariables.ToList());
		}
	}
}
