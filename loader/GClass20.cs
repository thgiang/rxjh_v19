using System;
using System.Runtime.InteropServices;

namespace loader
{
	public class GClass20
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint Delegate0(IntPtr intptr_0, uint uint_0, IntPtr intptr_1);

		[DllImport("kernel32.dll")]
		private static extern bool VirtualProtect(IntPtr intptr_0, uint uint_0, uint uint_1, out uint uint_2);

		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualAlloc(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2);

		[DllImport("kernel32.dll")]
		private static extern bool VirtualFree(IntPtr intptr_0, uint uint_0, uint uint_1);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string string_0);

		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibrary(string string_0);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetProcAddress(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("kernel32.dll")]
		private static extern IntPtr RtlMoveMemory(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

		public static IntPtr smethod_0(IntPtr intptr_0, int int_0)
		{
			return new IntPtr(intptr_0.ToInt64() + int_0);
		}

		private static void smethod_1(byte[] byte_0, IntPtr intptr_0, IntPtr intptr_1, int int_0)
		{
			Class8.Struct8 struct8_ = default(Class8.Struct8);
			Class8.smethod_0(ref struct8_, byte_0, 16);
			byte[] byte_ = new byte[int_0];
			Marshal.Copy(intptr_1, byte_, 0, int_0);
			Class8.smethod_1(ref struct8_, byte_, ref byte_, int_0);
			Marshal.Copy(byte_, 0, intptr_0, int_0);
		}

		private static void smethod_2(IntPtr intptr_0)
		{
			VirtualFree(intptr_0, 0u, 32768u);
		}

		public static IntPtr smethod_3(IntPtr intptr_0)
		{
			int uint_ = Marshal.ReadInt32(intptr_0, 60);
			return GClass21.smethod_1(intptr_0, (uint)uint_);
		}

		public static IntPtr smethod_4(IntPtr intptr_0)
		{
			int num = Marshal.ReadInt32(intptr_0, 60);
			int int_ = num + 20 + 4;
			return smethod_0(intptr_0, int_);
		}

		public static IntPtr smethod_5(IntPtr intptr_0)
		{
			IntPtr intPtr = smethod_4(intptr_0);
			short num = Marshal.ReadInt16(intPtr);
			int int_ = 96;
			if (num != 267)
			{
				int_ = 112;
			}
			return smethod_0(intPtr, int_);
		}

		public static IntPtr smethod_6(IntPtr intptr_0)
		{
			IntPtr intPtr = smethod_4(intptr_0);
			short num = Marshal.ReadInt16(intPtr);
			int num2 = 96;
			if (num != 267)
			{
				num2 = 112;
			}
			return smethod_0(intPtr, num2 + 128);
		}

		private static bool smethod_7(IntPtr intptr_0)
		{
			IntPtr ptr = smethod_4(intptr_0);
			short num = Marshal.ReadInt16(ptr);
			if (num != 267)
			{
				return true;
			}
			return false;
		}

		private static uint smethod_8(IntPtr intptr_0)
		{
			IntPtr ptr = smethod_4(intptr_0);
			return (uint)Marshal.ReadInt32(ptr, 56);
		}

		private static uint smethod_9(IntPtr intptr_0)
		{
			IntPtr ptr = smethod_4(intptr_0);
			return (uint)Marshal.ReadInt32(ptr, 60);
		}

		public static IntPtr smethod_10(IntPtr intptr_0)
		{
			IntPtr ptr = smethod_4(intptr_0);
			int num = Marshal.ReadInt32(ptr, 16);
			if (num == 0)
			{
				return IntPtr.Zero;
			}
			return smethod_0(intptr_0, num);
		}

		private static void smethod_11(IntPtr intptr_0, IntPtr intptr_1)
		{
			Marshal.WriteInt32(intptr_0, 0, 23117);
			Marshal.WriteInt32(intptr_0, 60, 64);
			Marshal.WriteInt32(intptr_0, 64, 17744);
			ushort num = (ushort)Marshal.ReadInt16(intptr_1, 4);
			Marshal.WriteInt16(intptr_0, 68, (short)num);
			ushort num2 = (ushort)Marshal.ReadInt16(intptr_1, 8);
			Marshal.WriteInt16(intptr_0, 84, (short)num2);
			num2 = (ushort)Marshal.ReadInt16(intptr_1, 10);
			Marshal.WriteInt16(intptr_0, 86, (short)num2);
			IntPtr zero = IntPtr.Zero;
			if (num == 332)
			{
				num2 = (ushort)Marshal.ReadInt16(intptr_1, 12);
				Marshal.WriteInt16(intptr_0, 88, (short)num2);
				uint val = (uint)Marshal.ReadInt32(intptr_1, 18);
				Marshal.WriteInt32(intptr_0, 116, (int)val);
				num2 = (ushort)Marshal.ReadInt16(intptr_1, 42);
				Marshal.WriteInt16(intptr_0, 156, (short)num2);
				num2 = (ushort)Marshal.ReadInt16(intptr_1, 44);
				Marshal.WriteInt16(intptr_0, 158, (short)num2);
				Marshal.WriteInt32(intptr_0, 180, 16);
				zero = smethod_0(intptr_0, 184);
			}
			else
			{
				num2 = (ushort)Marshal.ReadInt16(intptr_1, 12);
				Marshal.WriteInt16(intptr_0, 88, (short)num2);
				long val2 = Marshal.ReadInt64(intptr_1, 18);
				Marshal.WriteInt64(intptr_0, 112, val2);
				num2 = (ushort)Marshal.ReadInt16(intptr_1, 42);
				Marshal.WriteInt16(intptr_0, 156, (short)num2);
				num2 = (ushort)Marshal.ReadInt16(intptr_1, 44);
				Marshal.WriteInt16(intptr_0, 158, (short)num2);
				Marshal.WriteInt32(intptr_0, 196, 16);
				zero = smethod_0(intptr_0, 200);
			}
			uint val3 = (uint)Marshal.ReadInt32(intptr_1, 14);
			Marshal.WriteInt32(intptr_0, 104, (int)val3);
			for (int i = 0; i <= 2; i++)
			{
				uint val = (uint)Marshal.ReadInt32(intptr_1, 46 + i * 8);
				Marshal.WriteInt32(zero, i * 8, (int)val);
				val = (uint)Marshal.ReadInt32(intptr_1, 46 + i * 8 + 4);
				Marshal.WriteInt32(zero, i * 8 + 4, (int)val);
			}
		}

		private static void smethod_12(IntPtr intptr_0, IntPtr intptr_1)
		{
			ushort num = (ushort)Marshal.ReadInt16(intptr_1, 6);
			for (ushort num2 = 0; num2 < num; num2 = (ushort)(num2 + 1))
			{
				uint int_ = (uint)Marshal.ReadInt32(intptr_1, 94 + 36 * num2);
				uint int_2 = (uint)Marshal.ReadInt32(intptr_1, 94 + 36 * num2 + 12);
				uint num3 = (uint)Marshal.ReadInt32(intptr_1, 94 + 36 * num2 + 8);
				if (num3 != 0)
				{
					IntPtr source = smethod_0(intptr_1, 94 + 36 * num2 + 20);
					byte[] array = new byte[16];
					Marshal.Copy(source, array, 0, 16);
					smethod_1(array, smethod_0(intptr_0, (int)int_), smethod_0(intptr_1, (int)int_2), (int)num3);
				}
			}
			IntPtr ptr = smethod_3(intptr_0);
			Marshal.WriteInt16(ptr, 6, 1);
			IntPtr ptr2 = smethod_6(intptr_0);
			int val = Marshal.ReadInt32(intptr_1, 34);
			Marshal.WriteInt32(ptr2, 8, val);
			Marshal.WriteInt32(ptr2, 12, 0);
			Marshal.WriteInt32(ptr2, 36, 1610612800);
		}

		public static IntPtr smethod_13(IntPtr intptr_0, IntPtr intptr_1)
		{
			IntPtr zero = IntPtr.Zero;
			uint num = (uint)Marshal.ReadInt32(intptr_0, 0);
			if (num > 8)
			{
				num = (uint)Marshal.ReadInt32(intptr_0, 34);
				if (num == 0)
				{
					return IntPtr.Zero;
				}
				zero = VirtualAlloc(IntPtr.Zero, num, 4096u, 64u);
				if (zero == IntPtr.Zero)
				{
					return IntPtr.Zero;
				}
				smethod_11(zero, intptr_0);
				smethod_12(zero, intptr_0);
			}
			else
			{
				num = smethod_8(intptr_1);
				if (num == 0)
				{
					return IntPtr.Zero;
				}
				uint uint_ = 32768u;
				zero = VirtualAlloc(IntPtr.Zero, num, 4096u, 64u);
				if (zero == IntPtr.Zero)
				{
					return IntPtr.Zero;
				}
				num = smethod_9(intptr_1);
				if (num == 0)
				{
					VirtualFree(zero, 0u, uint_);
					return IntPtr.Zero;
				}
				RtlMoveMemory(zero, intptr_1, num);
				IntPtr ptr = smethod_3(intptr_1);
				int num2 = Marshal.ReadInt16(ptr, 6);
				IntPtr intPtr = smethod_6(zero);
				for (int i = 0; i < num2; i++)
				{
					uint num3 = (uint)Marshal.ReadInt32(intPtr, 8);
					uint int_ = (uint)Marshal.ReadInt32(intPtr, 12);
					uint num4 = (uint)Marshal.ReadInt32(intPtr, 16);
					uint int_2 = (uint)Marshal.ReadInt32(intPtr, 20);
					if (num4 != 0 && num3 != 0)
					{
						IntPtr intptr_2 = smethod_0(intptr_1, (int)int_2);
						IntPtr intptr_3 = smethod_0(zero, (int)int_);
						RtlMoveMemory(intptr_3, intptr_2, num4);
					}
					intPtr = smethod_0(intPtr, 40);
				}
			}
			return zero;
		}

		private static int smethod_14(IntPtr intptr_0, IntPtr intptr_1)
		{
			int num = 0;
			long num2 = 0L;
			bool flag = smethod_7(intptr_1);
			int num3 = 0;
			uint num4 = (uint)Marshal.ReadInt32(intptr_0, 0);
			if (num4 > 8)
			{
				IntPtr ptr = smethod_0(intptr_0, 86);
				num3 = Marshal.ReadInt32(ptr);
				if (flag)
				{
					long num5 = Marshal.ReadInt64(intptr_0, 18);
					num2 = (long)intptr_1 - num5;
				}
				else
				{
					uint num6 = (uint)Marshal.ReadInt32(intptr_0, 18);
					num = (int)intptr_1 - (int)num6;
				}
			}
			else
			{
				IntPtr intptr_2 = smethod_5(intptr_1);
				IntPtr ptr = smethod_0(intptr_2, 40);
				num3 = Marshal.ReadInt32(ptr);
				IntPtr ptr2 = smethod_4(intptr_1);
				if (flag)
				{
					long num5 = Marshal.ReadInt64(ptr2, 24);
					num2 = (long)intptr_1 - num5;
				}
				else
				{
					int num7 = Marshal.ReadInt32(ptr2, 28);
					num = (int)intptr_1 - num7;
				}
			}
			for (int num8 = Marshal.ReadInt32(intptr_1, num3 + 4); num8 != 0; num8 = Marshal.ReadInt32(intptr_1, num3 + 4))
			{
				int num9 = Marshal.ReadInt32(intptr_1, num3);
				int num10 = num3 + 8;
				num4 = (uint)(num8 - 8) / 2u;
				for (int i = 0; i < num4; i++)
				{
					short num11 = Marshal.ReadInt16(intptr_1, num10 + i * 2);
					if (flag)
					{
						if ((num11 & 0xF000) == 40960)
						{
							long num12 = Marshal.ReadInt64(intptr_1, num9 + (num11 & 0xFFF));
							long val = num12 + num2;
							Marshal.WriteInt64(intptr_1, num9 + (num11 & 0xFFF), val);
						}
					}
					else if ((num11 & 0xF000) == 12288)
					{
						int num13 = Marshal.ReadInt32(intptr_1, num9 + (num11 & 0xFFF));
						num13 += num;
						Marshal.WriteInt32(intptr_1, num9 + (num11 & 0xFFF), num13);
					}
				}
				num3 += num8;
			}
			return 0;
		}

		private static int smethod_15(IntPtr intptr_0, IntPtr intptr_1)
		{
			int num = 0;
			uint num2 = (uint)Marshal.ReadInt32(intptr_0, 0);
			if (num2 > 8)
			{
				IntPtr ptr = smethod_0(intptr_0, 54);
				num = Marshal.ReadInt32(ptr);
			}
			else
			{
				IntPtr intptr_2 = smethod_5(intptr_1);
				IntPtr ptr = smethod_0(intptr_2, 8);
				num = Marshal.ReadInt32(ptr);
			}
			int num3 = Marshal.ReadInt32(intptr_1, num);
			int num4 = Marshal.ReadInt32(intptr_1, num + 16);
			int int_ = Marshal.ReadInt32(intptr_1, num + 12);
			while (true)
			{
				if (num3 != 0)
				{
					int num5 = 0;
					string string_ = Marshal.PtrToStringAnsi(smethod_0(intptr_1, int_));
					IntPtr intPtr = GetModuleHandle(string_);
					if (IntPtr.Zero == intPtr)
					{
						intPtr = LoadLibrary(string_);
						if (IntPtr.Zero == intPtr)
						{
							break;
						}
					}
					num5 = Marshal.ReadInt32(intptr_1, num3);
					Marshal.ReadInt32(intptr_1, num4);
					while (num5 != 0)
					{
						IntPtr zero = IntPtr.Zero;
						int num6 = num5;
						if ((uint)num6 > 2147483648u)
						{
							int value = num6 & 0xFFFF;
							zero = GetProcAddress(intPtr, new IntPtr(value));
						}
						else
						{
							Marshal.PtrToStringAnsi(smethod_0(intptr_1, num6 + 2));
							zero = GetProcAddress(intPtr, smethod_0(intptr_1, num6 + 2));
						}
						if (!(IntPtr.Zero == zero))
						{
							Marshal.WriteInt32(intptr_1, num4, (int)zero);
							num3 += 4;
							num4 += 4;
							num5 = Marshal.ReadInt32(intptr_1, num3);
							Marshal.ReadInt32(intptr_1, num4);
							continue;
						}
						return -1;
					}
					num += 20;
					num3 = Marshal.ReadInt32(intptr_1, num);
					num4 = Marshal.ReadInt32(intptr_1, num + 16);
					int_ = Marshal.ReadInt32(intptr_1, num + 12);
					continue;
				}
				return 0;
			}
			return -1;
		}

		private static int smethod_16(IntPtr intptr_0, IntPtr intptr_1)
		{
			int num = 0;
			uint num2 = (uint)Marshal.ReadInt32(intptr_0, 0);
			if (num2 > 8)
			{
				IntPtr ptr = smethod_0(intptr_0, 54);
				num = Marshal.ReadInt32(ptr);
			}
			else
			{
				IntPtr intptr_2 = smethod_5(intptr_1);
				IntPtr ptr = smethod_0(intptr_2, 8);
				num = Marshal.ReadInt32(ptr);
			}
			int num3 = Marshal.ReadInt32(intptr_1, num);
			int num4 = Marshal.ReadInt32(intptr_1, num + 16);
			int int_ = Marshal.ReadInt32(intptr_1, num + 12);
			while (true)
			{
				if (num3 != 0)
				{
					long num5 = 0L;
					string string_ = Marshal.PtrToStringAnsi(smethod_0(intptr_1, int_));
					IntPtr intPtr = GetModuleHandle(string_);
					if (IntPtr.Zero == intPtr)
					{
						intPtr = LoadLibrary(string_);
						if (IntPtr.Zero == intPtr)
						{
							break;
						}
					}
					num5 = Marshal.ReadInt64(intptr_1, num3);
					Marshal.ReadInt64(intptr_1, num4);
					while ((ulong)num5 > 0uL)
					{
						IntPtr zero = IntPtr.Zero;
						long num6 = num5;
						if ((ulong)num6 > 9223372036854775808uL)
						{
							ulong value = (ulong)(num6 & 0xFFFFL);
							zero = GetProcAddress(intPtr, new IntPtr((long)value));
						}
						else
						{
							Marshal.PtrToStringAnsi(smethod_0(intptr_1, (int)num6 + 2));
							zero = GetProcAddress(intPtr, smethod_0(intptr_1, (int)num6 + 2));
						}
						if (!(IntPtr.Zero == zero))
						{
							Marshal.WriteInt64(intptr_1, num4, (long)zero);
							num3 += 8;
							num4 += 8;
							num5 = Marshal.ReadInt64(intptr_1, num3);
							Marshal.ReadInt64(intptr_1, num4);
							continue;
						}
						return -1;
					}
					num += 20;
					num3 = Marshal.ReadInt32(intptr_1, num);
					num4 = Marshal.ReadInt32(intptr_1, num + 16);
					int_ = Marshal.ReadInt32(intptr_1, num + 12);
					continue;
				}
				return 0;
			}
			return -1;
		}

		private static uint smethod_17(uint uint_0)
		{
			uint num = 536870912u;
			uint num2 = 1073741824u;
			uint num3 = 2147483648u;
			uint num4 = 16u;
			uint num5 = 32u;
			uint num6 = 64u;
			uint num7 = 4u;
			uint num8 = 2u;
			uint num9 = 0u;
			if (((int)uint_0 & -536870912) != 0)
			{
				return num9 | num6;
			}
			if ((uint_0 & (num2 | num3)) != 0)
			{
				return num9 | num7;
			}
			if ((uint_0 & (num | num2)) != 0)
			{
				return num9 | num5;
			}
			if ((uint_0 & num) != 0)
			{
				return num9 | num4;
			}
			return num9 | num8;
		}

		private static int smethod_18(IntPtr intptr_0, IntPtr intptr_1)
		{
			uint uint_ = 2u;
			uint num = (uint)Marshal.ReadInt32(intptr_0, 0);
			if (num > 8)
			{
				ushort num2 = (ushort)Marshal.ReadInt16(intptr_0, 6);
				IntPtr ptr = smethod_0(intptr_0, 94);
				for (ushort num3 = 0; num3 < num2; num3 = (ushort)(num3 + 1))
				{
					uint uint_2 = (uint)Marshal.ReadInt32(ptr, 36 * num3 + 4);
					uint int_ = (uint)Marshal.ReadInt32(ptr, 36 * num3);
					uint uint_3 = (uint)Marshal.ReadInt32(ptr, 36 * num3 + 16);
					uint uint_4 = smethod_17(uint_3);
					uint uint_5 = 0u;
					VirtualProtect(smethod_0(intptr_1, (int)int_), uint_2, uint_4, out uint_5);
				}
				num = (uint)Marshal.ReadInt32(ptr, 0);
				uint uint_6 = 0u;
				VirtualProtect(intptr_1, num, uint_, out uint_6);
			}
			else
			{
				IntPtr ptr2 = smethod_3(intptr_1);
				int num4 = Marshal.ReadInt16(ptr2, 6);
				IntPtr ptr = smethod_6(intptr_1);
				for (int i = 0; i < num4; i++)
				{
					uint uint_2 = (uint)Marshal.ReadInt32(ptr, 8);
					uint int_ = (uint)Marshal.ReadInt32(ptr, 12);
					Marshal.ReadInt32(ptr, 16);
					Marshal.ReadInt32(ptr, 20);
					uint uint_3 = (uint)Marshal.ReadInt32(ptr, 36);
					uint uint_4 = smethod_17(uint_3);
					uint uint_5 = 0u;
					VirtualProtect(smethod_0(intptr_1, (int)int_), uint_2, uint_4, out uint_5);
					ptr = smethod_0(ptr, 40);
				}
			}
			return 0;
		}

		public static IntPtr smethod_19(GStruct1 gstruct1_0, IntPtr intptr_0)
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			int num = Marshal.ReadInt32(intptr_0, 0);
			byte[] array = new byte[16];
			Marshal.Copy(smethod_0(intptr_0, 8), array, 0, 16);
			IntPtr intptr_ = smethod_0(intptr_0, 24);
			zero2 = Marshal.AllocHGlobal(num);
			smethod_1(array, zero2, intptr_, num);
			int int_ = Marshal.ReadInt32(zero2, 0);
			zero = smethod_13(zero2, smethod_0(zero2, int_));
			if (zero == IntPtr.Zero)
			{
				return IntPtr.Zero;
			}
			if (smethod_14(zero2, zero) != 0)
			{
				smethod_2(zero);
				return IntPtr.Zero;
			}
			if (!smethod_7(zero))
			{
				if (smethod_15(zero2, zero) != 0)
				{
					smethod_2(zero);
					return IntPtr.Zero;
				}
			}
			else if (smethod_16(zero2, zero) != 0)
			{
				smethod_2(zero);
				return IntPtr.Zero;
			}
			if (smethod_18(zero2, zero) != 0)
			{
				smethod_2(zero);
				return IntPtr.Zero;
			}
			IntPtr ptr = smethod_10(zero);
			Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(ptr, typeof(Delegate0));
			if (@delegate(zero, 1u, IntPtr.Zero) == 0)
			{
				smethod_2(zero);
				return IntPtr.Zero;
			}
			Marshal.FreeHGlobal(zero2);
			return zero;
		}

		public static IntPtr smethod_20(IntPtr intptr_0, string string_0)
		{
			IntPtr intptr_ = smethod_5(intptr_0);
			IntPtr ptr = smethod_0(intptr_, 0);
			int num = Marshal.ReadInt32(ptr);
			Marshal.ReadInt32(intptr_0, num);
			int num2 = -1;
			int num3 = 0;
			num3 = Marshal.ReadInt32(intptr_0, num + 20);
			int num4 = Marshal.ReadInt32(intptr_0, num + 36);
			int num5 = Marshal.ReadInt32(intptr_0, num + 16);
			if (string_0[0] == '#')
			{
				string value = string_0.Substring(1);
				num2 = Convert.ToInt32(value);
				num2 -= num5;
			}
			else
			{
				int num6 = -1;
				int num7 = Marshal.ReadInt32(intptr_0, num + 24);
				int num8 = Marshal.ReadInt32(intptr_0, num + 32);
				for (int i = 0; i < num7; i++)
				{
					int int_ = Marshal.ReadInt32(intptr_0, num8);
					string strA = Marshal.PtrToStringAnsi(smethod_0(intptr_0, int_));
					if (0 != string.Compare(strA, string_0))
					{
						num8 += 4;
						continue;
					}
					num6 = i;
					break;
				}
				if (num6 >= 0)
				{
					num2 = Marshal.ReadInt16(intptr_0, num4 + num6 * 2);
				}
			}
			if (num2 == -1 || num2 > num3)
			{
				return IntPtr.Zero;
			}
			int int_2 = Marshal.ReadInt32(intptr_0, num + 28);
			return smethod_0(intptr_0, Marshal.ReadInt32(smethod_0(intptr_0, int_2), num2 * 4));
		}

		public static IntPtr smethod_21(IntPtr intptr_0, IntPtr intptr_1)
		{
			string string_ = (intptr_1.ToInt64() >= 65535L) ? Marshal.PtrToStringAnsi(intptr_1) : ("#" + intptr_1.ToInt64());
			return smethod_20(intptr_0, string_);
		}

		public static int smethod_22(byte[] byte_0)
		{
			return BitConverter.ToInt32(byte_0, 60);
		}

		public static int smethod_23(byte[] byte_0)
		{
			int num = smethod_22(byte_0);
			return num + 20 + 4;
		}

		public static int smethod_24(byte[] byte_0)
		{
			int num = smethod_23(byte_0);
			short num2 = BitConverter.ToInt16(byte_0, num);
			int num3 = 96;
			if (num2 != 267)
			{
				num3 = 112;
			}
			return num + num3 + 128;
		}
	}
}
