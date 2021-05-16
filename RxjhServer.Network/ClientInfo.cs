using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RxjhServer.Network
{
	[StructLayout(LayoutKind.Sequential)]
	public class ClientInfo
	{
		[CompilerGenerated]
		private IntPtr intptr_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private ushort ushort_0;

		[CompilerGenerated]
		private TcpServer tcpServer_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private NetState netState_0;

		public IntPtr ConnId
		{
			get;
			set;
		}

		public string IpAddress
		{
			get;
			set;
		}

		public ushort Port
		{
			get;
			set;
		}

		public TcpServer Server
		{
			get;
			set;
		}

		public int WorldId
		{
			get;
			set;
		}

		public NetState Client
		{
			get;
			set;
		}
	}
}
