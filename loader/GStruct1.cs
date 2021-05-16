using System.Runtime.InteropServices;

namespace loader
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GStruct1
	{
		public int int_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ulong ulong_0;

		public uint uint_3;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] key;
	}
}
