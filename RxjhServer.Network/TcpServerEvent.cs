using System;

namespace RxjhServer.Network
{
	public class TcpServerEvent
	{
		public delegate HandleResult OnSendEventHandler(IntPtr intptr_0, byte[] byte_0);

		public delegate HandleResult OnReceiveEventHandler(IntPtr intptr_0, byte[] byte_0);

		public delegate HandleResult OnCloseEventHandler(IntPtr intptr_0, SocketOperation socketOperation_0, int int_0);

		public delegate HandleResult OnShutdownEventHandler();

		public delegate HandleResult OnPrepareListenEventHandler(IntPtr intptr_0);

		public delegate HandleResult OnAcceptEventHandler(IntPtr intptr_0, IntPtr intptr_1);
	}
}
