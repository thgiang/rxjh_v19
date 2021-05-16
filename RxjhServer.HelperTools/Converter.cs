using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RxjhServer.HelperTools
{
	public class Converter
	{
		public static Dictionary<string, byte[]> Hexstring = new Dictionary<string, byte[]>();

		public static byte ToByte(byte[] byte_0, ref int int_0)
		{
			return byte_0[int_0++];
		}

		public static void ToBytes(byte byte_0, byte[] byte_1, ref int int_0)
		{
			byte_1[int_0++] = byte_0;
		}

		public static void ToBytes(BitArray bitArray_0, byte[] byte_0, ref int int_0)
		{
			bitArray_0.CopyTo(byte_0, int_0);
			int_0 += bitArray_0.Length / 8;
		}

		public static void ToBytes(double double_0, byte[] byte_0, ref int int_0)
		{
			byte[] bytes = BitConverter.GetBytes(double_0);
			System.Buffer.BlockCopy(bytes, 0, byte_0, int_0, bytes.Length);
			int_0 += bytes.Length;
		}

		public static void ToBytes(short short_0, byte[] byte_0, ref int int_0)
		{
			byte_0[int_0++] = (byte)(short_0 & 0xFF);
			byte_0[int_0++] = (byte)((short_0 >> 8) & 0xFF);
		}

		public static void ToBytes(int int_0, byte[] byte_0, ref int int_1)
		{
			byte_0[int_1++] = (byte)(int_0 & 0xFF);
			byte_0[int_1++] = (byte)((int_0 >> 8) & 0xFF);
			byte_0[int_1++] = (byte)((int_0 >> 16) & 0xFF);
			byte_0[int_1++] = (byte)((int_0 >> 24) & 0xFF);
		}

		public static void ToBytes(long long_0, byte[] byte_0, ref int int_0)
		{
			ToBytes((ulong)long_0, byte_0, ref int_0);
		}

		public static void ToBytes(object object_0, byte[] byte_0, ref int int_0)
		{
			if (object_0 is int)
			{
				ToBytes((int)object_0, byte_0, ref int_0);
			}
			if (object_0 is uint)
			{
				ToBytes((uint)object_0, byte_0, ref int_0);
			}
			else if (object_0 is ulong)
			{
				ToBytes((ulong)object_0, byte_0, ref int_0);
			}
			else if (object_0 is long)
			{
				ToBytes((long)object_0, byte_0, ref int_0);
			}
			else if (object_0 is ushort)
			{
				ToBytes((ushort)object_0, byte_0, ref int_0);
			}
			else if (object_0 is short)
			{
				ToBytes((short)object_0, byte_0, ref int_0);
			}
			else if (object_0 is byte)
			{
				ToBytes((byte)object_0, byte_0, ref int_0);
			}
			else if (object_0 is string)
			{
				ToBytes((string)object_0, byte_0, ref int_0);
			}
		}

		public static void ToBytes(float float_0, byte[] byte_0, ref int int_0)
		{
			byte[] bytes = BitConverter.GetBytes(float_0);
			System.Buffer.BlockCopy(bytes, 0, byte_0, int_0, bytes.Length);
			int_0 += bytes.Length;
		}

		public static void ToBytes(string string_0, byte[] byte_0, ref int int_0)
		{
			char[] array = string_0.ToCharArray();
			foreach (char c in array)
			{
				byte_0[int_0++] = (byte)c;
			}
		}

		public static void ToBytes(ushort ushort_0, byte[] byte_0, ref int int_0)
		{
			byte_0[int_0++] = (byte)(ushort_0 & 0xFF);
			byte_0[int_0++] = (byte)((ushort_0 >> 8) & 0xFF);
		}

		public static void ToBytes(uint uint_0, byte[] byte_0, ref int int_0)
		{
			byte_0[int_0++] = (byte)(uint_0 & 0xFF);
			byte_0[int_0++] = (byte)((uint_0 >> 8) & 0xFF);
			byte_0[int_0++] = (byte)((uint_0 >> 16) & 0xFF);
			byte_0[int_0++] = (byte)((uint_0 >> 24) & 0xFF);
		}

		public static void ToBytes(ulong ulong_0, byte[] byte_0, ref int int_0)
		{
			byte_0[int_0++] = (byte)(ulong_0 & 0xFFL);
			byte_0[int_0++] = (byte)((ulong_0 >> 8) & 0xFFL);
			byte_0[int_0++] = (byte)((ulong_0 >> 16) & 0xFFL);
			byte_0[int_0++] = (byte)((ulong_0 >> 24) & 0xFFL);
			byte_0[int_0++] = (byte)((ulong_0 >> 32) & 0xFFL);
			byte_0[int_0++] = (byte)((ulong_0 >> 40) & 0xFFL);
			byte_0[int_0++] = (byte)((ulong_0 >> 48) & 0xFFL);
			byte_0[int_0++] = (byte)((ulong_0 >> 56) & 0xFFL);
		}

		public static void ToBytes(BitArray bitArray_0, byte[] byte_0, ref int int_0, int int_1)
		{
			bitArray_0.CopyTo(byte_0, int_0);
			int_0 += int_1;
		}

		public static double ToDouble(byte[] byte_0, ref int int_0)
		{
			double result = BitConverter.ToDouble(byte_0, int_0);
			int_0 += 8;
			return result;
		}

		public static float ToFloat(byte[] byte_0, ref int int_0)
		{
			float result = BitConverter.ToSingle(byte_0, int_0);
			int_0 += 4;
			return result;
		}

		public static short ToInt16(byte[] byte_0, ref int int_0)
		{
			short result = BitConverter.ToInt16(byte_0, int_0);
			int_0 += 2;
			return result;
		}

		public static int ToInt32(byte[] byte_0, ref int int_0)
		{
			int result = BitConverter.ToInt32(byte_0, int_0);
			int_0 += 4;
			return result;
		}

		public static long ToInt64(byte[] byte_0, ref int int_0)
		{
			long result = BitConverter.ToInt64(byte_0, int_0);
			int_0 += 8;
			return result;
		}

		public static ushort ToUInt16(byte[] byte_0, ref int int_0)
		{
			ushort result = BitConverter.ToUInt16(byte_0, int_0);
			int_0 += 2;
			return result;
		}

		public static uint ToUInt32(byte[] byte_0, ref int int_0)
		{
			uint result = BitConverter.ToUInt32(byte_0, int_0);
			int_0 += 4;
			return result;
		}

		public static ulong ToUInt64(byte[] byte_0, ref int int_0)
		{
			ulong result = BitConverter.ToUInt64(byte_0, int_0);
			int_0 += 8;
			return result;
		}

		public static void ToGuidMark(ulong ulong_0, byte[] byte_0, ref int int_0)
		{
			byte b = 0;
			byte[] array = new byte[8];
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				if (((ulong_0 >> 8 * i) & 0xFFL) != 0L)
				{
					b = (byte)(b + (byte)Math.Pow(2.0, i));
					array[num] = (byte)((ulong_0 >> 8 * i) & 0xFFL);
					num++;
				}
			}
			byte_0[int_0++] = b;
			System.Buffer.BlockCopy(array, 0, byte_0, int_0, num);
			int_0 += num;
		}

		public static ulong ReadGuidToUlong(byte[] byte_0, int int_0)
		{
			byte b = byte_0[int_0++];
			byte[] array = new byte[8];
			for (int i = 0; i < 8; i++)
			{
				if ((byte)((b >> i) & 1) != 0)
				{
					array[i] = byte_0[int_0++];
				}
				else
				{
					array[i] = 0;
				}
			}
			return BitConverter.ToUInt64(array, 0);
		}

		public static string ToString(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			foreach (byte b in byte_0)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string ToString1(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			foreach (byte b in byte_0)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return "0x" + stringBuilder.ToString();
		}

		public static string ToString2(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte value in byte_0)
			{
				stringBuilder.Append(Convert.ToString((short)value, 16).PadLeft(2, '0').ToUpper());
			}
			return stringBuilder.ToString();
		}

		public static byte[] hexStringToByte(string string_0)
		{
			string key = (string_0.Length > 40) ? string_0.Remove(40, string_0.Length - 40) : string_0;
			byte[] value;
			if (!Hexstring.TryGetValue(key, out value))
			{
				value = hexStringToByte2(string_0);
				Hexstring.Add(key, value);
			}
			byte[] array = new byte[value.Length];
			value.CopyTo(array, 0);
			return array;
		}

		public static byte[] hexStringToByte2(string string_0)
		{
			try
			{
				int num = string_0.Length / 2;
				byte[] array = new byte[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = Convert.ToByte(string_0.Substring(i * 2, 2), 16);
				}
				return array;
			}
			catch (Exception)
			{
				return new byte[string_0.Length];
			}
		}

		private static byte smethod_0(char char_0)
		{
			return (byte)"0123456789ABCDEF".IndexOf(char_0);
		}

		public static int getitmeid(string string_0)
		{
			string str = string_0.Substring(4, 2);
			string str2 = string_0.Substring(2, 2);
			string str3 = string_0.Substring(0, 2);
			return int.Parse(str + str2 + str3, NumberStyles.HexNumber);
		}

		public static int getItmeid(string string_0)
		{
			string str = string_0.Substring(6, 2);
			string str2 = string_0.Substring(4, 2);
			string str3 = string_0.Substring(2, 2);
			string str4 = string_0.Substring(0, 2);
			return int.Parse(str + str2 + str3 + str4, NumberStyles.HexNumber);
		}
	}
}
