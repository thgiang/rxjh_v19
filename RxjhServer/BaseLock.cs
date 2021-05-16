using System;
using System.Threading;

namespace RxjhServer
{
	public abstract class BaseLock : IDisposable
	{
		protected ReaderWriterLockSlim _Locks;

		public BaseLock(ReaderWriterLockSlim locks)
		{
			_Locks = locks;
		}

		public abstract void Dispose();
	}
}
