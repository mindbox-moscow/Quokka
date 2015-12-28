﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Quokka
{
	/// <summary>
	/// The collection of variables of the same level (can represent a collection of root-level variables in the scope
	/// or a member collection of a single composite variable).
	/// </summary>
	internal class VariableCollection
	{
		private readonly Dictionary<string, VariableDefinition> items;

		public VariableCollection()
			: this(new Dictionary<string, VariableDefinition>(StringComparer.InvariantCultureIgnoreCase))
		{
		}

		private VariableCollection(Dictionary<string, VariableDefinition> items)
		{
			this.items = items;
		}

		public ICompositeModelDefinition ToModelDefinition(
			ModelDefinitionFactory modelDefinitionFactory,
			ISemanticErrorListener errorListener)
		{
			return modelDefinitionFactory.CreateComposite(
				new ReadOnlyDictionary<string, IModelDefinition>(
					items
						.ToDictionary(
							kvp => kvp.Key,
							kvp => kvp.Value.ToModelDefinition(modelDefinitionFactory, errorListener),
							StringComparer.InvariantCultureIgnoreCase)));
		}

		public void ValidateAgainstExpectedModelDefinition(
			ICompositeModelDefinition expectedModelDefinition,
			ISemanticErrorListener errorListener)
		{
			if (expectedModelDefinition == null)
				return;

			foreach (var actualItem in items)
			{
				IModelDefinition fieldExpectedDefinition;
				if (expectedModelDefinition.Fields.TryGetValue(actualItem.Key, out fieldExpectedDefinition))
				{
					actualItem.Value.ValidateAgainstExpectedModelDefinition(fieldExpectedDefinition, errorListener);
				}
				else
				{
					errorListener.AddUnexpectedFieldOnCompositeDeclaredTypeError(
						actualItem.Value,
						actualItem.Value.GetFirstLocation());
				}
			}
		}

		public bool CheckIfVariableExists(string variableName)
		{
			return items.ContainsKey(variableName);
		}

		public VariableDefinition CreateDefinitionForVariableDeclaration(
			VariableDeclaration variableDeclaration)
		{
			return CreateOrUpdateVariableDefinition(variableDeclaration, null);
		}

		public VariableDefinition CreateOrUpdateVariableDefinition(VariableOccurence variableOccurence)
		{
			if (variableOccurence is VariableDeclaration)
				throw new ArgumentException("variableOccurence is VariableDeclaration, specific method should be used for declaring variables");

			return CreateOrUpdateVariableDefinition(variableOccurence, null);
		}

		private VariableDefinition CreateOrUpdateVariableDefinition(
			VariableOccurence variableOccurence,
			VariableOccurence ownerVariableOccurence)
		{

			VariableDefinition definition;
			if (!items.TryGetValue(variableOccurence.Name, out definition))
			{
				var fullName = ownerVariableOccurence == null
					? variableOccurence.Name
					: $"{ownerVariableOccurence.Name}.{variableOccurence.Name}";
				definition = new VariableDefinition(variableOccurence.Name, fullName);
				items.Add(variableOccurence.Name, definition);
			}

			definition.AddOccurence(variableOccurence);

			if (variableOccurence.Member != null)
			{
				return definition.Fields.CreateOrUpdateVariableDefinition(
					variableOccurence.Member,
					variableOccurence);
			}

			return definition;
		}

		public VariableDefinition TryGetVariableDefinition(VariableOccurence variableOccurence)
		{
			VariableDefinition definition;
			if (items.TryGetValue(variableOccurence.Name, out definition))
			{
				if (variableOccurence.Member != null)
					return definition.Fields.TryGetVariableDefinition(variableOccurence.Member);

				return definition;
			}

			return null;
		}

		public VariableDefinition TryGetVariableDefinition(string name)
		{
			VariableDefinition definition;
			if (items.TryGetValue(name, out definition))
				return definition;

			return null;
		}

		public static VariableCollection Merge(string ownerFullName, IList<VariableCollection> collections)
		{
			/*
			if (collections.Count == 1)
				return collections.Single();
				*/
			var fields = collections
				.SelectMany(fieldCollection => fieldCollection.items.Values)
				.GroupBy(
					field => field.Name,
					(name, values) => VariableDefinition.Merge(
						name,
						$"{ownerFullName}.{name}",
						values.ToList()),
					StringComparer.InvariantCultureIgnoreCase)
				.ToDictionary(definition => definition.Name, StringComparer.InvariantCultureIgnoreCase);

			return new VariableCollection(fields);
		}
	}
}
