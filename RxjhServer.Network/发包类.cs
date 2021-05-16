using System;
using System.IO;
using System.Text;

namespace RxjhServer.Network
{
	public class 发包类 : IDisposable
	{
		private byte[] m_Buffer;

		private int _InfoType;

		private MemoryStream m_Stream;

		private MemoryStream Z_Stream;

		public int InfoType
		{
			get
			{
				return _InfoType;
			}
			set
			{
				_InfoType = value;
			}
		}

		public int Length
		{
			get
			{
				return (int)(m_Stream.Length + 6L);
			}
		}

		public void Dispose()
		{
			m_Stream = null;
			Z_Stream = null;
		}

		public 发包类()
		{
			m_Buffer = new byte[8];
			m_Stream = new MemoryStream();
		}

		public void Write(byte[] value)
		{
			m_Stream.Write(value, 0, value.Length);
		}

		public void Write(float value)
		{
			m_Buffer = BitConverter.GetBytes(value);
			m_Stream.Write(m_Buffer, 0, 4);
		}

		public void Write(int value)
		{
			m_Stream.WriteByte((byte)(value & 0xFF));
		}

		public void Write1(int value)
		{
			m_Stream.WriteByte((byte)(value & 0xFF));
		}

		public void Write2(int value)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Stream.Write(m_Buffer, 0, 2);
		}

		public void Write4(int value)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Buffer[2] = (byte)(value >> 16);
			m_Buffer[3] = (byte)(value >> 24);
			m_Stream.Write(m_Buffer, 0, 4);
		}

		public void Write4(uint value)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Buffer[2] = (byte)(value >> 16);
			m_Buffer[3] = (byte)(value >> 24);
			m_Stream.Write(m_Buffer, 0, 4);
		}

		public void Write8(long value)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Buffer[2] = (byte)(value >> 16);
			m_Buffer[3] = (byte)(value >> 24);
			m_Buffer[4] = (byte)(value >> 32);
			m_Buffer[5] = (byte)(value >> 40);
			m_Buffer[6] = (byte)(value >> 48);
			m_Buffer[7] = (byte)(value >> 56);
			m_Stream.Write(m_Buffer, 0, 8);
		}

		public void Write(long value)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Buffer[2] = (byte)(value >> 16);
			m_Buffer[3] = (byte)(value >> 24);
			m_Buffer[4] = (byte)(value >> 32);
			m_Buffer[5] = (byte)(value >> 40);
			m_Buffer[6] = (byte)(value >> 48);
			m_Buffer[7] = (byte)(value >> 56);
			m_Stream.Write(m_Buffer, 0, 8);
		}

		public void Write(byte[] buffer, int offset, int size)
		{
			m_Stream.Write(buffer, offset, size);
		}

		public void WriteAsciiFixed(string value)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				value = string.Empty;
			}
			byte[] bytes = Encoding.Default.GetBytes(value);
			Write2((byte)bytes.Length);
			m_Stream.Write(bytes, 0, bytes.Length);
		}

		public void WriteString(string value, int 数量)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				value = string.Empty;
			}
			byte[] array = new byte[数量];
			byte[] bytes = Encoding.Default.GetBytes(value);
			System.Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			m_Stream.Write(array, 0, array.Length);
		}

		public void WriteName(string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			byte[] bytes = Encoding.Default.GetBytes(value);
			byte[] array = new byte[15];
			if (bytes.Length <= 15)
			{
				System.Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			}
			else
			{
				System.Buffer.BlockCopy(bytes, 0, array, 0, 15);
			}
			m_Stream.Write(array, 0, array.Length);
		}

		public byte[] ToArray3()
		{
			return m_Stream.ToArray();
		}

		public byte[] ToArray2(int aa, int wordid)
		{
			Z_Stream = new MemoryStream();
			m_Buffer[0] = (byte)wordid;
			m_Buffer[1] = (byte)(wordid >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)(aa >> 8);
			m_Buffer[1] = (byte)aa;
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)m_Stream.Length;
			m_Buffer[1] = (byte)(m_Stream.Length >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Stream.WriteTo(Z_Stream);
			return Z_Stream.ToArray();
		}

		public byte[] ToArray(int aa, int wordid)
		{
			Z_Stream = new MemoryStream();
			Z_Stream.WriteByte(170);
			Z_Stream.WriteByte(85);
			m_Buffer[0] = (byte)(m_Stream.Length + 7L);
			m_Buffer[1] = (byte)(m_Stream.Length + 7L >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			Z_Stream.WriteByte(0);
			m_Buffer[0] = (byte)wordid;
			m_Buffer[1] = (byte)(wordid >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)(aa >> 8);
			m_Buffer[1] = (byte)aa;
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)(m_Stream.Length - 8L);
			m_Buffer[1] = (byte)(m_Stream.Length - 8L >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			Z_Stream.Write(new byte[8], 0, 8);
			m_Stream.WriteTo(Z_Stream);
			Z_Stream.WriteByte(85);
			Z_Stream.WriteByte(170);
			return Z_Stream.ToArray();
		}
	}
}
