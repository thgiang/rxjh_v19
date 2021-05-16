using System;

namespace RxjhServer
{
	public interface IWUser<TContext>
	{
		DateTime Timestamp
		{
			get;
			set;
		}

		IDisposable ReadLock
		{
			get;
		}

		IDisposable UpdateLock
		{
			get;
		}

		IDisposable WriteLock
		{
			get;
		}

		int Index
		{
			get;
			set;
		}

		bool Invalid
		{
			get;
			set;
		}

		string Credentials
		{
			get;
		}

		TContext Context
		{
			get;
			set;
		}

		void Reset();

		bool Authentication(string credentials);
	}
}
