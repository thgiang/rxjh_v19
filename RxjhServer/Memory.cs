using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RxjhServer
{
	public class Memory
	{
		private static readonly Version myVersion = new Version(1, 0);

		public static int SetProcessMemoryToMin()
		{
			return SetProcessMemoryToMin(Process.GetCurrentProcess().Handle);
		}

		public static int SetProcessMemoryToMin(IntPtr intptr_0)
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return SetProcessWorkingSetSize(intptr_0, -1, -1);
			}
			return -1;
		}

		[DllImport("kernel32.dll")]
		private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, int int_0, int int_1);
	}
}
