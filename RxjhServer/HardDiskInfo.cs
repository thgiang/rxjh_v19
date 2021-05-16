using System;

namespace RxjhServer
{
	[Serializable]
	public struct HardDiskInfo
	{
		public string ModuleNumber;

		public string Firmware;

		public string SerialNumber;

		public uint Capacity;
	}
}
