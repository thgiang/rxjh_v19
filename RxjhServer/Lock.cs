using System;
using System.Threading;

namespace RxjhServer
{
	public class Lock : IDisposable
	{
		public static int DefaultMillisecondsTimeout = 1000;

		private object _obj;

		public bool IsTimeout
		{
			get
			{
				return _obj == null;
			}
		}

		public Lock(object obj)
		{
			TryGet(obj, 1000, true, string.Empty);
		}

		public Lock(object obj, string lei)
		{
			TryGet(obj, 1000, true, lei);
		}

		public Lock(object obj, int millisecondsTimeout, bool throwTimeoutException, string lei)
		{
			TryGet(obj, millisecondsTimeout, throwTimeoutException, lei);
		}

		private void TryGet(object obj, int millisecondsTimeout, bool throwTimeoutException, string lei)
		{
			if (Monitor.TryEnter(obj, millisecondsTimeout))
			{
				_obj = obj;
			}
			else if (throwTimeoutException)
			{
				Type type = obj.GetType();
				Form1.WriteLine(100, "锁定对象超时:" + lei + " " + ((type != null) ? type.ToString() : null));
			}
		}

		public void Dispose()
		{
			if (_obj != null)
			{
				Monitor.Exit(_obj);
				_obj = null;
			}
		}
	}
}
