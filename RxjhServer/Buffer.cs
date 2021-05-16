using System.Runtime.InteropServices;

namespace RxjhServer
{
	public class Buffer
	{
		[DllImport("HelpTool.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void iCopyMemory(int int_0, int int_1, int int_2);

		[DllImport("HelpTool.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void Decrypt(int int_0, byte[] byte_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] byte_1);

		[DllImport("HelpTool.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void String2hex(string string_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] byte_0);

		public static byte[] GetBytes(int int_0)
		{
			byte[] array = new byte[4];
			array[3] = (byte)((int_0 >> 24) & 0xFF);
			array[2] = (byte)((int_0 >> 16) & 0xFF);
			array[1] = (byte)((int_0 >> 8) & 0xFF);
			array[0] = (byte)(int_0 & 0xFF);
			return array;
		}

		public static byte[] GetBytes(long long_0)
		{
			byte[] array = new byte[8];
			array[7] = (byte)((long_0 >> 56) & 0xFFL);
			array[6] = (byte)((long_0 >> 48) & 0xFFL);
			array[5] = (byte)((long_0 >> 40) & 0xFFL);
			array[4] = (byte)((long_0 >> 32) & 0xFFL);
			array[3] = (byte)((long_0 >> 24) & 0xFFL);
			array[2] = (byte)((long_0 >> 16) & 0xFFL);
			array[1] = (byte)((long_0 >> 8) & 0xFFL);
			array[0] = (byte)(long_0 & 0xFFL);
			return array;
		}

		public static int ToInt32(byte[] byte_0, int int_0)
		{
			return (byte_0[int_0] & 0xFF) | ((byte_0[int_0 + 1] & 0xFF) << 8) | ((byte_0[int_0 + 2] & 0xFF) << 16) | ((byte_0[int_0 + 3] & 0xFF) << 24);
		}

		public static short ToInt16(byte[] byte_0, int int_0)
		{
			return (short)((byte_0[int_0] & 0xFF) | ((byte_0[int_0 + 1] & 0xFF) << 8));
		}

		public unsafe static bool IsEquals(string string_0, string string_1)
		{
			bool result = true;
			if (string_0.Length != string_1.Length)
			{
				return false;
			}
			int num = (string_0.Length % 4 != 0) ? (4 - string_0.Length % 4) : 0;
			int num2 = (string_1.Length % 4 != 0) ? (4 - string_0.Length % 4) : 0;
			int num3 = (num > num2) ? num : num2;
			int i;
			for (i = 0; i < num3; i++)
			{
				if (i < num)
				{
					string_0 += "   ";
				}
				if (i < num2)
				{
					string_1 += "   ";
				}
			}
			fixed (char* ptr = string_0)
			{
				fixed (char* ptr3 = string_1)
				{
					char* ptr2 = ptr;
					char* ptr4 = ptr3;
					while (i < string_0.Length)
					{
						if (*(long*)ptr2 != *(long*)ptr4)
						{
							result = false;
							break;
						}
						i += 4;
						ptr2 += 4;
						ptr4 += 4;
					}
				}
			}
			return result;
		}
	}
}
