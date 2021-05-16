#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace RxjhServer
{
	public class WUserManager<TUser> where TUser : IWUser<string>, new()
	{
		private static volatile bool _initialized;

		private static WUserManager<TUser> _userManager;

		private Dictionary<int, TUser> _users;

		private int _maxUsers;

		public static void Init(int maxUsers)
		{
			if (_initialized)
			{
				throw new ApplicationException("alread inited");
			}
			_userManager = new WUserManager<TUser>();
			_userManager._maxUsers = maxUsers;
			_userManager._users = new Dictionary<int, TUser>(maxUsers);
			for (int i = 0; i < maxUsers; i++)
			{
				Dictionary<int, TUser> users = _userManager._users;
				int key = i;
				TUser value = new TUser();
				value.Index = i;
				users[key] = value;
			}
			Thread thread = new Thread(threadProce);
			thread.Name = "user manager clearner";
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Highest;
			thread.Start();
			_initialized = true;
		}

		private static void threadProce(object State)
		{
			try
			{
				while (true)
				{
					foreach (TUser value in _userManager._users.Values)
					{
						TUser current = value;
						using (current.ReadLock)
						{
							if (!current.Invalid)
							{
								using (current.UpdateLock)
								{
									if (DateTime.Now - current.Timestamp > TimeSpan.FromMinutes(3.0))
									{
										using (current.WriteLock)
										{
											current.Invalid = true;
										}
									}
								}
							}
						}
					}
					Thread.Sleep(TimeSpan.FromMinutes(1.0));
				}
			}
			catch (Exception arg)
			{
				Trace.TraceError(string.Format("user manager clear error:", arg));
			}
		}

		public static WUserManager<TUser> GetInstance()
		{
			if (!_initialized)
			{
				throw new ApplicationException("no init");
			}
			return _userManager;
		}

		public TUser GetUser(int index, string credentials)
		{
			if (index >= 0 && index < _maxUsers)
			{
				if (string.IsNullOrEmpty(credentials))
				{
					return default(TUser);
				}
				TUser result = _users[index];
				using (result.UpdateLock)
				{
					if (!result.Authentication(credentials))
					{
						throw new ApplicationException("Authentication failed");
					}
					if (!result.Invalid)
					{
						using (result.WriteLock)
						{
							result.Timestamp = DateTime.Now;
							return result;
						}
					}
				}
				return default(TUser);
			}
			return default(TUser);
		}

		public TUser AddUser()
		{
			for (int i = 0; i < _maxUsers; i++)
			{
				TUser result = _users[i];
				using (result.UpdateLock)
				{
					if (result.Invalid)
					{
						using (result.WriteLock)
						{
							result.Reset();
							result.Invalid = false;
							result.Timestamp = DateTime.Now;
							return result;
						}
					}
				}
			}
			return default(TUser);
		}

		public bool RemoveUser(int index, string credentials)
		{
			if (index >= 0 && index < _maxUsers && !string.IsNullOrEmpty(credentials))
			{
				TUser val = _users[index];
				if (val == null)
				{
					return false;
				}
				using (val.WriteLock)
				{
					val.Invalid = true;
				}
				return true;
			}
			return false;
		}
	}
}
