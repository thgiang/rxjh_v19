using System.Runtime.InteropServices;

namespace RxjhServer
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct SendCmdOutParams
	{
		public uint uint_0;

		public DriverStatus driverStatus_0;

		public IdSector idSector_0;
	}
}
