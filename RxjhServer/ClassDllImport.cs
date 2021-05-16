using System;
using System.Runtime.InteropServices;

namespace RxjhServer
{
	public class ClassDllImport
	{
		public delegate int Decrypt(byte[] byte_0, int int_0);

		private static IntPtr instance;

		[DllImport("Kernel32.dll")]
		public static extern IntPtr LoadLibrary(string string_0);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int GetProcAddress(IntPtr intptr_0, string string_0);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool FreeLibrary(IntPtr intptr_0);

		private static Delegate smethod_0(IntPtr intptr_0, string string_0, Type type_0)
		{
			int procAddress = GetProcAddress(instance, string_0);
			if (procAddress == 0)
			{
				return null;
			}
			return Marshal.GetDelegateForFunctionPointer(new IntPtr(procAddress), type_0);
		}

		public static void LoadLib()
		{
			instance = LoadLibrary("rxjhDeBuf.dll");
			if (instance.ToInt32() == 0)
			{
				Form1.WriteLine(1, "rxjhDeBuf.dll不存在或无法加载！");
			}
		}

		public static void FreeLib()
		{
			FreeLibrary(instance);
		}

		public static void DecryptaBK(byte[] byte_0, int int_0)
		{
			try
			{
				((Decrypt)smethod_0(instance, "Decrypt", typeof(Decrypt)))(byte_0, int_0);
			}
			catch
			{
				Form1.WriteLine(1, "rxjhDeBuf.dll版本错误");
			}
		}
	}
}
