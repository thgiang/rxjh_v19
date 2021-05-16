using System.Runtime.InteropServices;

namespace loader
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct0
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
		public byte[] name;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] key;

		public ulong ulong_0;

		public ulong ulong_1;
	}
}
