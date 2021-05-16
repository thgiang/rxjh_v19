using System;
using System.Net.Sockets;

namespace RxjhServer
{
	public class SocketConnectEventArgs : EventArgs
	{
		private Socket socket_0;

		private bool bool_0;

		public Socket Socket
		{
			get
			{
				return socket_0;
			}
		}

		public bool AllowConnection
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public SocketConnectEventArgs(Socket socket_1)
		{
			socket_0 = socket_1;
			bool_0 = true;
		}
	}
}
