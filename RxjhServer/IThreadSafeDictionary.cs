using System;
using System.Collections;
using System.Collections.Generic;

namespace RxjhServer
{
	public interface IThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerable
	{
		void MergeSafe(TKey key, TValue newValue);

		void RemoveSafe(TKey key);

		new void Dispose();
	}
}
