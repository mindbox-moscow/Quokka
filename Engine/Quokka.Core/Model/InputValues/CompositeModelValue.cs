using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.Quokka
{
	public class CompositeModelValue : ICompositeModelValue
	{
		public IEnumerable<IModelField> Fields { get; }
		public IEnumerable<IModelMethod> Methods { get; }

		internal CompositeModelValue()
			: this(Enumerable.Empty<IModelField>(), Enumerable.Empty<IModelMethod>())
		{
		}

		internal CompositeModelValue(params IModelField[] fields)
			: this((IEnumerable<IModelField>)fields)
		{
		}

		internal CompositeModelValue(params IModelMethod[] methods)
			: this((IEnumerable<IModelMethod>)methods)
		{
		}

		internal CompositeModelValue(IEnumerable<IModelField> fields)
			: this(fields, Enumerable.Empty<IModelMethod>())
		{
		}
		internal CompositeModelValue(IEnumerable<IModelMethod> methods)
			: this(Enumerable.Empty<IModelField>(), methods)
		{
		}

		public CompositeModelValue(IEnumerable<IModelField> fields, IEnumerable<IModelMethod> methods)
		{
			if (fields == null)
				throw new ArgumentNullException(nameof(fields));
			if (methods == null)
				throw new ArgumentNullException(nameof(methods));

			Fields = fields.ToList();

			Methods = methods
				.ToList()
				.AsReadOnly();
		}
	}
}