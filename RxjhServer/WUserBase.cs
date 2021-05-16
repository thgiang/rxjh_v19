using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace RxjhServer
{
	public class WUserBase<TContext> : IWUser<TContext>
	{
		[NonSerialized]
		private ReaderWriterLockSlim _objLock = Locks.GetLockInstance(LockRecursionPolicy.NoRecursion);

		private string _credentials = string.Empty;

		[CompilerGenerated]
		private DateTime dateTime_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private TContext gparam_0;

		public DateTime Timestamp
		{
			get;
			set;
		}

		public int Index
		{
			get;
			set;
		}

		public bool Invalid
		{
			get;
			set;
		}

		public TContext Context
		{
			get;
			set;
		}

		public string Credentials
		{
			get
			{
				return _credentials;
			}
		}

		public IDisposable ReadLock
		{
			get
			{
				return new ReadOnlyLock(_objLock);
			}
		}

		public IDisposable UpdateLock
		{
			get
			{
				return new ReadLock(_objLock);
			}
		}

		public IDisposable WriteLock
		{
			get
			{
				return new WriteLock(_objLock);
			}
		}

		public virtual void Reset()
		{
			_credentials = Guid.NewGuid().ToString();
			Context = default(TContext);
		}

		public bool Authentication(string credentials)
		{
			if (!string.IsNullOrEmpty(_credentials) && !string.IsNullOrEmpty(credentials))
			{
				return !(_credentials != credentials);
			}
			return false;
		}

		public WUserBase()
		{
			Index = -1;
			Timestamp = DateTime.MinValue;
			Invalid = true;
		}

		public override string ToString()
		{
			return string.Format("{0}-{1}", Index, Timestamp);
		}
	}
}
