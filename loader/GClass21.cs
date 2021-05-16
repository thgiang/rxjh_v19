using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace loader
{
	public class GClass21
	{
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct GStruct4
		{
			public IntPtr BaseAddress;

			public IntPtr AllocationBase;

			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct GStruct5
		{
			public IntPtr BaseAddress;

			public IntPtr AllocationBase;

			public int int_0;

			public int int_1;

			public ulong ulong_0;

			public int int_2;

			public int int_3;

			public int int_4;

			public int int_5;
		}

		public enum GEnum0
		{
			STKTYPE_I32 = 0,
			STKTYPE_I32_B1 = 1,
			STKTYPE_I32_C2 = 2,
			STKTYPE_I32_I1 = 3,
			STKTYPE_I32_U1 = 4,
			STKTYPE_I32_I2 = 5,
			STKTYPE_I32_U2 = 6,
			STKTYPE_I32_I4 = 7,
			STKTYPE_I32_U4 = 8,
			STKTYPE_I64 = 0x10,
			STKTYPE_I64_I8 = 17,
			STKTYPE_I64_U8 = 18,
			STKTYPE_F80 = 33
		}

		public struct GStruct6
		{
			public uint uint_0;

			public uint uint_1;

			public ulong ulong_0;
		}

		public const int PAGE_READWRITE = 4;

		public const int PAGE_READONLY = 2;

		private static int int_0 = 16;

		public static bool bool_0 = false;

		public static byte[] image_bytes;

		[DllImport("kernel32.dll")]
		private static extern bool VirtualProtect(IntPtr intptr_0, int int_1, int int_2, out int int_3);

		[DllImport("kernel32.dll")]
		private static extern int VirtualQuery(IntPtr intptr_0, out GStruct4 gstruct4_0, int int_1);

		[DllImport("kernel32.dll", EntryPoint = "VirtualQuery")]
		private static extern int VirtualQuery_1(IntPtr intptr_0, out GStruct5 gstruct5_0, int int_1);

		public static void smethod_0(IntPtr intptr_0, int int_1, IntPtr intptr_1)
		{
			if (Marshal.SizeOf(intptr_0) == 4)
			{
				GStruct4 gstruct4_ = default(GStruct4);
				VirtualQuery(intptr_0, out gstruct4_, Marshal.SizeOf(gstruct4_));
				if ((gstruct4_.int_3 & 2) != 0)
				{
					int int_2 = 0;
					VirtualProtect(intptr_0, int_1 + 8, 4, out int_2);
					Marshal.WriteIntPtr(intptr_0, int_1, intptr_1);
					VirtualProtect(intptr_0, int_1 + 8, int_2, out int_2);
				}
				else
				{
					Marshal.WriteIntPtr(intptr_0, int_1, intptr_1);
				}
			}
			else
			{
				GStruct5 gstruct5_ = default(GStruct5);
				VirtualQuery_1(intptr_0, out gstruct5_, Marshal.SizeOf(gstruct5_));
				if ((gstruct5_.int_3 & 2) != 0)
				{
					int int_2 = 0;
					VirtualProtect(intptr_0, int_1 + 8, 4, out int_2);
					Marshal.WriteIntPtr(intptr_0, int_1, intptr_1);
					VirtualProtect(intptr_0, int_1 + 8, int_2, out int_2);
				}
				else
				{
					Marshal.WriteIntPtr(intptr_0, int_1, intptr_1);
				}
			}
		}

		public static IntPtr smethod_1(IntPtr intptr_0, uint uint_0)
		{
			return new IntPtr(intptr_0.ToInt64() + uint_0);
		}

		public static IntPtr smethod_2()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Module m = executingAssembly.GetModules()[0];
			return Marshal.GetHINSTANCE(m);
		}

		public static bool smethod_3(IntPtr intptr_0)
		{
			IntPtr intptr_ = GClass20.smethod_5(intptr_0);
			IntPtr ptr = smethod_1(intptr_, 112u);
			int num = Marshal.ReadInt32(ptr);
			if (num == 0)
			{
				return false;
			}
			try
			{
				int num2 = Marshal.ReadInt32(intptr_0, num);
				if (num2 == 72)
				{
					return false;
				}
			}
			catch (Exception)
			{
			}
			return true;
		}

		private static uint smethod_4(IntPtr intptr_0, uint uint_0)
		{
			uint result = 0u;
			IntPtr ptr = GClass20.smethod_3(intptr_0);
			int num = Marshal.ReadInt16(ptr, 6);
			IntPtr intPtr = GClass20.smethod_6(intptr_0);
			for (int i = 0; i < num; i++)
			{
				uint num2 = (uint)Marshal.ReadInt32(intPtr, 8);
				uint num3 = (uint)Marshal.ReadInt32(intPtr, 12);
				Marshal.ReadInt32(intPtr, 16);
				uint num4 = (uint)Marshal.ReadInt32(intPtr, 20);
				if (uint_0 < num3 || uint_0 >= num3 + num2)
				{
					intPtr = smethod_1(intPtr, 40u);
					continue;
				}
				result = num4 + (uint_0 - num3);
				break;
			}
			return result;
		}

		public static IntPtr smethod_5(IntPtr intptr_0, uint uint_0)
		{
			uint uint_ = uint_0;
			if (smethod_3(intptr_0))
			{
				uint_ = smethod_4(intptr_0, uint_0);
			}
			return smethod_1(intptr_0, uint_);
		}

		public static object smethod_6(byte[] byte_0, Type type_0)
		{
			int num = Marshal.SizeOf(type_0);
			if (num > byte_0.Length)
			{
				return null;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object result = Marshal.PtrToStructure(intPtr, type_0);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public static byte[] smethod_7(object[] object_0)
		{
			GStruct6[] array = new GStruct6[object_0.Length];
			int num = 0;
			foreach (object obj in object_0)
			{
				if (obj is bool)
				{
					array[num].uint_0 = 1u;
					array[num].ulong_0 = (ulong)(((bool)obj) ? 1 : 0);
				}
				else if (obj is char)
				{
					array[num].uint_0 = 2u;
					array[num].ulong_0 = (char)obj;
				}
				else if (obj is byte)
				{
					array[num].uint_0 = 4u;
					array[num].ulong_0 = (byte)obj;
				}
				else if (obj is sbyte)
				{
					array[num].uint_0 = 3u;
					array[num].ulong_0 = (ulong)(sbyte)obj;
				}
				else if (obj is short)
				{
					array[num].uint_0 = 5u;
					array[num].ulong_0 = (ulong)(short)obj;
				}
				else if (obj is ushort)
				{
					array[num].uint_0 = 6u;
					array[num].ulong_0 = (ushort)obj;
				}
				else if (obj is int)
				{
					array[num].uint_0 = 7u;
					array[num].ulong_0 = (ulong)(int)obj;
				}
				else if (obj is uint)
				{
					array[num].uint_0 = 8u;
					array[num].ulong_0 = (uint)obj;
				}
				else if (obj is long)
				{
					array[num].uint_0 = 17u;
					array[num].ulong_0 = (ulong)(long)obj;
				}
				else
				{
					if (!(obj is ulong))
					{
						throw new Exception("unexpected runtime type");
					}
					array[num].uint_0 = 18u;
					array[num].ulong_0 = (ulong)obj;
				}
				num++;
			}
			return smethod_10(array);
		}

		public static void smethod_8(byte[] byte_0, int int_1, uint uint_0)
		{
			byte_0[int_1] = (byte)(uint_0 & 0xFF);
			byte_0[int_1 + 1] = (byte)((uint_0 >> 8) & 0xFF);
			byte_0[int_1 + 2] = (byte)((uint_0 >> 16) & 0xFF);
			byte_0[int_1 + 3] = (byte)((uint_0 >> 24) & 0xFF);
		}

		public static void smethod_9(byte[] byte_0, int int_1, ulong ulong_0)
		{
			smethod_8(byte_0, int_1, (uint)(ulong_0 & 0xFFFFFFFFL));
			smethod_8(byte_0, int_1 + 4, (uint)((ulong_0 >> 32) & 0xFFFFFFFFL));
		}

		public static byte[] smethod_10(GStruct6[] gstruct6_0)
		{
			byte[] array = new byte[gstruct6_0.Length * int_0];
			int num = 0;
			for (int i = 0; i < gstruct6_0.Length; i++)
			{
				GStruct6 gStruct = gstruct6_0[i];
				smethod_8(array, num * int_0, gStruct.uint_0);
				smethod_8(array, num * int_0 + 4, gStruct.uint_1);
				smethod_9(array, num * int_0 + 8, gStruct.ulong_0);
				num++;
			}
			return array;
		}

		public static uint smethod_11(byte[] byte_0, int int_1)
		{
			uint num = 0u;
			num = (uint)(0 | byte_0[int_1]);
			num = (uint)((int)num | (byte_0[int_1 + 1] << 8));
			num = (uint)((int)num | (byte_0[int_1 + 2] << 16));
			return (uint)((int)num | (byte_0[int_1 + 3] << 24));
		}

		public static ulong smethod_12(byte[] byte_0, int int_1)
		{
			ulong num = 0uL;
			num = (ulong)(0L | smethod_11(byte_0, int_1));
			return num | ((ulong)smethod_11(byte_0, int_1 + 4) << 32);
		}

		private static GStruct6[] smethod_13(byte[] byte_0)
		{
			GStruct6[] array = new GStruct6[byte_0.Length / int_0];
			for (int i = 0; i < array.Length; i++)
			{
				array[i].uint_0 = smethod_11(byte_0, i * int_0);
				array[i].uint_1 = smethod_11(byte_0, i * int_0 + 4);
				array[i].ulong_0 = smethod_12(byte_0, i * int_0 + 8);
			}
			return array;
		}

		public static object[] smethod_14(byte[] byte_0)
		{
			GStruct6[] array = smethod_13(byte_0);
			object[] array2 = new object[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				switch (array[i].uint_0)
				{
				case 1u:
					array2[i] = ((array[i].ulong_0 & 0xFFFFFFFFL) != 0L);
					break;
				case 2u:
					array2[i] = (char)array[i].ulong_0;
					break;
				case 3u:
					array2[i] = (sbyte)array[i].ulong_0;
					break;
				case 4u:
					array2[i] = (byte)array[i].ulong_0;
					break;
				case 5u:
					array2[i] = (short)array[i].ulong_0;
					break;
				case 6u:
					array2[i] = (ushort)array[i].ulong_0;
					break;
				case 7u:
					array2[i] = (int)array[i].ulong_0;
					break;
				case 8u:
					array2[i] = (uint)array[i].ulong_0;
					break;
				case 17u:
					array2[i] = (long)array[i].ulong_0;
					break;
				case 18u:
					array2[i] = array[i].ulong_0;
					break;
				default:
					throw new Exception("unexpected returned type");
				}
			}
			return array2;
		}

		public static void smethod_15()
		{
			try
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Module module = executingAssembly.GetModules()[0];
				Marshal.GetHINSTANCE(module);
				string fullyQualifiedName = module.FullyQualifiedName;
				int num = (int)new FileInfo(fullyQualifiedName).Length;
				byte[] buffer = new byte[num];
				new FileStream(fullyQualifiedName, FileMode.Open, FileAccess.Read).Read(buffer, 0, num);
				image_bytes = buffer;
			}
			catch (Exception ex)
			{
				throw new Exception("sense exception: fail to open maps file, with exception message: " + ex.Message);
			}
		}

		private static uint smethod_16(byte[] byte_0, uint uint_0)
		{
			uint result = 0u;
			int num = GClass20.smethod_22(byte_0);
			int num2 = BitConverter.ToInt16(byte_0, num + 4 + 2);
			int num3 = GClass20.smethod_24(byte_0);
			for (int i = 0; i < num2; i++)
			{
				uint num4 = BitConverter.ToUInt32(byte_0, num3 + 8);
				uint num5 = BitConverter.ToUInt32(byte_0, num3 + 8 + 4);
				BitConverter.ToUInt32(byte_0, num3 + 8 + 4 + 4);
				uint num6 = BitConverter.ToUInt32(byte_0, num3 + 8 + 4 + 4 + 4);
				if (uint_0 < num5 || uint_0 >= num5 + num4)
				{
					num3 += 40;
					continue;
				}
				result = num6 + (uint_0 - num5);
				break;
			}
			return result;
		}

		public static byte[] smethod_17(uint uint_0, int int_1)
		{
			byte[] array = new byte[int_1];
			if (bool_0)
			{
				uint sourceIndex = smethod_16(image_bytes, uint_0);
				Array.Copy(image_bytes, (int)sourceIndex, array, 0, int_1);
			}
			else
			{
				IntPtr source = smethod_5(GClass19.imagebase, uint_0);
				Marshal.Copy(source, array, 0, int_1);
			}
			return array;
		}
	}
}
