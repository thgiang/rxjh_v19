using System;
using System.Text;

namespace RxjhServer
{
	public class RC6
	{
		public Encoding Enc_default = Encoding.Unicode;

		private const int m_nWord = 32;

		private const int r = 20;

		private const int c = 4;

		private string string_0;

		public string m_sCryptedText;

		private int int_0;

		private uint[] m_nKeyExpandBox;

		private uint[] n_WordBox;

		public string KEY
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public int IV
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public uint ROTL(uint uint_0, uint uint_1, int int_1)
		{
			return (uint_0 << (int)(uint_1 & 0xFF)) | (uint_0 >> (int)(int_1 - (uint_1 & 0xFF)));
		}

		public uint ROTR(uint uint_0, uint uint_1, int int_1)
		{
			return (uint_0 >> (int)(uint_1 & 0xFF)) | (uint_0 << (int)(int_1 - (uint_1 & 0xFF)));
		}

		public RC6()
		{
			IV = 16;
			m_nKeyExpandBox = new uint[8 * int_0];
		}

		public RC6(int int_1)
		{
			IV = int_1;
			m_nKeyExpandBox = new uint[8 * int_0];
		}

		public int _IV()
		{
			if (int_0 < 16)
			{
				int_0 = 16;
			}
			if (int_0 > 32)
			{
				int_0 = 32;
			}
			return int_0;
		}

		private char[] method_0()
		{
			string text = string_0;
			byte[] array = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, Encoding.Unicode.GetBytes((text.Length % int_0 != 0) ? text.PadRight(text.Length + (int_0 - text.Length % int_0), '\0') : text));
			char[] array2 = new char[Encoding.ASCII.GetCharCount(array, 0, array.Length)];
			Encoding.ASCII.GetChars(array, 0, array.Length, array2, 0);
			return array2;
		}

		private void method_1()
		{
			uint num = 3084996963u;
			uint num2 = 2654435769u;
			uint num3 = 0u;
			uint num4 = 0u;
			char[] array = method_0();
			n_WordBox = new uint[int_0 / 4];
			for (int i = 0; i < int_0; i++)
			{
				uint num5 = (uint)((array[i] & 0xFF) << 8 * (i % 4));
				n_WordBox[i / 4] += num5;
			}
			m_nKeyExpandBox[0] = num;
			for (int j = 1; j < 2 * int_0 + 4; j++)
			{
				m_nKeyExpandBox[j] = m_nKeyExpandBox[j - 1] + num2;
			}
			int num6 = 3 * Math.Max(n_WordBox.Length, 2 * int_0 + 4);
			int num7 = 0;
			int num8 = 0;
			while (num6 > 0)
			{
				num4 = ROTL(m_nKeyExpandBox[num8] + num4 + num3, 3u, 32);
				m_nKeyExpandBox[num8] = (byte)num4;
				uint num9 = num3 + num4;
				num3 = ROTL(n_WordBox[num7] + num4 + num9, num4 + num9, 32);
				n_WordBox[num7] = num3;
				num8 = (num8 + 1) % (2 * int_0 + 4);
				num7 = (num7 + 1) % n_WordBox.Length;
				num6--;
			}
		}

		public string Encrypt(string string_1, string string_2)
		{
			string_1 = ((string_1.Length % 32 != 0) ? string_1.PadRight(string_1.Length + (32 - string_1.Length % 32), '\0') : string_1);
			KEY = string_2;
			method_1();
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			byte[] bytes = Encoding.Unicode.GetBytes(string_1);
			char[] chars = new char[Encoding.ASCII.GetCharCount(bytes, 0, bytes.Length)];
			Encoding.ASCII.GetChars(bytes, 0, bytes.Length, chars, 0);
			byte[] array = new byte[bytes.Length];
			for (int i = 0; i < 4; i++)
			{
				num4 = (uint)((int)num4 + ((bytes[2 * i] & 0xFF) << 8 * i));
				num3 = (uint)((int)num3 + ((bytes[2 * i + 8] & 0xFF) << 8 * i));
				num2 = (uint)((int)num2 + ((bytes[2 * i + 16] & 0xFF) << 8 * i));
				num = (uint)((int)num + ((bytes[2 * i + 24] & 0xFF) << 8 * i));
			}
			uint num5 = num3 + m_nKeyExpandBox[0];
			uint num6 = num + m_nKeyExpandBox[1];
			for (int j = 1; j <= int_0; j++)
			{
				uint num7 = ROTL(num6 * (2 * num6 + 1), 5u, 32);
				uint num8 = ROTL(num5 * (2 * num5 + 1), 5u, 32);
				uint num9 = ROTL(num4 ^ num8, num7, 32) + m_nKeyExpandBox[2 * j];
				uint num10 = ROTL(num2 ^ num7, num8, 32) + m_nKeyExpandBox[2 * j + 1];
				uint num11 = num9;
				num4 = num5;
				num5 = num10;
				num2 = num6;
				num6 = num11;
			}
			uint[] array2 = new uint[4];
			uint num12 = num4 + m_nKeyExpandBox[42];
			uint num13 = num2 + m_nKeyExpandBox[43];
			array2[0] = num12;
			array2[1] = num5;
			array2[2] = num13;
			array2[3] = num6;
			for (int k = 0; k < 4; k++)
			{
				array[2 * k] = (byte)((array2[0] >> 8 * k) & 0xFF);
				array[2 * k + 8] = (byte)((array2[1] >> 8 * k) & 0xFF);
				array[2 * k + 16] = (byte)((array2[2] >> 8 * k) & 0xFF);
				array[2 * k + 24] = (byte)((array2[3] >> 8 * k) & 0xFF);
			}
			char[] array3 = new char[array.Length];
			Encoding.Unicode.GetChars(array, 0, array.Length, array3, 0);
			m_sCryptedText = new string(array3, 0, array3.Length);
			Enc_default.GetBytes(m_sCryptedText);
			return m_sCryptedText;
		}

		public string Decrypt(string string_1, string string_2)
		{
			string_1 = ((string_1.Length % 32 != 0) ? string_1.PadRight(string_1.Length + (32 - string_1.Length % 32), '\0') : string_1);
			KEY = string_2;
			method_1();
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			byte[] bytes = Enc_default.GetBytes(string_1);
			byte[] array = new byte[bytes.Length];
			for (int i = 0; i < 4; i++)
			{
				num4 = (uint)((int)num4 + ((bytes[2 * i] & 0xFF) << 8 * i));
				num3 = (uint)((int)num3 + ((bytes[2 * i + 8] & 0xFF) << 8 * i));
				num2 = (uint)((int)num2 + ((bytes[2 * i + 16] & 0xFF) << 8 * i));
				num = (uint)((int)num + ((bytes[2 * i + 24] & 0xFF) << 8 * i));
			}
			uint num5 = num2 - m_nKeyExpandBox[43];
			uint num6 = num4 - m_nKeyExpandBox[42];
			for (int j = 1; j <= int_0; j++)
			{
				uint num7 = num;
				num = num5;
				uint num8 = num3;
				num3 = num6;
				uint num9 = num7;
				uint num10 = ROTL(num * (2 * num + 1), 5u, 32);
				uint num11 = ROTL(num3 * (2 * num3 + 1), 5u, 32);
				num5 = (ROTR(num8 - m_nKeyExpandBox[2 * (int_0 - j) + 3], num11, 32) ^ num10);
				num6 = (ROTR(num9 - m_nKeyExpandBox[2 * (int_0 - j) + 2], num10, 32) ^ num11);
			}
			uint num12 = num - m_nKeyExpandBox[1];
			uint num13 = num3 - m_nKeyExpandBox[0];
			for (int k = 0; k < 4; k++)
			{
				array[2 * k] = (byte)((num6 >> 8 * k) & 0xFF);
				array[2 * k + 8] = (byte)((num13 >> 8 * k) & 0xFF);
				array[2 * k + 16] = (byte)((num5 >> 8 * k) & 0xFF);
				array[2 * k + 24] = (byte)((num12 >> 8 * k) & 0xFF);
			}
			char[] array2 = new char[Enc_default.GetCharCount(array, 0, array.Length)];
			Enc_default.GetChars(array, 0, array.Length, array2, 0);
			m_sCryptedText = new string(array2, 0, array2.Length);
			Enc_default.GetBytes(m_sCryptedText);
			return m_sCryptedText;
		}
	}
}
