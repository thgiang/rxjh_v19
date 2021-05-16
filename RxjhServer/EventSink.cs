using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace RxjhServer
{
	public class EventSink
	{
		[CompilerGenerated]
		private static SocketConnectEventHandler socketConnectEventHandler_0;

		public static event SocketConnectEventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				SocketConnectEventHandler socketConnectEventHandler = socketConnectEventHandler_0;
				SocketConnectEventHandler socketConnectEventHandler2;
				do
				{
					socketConnectEventHandler2 = socketConnectEventHandler;
					SocketConnectEventHandler value2 = (SocketConnectEventHandler)Delegate.Combine(socketConnectEventHandler2, value);
					socketConnectEventHandler = Interlocked.CompareExchange(ref socketConnectEventHandler_0, value2, socketConnectEventHandler2);
				}
				while ((object)socketConnectEventHandler != socketConnectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				SocketConnectEventHandler socketConnectEventHandler = socketConnectEventHandler_0;
				SocketConnectEventHandler socketConnectEventHandler2;
				do
				{
					socketConnectEventHandler2 = socketConnectEventHandler;
					SocketConnectEventHandler value2 = (SocketConnectEventHandler)Delegate.Remove(socketConnectEventHandler2, value);
					socketConnectEventHandler = Interlocked.CompareExchange(ref socketConnectEventHandler_0, value2, socketConnectEventHandler2);
				}
				while ((object)socketConnectEventHandler != socketConnectEventHandler2);
			}
		}

		public static void InvokeSocketConnect(SocketConnectEventArgs socketConnectEventArgs_0)
		{
			if (socketConnectEventHandler_0 != null)
			{
				socketConnectEventHandler_0(socketConnectEventArgs_0);
			}
		}
	}
}
