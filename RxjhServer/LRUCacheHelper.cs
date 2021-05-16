using System.Collections.Generic;

namespace RxjhServer
{
	public class LRUCacheHelper<K, V>
	{
		private readonly LinkedList<K> _queue = new LinkedList<K>();

		private readonly object _syncRoot = new object();

		private readonly Dictionary<K, V> _dict;

		private readonly int _max;

		public LRUCacheHelper(int capacity, int max)
		{
			_dict = new Dictionary<K, V>(capacity);
			_max = max;
		}

		public void Add(K key, V value)
		{
			lock (_syncRoot)
			{
				checkAndTruncate();
				_queue.AddFirst(key);
				_dict[key] = value;
			}
		}

		private void checkAndTruncate()
		{
			lock (_syncRoot)
			{
				int count = _dict.Count;
				if (count >= _max)
				{
					int num = count / 10;
					for (int i = 0; i < num; i++)
					{
						_dict.Remove(_queue.Last.Value);
						_queue.RemoveLast();
					}
				}
			}
		}

		public void Delete(K key)
		{
			lock (_syncRoot)
			{
				_dict.Remove(key);
				_queue.Remove(key);
			}
		}

		public V Get(K key)
		{
			lock (_syncRoot)
			{
				V value;
				_dict.TryGetValue(key, out value);
				_queue.Remove(key);
				_queue.AddFirst(key);
				return value;
			}
		}
	}
}
