using System.Runtime.InteropServices;

namespace RxjhServer
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct DriverStatus
	{
		public byte byte_0;

		public byte byte_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] bReserved;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public uint[] dwReserved;
	}
}
