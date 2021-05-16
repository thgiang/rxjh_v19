using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace RxjhServer
{
	[Serializable]
	public class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IThreadSafeDictionary<TKey, TValue>, IDisposable, IEnumerable
	{
		private IDictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

		[NonSerialized]
		private ReaderWriterLockSlim dictionaryLock = Locks.GetLockInstance(LockRecursionPolicy.NoRecursion);

		public virtual TValue this[TKey key]
		{
			get
			{
				using (new ReadOnlyLock(dictionaryLock))
				{
					return dict[key];
				}
			}
			set
			{
				using (new WriteLock(dictionaryLock))
				{
					dict[key] = value;
				}
			}
		}

		public virtual ICollection<TKey> Keys
		{
			get
			{
				using (new ReadOnlyLock(dictionaryLock))
				{
					return new List<TKey>(dict.Keys);
				}
			}
		}

		public virtual ICollection<TValue> Values
		{
			get
			{
				using (new ReadOnlyLock(dictionaryLock))
				{
					return new List<TValue>(dict.Values);
				}
			}
		}

		public virtual int Count
		{
			get
			{
				using (new ReadOnlyLock(dictionaryLock))
				{
					return dict.Count;
				}
			}
		}

		public virtual bool IsReadOnly
		{
			get
			{
				using (new ReadOnlyLock(dictionaryLock))
				{
					return dict.IsReadOnly;
				}
			}
		}

		public void Dispose()
		{
			if (dictionaryLock != null)
			{
				dictionaryLock.Dispose();
				dictionaryLock = null;
			}
			if (dict != null)
			{
				dict.Clear();
				dict = null;
			}
		}

		public void RemoveSafe(TKey key)
		{
			using (new ReadLock(dictionaryLock))
			{
				if (dict.ContainsKey(key))
				{
					using (new WriteLock(dictionaryLock))
					{
						dict.Remove(key);
					}
				}
			}
		}

		public void MergeSafe(TKey key, TValue newValue)
		{
			using (new WriteLock(dictionaryLock))
			{
				if (dict.ContainsKey(key))
				{
					dict.Remove(key);
				}
				dict.Add(key, newValue);
			}
		}

		public virtual bool Remove(TKey key)
		{
			using (new WriteLock(dictionaryLock))
			{
				return dict.Remove(key);
			}
		}

		public virtual bool ContainsKey(TKey key)
		{
			using (new ReadOnlyLock(dictionaryLock))
			{
				return dict.ContainsKey(key);
			}
		}

		public virtual bool TryGetValue(TKey key, out TValue value)
		{
			using (new ReadOnlyLock(dictionaryLock))
			{
				return dict.TryGetValue(key, out value);
			}
		}

		public virtual void Clear()
		{
			using (new WriteLock(dictionaryLock))
			{
				dict.Clear();
			}
		}

		public virtual bool Contains(KeyValuePair<TKey, TValue> item)
		{
			using (new ReadOnlyLock(dictionaryLock))
			{
				return dict.Contains(item);
			}
		}

		public virtual void Add(KeyValuePair<TKey, TValue> item)
		{
			using (new WriteLock(dictionaryLock))
			{
				dict.Add(item);
			}
		}

		public virtual void Add(TKey key, TValue value)
		{
			using (new WriteLock(dictionaryLock))
			{
				dict.Add(key, value);
			}
		}

		public virtual bool Remove(KeyValuePair<TKey, TValue> item)
		{
			using (new WriteLock(dictionaryLock))
			{
				return dict.Remove(item);
			}
		}

		public virtual void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			using (new ReadOnlyLock(dictionaryLock))
			{
				dict.CopyTo(array, arrayIndex);
			}
		}

		public virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw new NotSupportedException("Cannot enumerate a threadsafe dictionary.  Instead, enumerate the keys or values collection");
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotSupportedException("Cannot enumerate a threadsafe dictionary.  Instead, enumerate the keys or values collection");
		}
	}
}
