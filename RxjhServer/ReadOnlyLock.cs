using System.Threading;

namespace RxjhServer
{
	public class ReadOnlyLock : BaseLock
	{
		public ReadOnlyLock(ReaderWriterLockSlim readerWriterLockSlim_0)
			: base(readerWriterLockSlim_0)
		{
			Locks.GetReadOnlyLock(_Locks);
		}

		public override void Dispose()
		{
			Locks.ReleaseReadOnlyLock(_Locks);
		}
	}
}
