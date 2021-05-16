using System.Runtime.InteropServices;

namespace RxjhServer
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 512)]
	internal struct IdSector
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public ushort ushort_6;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public ushort[] wVendorUnique;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public byte[] sSerialNumber;

		public ushort ushort_7;

		public ushort ushort_8;

		public ushort ushort_9;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] sFirmwareRev;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
		public byte[] sModelNumber;

		public ushort ushort_10;

		public ushort ushort_11;

		public ushort ushort_12;

		public ushort ushort_13;

		public ushort ushort_14;

		public ushort ushort_15;

		public ushort ushort_16;

		public ushort ushort_17;

		public ushort ushort_18;

		public ushort ushort_19;

		public uint uint_0;

		public ushort ushort_20;

		public uint uint_1;

		public ushort ushort_21;

		public ushort ushort_22;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		public byte[] bReserved;
	}
}
