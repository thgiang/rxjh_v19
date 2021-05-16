#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace loader
{
	public class GClass19
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate IntPtr GDelegate0(string string_0);

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate IntPtr GDelegate1(IntPtr intptr_0, IntPtr intptr_1);

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate int GDelegate2(IntPtr intptr_0, int int_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_1, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_1, ref int int_2, int int_3);

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate IntPtr GDelegate3(IntPtr intptr_0, IntPtr intptr_1, int int_0);

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct GStruct2
		{
			public IntPtr message;

			public IntPtr zero0;

			public GDelegate0 gdelegate0_0;

			public GDelegate1 gdelegate1_0;

			public IntPtr execute;

			public GDelegate3 gdelegate3_0;

			public IntPtr zero1;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct GStruct3
		{
			public int int_0;

			public uint uint_0;

			public GStruct2 gstruct2_0;
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public delegate int GDelegate4(ref GStruct3 gstruct3_0, IntPtr intptr_0);

		public static IntPtr imagebase;

		public static byte[] g_loader_context = new byte[48]
		{
			44,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			160,
			71,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			112,
			143,
			15,
			37,
			168,
			105,
			95,
			76,
			99,
			106,
			252,
			17,
			215,
			153,
			167,
			133,
			221,
			221,
			221,
			221
		};

		public static GStruct1 gstruct1_0;

		public static IntPtr g_hHeap = IntPtr.Zero;

		public static GStruct3 gstruct3_0;

		private static List<GStruct0> g_module = new List<GStruct0>();

		private static StreamWriter streamWriter_0 = null;

		private static string string_0 = "log.txt";

		private static int int_0 = 0;

		public static byte[] vb_key = new byte[32]
		{
			71,
			78,
			85,
			0,
			244,
			97,
			255,
			43,
			125,
			27,
			216,
			151,
			25,
			248,
			255,
			88,
			230,
			71,
			133,
			225,
			148,
			157,
			26,
			220,
			69,
			213,
			236,
			187,
			227,
			146,
			124,
			70
		};

		private static void smethod_0(int int_1)
		{
			Environment.Exit(int_1);
			Environment.FailFast(string.Format("{0:X}", int_1));
		}

		[DllImport("kernel32.dll")]
		private static extern IntPtr HeapCreate(int int_1, UIntPtr uintptr_0, UIntPtr uintptr_1);

		[DllImport("kernel32.dll")]
		private static extern IntPtr HeapAlloc(IntPtr intptr_0, int int_1, UIntPtr uintptr_0);

		[DllImport("kernel32.dll")]
		private static extern int HeapFree(IntPtr intptr_0, int int_1, IntPtr intptr_1);

		public static IntPtr smethod_1(int int_1)
		{
			if (g_hHeap == IntPtr.Zero)
			{
				g_hHeap = HeapCreate(0, UIntPtr.Zero, UIntPtr.Zero);
			}
			return HeapAlloc(g_hHeap, 0, (UIntPtr)(ulong)int_1);
		}

		public static IntPtr smethod_2(IntPtr intptr_0, IntPtr intptr_1, int int_1)
		{
			Class8.Struct8 struct8_ = default(Class8.Struct8);
			Class8.smethod_0(ref struct8_, gstruct1_0.key, 16);
			byte[] byte_ = new byte[int_1];
			Marshal.Copy(intptr_1, byte_, 0, int_1);
			Class8.smethod_1(ref struct8_, byte_, ref byte_, int_1);
			Marshal.Copy(byte_, 0, intptr_0, int_1);
			return intptr_0;
		}

		public static void smethod_3(IntPtr intptr_0)
		{
			HeapFree(g_hHeap, 0, intptr_0);
		}

		public static IntPtr smethod_4(string string_1)
		{
			if (string.IsNullOrEmpty(string_1))
			{
				return imagebase;
			}
			foreach (GStruct0 item in g_module)
			{
				int i = 0;
				byte[] array = new byte[12];
				for (; i < 12; i++)
				{
					array[i] = (byte)((item.name[i] - 1) ^ item.key[i]);
					if (array[i] == 0)
					{
						break;
					}
				}
				string @string = Encoding.ASCII.GetString(array, 0, i);
				if (string_1 == @string)
				{
					return (IntPtr)(long)item.ulong_0;
				}
			}
			return IntPtr.Zero;
		}

		private static void smethod_5(string string_1)
		{
			Debug.Write(string_1);
		}

		private static void smethod_6(string string_1)
		{
			Debug.WriteLine(string_1);
		}

		private static void smethod_7()
		{
			string name = Assembly.GetExecutingAssembly().GetModules()[0].Name;
			string text = DateTime.Now.ToLocalTime().ToString("yyyy.MM.dd_hh.mm.ss");
			string str = "log_" + name + "_execute_" + text + ".txt";
			if (!Directory.Exists("d:"))
			{
				string_0 = str;
			}
			else
			{
				if (!Directory.Exists("d:\\log"))
				{
					Directory.CreateDirectory("d:\\log");
				}
				if (Directory.Exists("d:\\log"))
				{
					string_0 = "d:\\log\\" + str;
				}
			}
			smethod_5("log file: " + string_0);
			streamWriter_0 = new StreamWriter(string_0, false);
			if (streamWriter_0 != null)
			{
				streamWriter_0.WriteLine(DateTime.Now.ToLocalTime().ToString());
				streamWriter_0.Close();
				streamWriter_0 = new StreamWriter(string_0, true);
			}
		}

		private static void smethod_8(string string_1)
		{
			try
			{
				int_0++;
				if (int_0 >= 100)
				{
					int_0 = 0;
					streamWriter_0.Close();
					streamWriter_0 = new StreamWriter(string_0, true);
				}
				if (streamWriter_0 == null)
				{
					smethod_7();
				}
				if (streamWriter_0 != null)
				{
					streamWriter_0.Write(string_1);
					streamWriter_0.Flush();
				}
				else
				{
					smethod_5("fail to output: " + string_1);
				}
			}
			catch (Exception ex)
			{
				smethod_5("fail to output: " + string_1 + "as " + ex.Message);
			}
		}

		private static void smethod_9(string string_1)
		{
			try
			{
				int_0++;
				if (int_0 >= 100)
				{
					int_0 = 0;
					streamWriter_0.Close();
					streamWriter_0 = new StreamWriter(string_0, true);
				}
				if (streamWriter_0 == null)
				{
					smethod_7();
				}
				if (streamWriter_0 != null)
				{
					streamWriter_0.WriteLine(string_1);
					streamWriter_0.Flush();
				}
				else
				{
					smethod_5("fail to outputline: " + string_1);
				}
			}
			catch (Exception ex)
			{
				smethod_5("fail to outputline: " + string_1 + "as " + ex.Message);
			}
		}

		public static int smethod_10(object[] object_0, int int_1, int int_2, int int_3)
		{
			try
			{
				StackTrace stackTrace = new StackTrace();
				StackFrame frame = stackTrace.GetFrame(1);
				MethodBase method = frame.GetMethod();
				smethod_8("execute: " + method.ToString());
				if (method.ReflectedType != null)
				{
					smethod_9(" in " + method.ReflectedType.ToString());
				}
			}
			catch (Exception)
			{
				smethod_9("\t----catch exeption when logging execution");
			}
			IntPtr intptr_ = GClass21.smethod_5(imagebase, (uint)int_1);
			byte[] array = GClass21.smethod_7(object_0);
			byte[] array2 = new byte[array.Length];
			int int_4 = array.Length;
			GDelegate2 gDelegate = (GDelegate2)Marshal.GetDelegateForFunctionPointer(gstruct3_0.gstruct2_0.execute, typeof(GDelegate2));
			gDelegate(intptr_, int_2, array, int_4, array2, ref int_4, int_3);
			object[] array3 = GClass21.smethod_14(array2);
			for (int i = 0; i < array3.Length; i++)
			{
				object_0[i] = array3[i];
			}
			return 0;
		}

		public static int smethod_11(byte[] byte_0, byte[] byte_1)
		{
			int num = byte_1.Length;
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_1, 0, intPtr, num);
			gstruct3_0.gstruct2_0.gdelegate3_0(intPtr, intPtr, num);
			Marshal.Copy(intPtr, byte_0, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return 0;
		}

		public static IntPtr smethod_12(IntPtr intptr_0, IntPtr intptr_1, int int_1)
		{
			Class8.Struct8 struct8_ = default(Class8.Struct8);
			byte[] array = new byte[32];
			for (int i = 0; i < 32; i++)
			{
				array[i] = (byte)((vb_key[i] ^ 0x3C) - 195);
			}
			Class8.smethod_0(ref struct8_, array, 32);
			byte[] byte_ = new byte[int_1];
			Marshal.Copy(intptr_1, byte_, 0, int_1);
			Class8.smethod_1(ref struct8_, byte_, ref byte_, int_1);
			Marshal.Copy(byte_, 0, intptr_0, int_1);
			return intptr_0;
		}

		public static void smethod_13(GStruct1 gstruct1_1)
		{
			gstruct3_0.int_0 = Marshal.SizeOf(gstruct3_0);
			gstruct3_0.uint_0 = gstruct1_1.uint_0;
			gstruct3_0.gstruct2_0.message = IntPtr.Zero;
			gstruct3_0.gstruct2_0.gdelegate0_0 = smethod_4;
			gstruct3_0.gstruct2_0.gdelegate1_0 = GClass20.smethod_21;
			gstruct3_0.gstruct2_0.gdelegate3_0 = smethod_12;
		}

		public static IntPtr smethod_14(GStruct0 gstruct0_0, IntPtr intptr_0)
		{
			IntPtr intPtr = intptr_0;
			int num = Marshal.ReadInt32(intptr_0, 4);
			if ((num & 1) != 0)
			{
				int num2 = Marshal.ReadInt32(intptr_0, 0);
				IntPtr intPtr2 = smethod_1(num2);
				IntPtr source = GClass21.smethod_1(intptr_0, 12u);
				IntPtr destination = GClass21.smethod_1(intPtr2, 12u);
				int num3 = num2 - 12;
				Class8.Struct8 struct8_ = default(Class8.Struct8);
				Class8.smethod_0(ref struct8_, gstruct0_0.key, 16);
				byte[] byte_ = new byte[num3];
				Marshal.Copy(source, byte_, 0, num3);
				Class8.smethod_1(ref struct8_, byte_, ref byte_, num3);
				Marshal.Copy(byte_, 0, destination, num3);
				Marshal.WriteInt32(intPtr2, num2);
				int val = Marshal.ReadInt32(intptr_0, 8);
				Marshal.WriteInt32(intPtr2, 8, val);
				intPtr = intPtr2;
			}
			int num4 = Marshal.ReadInt32(intPtr, 8);
			if (num4 != 0)
			{
				for (int num5 = Marshal.ReadInt32(intPtr, num4); num5 != 0; num5 = Marshal.ReadInt32(intPtr, num4))
				{
					int uint_ = Marshal.ReadInt32(intPtr, num5);
					IntPtr intptr_ = GClass21.smethod_1(intPtr, (uint)uint_);
					GClass21.smethod_0(intPtr, num5, intptr_);
					num4 += 4;
				}
			}
			return intPtr;
		}

		public static int smethod_15(ref GStruct0 gstruct0_0)
		{
			IntPtr intPtr = GClass20.smethod_19(gstruct1_0, GClass21.smethod_5(imagebase, (uint)gstruct0_0.ulong_0));
			if (intPtr == IntPtr.Zero)
			{
				return 10;
			}
			gstruct0_0.ulong_0 = (ulong)(long)intPtr;
			return 0;
		}

		public static int smethod_16(ref GStruct3 gstruct3_1)
		{
			int num = 0;
			IntPtr intPtr = GClass21.smethod_5(imagebase, gstruct1_0.uint_2);
			int num2 = Marshal.SizeOf(intPtr) * 8;
			GStruct0 gstruct0_ = (GStruct0)Marshal.PtrToStructure(intPtr, typeof(GStruct0));
			while (gstruct0_.ulong_0 != 0L)
			{
				if (gstruct0_.uint_0 == num2)
				{
					num = smethod_15(ref gstruct0_);
					if (num != 0)
					{
						smethod_0(num);
					}
					g_module.Add(gstruct0_);
					IntPtr intPtr2 = GClass20.smethod_20((IntPtr)(long)gstruct0_.ulong_0, "vb_onload");
					if (intPtr2 != IntPtr.Zero)
					{
						IntPtr intptr_ = IntPtr.Zero;
						if (gstruct0_.ulong_1 != 0L)
						{
							IntPtr intPtr3 = smethod_14(gstruct0_, GClass21.smethod_5(imagebase, (uint)gstruct0_.ulong_1));
							if (intPtr3 != IntPtr.Zero)
							{
								intptr_ = GClass21.smethod_1(intPtr3, 12u);
							}
						}
						GDelegate4 gDelegate = (GDelegate4)Marshal.GetDelegateForFunctionPointer(intPtr2, typeof(GDelegate4));
						if (gDelegate(ref gstruct3_1, intptr_) != 0)
						{
							smethod_0(12);
						}
					}
				}
				intPtr = GClass21.smethod_1(intPtr, (uint)Marshal.SizeOf(gstruct0_));
				gstruct0_ = (GStruct0)Marshal.PtrToStructure(intPtr, typeof(GStruct0));
			}
			int num3 = gstruct1_0.key.Length;
			IntPtr intPtr4 = Marshal.AllocHGlobal(num3);
			Marshal.Copy(gstruct1_0.key, 0, intPtr4, num3);
			gstruct3_0.gstruct2_0.gdelegate3_0(intPtr4, intPtr4, num3);
			Marshal.Copy(intPtr4, gstruct1_0.key, 0, num3);
			Marshal.FreeHGlobal(intPtr4);
			return num;
		}

		public static void smethod_17()
		{
		}

		public static void smethod_18(byte[] byte_0)
		{
			Class8.Struct8 struct8_ = default(Class8.Struct8);
			byte[] array = new byte[32];
			for (int i = 0; i < 32; i++)
			{
				array[i] = (byte)((vb_key[i] ^ 0x3C) - 195);
			}
			Class8.smethod_0(ref struct8_, array, 32);
			Class8.smethod_1(ref struct8_, byte_0, ref byte_0, byte_0.Length);
		}
	}
}
