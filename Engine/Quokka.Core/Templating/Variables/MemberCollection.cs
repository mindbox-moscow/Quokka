﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Mindbox.Quokka
{
	/// <summary>
	/// The collection of variables of the same level (can represent a collection of root-level variables in the scope
	/// or a member collection of a single composite variable).
	/// </summary>
	internal class MemberCollection<TMemberKey>
		where TMemberKey : IEquatable<TMemberKey>
	{
		private readonly Dictionary<TMemberKey, ValueUsageSummary> items;

		public IReadOnlyCollection<KeyValuePair<TMemberKey, ValueUsageSummary>> Items => items;

		public MemberCollection(IEqualityComparer<TMemberKey> equalityComparer)
			: this(new Dictionary<TMemberKey, ValueUsageSummary>(equalityComparer))
		{
		}

		private MemberCollection(Dictionary<TMemberKey, ValueUsageSummary> items)
		{
			this.items = items;
		}
		
		public bool CheckIfMemberExists(TMemberKey key)
		{
			return items.ContainsKey(key);
		}
		
		public ValueUsageSummary CreateOrUpdateMember(TMemberKey memberKey, ValueUsage valueUsage)
		{
			if (!items.TryGetValue(memberKey, out ValueUsageSummary definition))
			{
				definition = new ValueUsageSummary(memberKey.ToString());
				items.Add(memberKey, definition);
			}

			definition.AddUsage(valueUsage);
			return definition;
		}

		public ValueUsageSummary TryGetMemberUsageSummary(TMemberKey key)
		{
			return items.TryGetValue(key, out ValueUsageSummary definition) 
				? definition 
				: null;
		}

		public static MemberCollection<TMemberKey> Merge(
			string ownerFullName, 
			IEnumerable<MemberCollection<TMemberKey>> collections,
			IEqualityComparer<TMemberKey> equalityComparer)
		{
			var fields = collections
				.SelectMany(fieldCollection => fieldCollection.items)
				.GroupBy(
					field => field.Key,
					(name, values) => new
					{
						ResultDefinition = ValueUsageSummary.Merge(
							$"{ownerFullName}.{name}",
							values.Select(v => v.Value).ToList()),
						ResultKey = name
					},
					equalityComparer)
				.ToDictionary(
					definition => definition.ResultKey,
					definition => definition.ResultDefinition,
					equalityComparer);

			return new MemberCollection<TMemberKey>(fields);
		}
	}
}
