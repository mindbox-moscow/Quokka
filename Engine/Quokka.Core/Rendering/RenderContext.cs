﻿// // Copyright 2022 Mindbox Ltd
// //
// // Licensed under the Apache License, Version 2.0 (the "License");
// // you may not use this file except in compliance with the License.
// // You may obtain a copy of the License at
// //
// //     http://www.apache.org/licenses/LICENSE-2.0
// //
// // Unless required by applicable law or agreed to in writing, software
// // distributed under the License is distributed on an "AS IS" BASIS,
// // WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// // See the License for the specific language governing permissions and
// // limitations under the License.

using System;
using System.IO;

namespace Mindbox.Quokka
{
	internal class RenderContext
	{
		public RuntimeVariableScope VariableScope { get; }
		public FunctionRegistry Functions { get; }
		public ICallContextContainer CallContextContainer { get; }

		public RenderContext(
			RuntimeVariableScope variableScope, FunctionRegistry functions, ICallContextContainer callContextContainer)
		{
			if (callContextContainer == null) 
				throw new ArgumentNullException(nameof(callContextContainer));

			VariableScope = variableScope;
			Functions = functions;
			CallContextContainer = callContextContainer;
		}

		public virtual RenderContext CreateInnerContext(RuntimeVariableScope variableScope)
		{
			return new RenderContext(variableScope, Functions, CallContextContainer);
		}

		public virtual void OnRenderingEnd(TextWriter resultWriter)
		{
		}

		public TContext GetCallContextValue<TContext>()
			where TContext : class
		{
			return CallContextContainer.GetCallContext<TContext>();
		}
	}
}
