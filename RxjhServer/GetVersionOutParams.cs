using System.Runtime.InteropServices;

namespace RxjhServer
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct GetVersionOutParams
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public uint[] dwReserved;
	}
}
