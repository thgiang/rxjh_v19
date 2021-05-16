using System.Runtime.InteropServices;

namespace RxjhServer
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct SendCmdInParams
	{
		public uint uint_0;

		public IdeRegs ideRegs_0;

		public byte byte_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public byte[] bReserved;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public uint[] dwReserved;

		public byte byte_1;
	}
}
