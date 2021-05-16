using System.Threading;

namespace RxjhServer
{
	public static class Locks
	{
		public static void GetReadLock(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			bool flag = false;
			while (!flag)
			{
				flag = readerWriterLockSlim_0.TryEnterUpgradeableReadLock(1);
			}
		}

		public static void GetReadOnlyLock(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			bool flag = false;
			while (!flag)
			{
				flag = readerWriterLockSlim_0.TryEnterReadLock(1);
			}
		}

		public static void GetWriteLock(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			bool flag = false;
			while (!flag)
			{
				flag = readerWriterLockSlim_0.TryEnterWriteLock(1);
			}
		}

		public static void ReleaseReadOnlyLock(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			if (readerWriterLockSlim_0.IsReadLockHeld)
			{
				readerWriterLockSlim_0.ExitReadLock();
			}
		}

		public static void ReleaseReadLock(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			if (readerWriterLockSlim_0.IsUpgradeableReadLockHeld)
			{
				readerWriterLockSlim_0.ExitUpgradeableReadLock();
			}
		}

		public static void ReleaseWriteLock(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			if (readerWriterLockSlim_0.IsWriteLockHeld)
			{
				readerWriterLockSlim_0.ExitWriteLock();
			}
		}

		public static void ReleaseLock(ReaderWriterLockSlim readerWriterLockSlim_0)
		{
			ReleaseWriteLock(readerWriterLockSlim_0);
			ReleaseReadLock(readerWriterLockSlim_0);
			ReleaseReadOnlyLock(readerWriterLockSlim_0);
		}

		public static ReaderWriterLockSlim GetLockInstance()
		{
			return GetLockInstance(LockRecursionPolicy.SupportsRecursion);
		}

		public static ReaderWriterLockSlim GetLockInstance(LockRecursionPolicy lockRecursionPolicy_0)
		{
			return new ReaderWriterLockSlim(lockRecursionPolicy_0);
		}
	}
}
