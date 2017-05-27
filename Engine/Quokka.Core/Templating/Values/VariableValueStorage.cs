﻿using System;
using System.Collections.Generic;

namespace Mindbox.Quokka
{
	internal abstract class VariableValueStorage
	{
		public abstract IModelValue ModelValue { get; }

		public virtual object GetPrimitiveValue()
		{
			throw new InvalidOperationException("This storage can't provide values of this type");
		}

		public virtual bool CheckIfValueIsNull()
		{
			return false;
		}

		public virtual IEnumerable<VariableValueStorage> GetElements()
		{
			throw new InvalidOperationException("This storage can't provide values of this type");
		}

		public virtual VariableValueStorage GetFieldValueStorage(string memberName)
		{
			throw new InvalidOperationException("This storage type doesn't contain members");
		}
		public virtual VariableValueStorage GetMethodCallResultValueStorage(MethodCall methodCall)
		{
			throw new InvalidOperationException("This storage type doesn't contain members");
		}

		public static VariableValueStorage CreateStorageForValue(IModelValue value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			var primitiveValue = value as IPrimitiveModelValue;
			if (primitiveValue != null)
				return new PrimitiveVariableValueStorage(primitiveValue);

			var compositeValue = value as ICompositeModelValue;
			if (compositeValue != null)
				return new CompositeVariableValueStorage(compositeValue);

			var arrayValue = value as IArrayModelValue;
			if (arrayValue != null)
				return new ArrayVariableValueStorage(arrayValue);

			throw new NotSupportedException("Unsupported parameter value type");
		}
	}
}
