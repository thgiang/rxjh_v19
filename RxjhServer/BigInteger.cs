using System;

namespace RxjhServer
{
	public class BigInteger
	{
		private const int maxLength = 70;

		public static readonly int[] primesBelow2000 = new int[303]
		{
			2,
			3,
			5,
			7,
			11,
			13,
			17,
			19,
			23,
			29,
			31,
			37,
			41,
			43,
			47,
			53,
			59,
			61,
			67,
			71,
			73,
			79,
			83,
			89,
			97,
			101,
			103,
			107,
			109,
			113,
			127,
			131,
			137,
			139,
			149,
			151,
			157,
			163,
			167,
			173,
			179,
			181,
			191,
			193,
			197,
			199,
			211,
			223,
			227,
			229,
			233,
			239,
			241,
			251,
			257,
			263,
			269,
			271,
			277,
			281,
			283,
			293,
			307,
			311,
			313,
			317,
			331,
			337,
			347,
			349,
			353,
			359,
			367,
			373,
			379,
			383,
			389,
			397,
			401,
			409,
			419,
			421,
			431,
			433,
			439,
			443,
			449,
			457,
			461,
			463,
			467,
			479,
			487,
			491,
			499,
			503,
			509,
			521,
			523,
			541,
			547,
			557,
			563,
			569,
			571,
			577,
			587,
			593,
			599,
			601,
			607,
			613,
			617,
			619,
			631,
			641,
			643,
			647,
			653,
			659,
			661,
			673,
			677,
			683,
			691,
			701,
			709,
			719,
			727,
			733,
			739,
			743,
			751,
			757,
			761,
			769,
			773,
			787,
			797,
			809,
			811,
			821,
			823,
			827,
			829,
			839,
			853,
			857,
			859,
			863,
			877,
			881,
			883,
			887,
			907,
			911,
			919,
			929,
			937,
			941,
			947,
			953,
			967,
			971,
			977,
			983,
			991,
			997,
			1009,
			1013,
			1019,
			1021,
			1031,
			1033,
			1039,
			1049,
			1051,
			1061,
			1063,
			1069,
			1087,
			1091,
			1093,
			1097,
			1103,
			1109,
			1117,
			1123,
			1129,
			1151,
			1153,
			1163,
			1171,
			1181,
			1187,
			1193,
			1201,
			1213,
			1217,
			1223,
			1229,
			1231,
			1237,
			1249,
			1259,
			1277,
			1279,
			1283,
			1289,
			1291,
			1297,
			1301,
			1303,
			1307,
			1319,
			1321,
			1327,
			1361,
			1367,
			1373,
			1381,
			1399,
			1409,
			1423,
			1427,
			1429,
			1433,
			1439,
			1447,
			1451,
			1453,
			1459,
			1471,
			1481,
			1483,
			1487,
			1489,
			1493,
			1499,
			1511,
			1523,
			1531,
			1543,
			1549,
			1553,
			1559,
			1567,
			1571,
			1579,
			1583,
			1597,
			1601,
			1607,
			1609,
			1613,
			1619,
			1621,
			1627,
			1637,
			1657,
			1663,
			1667,
			1669,
			1693,
			1697,
			1699,
			1709,
			1721,
			1723,
			1733,
			1741,
			1747,
			1753,
			1759,
			1777,
			1783,
			1787,
			1789,
			1801,
			1811,
			1823,
			1831,
			1847,
			1861,
			1867,
			1871,
			1873,
			1877,
			1879,
			1889,
			1901,
			1907,
			1913,
			1931,
			1933,
			1949,
			1951,
			1973,
			1979,
			1987,
			1993,
			1997,
			1999
		};

		private uint[] data;

		public int dataLength;

		public BigInteger()
		{
			data = new uint[70];
			dataLength = 1;
		}

		public BigInteger(long long_0)
		{
			data = new uint[70];
			long num = long_0;
			dataLength = 0;
			while (long_0 != 0L && dataLength < 70)
			{
				data[dataLength] = (uint)(long_0 & 0xFFFFFFFFL);
				long_0 >>= 32;
				dataLength++;
			}
			if (num > 0L)
			{
				if (long_0 != 0L || ((int)data[69] & int.MinValue) != 0)
				{
					throw new ArithmeticException("Positive overflow in constructor.");
				}
			}
			else if (num < 0L && (long_0 != -1L || ((int)data[dataLength - 1] & int.MinValue) == 0))
			{
				throw new ArithmeticException("Negative underflow in constructor.");
			}
			if (dataLength == 0)
			{
				dataLength = 1;
			}
		}

		public BigInteger(ulong ulong_0)
		{
			data = new uint[70];
			dataLength = 0;
			while (ulong_0 != 0L && dataLength < 70)
			{
				data[dataLength] = (uint)(ulong_0 & 0xFFFFFFFFL);
				ulong_0 >>= 32;
				dataLength++;
			}
			if (ulong_0 == 0L && ((int)data[69] & int.MinValue) == 0)
			{
				if (dataLength == 0)
				{
					dataLength = 1;
				}
				return;
			}
			throw new ArithmeticException("Positive overflow in constructor.");
		}

		public BigInteger(BigInteger bigInteger_0)
		{
			data = new uint[70];
			dataLength = bigInteger_0.dataLength;
			for (int i = 0; i < dataLength; i++)
			{
				data[i] = bigInteger_0.data[i];
			}
		}

		public BigInteger(string string_0, int int_0)
		{
			BigInteger bigInteger_ = new BigInteger(1L);
			BigInteger bigInteger = new BigInteger();
			string_0 = string_0.ToUpper().Trim();
			int num = 0;
			if (string_0[0] == '-')
			{
				num = 1;
			}
			int num2 = string_0.Length - 1;
			while (true)
			{
				if (num2 >= num)
				{
					int num3 = string_0[num2];
					num3 = ((num3 >= 48 && num3 <= 57) ? (num3 - 48) : ((num3 < 65 || num3 > 90) ? 9999999 : (num3 - 65 + 10)));
					if (num3 < int_0)
					{
						if (string_0[0] == '-')
						{
							num3 = -num3;
						}
						bigInteger += bigInteger_ * num3;
						if (num2 - 1 >= num)
						{
							bigInteger_ *= (BigInteger)int_0;
						}
						num2--;
						continue;
					}
					throw new ArithmeticException("Invalid string in constructor.");
				}
				if (string_0[0] == '-')
				{
					if (((int)bigInteger.data[69] & int.MinValue) == 0)
					{
						throw new ArithmeticException("Negative underflow in constructor.");
					}
				}
				else if (((int)bigInteger.data[69] & int.MinValue) != 0)
				{
					throw new ArithmeticException("Positive overflow in constructor.");
				}
				data = new uint[70];
				for (int i = 0; i < bigInteger.dataLength; i++)
				{
					data[i] = bigInteger.data[i];
				}
				break;
			}
			dataLength = bigInteger.dataLength;
		}

		public BigInteger(byte[] byte_0)
		{
			dataLength = byte_0.Length >> 2;
			int num = byte_0.Length & 3;
			if (num != 0)
			{
				dataLength++;
			}
			if (dataLength > 70)
			{
				throw new ArithmeticException("Byte overflow in constructor.");
			}
			data = new uint[70];
			int num2 = byte_0.Length - 1;
			int num3 = 0;
			while (num2 >= 3)
			{
				data[num3] = (uint)((byte_0[num2 - 3] << 24) + (byte_0[num2 - 2] << 16) + (byte_0[num2 - 1] << 8) + byte_0[num2]);
				num2 -= 4;
				num3++;
			}
			switch (num)
			{
			case 1:
				data[dataLength - 1] = byte_0[0];
				break;
			case 2:
				data[dataLength - 1] = (uint)((byte_0[0] << 8) + byte_0[1]);
				break;
			case 3:
				data[dataLength - 1] = (uint)((byte_0[0] << 16) + (byte_0[1] << 8) + byte_0[2]);
				break;
			}
			while (dataLength > 1 && data[dataLength - 1] == 0)
			{
				dataLength--;
			}
		}

		public BigInteger(byte[] byte_0, int int_0)
		{
			dataLength = int_0 >> 2;
			int num = int_0 & 3;
			if (num != 0)
			{
				dataLength++;
			}
			if (dataLength <= 70 && int_0 <= byte_0.Length)
			{
				data = new uint[70];
				int num2 = int_0 - 1;
				int num3 = 0;
				while (num2 >= 3)
				{
					data[num3] = (uint)((byte_0[num2 - 3] << 24) + (byte_0[num2 - 2] << 16) + (byte_0[num2 - 1] << 8) + byte_0[num2]);
					num2 -= 4;
					num3++;
				}
				switch (num)
				{
				case 1:
					data[dataLength - 1] = byte_0[0];
					break;
				case 2:
					data[dataLength - 1] = (uint)((byte_0[0] << 8) + byte_0[1]);
					break;
				case 3:
					data[dataLength - 1] = (uint)((byte_0[0] << 16) + (byte_0[1] << 8) + byte_0[2]);
					break;
				}
				if (dataLength == 0)
				{
					dataLength = 1;
				}
				while (dataLength > 1 && data[dataLength - 1] == 0)
				{
					dataLength--;
				}
				return;
			}
			throw new ArithmeticException("Byte overflow in constructor.");
		}

		public BigInteger(uint[] uint_0)
		{
			dataLength = uint_0.Length;
			if (dataLength > 70)
			{
				throw new ArithmeticException("Byte overflow in constructor.");
			}
			data = new uint[70];
			int num = dataLength - 1;
			int num2 = 0;
			while (num >= 0)
			{
				data[num2] = uint_0[num];
				num--;
				num2++;
			}
			while (dataLength > 1 && data[dataLength - 1] == 0)
			{
				dataLength--;
			}
		}

		public static implicit operator BigInteger(long long_0)
		{
			return new BigInteger(long_0);
		}

		public static implicit operator BigInteger(ulong ulong_0)
		{
			return new BigInteger(ulong_0);
		}

		public static implicit operator BigInteger(int int_0)
		{
			return new BigInteger(int_0);
		}

		public static implicit operator BigInteger(uint uint_0)
		{
			return new BigInteger((ulong)uint_0);
		}

		public static BigInteger operator +(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			BigInteger bigInteger = new BigInteger();
			bigInteger.dataLength = ((bigInteger_0.dataLength > bigInteger_1.dataLength) ? bigInteger_0.dataLength : bigInteger_1.dataLength);
			long num = 0L;
			for (int i = 0; i < bigInteger.dataLength; i++)
			{
				long num2 = (long)bigInteger_0.data[i] + (long)bigInteger_1.data[i] + num;
				num = num2 >> 32;
				bigInteger.data[i] = (uint)(num2 & 0xFFFFFFFFL);
			}
			if (num != 0L && bigInteger.dataLength < 70)
			{
				bigInteger.data[bigInteger.dataLength] = (uint)num;
				bigInteger.dataLength++;
			}
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			int num3 = 69;
			if (((int)bigInteger_0.data[69] & int.MinValue) == ((int)bigInteger_1.data[69] & int.MinValue) && ((int)bigInteger.data[num3] & int.MinValue) != ((int)bigInteger_0.data[num3] & int.MinValue))
			{
				throw new ArithmeticException();
			}
			return bigInteger;
		}

		public static BigInteger operator ++(BigInteger bigInteger_0)
		{
			BigInteger bigInteger = new BigInteger(bigInteger_0);
			long num = 1L;
			int num2 = 0;
			while (num != 0L && num2 < 70)
			{
				long num3 = bigInteger.data[num2];
				num3++;
				bigInteger.data[num2] = (uint)(num3 & 0xFFFFFFFFL);
				num = num3 >> 32;
				num2++;
			}
			if (num2 > bigInteger.dataLength)
			{
				bigInteger.dataLength = num2;
			}
			else
			{
				while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
				{
					bigInteger.dataLength--;
				}
			}
			int num4 = 69;
			if (((int)bigInteger_0.data[69] & int.MinValue) == 0 && ((int)bigInteger.data[num4] & int.MinValue) != ((int)bigInteger_0.data[num4] & int.MinValue))
			{
				throw new ArithmeticException("Overflow in ++.");
			}
			return bigInteger;
		}

		public static BigInteger operator -(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			BigInteger bigInteger = new BigInteger();
			bigInteger.dataLength = ((bigInteger_0.dataLength > bigInteger_1.dataLength) ? bigInteger_0.dataLength : bigInteger_1.dataLength);
			long num = 0L;
			for (int i = 0; i < bigInteger.dataLength; i++)
			{
				long num2 = (long)bigInteger_0.data[i] - (long)bigInteger_1.data[i] - num;
				bigInteger.data[i] = (uint)(num2 & 0xFFFFFFFFL);
				num = ((num2 >= 0L) ? 0L : 1L);
			}
			if (num != 0L)
			{
				for (int j = bigInteger.dataLength; j < 70; j++)
				{
					bigInteger.data[j] = uint.MaxValue;
				}
				bigInteger.dataLength = 70;
			}
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			int num3 = 69;
			if (((int)bigInteger_0.data[69] & int.MinValue) != ((int)bigInteger_1.data[69] & int.MinValue) && ((int)bigInteger.data[num3] & int.MinValue) != ((int)bigInteger_0.data[num3] & int.MinValue))
			{
				throw new ArithmeticException();
			}
			return bigInteger;
		}

		public static BigInteger operator --(BigInteger bigInteger_0)
		{
			BigInteger bigInteger = new BigInteger(bigInteger_0);
			bool flag = true;
			int num = 0;
			while (flag && num < 70)
			{
				long num2 = bigInteger.data[num];
				num2--;
				bigInteger.data[num] = (uint)(num2 & 0xFFFFFFFFL);
				if (num2 >= 0L)
				{
					flag = false;
				}
				num++;
			}
			if (num > bigInteger.dataLength)
			{
				bigInteger.dataLength = num;
			}
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			int num3 = 69;
			if (((int)bigInteger_0.data[69] & int.MinValue) != 0 && ((int)bigInteger.data[num3] & int.MinValue) != ((int)bigInteger_0.data[num3] & int.MinValue))
			{
				throw new ArithmeticException("Underflow in --.");
			}
			return bigInteger;
		}

		public static BigInteger operator *(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			int num = 69;
			bool flag = false;
			bool flag2 = false;
			try
			{
				if (((int)bigInteger_0.data[num] & int.MinValue) != 0)
				{
					flag = true;
					bigInteger_0 = -bigInteger_0;
				}
				if (((int)bigInteger_1.data[num] & int.MinValue) != 0)
				{
					flag2 = true;
					bigInteger_1 = -bigInteger_1;
				}
			}
			catch (Exception)
			{
			}
			BigInteger bigInteger = new BigInteger();
			try
			{
				for (int i = 0; i < bigInteger_0.dataLength; i++)
				{
					if (bigInteger_0.data[i] != 0)
					{
						ulong num2 = 0uL;
						int num3 = 0;
						int num4 = i;
						while (num3 < bigInteger_1.dataLength)
						{
							ulong num5 = (ulong)((long)bigInteger_0.data[i] * (long)bigInteger_1.data[num3] + bigInteger.data[num4] + (long)num2);
							bigInteger.data[num4] = (uint)(num5 & 0xFFFFFFFFL);
							num2 = num5 >> 32;
							num3++;
							num4++;
						}
						if (num2 != 0L)
						{
							bigInteger.data[i + bigInteger_1.dataLength] = (uint)num2;
						}
					}
				}
			}
			catch (Exception)
			{
				throw new ArithmeticException("Multiplication overflow.");
			}
			bigInteger.dataLength = bigInteger_0.dataLength + bigInteger_1.dataLength;
			if (bigInteger.dataLength > 70)
			{
				bigInteger.dataLength = 70;
			}
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			if (((int)bigInteger.data[num] & int.MinValue) != 0)
			{
				if (flag != flag2 && bigInteger.data[num] == 2147483648u)
				{
					if (bigInteger.dataLength == 1)
					{
						return bigInteger;
					}
					bool flag3 = true;
					for (int j = 0; j < bigInteger.dataLength - 1 && flag3; j++)
					{
						if (bigInteger.data[j] != 0)
						{
							flag3 = false;
						}
					}
					if (flag3)
					{
						return bigInteger;
					}
				}
				throw new ArithmeticException("Multiplication overflow.");
			}
			if (flag != flag2)
			{
				return -bigInteger;
			}
			return bigInteger;
		}

		public static BigInteger operator <<(BigInteger bigInteger_0, int int_0)
		{
			BigInteger bigInteger = new BigInteger(bigInteger_0);
			bigInteger.dataLength = smethod_0(bigInteger.data, int_0);
			return bigInteger;
		}

		private static int smethod_0(uint[] uint_0, int int_0)
		{
			int num = 32;
			int num2 = uint_0.Length;
			while (num2 > 1 && uint_0[num2 - 1] == 0)
			{
				num2--;
			}
			for (int num3 = int_0; num3 > 0; num3 -= num)
			{
				if (num3 < num)
				{
					num = num3;
				}
				ulong num4 = 0uL;
				for (int i = 0; i < num2; i++)
				{
					ulong num5 = (ulong)uint_0[i] << num;
					num5 |= num4;
					uint_0[i] = (uint)(num5 & 0xFFFFFFFFL);
					num4 = num5 >> 32;
				}
				if (num4 != 0L && num2 + 1 <= uint_0.Length)
				{
					uint_0[num2] = (uint)num4;
					num2++;
				}
			}
			return num2;
		}

		public static BigInteger operator >>(BigInteger bigInteger_0, int int_0)
		{
			BigInteger bigInteger = new BigInteger(bigInteger_0);
			bigInteger.dataLength = smethod_1(bigInteger.data, int_0);
			if (((int)bigInteger_0.data[69] & int.MinValue) != 0)
			{
				for (int num = 69; num >= bigInteger.dataLength; num--)
				{
					bigInteger.data[num] = uint.MaxValue;
				}
				uint num2 = 2147483648u;
				for (int i = 0; i < 32; i++)
				{
					if ((bigInteger.data[bigInteger.dataLength - 1] & num2) != 0)
					{
						break;
					}
					bigInteger.data[bigInteger.dataLength - 1] |= num2;
					num2 >>= 1;
				}
				bigInteger.dataLength = 70;
			}
			return bigInteger;
		}

		private static int smethod_1(uint[] uint_0, int int_0)
		{
			int num = 32;
			int num2 = 0;
			int num3 = uint_0.Length;
			while (num3 > 1 && uint_0[num3 - 1] == 0)
			{
				num3--;
			}
			for (int num4 = int_0; num4 > 0; num4 -= num)
			{
				if (num4 < num)
				{
					num = num4;
					num2 = 32 - num;
				}
				ulong num5 = 0uL;
				for (int num6 = num3 - 1; num6 >= 0; num6--)
				{
					ulong num7 = (ulong)uint_0[num6] >> num;
					num7 |= num5;
					num5 = (ulong)uint_0[num6] << num2;
					uint_0[num6] = (uint)num7;
				}
			}
			while (num3 > 1 && uint_0[num3 - 1] == 0)
			{
				num3--;
			}
			return num3;
		}

		public static BigInteger operator ~(BigInteger bigInteger_0)
		{
			BigInteger bigInteger = new BigInteger(bigInteger_0);
			for (int i = 0; i < 70; i++)
			{
				bigInteger.data[i] = ~bigInteger_0.data[i];
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static BigInteger operator -(BigInteger bigInteger_0)
		{
			if (bigInteger_0.dataLength == 1 && bigInteger_0.data[0] == 0)
			{
				return new BigInteger();
			}
			BigInteger bigInteger = new BigInteger(bigInteger_0);
			for (int i = 0; i < 70; i++)
			{
				bigInteger.data[i] = ~bigInteger_0.data[i];
			}
			long num = 1L;
			int num2 = 0;
			while (num != 0L && num2 < 70)
			{
				long num3 = bigInteger.data[num2];
				num3++;
				bigInteger.data[num2] = (uint)(num3 & 0xFFFFFFFFL);
				num = num3 >> 32;
				num2++;
			}
			if (((int)bigInteger_0.data[69] & int.MinValue) == ((int)bigInteger.data[69] & int.MinValue))
			{
				throw new ArithmeticException("Overflow in negation.\n");
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static bool operator ==(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			return bigInteger_0.Equals(bigInteger_1);
		}

		public static bool operator !=(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			return !bigInteger_0.Equals(bigInteger_1);
		}

		public override bool Equals(object obj)
		{
			BigInteger bigInteger = (BigInteger)obj;
			if (dataLength != bigInteger.dataLength)
			{
				return false;
			}
			int num = 0;
			while (true)
			{
				if (num < dataLength)
				{
					if (data[num] != bigInteger.data[num])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public static bool operator >(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			int num = 69;
			if (((int)bigInteger_0.data[69] & int.MinValue) != 0 && ((int)bigInteger_1.data[num] & int.MinValue) == 0)
			{
				return false;
			}
			if (((int)bigInteger_0.data[num] & int.MinValue) == 0 && ((int)bigInteger_1.data[num] & int.MinValue) != 0)
			{
				return true;
			}
			num = ((bigInteger_0.dataLength > bigInteger_1.dataLength) ? bigInteger_0.dataLength : bigInteger_1.dataLength) - 1;
			while (num >= 0 && bigInteger_0.data[num] == bigInteger_1.data[num])
			{
				num--;
			}
			if (num >= 0)
			{
				if (bigInteger_0.data[num] > bigInteger_1.data[num])
				{
					return true;
				}
				return false;
			}
			return false;
		}

		public static bool operator <(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			int num = 69;
			if (((int)bigInteger_0.data[69] & int.MinValue) != 0 && ((int)bigInteger_1.data[num] & int.MinValue) == 0)
			{
				return true;
			}
			if (((int)bigInteger_0.data[num] & int.MinValue) == 0 && ((int)bigInteger_1.data[num] & int.MinValue) != 0)
			{
				return false;
			}
			num = ((bigInteger_0.dataLength > bigInteger_1.dataLength) ? bigInteger_0.dataLength : bigInteger_1.dataLength) - 1;
			while (num >= 0 && bigInteger_0.data[num] == bigInteger_1.data[num])
			{
				num--;
			}
			if (num >= 0)
			{
				if (bigInteger_0.data[num] < bigInteger_1.data[num])
				{
					return true;
				}
				return false;
			}
			return false;
		}

		public static bool operator >=(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			if (!(bigInteger_0 == bigInteger_1))
			{
				return bigInteger_0 > bigInteger_1;
			}
			return true;
		}

		public static bool operator <=(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			if (!(bigInteger_0 == bigInteger_1))
			{
				return bigInteger_0 < bigInteger_1;
			}
			return true;
		}

		private static void smethod_2(BigInteger bigInteger_0, BigInteger bigInteger_1, BigInteger bigInteger_2, BigInteger bigInteger_3)
		{
			uint[] array = new uint[70];
			int num = bigInteger_0.dataLength + 1;
			uint[] array2 = new uint[num];
			uint num2 = 2147483648u;
			uint num3 = bigInteger_1.data[bigInteger_1.dataLength - 1];
			int num4 = 0;
			int num5 = 0;
			while (num2 != 0 && (num3 & num2) == 0)
			{
				num4++;
				num2 >>= 1;
			}
			for (int i = 0; i < bigInteger_0.dataLength; i++)
			{
				array2[i] = bigInteger_0.data[i];
			}
			smethod_0(array2, num4);
			bigInteger_1 <<= num4;
			int num6 = num - bigInteger_1.dataLength;
			int num7 = num - 1;
			ulong num8 = bigInteger_1.data[bigInteger_1.dataLength - 1];
			ulong num9 = bigInteger_1.data[bigInteger_1.dataLength - 2];
			int num10 = bigInteger_1.dataLength + 1;
			uint[] array3 = new uint[num10];
			while (num6 > 0)
			{
				ulong num11 = ((ulong)array2[num7] << 32) + array2[num7 - 1];
				ulong num12 = num11 / num8;
				ulong num13 = num11 % num8;
				bool flag = false;
				while (!flag)
				{
					flag = true;
					if (num12 == 4294967296L || num12 * num9 > (num13 << 32) + array2[num7 - 2])
					{
						num12--;
						num13 += num8;
						if (num13 < 4294967296L)
						{
							flag = false;
						}
					}
				}
				for (int j = 0; j < num10; j++)
				{
					array3[j] = array2[num7 - j];
				}
				BigInteger bigInteger = new BigInteger(array3);
				BigInteger bigInteger2;
				for (bigInteger2 = bigInteger_1 * (long)num12; bigInteger2 > bigInteger; bigInteger2 -= bigInteger_1)
				{
					num12--;
				}
				BigInteger bigInteger3 = bigInteger - bigInteger2;
				for (int k = 0; k < num10; k++)
				{
					array2[num7 - k] = bigInteger3.data[bigInteger_1.dataLength - k];
				}
				array[num5++] = (uint)num12;
				num7--;
				num6--;
			}
			bigInteger_2.dataLength = num5;
			int l = 0;
			int num14 = bigInteger_2.dataLength - 1;
			while (num14 >= 0)
			{
				bigInteger_2.data[l] = array[num14];
				num14--;
				l++;
			}
			for (; l < 70; l++)
			{
				bigInteger_2.data[l] = 0u;
			}
			while (bigInteger_2.dataLength > 1 && bigInteger_2.data[bigInteger_2.dataLength - 1] == 0)
			{
				bigInteger_2.dataLength--;
			}
			if (bigInteger_2.dataLength == 0)
			{
				bigInteger_2.dataLength = 1;
			}
			bigInteger_3.dataLength = smethod_1(array2, num4);
			for (l = 0; l < bigInteger_3.dataLength; l++)
			{
				bigInteger_3.data[l] = array2[l];
			}
			for (; l < 70; l++)
			{
				bigInteger_3.data[l] = 0u;
			}
		}

		private static void smethod_3(BigInteger bigInteger_0, BigInteger bigInteger_1, BigInteger bigInteger_2, BigInteger bigInteger_3)
		{
			uint[] array = new uint[70];
			int num = 0;
			for (int i = 0; i < 70; i++)
			{
				bigInteger_3.data[i] = bigInteger_0.data[i];
			}
			bigInteger_3.dataLength = bigInteger_0.dataLength;
			while (bigInteger_3.dataLength > 1 && bigInteger_3.data[bigInteger_3.dataLength - 1] == 0)
			{
				bigInteger_3.dataLength--;
			}
			ulong num2 = bigInteger_1.data[0];
			int num3 = bigInteger_3.dataLength - 1;
			ulong num4 = bigInteger_3.data[num3];
			if (num4 >= num2)
			{
				ulong num5 = num4 / num2;
				array[num++] = (uint)num5;
				bigInteger_3.data[num3] = (uint)(num4 % num2);
			}
			num3--;
			while (num3 >= 0)
			{
				num4 = ((ulong)bigInteger_3.data[num3 + 1] << 32) + bigInteger_3.data[num3];
				ulong num6 = num4 / num2;
				array[num++] = (uint)num6;
				bigInteger_3.data[num3 + 1] = 0u;
				bigInteger_3.data[num3--] = (uint)(num4 % num2);
			}
			bigInteger_2.dataLength = num;
			int j = 0;
			int num7 = bigInteger_2.dataLength - 1;
			while (num7 >= 0)
			{
				bigInteger_2.data[j] = array[num7];
				num7--;
				j++;
			}
			for (; j < 70; j++)
			{
				bigInteger_2.data[j] = 0u;
			}
			while (bigInteger_2.dataLength > 1 && bigInteger_2.data[bigInteger_2.dataLength - 1] == 0)
			{
				bigInteger_2.dataLength--;
			}
			if (bigInteger_2.dataLength == 0)
			{
				bigInteger_2.dataLength = 1;
			}
			while (bigInteger_3.dataLength > 1 && bigInteger_3.data[bigInteger_3.dataLength - 1] == 0)
			{
				bigInteger_3.dataLength--;
			}
		}

		public static BigInteger operator /(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			BigInteger bigInteger = new BigInteger();
			BigInteger bigInteger_2 = new BigInteger();
			int num = 69;
			bool flag = false;
			bool flag2 = false;
			if (((int)bigInteger_0.data[69] & int.MinValue) != 0)
			{
				bigInteger_0 = -bigInteger_0;
				flag2 = true;
			}
			if (((int)bigInteger_1.data[num] & int.MinValue) != 0)
			{
				bigInteger_1 = -bigInteger_1;
				flag = true;
			}
			if (bigInteger_0 < bigInteger_1)
			{
				return bigInteger;
			}
			if (bigInteger_1.dataLength == 1)
			{
				smethod_3(bigInteger_0, bigInteger_1, bigInteger, bigInteger_2);
			}
			else
			{
				smethod_2(bigInteger_0, bigInteger_1, bigInteger, bigInteger_2);
			}
			if (flag2 != flag)
			{
				return -bigInteger;
			}
			return bigInteger;
		}

		public static BigInteger operator %(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			BigInteger bigInteger_2 = new BigInteger();
			BigInteger bigInteger = new BigInteger(bigInteger_0);
			int num = 69;
			bool flag = false;
			if (((int)bigInteger_0.data[69] & int.MinValue) != 0)
			{
				bigInteger_0 = -bigInteger_0;
				flag = true;
			}
			if (((int)bigInteger_1.data[num] & int.MinValue) != 0)
			{
				bigInteger_1 = -bigInteger_1;
			}
			if (bigInteger_0 < bigInteger_1)
			{
				return bigInteger;
			}
			if (bigInteger_1.dataLength == 1)
			{
				smethod_3(bigInteger_0, bigInteger_1, bigInteger_2, bigInteger);
			}
			else
			{
				smethod_2(bigInteger_0, bigInteger_1, bigInteger_2, bigInteger);
			}
			if (flag)
			{
				return -bigInteger;
			}
			return bigInteger;
		}

		public static BigInteger operator &(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			BigInteger bigInteger = new BigInteger();
			int num = (bigInteger_0.dataLength > bigInteger_1.dataLength) ? bigInteger_0.dataLength : bigInteger_1.dataLength;
			for (int i = 0; i < num; i++)
			{
				uint num2 = bigInteger_0.data[i] & bigInteger_1.data[i];
				bigInteger.data[i] = num2;
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static BigInteger operator |(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			BigInteger bigInteger = new BigInteger();
			int num = (bigInteger_0.dataLength > bigInteger_1.dataLength) ? bigInteger_0.dataLength : bigInteger_1.dataLength;
			for (int i = 0; i < num; i++)
			{
				uint num2 = bigInteger_0.data[i] | bigInteger_1.data[i];
				bigInteger.data[i] = num2;
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static BigInteger operator ^(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			BigInteger bigInteger = new BigInteger();
			int num = (bigInteger_0.dataLength > bigInteger_1.dataLength) ? bigInteger_0.dataLength : bigInteger_1.dataLength;
			for (int i = 0; i < num; i++)
			{
				uint num2 = bigInteger_0.data[i] ^ bigInteger_1.data[i];
				bigInteger.data[i] = num2;
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1 && bigInteger.data[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public BigInteger max(BigInteger bigInteger_0)
		{
			if (this > bigInteger_0)
			{
				return new BigInteger(this);
			}
			return new BigInteger(bigInteger_0);
		}

		public BigInteger min(BigInteger bigInteger_0)
		{
			if (this < bigInteger_0)
			{
				return new BigInteger(this);
			}
			return new BigInteger(bigInteger_0);
		}

		public BigInteger abs()
		{
			if (((int)data[69] & int.MinValue) != 0)
			{
				return -this;
			}
			return new BigInteger(this);
		}

		public override string ToString()
		{
			return ToString(10);
		}

		public string ToString(int int_0)
		{
			if (int_0 >= 2 && int_0 <= 36)
			{
				string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
				string text2 = "";
				BigInteger bigInteger = this;
				bool flag = false;
				if (((int)bigInteger.data[69] & int.MinValue) != 0)
				{
					flag = true;
					try
					{
						bigInteger = -bigInteger;
					}
					catch (Exception)
					{
					}
				}
				BigInteger bigInteger2 = new BigInteger();
				BigInteger bigInteger3 = new BigInteger();
				BigInteger bigInteger_ = new BigInteger(int_0);
				if (bigInteger.dataLength == 1 && bigInteger.data[0] == 0)
				{
					text2 = "0";
				}
				else
				{
					while (bigInteger.dataLength > 1 || (bigInteger.dataLength == 1 && bigInteger.data[0] != 0))
					{
						smethod_3(bigInteger, bigInteger_, bigInteger2, bigInteger3);
						text2 = ((bigInteger3.data[0] >= 10) ? (text[(int)(bigInteger3.data[0] - 10)] + text2) : (bigInteger3.data[0] + text2));
						bigInteger = bigInteger2;
					}
					if (flag)
					{
						text2 = "-" + text2;
					}
				}
				return text2;
			}
			throw new ArgumentException("Radix must be >= 2 and <= 36");
		}

		public string ToHexString()
		{
			string text = data[dataLength - 1].ToString("X");
			for (int num = dataLength - 2; num >= 0; num--)
			{
				text += data[num].ToString("X8");
			}
			return text;
		}

		public BigInteger modPow(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			if (((int)bigInteger_0.data[69] & int.MinValue) != 0)
			{
				throw new ArithmeticException("Positive exponents only.");
			}
			BigInteger bigInteger = 1;
			bool flag = false;
			BigInteger bigInteger2;
			if (((int)data[69] & int.MinValue) != 0)
			{
				bigInteger2 = -this % bigInteger_1;
				flag = true;
			}
			else
			{
				bigInteger2 = this % bigInteger_1;
			}
			if (((int)bigInteger_1.data[69] & int.MinValue) != 0)
			{
				bigInteger_1 = -bigInteger_1;
			}
			BigInteger bigInteger3 = new BigInteger();
			int num = bigInteger_1.dataLength << 1;
			bigInteger3.data[num] = 1u;
			bigInteger3.dataLength = num + 1;
			bigInteger3 /= bigInteger_1;
			int num2 = bigInteger_0.bitCount();
			int num3 = 0;
			for (int i = 0; i < bigInteger_0.dataLength; i++)
			{
				uint num4 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((bigInteger_0.data[i] & num4) != 0)
					{
						bigInteger = method_0(bigInteger * bigInteger2, bigInteger_1, bigInteger3);
					}
					num4 <<= 1;
					bigInteger2 = method_0(bigInteger2 * bigInteger2, bigInteger_1, bigInteger3);
					if (bigInteger2.dataLength != 1 || bigInteger2.data[0] != 1)
					{
						num3++;
						if (num3 == num2)
						{
							break;
						}
						continue;
					}
					if (flag && (bigInteger_0.data[0] & 1) != 0)
					{
						return -bigInteger;
					}
					return bigInteger;
				}
			}
			if (flag && (bigInteger_0.data[0] & 1) != 0)
			{
				return -bigInteger;
			}
			return bigInteger;
		}

		private BigInteger method_0(BigInteger bigInteger_0, BigInteger bigInteger_1, BigInteger bigInteger_2)
		{
			int num = bigInteger_1.dataLength;
			int num2 = num + 1;
			int num3 = num - 1;
			BigInteger bigInteger = new BigInteger();
			int num4 = num3;
			int num5 = 0;
			while (num4 < bigInteger_0.dataLength)
			{
				bigInteger.data[num5] = bigInteger_0.data[num4];
				num4++;
				num5++;
			}
			bigInteger.dataLength = bigInteger_0.dataLength - num3;
			if (bigInteger.dataLength <= 0)
			{
				bigInteger.dataLength = 1;
			}
			BigInteger bigInteger2 = bigInteger * bigInteger_2;
			BigInteger bigInteger3 = new BigInteger();
			int num6 = num2;
			int num7 = 0;
			while (num6 < bigInteger2.dataLength)
			{
				bigInteger3.data[num7] = bigInteger2.data[num6];
				num6++;
				num7++;
			}
			bigInteger3.dataLength = bigInteger2.dataLength - num2;
			if (bigInteger3.dataLength <= 0)
			{
				bigInteger3.dataLength = 1;
			}
			BigInteger bigInteger4 = new BigInteger();
			int num8 = (bigInteger_0.dataLength > num2) ? num2 : bigInteger_0.dataLength;
			for (int i = 0; i < num8; i++)
			{
				bigInteger4.data[i] = bigInteger_0.data[i];
			}
			bigInteger4.dataLength = num8;
			BigInteger bigInteger5 = new BigInteger();
			for (int j = 0; j < bigInteger3.dataLength; j++)
			{
				if (bigInteger3.data[j] != 0)
				{
					ulong num9 = 0uL;
					int num10 = j;
					int num11 = 0;
					while (num11 < bigInteger_1.dataLength && num10 < num2)
					{
						ulong num12 = (ulong)((long)bigInteger3.data[j] * (long)bigInteger_1.data[num11] + bigInteger5.data[num10] + (long)num9);
						bigInteger5.data[num10] = (uint)(num12 & 0xFFFFFFFFL);
						num9 = num12 >> 32;
						num11++;
						num10++;
					}
					if (num10 < num2)
					{
						bigInteger5.data[num10] = (uint)num9;
					}
				}
			}
			bigInteger5.dataLength = num2;
			while (bigInteger5.dataLength > 1 && bigInteger5.data[bigInteger5.dataLength - 1] == 0)
			{
				bigInteger5.dataLength--;
			}
			bigInteger4 -= bigInteger5;
			if (((int)bigInteger4.data[69] & int.MinValue) != 0)
			{
				BigInteger bigInteger6 = new BigInteger();
				bigInteger6.data[num2] = 1u;
				bigInteger6.dataLength = num2 + 1;
				bigInteger4 += bigInteger6;
			}
			for (; bigInteger4 >= bigInteger_1; bigInteger4 -= bigInteger_1)
			{
			}
			return bigInteger4;
		}

		public BigInteger gcd(BigInteger bigInteger_0)
		{
			BigInteger bigInteger = (((int)data[69] & int.MinValue) == 0) ? this : (-this);
			BigInteger bigInteger2 = (((int)bigInteger_0.data[69] & int.MinValue) == 0) ? bigInteger_0 : (-bigInteger_0);
			BigInteger bigInteger3 = bigInteger2;
			while (bigInteger.dataLength > 1 || (bigInteger.dataLength == 1 && bigInteger.data[0] != 0))
			{
				bigInteger3 = bigInteger;
				bigInteger = bigInteger2 % bigInteger;
				bigInteger2 = bigInteger3;
			}
			return bigInteger3;
		}

		public void genRandomBits(int int_0, Random random_0)
		{
			int num = int_0 >> 5;
			int num2 = int_0 & 0x1F;
			if (num2 != 0)
			{
				num++;
			}
			if (num > 70)
			{
				throw new ArithmeticException("Number of required bits > maxLength.");
			}
			for (int i = 0; i < num; i++)
			{
				data[i] = (uint)(random_0.NextDouble() * 4294967296.0);
			}
			for (int j = num; j < 70; j++)
			{
				data[j] = 0u;
			}
			if (num2 != 0)
			{
				uint num3 = (uint)(1 << num2 - 1);
				data[num - 1] |= num3;
				num3 = uint.MaxValue >> 32 - num2;
				data[num - 1] &= num3;
			}
			else
			{
				data[num - 1] |= 2147483648u;
			}
			dataLength = num;
			if (dataLength == 0)
			{
				dataLength = 1;
			}
		}

		public int bitCount()
		{
			while (dataLength > 1 && data[dataLength - 1] == 0)
			{
				dataLength--;
			}
			uint num = data[dataLength - 1];
			uint num2 = 2147483648u;
			int num3 = 32;
			while (num3 > 0 && (num & num2) == 0)
			{
				num3--;
				num2 >>= 1;
			}
			return num3 + (dataLength - 1 << 5);
		}

		public bool FermatLittleTest(int int_0)
		{
			BigInteger bigInteger = (((int)data[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.data[0] == 0 || bigInteger.data[0] == 1)
				{
					return false;
				}
				if (bigInteger.data[0] == 2 || bigInteger.data[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.data[0] & 1) == 0)
			{
				return false;
			}
			int num = bigInteger.bitCount();
			BigInteger bigInteger2 = new BigInteger();
			BigInteger bigInteger_ = bigInteger - new BigInteger(1L);
			Random random = new Random();
			int num2 = 0;
			while (true)
			{
				if (num2 < int_0)
				{
					bool flag = false;
					while (!flag)
					{
						int num3;
						for (num3 = 0; num3 < 2; num3 = (int)(random.NextDouble() * (double)num))
						{
						}
						bigInteger2.genRandomBits(num3, random);
						int num4 = bigInteger2.dataLength;
						if (num4 > 1 || (num4 == 1 && bigInteger2.data[0] != 1))
						{
							flag = true;
						}
					}
					BigInteger bigInteger3 = bigInteger2.gcd(bigInteger);
					if (bigInteger3.dataLength != 1 || bigInteger3.data[0] == 1)
					{
						BigInteger bigInteger4 = bigInteger2.modPow(bigInteger_, bigInteger);
						int num5 = bigInteger4.dataLength;
						if (num5 > 1 || (num5 == 1 && bigInteger4.data[0] != 1))
						{
							break;
						}
						num2++;
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}

		public bool RabinMillerTest(int int_0)
		{
			BigInteger bigInteger = (((int)data[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.data[0] == 0 || bigInteger.data[0] == 1)
				{
					return false;
				}
				if (bigInteger.data[0] == 2 || bigInteger.data[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.data[0] & 1) == 0)
			{
				return false;
			}
			BigInteger bigInteger2 = bigInteger - new BigInteger(1L);
			int num = 0;
			for (int i = 0; i < bigInteger2.dataLength; i++)
			{
				uint num2 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((bigInteger2.data[i] & num2) == 0)
					{
						num2 <<= 1;
						num++;
						continue;
					}
					i = bigInteger2.dataLength;
					break;
				}
			}
			BigInteger bigInteger_ = bigInteger2 >> num;
			int num3 = bigInteger.bitCount();
			BigInteger bigInteger3 = new BigInteger();
			Random random = new Random();
			int num4 = 0;
			while (true)
			{
				if (num4 < int_0)
				{
					bool flag = false;
					while (!flag)
					{
						int num5;
						for (num5 = 0; num5 < 2; num5 = (int)(random.NextDouble() * (double)num3))
						{
						}
						bigInteger3.genRandomBits(num5, random);
						int num6 = bigInteger3.dataLength;
						if (num6 > 1 || (num6 == 1 && bigInteger3.data[0] != 1))
						{
							flag = true;
						}
					}
					BigInteger bigInteger4 = bigInteger3.gcd(bigInteger);
					if (bigInteger4.dataLength != 1 || bigInteger4.data[0] == 1)
					{
						BigInteger bigInteger5 = bigInteger3.modPow(bigInteger_, bigInteger);
						bool flag2 = false;
						if (bigInteger5.dataLength == 1 && bigInteger5.data[0] == 1)
						{
							flag2 = true;
						}
						int num7 = 0;
						while (!flag2 && num7 < num)
						{
							if (!(bigInteger5 == bigInteger2))
							{
								bigInteger5 = bigInteger5 * bigInteger5 % bigInteger;
								num7++;
								continue;
							}
							flag2 = true;
							break;
						}
						if (!flag2)
						{
							break;
						}
						num4++;
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}

		public bool SolovayStrassenTest(int int_0)
		{
			BigInteger bigInteger = (((int)data[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.data[0] == 0 || bigInteger.data[0] == 1)
				{
					return false;
				}
				if (bigInteger.data[0] == 2 || bigInteger.data[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.data[0] & 1) == 0)
			{
				return false;
			}
			int num = bigInteger.bitCount();
			BigInteger bigInteger2 = new BigInteger();
			BigInteger bigInteger3 = bigInteger - 1;
			BigInteger bigInteger_ = bigInteger3 >> 1;
			Random random = new Random();
			int num2 = 0;
			while (true)
			{
				if (num2 < int_0)
				{
					bool flag = false;
					while (!flag)
					{
						int num3;
						for (num3 = 0; num3 < 2; num3 = (int)(random.NextDouble() * (double)num))
						{
						}
						bigInteger2.genRandomBits(num3, random);
						int num4 = bigInteger2.dataLength;
						if (num4 > 1 || (num4 == 1 && bigInteger2.data[0] != 1))
						{
							flag = true;
						}
					}
					BigInteger bigInteger4 = bigInteger2.gcd(bigInteger);
					if (bigInteger4.dataLength != 1 || bigInteger4.data[0] == 1)
					{
						BigInteger bigInteger_2 = bigInteger2.modPow(bigInteger_, bigInteger);
						if (bigInteger_2 == bigInteger3)
						{
							bigInteger_2 = -1;
						}
						BigInteger bigInteger_3 = Jacobi(bigInteger2, bigInteger);
						if (bigInteger_2 != bigInteger_3)
						{
							break;
						}
						num2++;
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}

		public bool LucasStrongTest()
		{
			BigInteger bigInteger = (((int)data[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.data[0] == 0 || bigInteger.data[0] == 1)
				{
					return false;
				}
				if (bigInteger.data[0] == 2 || bigInteger.data[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.data[0] & 1) == 0)
			{
				return false;
			}
			return method_1(bigInteger);
		}

		private bool method_1(BigInteger bigInteger_0)
		{
			long num = 5L;
			long num2 = -1L;
			long num3 = 0L;
			bool flag = false;
			while (!flag)
			{
				switch (Jacobi(num, bigInteger_0))
				{
				case -1:
					flag = true;
					break;
				case 0:
					if (Math.Abs(num) < bigInteger_0)
					{
						return false;
					}
					goto default;
				default:
					if (num3 == 20L)
					{
						BigInteger bigInteger = bigInteger_0.sqrt();
						if (bigInteger * bigInteger == bigInteger_0)
						{
							return false;
						}
					}
					num = (Math.Abs(num) + 2L) * num2;
					num2 = -num2;
					break;
				}
				num3++;
			}
			long num4 = 1L - num >> 2;
			BigInteger bigInteger2 = bigInteger_0 + 1;
			int num5 = 0;
			for (int i = 0; i < bigInteger2.dataLength; i++)
			{
				uint num6 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((bigInteger2.data[i] & num6) == 0)
					{
						num6 <<= 1;
						num5++;
						continue;
					}
					i = bigInteger2.dataLength;
					break;
				}
			}
			BigInteger bigInteger_ = bigInteger2 >> num5;
			BigInteger bigInteger3 = new BigInteger();
			int num7 = bigInteger_0.dataLength << 1;
			bigInteger3.data[num7] = 1u;
			bigInteger3.dataLength = num7 + 1;
			bigInteger3 /= bigInteger_0;
			BigInteger[] array = smethod_4(1, num4, bigInteger_, bigInteger_0, bigInteger3, 0);
			bool flag2 = false;
			if ((array[0].dataLength == 1 && array[0].data[0] == 0) || (array[1].dataLength == 1 && array[1].data[0] == 0))
			{
				flag2 = true;
			}
			for (int k = 1; k < num5; k++)
			{
				if (!flag2)
				{
					array[1] = bigInteger_0.method_0(array[1] * array[1], bigInteger_0, bigInteger3);
					array[1] = (array[1] - (array[2] << 1)) % bigInteger_0;
					if (array[1].dataLength == 1 && array[1].data[0] == 0)
					{
						flag2 = true;
					}
				}
				array[2] = bigInteger_0.method_0(array[2] * array[2], bigInteger_0, bigInteger3);
			}
			if (flag2)
			{
				BigInteger bigInteger4 = bigInteger_0.gcd(num4);
				if (bigInteger4.dataLength == 1 && bigInteger4.data[0] == 1)
				{
					if (((int)array[2].data[69] & int.MinValue) != 0)
					{
						BigInteger[] array2 = array;
						array2[2] += bigInteger_0;
					}
					BigInteger bigInteger5 = num4 * Jacobi(num4, bigInteger_0) % bigInteger_0;
					if (((int)bigInteger5.data[69] & int.MinValue) != 0)
					{
						bigInteger5 += bigInteger_0;
					}
					if (array[2] != bigInteger5)
					{
						flag2 = false;
					}
				}
			}
			return flag2;
		}

		public bool isProbablePrime(int int_0)
		{
			BigInteger bigInteger = (((int)data[69] & int.MinValue) == 0) ? this : (-this);
			for (int i = 0; i < primesBelow2000.Length; i++)
			{
				BigInteger bigInteger2 = primesBelow2000[i];
				if (bigInteger2 >= bigInteger)
				{
					break;
				}
				if ((bigInteger % bigInteger2).IntValue() == 0)
				{
					return false;
				}
			}
			if (bigInteger.RabinMillerTest(int_0))
			{
				return true;
			}
			return false;
		}

		public bool isProbablePrime()
		{
			BigInteger bigInteger = (((int)data[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.data[0] == 0 || bigInteger.data[0] == 1)
				{
					return false;
				}
				if (bigInteger.data[0] == 2 || bigInteger.data[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.data[0] & 1) == 0)
			{
				return false;
			}
			for (int i = 0; i < primesBelow2000.Length; i++)
			{
				BigInteger bigInteger2 = primesBelow2000[i];
				if (bigInteger2 >= bigInteger)
				{
					break;
				}
				if ((bigInteger % bigInteger2).IntValue() == 0)
				{
					return false;
				}
			}
			BigInteger bigInteger3 = bigInteger - new BigInteger(1L);
			int num = 0;
			for (int j = 0; j < bigInteger3.dataLength; j++)
			{
				uint num2 = 1u;
				for (int k = 0; k < 32; k++)
				{
					if ((bigInteger3.data[j] & num2) == 0)
					{
						num2 <<= 1;
						num++;
						continue;
					}
					j = bigInteger3.dataLength;
					break;
				}
			}
			BigInteger bigInteger_ = bigInteger3 >> num;
			bigInteger.bitCount();
			BigInteger bigInteger4 = ((BigInteger)2).modPow(bigInteger_, bigInteger);
			bool flag = false;
			if (bigInteger4.dataLength == 1 && bigInteger4.data[0] == 1)
			{
				flag = true;
			}
			int num3 = 0;
			while (!flag && num3 < num)
			{
				if (!(bigInteger4 == bigInteger3))
				{
					bigInteger4 = bigInteger4 * bigInteger4 % bigInteger;
					num3++;
					continue;
				}
				flag = true;
				break;
			}
			if (flag)
			{
				flag = method_1(bigInteger);
			}
			return flag;
		}

		public int IntValue()
		{
			return (int)data[0];
		}

		public long LongValue()
		{
			long num = 0L;
			num = data[0];
			try
			{
				num |= (long)((ulong)data[1] << 32);
				return num;
			}
			catch (Exception)
			{
				if (((int)data[0] & int.MinValue) != 0)
				{
					return (int)data[0];
				}
				return num;
			}
		}

		public static int Jacobi(BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			if ((bigInteger_1.data[0] & 1) == 0)
			{
				throw new ArgumentException("Jacobi defined only for odd integers.");
			}
			if (bigInteger_0 >= bigInteger_1)
			{
				bigInteger_0 %= bigInteger_1;
			}
			if (bigInteger_0.dataLength == 1 && bigInteger_0.data[0] == 0)
			{
				return 0;
			}
			if (bigInteger_0.dataLength == 1 && bigInteger_0.data[0] == 1)
			{
				return 1;
			}
			if (bigInteger_0 < 0)
			{
				if (((bigInteger_1 - 1).data[0] & 2) == 0)
				{
					return Jacobi(-bigInteger_0, bigInteger_1);
				}
				return -Jacobi(-bigInteger_0, bigInteger_1);
			}
			int num = 0;
			for (int i = 0; i < bigInteger_0.dataLength; i++)
			{
				uint num2 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((bigInteger_0.data[i] & num2) == 0)
					{
						num2 <<= 1;
						num++;
						continue;
					}
					i = bigInteger_0.dataLength;
					break;
				}
			}
			BigInteger bigInteger = bigInteger_0 >> num;
			int num3 = 1;
			if ((num & 1) != 0 && ((bigInteger_1.data[0] & 7) == 3 || (bigInteger_1.data[0] & 7) == 5))
			{
				num3 = -1;
			}
			if ((bigInteger_1.data[0] & 3) == 3 && (bigInteger.data[0] & 3) == 3)
			{
				num3 = -num3;
			}
			if (bigInteger.dataLength == 1 && bigInteger.data[0] == 1)
			{
				return num3;
			}
			return num3 * Jacobi(bigInteger_1 % bigInteger, bigInteger);
		}

		public static BigInteger genPseudoPrime(int int_0, int int_1, Random random_0)
		{
			BigInteger bigInteger = new BigInteger();
			bool flag = false;
			while (!flag)
			{
				bigInteger.genRandomBits(int_0, random_0);
				bigInteger.data[0] |= 1u;
				flag = bigInteger.isProbablePrime(int_1);
			}
			return bigInteger;
		}

		public BigInteger genCoPrime(int int_0, Random random_0)
		{
			bool flag = false;
			BigInteger bigInteger = new BigInteger();
			while (!flag)
			{
				bigInteger.genRandomBits(int_0, random_0);
				BigInteger bigInteger2 = bigInteger.gcd(this);
				if (bigInteger2.dataLength == 1 && bigInteger2.data[0] == 1)
				{
					flag = true;
				}
			}
			return bigInteger;
		}

		public BigInteger modInverse(BigInteger bigInteger_0)
		{
			BigInteger[] array = new BigInteger[2]
			{
				0,
				1
			};
			BigInteger[] array2 = new BigInteger[2];
			BigInteger[] array3 = new BigInteger[2]
			{
				0,
				0
			};
			int num = 0;
			BigInteger bigInteger_ = bigInteger_0;
			BigInteger bigInteger = this;
			while (bigInteger.dataLength > 1 || (bigInteger.dataLength == 1 && bigInteger.data[0] != 0))
			{
				BigInteger bigInteger2 = new BigInteger();
				BigInteger bigInteger3 = new BigInteger();
				if (num > 1)
				{
					BigInteger bigInteger4 = (array[0] - array[1] * array2[0]) % bigInteger_0;
					array[0] = array[1];
					array[1] = bigInteger4;
				}
				if (bigInteger.dataLength == 1)
				{
					smethod_3(bigInteger_, bigInteger, bigInteger2, bigInteger3);
				}
				else
				{
					smethod_2(bigInteger_, bigInteger, bigInteger2, bigInteger3);
				}
				array2[0] = array2[1];
				array3[0] = array3[1];
				array2[1] = bigInteger2;
				array3[1] = bigInteger3;
				bigInteger_ = bigInteger;
				bigInteger = bigInteger3;
				num++;
			}
			if (array3[0].dataLength <= 1 && (array3[0].dataLength != 1 || array3[0].data[0] == 1))
			{
				BigInteger bigInteger5 = (array[0] - array[1] * array2[0]) % bigInteger_0;
				if (((int)bigInteger5.data[69] & int.MinValue) != 0)
				{
					bigInteger5 += bigInteger_0;
				}
				return bigInteger5;
			}
			throw new ArithmeticException("No inverse!");
		}

		public byte[] getBytes()
		{
			int num = bitCount();
			int num2 = num >> 3;
			if ((num & 7) != 0)
			{
				num2++;
			}
			byte[] array = new byte[num2];
			int num3 = 0;
			uint num4 = data[dataLength - 1];
			uint num5;
			if ((num5 = ((num4 >> 24) & 0xFF)) != 0)
			{
				array[num3++] = (byte)num5;
			}
			if ((num5 = ((num4 >> 16) & 0xFF)) != 0)
			{
				array[num3++] = (byte)num5;
			}
			if ((num5 = ((num4 >> 8) & 0xFF)) != 0)
			{
				array[num3++] = (byte)num5;
			}
			if ((num5 = (num4 & 0xFF)) != 0)
			{
				array[num3++] = (byte)num5;
			}
			int num6 = dataLength - 2;
			while (num6 >= 0)
			{
				num4 = data[num6];
				array[num3 + 3] = (byte)(num4 & 0xFF);
				num4 >>= 8;
				array[num3 + 2] = (byte)(num4 & 0xFF);
				num4 >>= 8;
				array[num3 + 1] = (byte)(num4 & 0xFF);
				num4 >>= 8;
				array[num3] = (byte)(num4 & 0xFF);
				num6--;
				num3 += 4;
			}
			return array;
		}

		public void setBit(uint uint_0)
		{
			uint num = uint_0 >> 5;
			byte b = (byte)(uint_0 & 0x1F);
			uint num2 = (uint)(1 << (int)b);
			data[num] |= num2;
			if (num >= dataLength)
			{
				dataLength = (int)(num + 1);
			}
		}

		public void unsetBit(uint uint_0)
		{
			uint num = uint_0 >> 5;
			if (num < dataLength)
			{
				byte b = (byte)(uint_0 & 0x1F);
				uint num2 = (uint)(1 << (int)b);
				uint num3 = (uint)(-1 ^ (int)num2);
				data[num] &= num3;
				if (dataLength > 1 && data[dataLength - 1] == 0)
				{
					dataLength--;
				}
			}
		}

		public BigInteger sqrt()
		{
			uint num = (uint)bitCount();
			num = (((num & 1) == 0) ? (num >> 1) : ((num >> 1) + 1));
			uint num2 = num >> 5;
			byte b = (byte)(num & 0x1F);
			BigInteger bigInteger = new BigInteger();
			uint num3;
			if (b == 0)
			{
				num3 = 2147483648u;
			}
			else
			{
				num3 = (uint)(1 << (int)b);
				num2++;
			}
			bigInteger.dataLength = (int)num2;
			for (int num4 = (int)(num2 - 1); num4 >= 0; num4--)
			{
				while (num3 != 0)
				{
					bigInteger.data[num4] ^= num3;
					if (bigInteger * bigInteger > this)
					{
						bigInteger.data[num4] ^= num3;
					}
					num3 >>= 1;
				}
				num3 = 2147483648u;
			}
			return bigInteger;
		}

		public static BigInteger[] LucasSequence(BigInteger bigInteger_0, BigInteger bigInteger_1, BigInteger bigInteger_2, BigInteger bigInteger_3)
		{
			if (bigInteger_2.dataLength == 1 && bigInteger_2.data[0] == 0)
			{
				return new BigInteger[3]
				{
					0,
					2 % bigInteger_3,
					1 % bigInteger_3
				};
			}
			BigInteger bigInteger = new BigInteger();
			int num = bigInteger_3.dataLength << 1;
			bigInteger.data[num] = 1u;
			bigInteger.dataLength = num + 1;
			bigInteger /= bigInteger_3;
			int num2 = 0;
			for (int i = 0; i < bigInteger_2.dataLength; i++)
			{
				uint num3 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((bigInteger_2.data[i] & num3) == 0)
					{
						num3 <<= 1;
						num2++;
						continue;
					}
					i = bigInteger_2.dataLength;
					break;
				}
			}
			BigInteger bigInteger_4 = bigInteger_2 >> num2;
			return smethod_4(bigInteger_0, bigInteger_1, bigInteger_4, bigInteger_3, bigInteger, num2);
		}

		private static BigInteger[] smethod_4(BigInteger bigInteger_0, BigInteger bigInteger_1, BigInteger bigInteger_2, BigInteger bigInteger_3, BigInteger bigInteger_4, int int_0)
		{
			BigInteger[] array = new BigInteger[3];
			if ((bigInteger_2.data[0] & 1) == 0)
			{
				throw new ArgumentException("Argument k must be odd.");
			}
			int num = bigInteger_2.bitCount();
			uint num2 = (uint)(1 << (num & 0x1F) - 1);
			BigInteger bigInteger = 2 % bigInteger_3;
			BigInteger bigInteger2 = 1 % bigInteger_3;
			BigInteger bigInteger3 = bigInteger_0 % bigInteger_3;
			BigInteger bigInteger_5 = bigInteger2;
			bool flag = true;
			for (int num3 = bigInteger_2.dataLength - 1; num3 >= 0; num3--)
			{
				while (num2 != 0 && (num3 != 0 || num2 != 1))
				{
					if ((bigInteger_2.data[num3] & num2) != 0)
					{
						bigInteger_5 = bigInteger_5 * bigInteger3 % bigInteger_3;
						bigInteger = (bigInteger * bigInteger3 - bigInteger_0 * bigInteger2) % bigInteger_3;
						bigInteger3 = bigInteger_3.method_0(bigInteger3 * bigInteger3, bigInteger_3, bigInteger_4);
						bigInteger3 = (bigInteger3 - (bigInteger2 * bigInteger_1 << 1)) % bigInteger_3;
						if (flag)
						{
							flag = false;
						}
						else
						{
							bigInteger2 = bigInteger_3.method_0(bigInteger2 * bigInteger2, bigInteger_3, bigInteger_4);
						}
						bigInteger2 = bigInteger2 * bigInteger_1 % bigInteger_3;
					}
					else
					{
						bigInteger_5 = (bigInteger_5 * bigInteger - bigInteger2) % bigInteger_3;
						bigInteger3 = (bigInteger * bigInteger3 - bigInteger_0 * bigInteger2) % bigInteger_3;
						bigInteger = bigInteger_3.method_0(bigInteger * bigInteger, bigInteger_3, bigInteger_4);
						bigInteger = (bigInteger - (bigInteger2 << 1)) % bigInteger_3;
						if (flag)
						{
							bigInteger2 = bigInteger_1 % bigInteger_3;
							flag = false;
						}
						else
						{
							bigInteger2 = bigInteger_3.method_0(bigInteger2 * bigInteger2, bigInteger_3, bigInteger_4);
						}
					}
					num2 >>= 1;
				}
				num2 = 2147483648u;
			}
			bigInteger_5 = (bigInteger_5 * bigInteger - bigInteger2) % bigInteger_3;
			bigInteger = (bigInteger * bigInteger3 - bigInteger_0 * bigInteger2) % bigInteger_3;
			if (flag)
			{
				flag = false;
			}
			else
			{
				bigInteger2 = bigInteger_3.method_0(bigInteger2 * bigInteger2, bigInteger_3, bigInteger_4);
			}
			bigInteger2 = bigInteger2 * bigInteger_1 % bigInteger_3;
			for (int i = 0; i < int_0; i++)
			{
				bigInteger_5 = bigInteger_5 * bigInteger % bigInteger_3;
				bigInteger = (bigInteger * bigInteger - (bigInteger2 << 1)) % bigInteger_3;
				if (flag)
				{
					bigInteger2 = bigInteger_1 % bigInteger_3;
					flag = false;
				}
				else
				{
					bigInteger2 = bigInteger_3.method_0(bigInteger2 * bigInteger2, bigInteger_3, bigInteger_4);
				}
			}
			array[0] = bigInteger_5;
			array[1] = bigInteger;
			array[2] = bigInteger2;
			return array;
		}

		public static void MulDivTest(int int_0)
		{
			Random random = new Random();
			byte[] array = new byte[64];
			byte[] array2 = new byte[64];
			int num = 0;
			BigInteger bigInteger;
			BigInteger bigInteger2;
			BigInteger bigInteger3;
			BigInteger bigInteger4;
			BigInteger bigInteger5;
			while (true)
			{
				if (num >= int_0)
				{
					return;
				}
				int num2;
				for (num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 65.0))
				{
				}
				int num3;
				for (num3 = 0; num3 == 0; num3 = (int)(random.NextDouble() * 65.0))
				{
				}
				bool flag = false;
				while (!flag)
				{
					for (int i = 0; i < 64; i++)
					{
						if (i < num2)
						{
							array[i] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array[i] = 0;
						}
						if (array[i] != 0)
						{
							flag = true;
						}
					}
				}
				flag = false;
				while (!flag)
				{
					for (int j = 0; j < 64; j++)
					{
						if (j < num3)
						{
							array2[j] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array2[j] = 0;
						}
						if (array2[j] != 0)
						{
							flag = true;
						}
					}
				}
				while (array[0] == 0)
				{
					array[0] = (byte)(random.NextDouble() * 256.0);
				}
				while (array2[0] == 0)
				{
					array2[0] = (byte)(random.NextDouble() * 256.0);
				}
				Console.WriteLine(num);
				bigInteger = new BigInteger(array, num2);
				bigInteger2 = new BigInteger(array2, num3);
				bigInteger3 = bigInteger / bigInteger2;
				bigInteger4 = bigInteger % bigInteger2;
				bigInteger5 = bigInteger3 * bigInteger2 + bigInteger4;
				if (bigInteger5 != bigInteger)
				{
					break;
				}
				num++;
			}
			Console.WriteLine("Error at " + num);
			Console.WriteLine((((object)bigInteger != null) ? bigInteger.ToString() : null) + "\n");
			Console.WriteLine((((object)bigInteger2 != null) ? bigInteger2.ToString() : null) + "\n");
			Console.WriteLine((((object)bigInteger3 != null) ? bigInteger3.ToString() : null) + "\n");
			Console.WriteLine((((object)bigInteger4 != null) ? bigInteger4.ToString() : null) + "\n");
			Console.WriteLine((((object)bigInteger5 != null) ? bigInteger5.ToString() : null) + "\n");
		}

		public static void RSATest(int int_0)
		{
			Random random = new Random(1);
			byte[] array = new byte[64];
			BigInteger bigInteger = new BigInteger("a932b948feed4fb2b692609bd22164fc9edb59fae7880cc1eaff7b3c9626b7e5b241c27a974833b2622ebe09beb451917663d47232488f23a117fc97720f1e7", 16);
			BigInteger bigInteger2 = new BigInteger("4adf2f7a89da93248509347d2ae506d683dd3a16357e859a980c4f77a4e2f7a01fae289f13a851df6e9db5adaa60bfd2b162bbbe31f7c8f828261a6839311929d2cef4f864dde65e556ce43c89bbbf9f1ac5511315847ce9cc8dc92470a747b8792d6a83b0092d2e5ebaf852c85cacf34278efa99160f2f8aa7ee7214de07b7", 16);
			BigInteger bigInteger3 = new BigInteger("e8e77781f36a7b3188d711c2190b560f205a52391b3479cdb99fa010745cbeba5f2adc08e1de6bf38398a0487c4a73610d94ec36f17f3f46ad75e17bc1adfec99839589f45f95ccc94cb2a5c500b477eb3323d8cfab0c8458c96f0147a45d27e45a4d11d54d77684f65d48f15fafcc1ba208e71e921b9bd9017c16a5231af7f", 16);
			Console.WriteLine("e =\n" + bigInteger.ToString(10));
			Console.WriteLine("\nd =\n" + bigInteger2.ToString(10));
			Console.WriteLine("\nn =\n" + bigInteger3.ToString(10) + "\n");
			int num = 0;
			BigInteger bigInteger4;
			while (true)
			{
				if (num >= int_0)
				{
					return;
				}
				int num2;
				for (num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 65.0))
				{
				}
				bool flag = false;
				while (!flag)
				{
					for (int i = 0; i < 64; i++)
					{
						if (i < num2)
						{
							array[i] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array[i] = 0;
						}
						if (array[i] != 0)
						{
							flag = true;
						}
					}
				}
				while (array[0] == 0)
				{
					array[0] = (byte)(random.NextDouble() * 256.0);
				}
				Console.Write("Round = " + num);
				bigInteger4 = new BigInteger(array, num2);
				if (bigInteger4.modPow(bigInteger, bigInteger3).modPow(bigInteger2, bigInteger3) != bigInteger4)
				{
					break;
				}
				Console.WriteLine(" <PASSED>.");
				num++;
			}
			Console.WriteLine("\nError at round " + num);
			Console.WriteLine((((object)bigInteger4 != null) ? bigInteger4.ToString() : null) + "\n");
		}

		public static void RSATest2(int int_0)
		{
			Random random = new Random();
			byte[] array = new byte[64];
			byte[] byte_ = new byte[64]
			{
				133,
				132,
				100,
				253,
				112,
				106,
				159,
				240,
				148,
				12,
				62,
				44,
				116,
				52,
				5,
				201,
				85,
				179,
				133,
				50,
				152,
				113,
				249,
				65,
				33,
				95,
				2,
				158,
				234,
				86,
				141,
				140,
				68,
				204,
				238,
				238,
				61,
				44,
				157,
				44,
				18,
				65,
				30,
				241,
				197,
				50,
				195,
				170,
				49,
				74,
				82,
				216,
				232,
				175,
				66,
				244,
				114,
				161,
				42,
				13,
				151,
				177,
				49,
				179
			};
			byte[] byte_2 = new byte[64]
			{
				153,
				152,
				202,
				184,
				94,
				215,
				229,
				220,
				40,
				92,
				111,
				14,
				21,
				9,
				89,
				110,
				132,
				243,
				129,
				205,
				222,
				66,
				220,
				147,
				194,
				122,
				98,
				172,
				108,
				175,
				222,
				116,
				227,
				203,
				96,
				32,
				56,
				156,
				33,
				195,
				220,
				200,
				162,
				77,
				198,
				42,
				53,
				127,
				243,
				169,
				232,
				29,
				123,
				44,
				120,
				250,
				184,
				2,
				85,
				128,
				155,
				194,
				165,
				203
			};
			BigInteger bigInteger_ = new BigInteger(byte_);
			BigInteger bigInteger = new BigInteger(byte_2);
			BigInteger bigInteger2 = (bigInteger_ - 1) * (bigInteger - 1);
			BigInteger bigInteger3 = bigInteger_ * bigInteger;
			int num = 0;
			BigInteger bigInteger6;
			while (true)
			{
				if (num >= int_0)
				{
					return;
				}
				BigInteger bigInteger4 = bigInteger2.genCoPrime(512, random);
				BigInteger bigInteger5 = bigInteger4.modInverse(bigInteger2);
				Console.WriteLine("\ne =\n" + bigInteger4.ToString(10));
				Console.WriteLine("\nd =\n" + bigInteger5.ToString(10));
				Console.WriteLine("\nn =\n" + bigInteger3.ToString(10) + "\n");
				int num2;
				for (num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 65.0))
				{
				}
				bool flag = false;
				while (!flag)
				{
					for (int i = 0; i < 64; i++)
					{
						if (i < num2)
						{
							array[i] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array[i] = 0;
						}
						if (array[i] != 0)
						{
							flag = true;
						}
					}
				}
				while (array[0] == 0)
				{
					array[0] = (byte)(random.NextDouble() * 256.0);
				}
				Console.Write("Round = " + num);
				bigInteger6 = new BigInteger(array, num2);
				if (bigInteger6.modPow(bigInteger4, bigInteger3).modPow(bigInteger5, bigInteger3) != bigInteger6)
				{
					break;
				}
				Console.WriteLine(" <PASSED>.");
				num++;
			}
			Console.WriteLine("\nError at round " + num);
			Console.WriteLine((((object)bigInteger6 != null) ? bigInteger6.ToString() : null) + "\n");
		}

		public static void SqrtTest(int int_0)
		{
			Random random = new Random();
			int num = 0;
			BigInteger bigInteger;
			while (true)
			{
				if (num < int_0)
				{
					int num2;
					for (num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 1024.0))
					{
					}
					Console.Write("Round = " + num);
					bigInteger = new BigInteger();
					bigInteger.genRandomBits(num2, random);
					BigInteger bigInteger_ = bigInteger.sqrt();
					if ((bigInteger_ + 1) * (bigInteger_ + 1) <= bigInteger)
					{
						break;
					}
					Console.WriteLine(" <PASSED>.");
					num++;
					continue;
				}
				return;
			}
			Console.WriteLine("\nError at round " + num);
			Console.WriteLine((((object)bigInteger != null) ? bigInteger.ToString() : null) + "\n");
		}
	}
}
