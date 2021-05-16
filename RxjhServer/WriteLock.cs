using System.Threading;

namespace RxjhServer
{
	public class WriteLock : BaseLock
	{
		public WriteLock(ReaderWriterLockSlim readerWriterLockSlim_0)
			: base(readerWriterLockSlim_0)
		{
			Locks.GetWriteLock(_Locks);
		}

		public override void Dispose()
		{
			Locks.ReleaseWriteLock(_Locks);
		}
	}
}
