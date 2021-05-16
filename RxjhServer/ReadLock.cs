using System.Threading;

namespace RxjhServer
{
	public class ReadLock : BaseLock
	{
		public ReadLock(ReaderWriterLockSlim readerWriterLockSlim_0)
			: base(readerWriterLockSlim_0)
		{
			Locks.GetReadLock(_Locks);
		}

		public override void Dispose()
		{
			Locks.ReleaseReadLock(_Locks);
		}
	}
}
