﻿using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quokka.Tests
{
	[TestClass]
	public class ModelDefinitionCombiningTests
	{
		[TestMethod]
		public void DefinitionCombining_SingleModel()
		{
			var definition = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{ "Primitive", new PrimitiveModelDefinition(TypeDefinition.Integer) },
				{
					"Composite", new CompositeModelDefinition(
						new Dictionary<string, IModelDefinition>
						{
							{
								"A",
								new PrimitiveModelDefinition(TypeDefinition.Boolean)
							},
							{
								"B",
								new PrimitiveModelDefinition(TypeDefinition.String)
							}
						})
				},
				{
					"Array", new ArrayModelDefinition(new PrimitiveModelDefinition(TypeDefinition.Boolean))
				}
			});

			var combinedDefinition = new DefaultTemplateFactory().CombineModelDefinition(new[] { definition });

			TemplateAssert.AreCompositeModelDefinitionsEqual(
				definition,
				combinedDefinition);
		}

		[TestMethod]
		public void DefinitionCombining_TwoNonIntersecting_Models()
		{
			var definition1 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{ "Primitive1", new PrimitiveModelDefinition(TypeDefinition.Integer) },
				{ "Primitive2", new PrimitiveModelDefinition(TypeDefinition.Decimal) }
			});

			var definition2 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{ "Primitive3", new PrimitiveModelDefinition(TypeDefinition.Integer) },
				{ "Primitive4", new PrimitiveModelDefinition(TypeDefinition.Decimal) }
			});

			var combinedDefinition = new DefaultTemplateFactory().CombineModelDefinition(new[] { definition1, definition2 });

			TemplateAssert.AreCompositeModelDefinitionsEqual(
				new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
				{
					{ "Primitive1", new PrimitiveModelDefinition(TypeDefinition.Integer) },
					{ "Primitive2", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
					{ "Primitive3", new PrimitiveModelDefinition(TypeDefinition.Integer) },
					{ "Primitive4", new PrimitiveModelDefinition(TypeDefinition.Decimal) }
				}),
				combinedDefinition);
		}

		[TestMethod]
		public void DefinitionCombining_TwoNonIntersecting_SubModels()
		{
			var definition1 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{
					"Composite", new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
					{
						{ "A", new PrimitiveModelDefinition(TypeDefinition.Integer) },
						{ "B", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
					})
				}
			});

			var definition2 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{
					"Composite", new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
					{
						{ "C", new PrimitiveModelDefinition(TypeDefinition.Integer) },
						{ "D", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
					})
				}
			});


			var combinedDefinition = new DefaultTemplateFactory().CombineModelDefinition(new[] { definition1, definition2 });

			TemplateAssert.AreCompositeModelDefinitionsEqual(
				new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
				{
					{
						"Composite", new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
						{
							{ "A", new PrimitiveModelDefinition(TypeDefinition.Integer) },
							{ "B", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
							{ "C", new PrimitiveModelDefinition(TypeDefinition.Integer) },
							{ "D", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
						})
					}
				}),
				combinedDefinition);
		}

		[TestMethod]
		public void DefinitionCombining_TwoNonIntersecting_ArrayCompositeModels()
		{
			var definition1 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{
					"Array", new ArrayModelDefinition(
						new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
						{

							{ "A", new PrimitiveModelDefinition(TypeDefinition.Integer) },
							{ "B", new PrimitiveModelDefinition(TypeDefinition.Decimal) }
						}))
				}
			});

			var definition2 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{
					"Array", new ArrayModelDefinition(
						new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
						{

							{ "C", new PrimitiveModelDefinition(TypeDefinition.Integer) },
							{ "D", new PrimitiveModelDefinition(TypeDefinition.Decimal) }
						}))
				}
			});


			var combinedDefinition = new DefaultTemplateFactory().CombineModelDefinition(new[] { definition1, definition2 });

			TemplateAssert.AreCompositeModelDefinitionsEqual(
				new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
				{
					{
						"Array", new ArrayModelDefinition(
							new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
							{

								{ "A", new PrimitiveModelDefinition(TypeDefinition.Integer) },
								{ "B", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
								{ "C", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
								{ "D", new PrimitiveModelDefinition(TypeDefinition.Decimal) }
							}))
					}
				}),
				combinedDefinition);
		}

		[TestMethod]
		public void DefinitionCombining_TwoIntersecting_CompositeSubModels()
		{
			var definition1 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{
					"Composite", new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
					{
						{ "A", new PrimitiveModelDefinition(TypeDefinition.Integer) },
						{ "B", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
					})
				}
			});

			var definition2 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{
					"Composite", new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
					{
						{ "A", new PrimitiveModelDefinition(TypeDefinition.Integer) },
						{ "D", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
					})
				}
			});


			var combinedDefinition = new DefaultTemplateFactory().CombineModelDefinition(new[] { definition1, definition2 });

			TemplateAssert.AreCompositeModelDefinitionsEqual(
				new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
				{
					{
						"Composite", new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
						{
							{ "A", new PrimitiveModelDefinition(TypeDefinition.Integer) },
							{ "B", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
							{ "D", new PrimitiveModelDefinition(TypeDefinition.Decimal) },
						})
					}
				}),
				combinedDefinition);
		}

		[TestMethod]
		public void DefinitionCombining_TwoIntersecting_Models_InconsistentTyping_Errors()
		{
			var definition1 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{ "Primitive1", new PrimitiveModelDefinition(TypeDefinition.Integer) }
			});

			var definition2 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{ "Primitive1", new PrimitiveModelDefinition(TypeDefinition.String) }
			});

			IList<ITemplateError> errors;
			var combinedDefinition =
				new DefaultTemplateFactory().TryCombineModelDefinition(new[] { definition1, definition2 },
					out errors);

			Assert.IsNull(combinedDefinition);
			Assert.IsTrue(errors.Single().Message.Contains("Primitive1"));
		}

		[TestMethod]
		public void DefinitionCombining_TwoIntersecting_Models_CompatibleTypes()
		{
			var definition1 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{ "Primitive1", new PrimitiveModelDefinition(TypeDefinition.Primitive) }
			});

			var definition2 = new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
			{
				{ "Primitive1", new PrimitiveModelDefinition(TypeDefinition.Integer) }
			});
			
			var combinedDefinition = new DefaultTemplateFactory().CombineModelDefinition(new[] { definition1, definition2 });

			TemplateAssert.AreCompositeModelDefinitionsEqual(
				new CompositeModelDefinition(new Dictionary<string, IModelDefinition>
				{
					{ "Primitive1", new PrimitiveModelDefinition(TypeDefinition.Integer) }
				}),
				combinedDefinition);
		}
	}
}
