using System.Runtime.InteropServices;

namespace RxjhServer.Network
{
	public struct sockaddr_in
	{
		public short sin_family;

		public ushort sin_port;

		public in_addr sin_addr;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] sLibNamesin_zero;
	}
}
