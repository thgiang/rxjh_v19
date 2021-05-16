using System;
using System.IO;
using System.Text;

namespace RxjhServer.Network
{
	public class PacketReader
	{
		private byte[] m_Data;

		private int int_0;

		private int int_1;

		public byte[] Buffer
		{
			get
			{
				return m_Data;
			}
		}

		public int Size
		{
			get
			{
				return int_0;
			}
		}

		public PacketReader(byte[] byte_0, int int_2, bool bool_0)
		{
			m_Data = byte_0;
			int_0 = int_2;
			int_1 = (bool_0 ? 1 : 3);
		}

		public void Trace(NetState netState_0)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter("Packets.log", true))
				{
					byte[] data = m_Data;
					if (data.Length != 0)
					{
						streamWriter.WriteLine("Client: {0}: Unhandled 包ID 0x{1:X2}{2:X2} 包长{3} 时间{4}", netState_0, data[8], data[7], data.Length, DateTime.Now);
					}
					using (MemoryStream stream_ = new MemoryStream(data))
					{
						Utility.FormatBuffer(streamWriter, stream_, data.Length);
					}
					streamWriter.WriteLine();
					streamWriter.WriteLine();
				}
			}
			catch
			{
			}
		}

		public int Seek(int int_2, SeekOrigin seekOrigin_0)
		{
			switch (seekOrigin_0)
			{
			case SeekOrigin.Begin:
				int_1 = int_2;
				break;
			case SeekOrigin.Current:
				int_1 += int_2;
				break;
			case SeekOrigin.End:
				int_1 = int_0 - int_2;
				break;
			}
			return int_1;
		}

		public int ReadInt32()
		{
			if (int_1 + 4 > int_0)
			{
				return 0;
			}
			return m_Data[int_1++] | (m_Data[int_1++] << 8) | (m_Data[int_1++] << 16) | (m_Data[int_1++] << 24);
		}

		public int ReadInt16()
		{
			if (int_1 + 2 > int_0)
			{
				return 0;
			}
			return m_Data[int_1++] | (m_Data[int_1++] << 8);
		}

		public int ReadInt8()
		{
			if (int_1 + 1 > int_0)
			{
				return 0;
			}
			return m_Data[int_1++];
		}

		public float Readfloat()
		{
			if (int_1 + 4 > int_0)
			{
				return 0f;
			}
			double num = BitConverter.ToSingle(m_Data, int_1);
			int_1 += 4;
			return (float)num;
		}

		public uint ReadUInt32()
		{
			if (int_1 + 4 > int_0)
			{
				return 0u;
			}
			return (uint)(m_Data[int_1++] | (m_Data[int_1++] << 8) | (m_Data[int_1++] << 16) | (m_Data[int_1++] << 24));
		}

		public ushort ReadUInt16()
		{
			if (int_1 + 2 > int_0)
			{
				return 0;
			}
			return (ushort)(m_Data[int_1++] | (m_Data[int_1++] << 8));
		}

		public byte ReadByte()
		{
			if (int_1 + 1 > int_0)
			{
				return 0;
			}
			return m_Data[int_1++];
		}

		public sbyte ReadSByte()
		{
			if (int_1 + 1 > int_0)
			{
				return 0;
			}
			return (sbyte)m_Data[int_1++];
		}

		public bool ReadBoolean()
		{
			if (int_1 + 1 <= int_0)
			{
				return m_Data[int_1++] > 0;
			}
			return false;
		}

		public string ReadUnicodeStringLE()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (int_1 + 1 < int_0)
			{
				byte num = m_Data[int_1++];
				int num2 = m_Data[int_1++] << 8;
				int num3;
				if ((num3 = (num | num2)) == 0)
				{
					break;
				}
				stringBuilder.Append((char)num3);
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringLESafe(int int_2)
		{
			int num = int_1 + (int_2 << 1);
			int num2 = num;
			if (num > int_0)
			{
				num = int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (int_1 + 1 < num)
			{
				byte num3 = m_Data[int_1++];
				int num4 = m_Data[int_1++] << 8;
				int num5;
				if ((num5 = (num3 | num4)) == 0)
				{
					break;
				}
				if (IsSafeChar(num5))
				{
					stringBuilder.Append((char)num5);
				}
			}
			int_1 = num2;
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringLESafe()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (int_1 + 1 < int_0)
			{
				byte num = m_Data[int_1++];
				int num2 = m_Data[int_1++] << 8;
				int num3;
				if ((num3 = (num | num2)) == 0)
				{
					break;
				}
				if (IsSafeChar(num3))
				{
					stringBuilder.Append((char)num3);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringSafe()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (int_1 + 1 < int_0)
			{
				int num = m_Data[int_1++] << 8;
				int num2 = m_Data[int_1++];
				int num3;
				if ((num3 = (num | num2)) == 0)
				{
					break;
				}
				if (IsSafeChar(num3))
				{
					stringBuilder.Append((char)num3);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (int_1 + 1 < int_0)
			{
				int num = m_Data[int_1++] << 8;
				int num2 = m_Data[int_1++];
				int num3;
				if ((num3 = (num | num2)) == 0)
				{
					break;
				}
				stringBuilder.Append((char)num3);
			}
			return stringBuilder.ToString();
		}

		public bool IsSafeChar(int int_2)
		{
			if (int_2 >= 32)
			{
				return int_2 < 65534;
			}
			return false;
		}

		public string ReadUTF8StringSafe(int int_2)
		{
			if (int_1 >= int_0)
			{
				int_1 += int_2;
				return string.Empty;
			}
			int num = int_1 + int_2;
			if (num > int_0)
			{
				num = int_0;
			}
			int num2 = 0;
			int num3 = int_1;
			int num4 = int_1;
			while (num3 < num && m_Data[num3++] != 0)
			{
				num2++;
			}
			int num5 = 0;
			byte[] array = new byte[num2];
			int num6;
			while (int_1 < num && (num6 = m_Data[int_1++]) != 0)
			{
				array[num5++] = (byte)num6;
			}
			string @string = Utility.UTF8.GetString(array);
			bool flag = true;
			int num7 = 0;
			while (flag && num7 < @string.Length)
			{
				flag = IsSafeChar(@string[num7]);
				num7++;
			}
			int_1 = num4 + int_2;
			if (flag)
			{
				return @string;
			}
			StringBuilder stringBuilder = new StringBuilder(@string.Length);
			for (int i = 0; i < @string.Length; i++)
			{
				if (IsSafeChar(@string[i]))
				{
					stringBuilder.Append(@string[i]);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUTF8StringSafe()
		{
			if (int_1 >= int_0)
			{
				return string.Empty;
			}
			int num = 0;
			int num2 = int_1;
			while (num2 < int_0 && m_Data[num2++] != 0)
			{
				num++;
			}
			int num3 = 0;
			byte[] array = new byte[num];
			int num4;
			while (int_1 < int_0 && (num4 = m_Data[int_1++]) != 0)
			{
				array[num3++] = (byte)num4;
			}
			string @string = Utility.UTF8.GetString(array);
			bool flag = true;
			int num5 = 0;
			while (flag && num5 < @string.Length)
			{
				flag = IsSafeChar(@string[num5]);
				num5++;
			}
			if (flag)
			{
				return @string;
			}
			StringBuilder stringBuilder = new StringBuilder(@string.Length);
			for (int i = 0; i < @string.Length; i++)
			{
				if (IsSafeChar(@string[i]))
				{
					stringBuilder.Append(@string[i]);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUTF8String()
		{
			if (int_1 >= int_0)
			{
				return string.Empty;
			}
			int num = 0;
			int num2 = int_1;
			while (num2 < int_0 && m_Data[num2++] != 0)
			{
				num++;
			}
			int num3 = 0;
			byte[] array = new byte[num];
			int num4;
			while (int_1 < int_0 && (num4 = m_Data[int_1++]) != 0)
			{
				array[num3++] = (byte)num4;
			}
			return Utility.UTF8.GetString(array);
		}

		public string ReadString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num;
			while (int_1 < int_0 && (num = m_Data[int_1++]) != 0)
			{
				stringBuilder.Append((char)num);
			}
			return stringBuilder.ToString();
		}

		public string ReadStringSafe()
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num;
			while (int_1 < int_0 && (num = m_Data[int_1++]) != 0)
			{
				if (IsSafeChar(num))
				{
					stringBuilder.Append((char)num);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringSafe(int int_2)
		{
			int num = int_1 + (int_2 << 1);
			int num2 = num;
			if (num > int_0)
			{
				num = int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (int_1 + 1 < num)
			{
				int num3 = m_Data[int_1++] << 8;
				int num4 = m_Data[int_1++];
				int num5;
				if ((num5 = (num3 | num4)) == 0)
				{
					break;
				}
				if (IsSafeChar(num5))
				{
					stringBuilder.Append((char)num5);
				}
			}
			int_1 = num2;
			return stringBuilder.ToString();
		}

		public string ReadUnicodeString(int int_2)
		{
			int num = int_1 + (int_2 << 1);
			int num2 = num;
			if (num > int_0)
			{
				num = int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (int_1 + 1 < num)
			{
				int num3 = m_Data[int_1++] << 8;
				int num4 = m_Data[int_1++];
				int num5;
				if ((num5 = (num3 | num4)) == 0)
				{
					break;
				}
				stringBuilder.Append((char)num5);
			}
			int_1 = num2;
			return stringBuilder.ToString();
		}

		public string ReadStringSafe(int int_2)
		{
			int num = int_1 + int_2;
			int num2 = num;
			if (num > int_0)
			{
				num = int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num3;
			while (int_1 < num && (num3 = m_Data[int_1++]) != 0)
			{
				if (IsSafeChar(num3))
				{
					stringBuilder.Append((char)num3);
				}
			}
			int_1 = num2;
			return stringBuilder.ToString();
		}

		public string ReadString(int int_2)
		{
			int num = int_1 + int_2;
			int num2 = num;
			if (num > int_0)
			{
				num = int_0;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num3;
			while (int_1 < num && (num3 = m_Data[int_1++]) != 0)
			{
				stringBuilder.Append((char)num3);
			}
			int_1 = num2;
			return stringBuilder.ToString();
		}
	}
}
