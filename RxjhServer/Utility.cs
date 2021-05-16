using System.IO;
using System.Text;

namespace RxjhServer
{
	public static class Utility
	{
		private static Encoding encoding_0;

		public static Encoding UTF8
		{
			get
			{
				if (encoding_0 == null)
				{
					encoding_0 = new UTF8Encoding(false, false);
				}
				return encoding_0;
			}
		}

		public static void FormatBuffer(TextWriter textWriter_0, Stream stream_0, int int_0)
		{
			textWriter_0.WriteLine("        0  1  2  3  4  5  6  7   8  9  A  B  C  D  E  F");
			textWriter_0.WriteLine("       -- -- -- -- -- -- -- --  -- -- -- -- -- -- -- --");
			int num = 0;
			int num2 = int_0 >> 4;
			int num3 = int_0 & 0xF;
			int num4 = 0;
			while (num4 < num2)
			{
				StringBuilder stringBuilder = new StringBuilder(49);
				StringBuilder stringBuilder2 = new StringBuilder(16);
				for (int i = 0; i < 16; i++)
				{
					int num5 = stream_0.ReadByte();
					stringBuilder.Append(num5.ToString("X2"));
					if (i != 7)
					{
						stringBuilder.Append(' ');
					}
					else
					{
						stringBuilder.Append("  ");
					}
					if (num5 >= 32 && num5 < 128)
					{
						stringBuilder2.Append((char)num5);
					}
					else
					{
						stringBuilder2.Append('.');
					}
				}
				textWriter_0.Write(num.ToString("X4"));
				textWriter_0.Write("   ");
				textWriter_0.Write(stringBuilder.ToString());
				textWriter_0.Write("  ");
				textWriter_0.WriteLine(stringBuilder2.ToString());
				num4++;
				num += 16;
			}
			if (num3 == 0)
			{
				return;
			}
			StringBuilder stringBuilder3 = new StringBuilder(49);
			StringBuilder stringBuilder4 = new StringBuilder(num3);
			for (int j = 0; j < 16; j++)
			{
				if (j < num3)
				{
					int num6 = stream_0.ReadByte();
					stringBuilder3.Append(num6.ToString("X2"));
					if (j != 7)
					{
						stringBuilder3.Append(' ');
					}
					else
					{
						stringBuilder3.Append("  ");
					}
					if (num6 >= 32 && num6 < 128)
					{
						stringBuilder4.Append((char)num6);
					}
					else
					{
						stringBuilder4.Append('.');
					}
				}
				else
				{
					stringBuilder3.Append("   ");
				}
			}
			textWriter_0.Write(num.ToString("X4"));
			textWriter_0.Write("   ");
			textWriter_0.Write(stringBuilder3.ToString());
			textWriter_0.Write("  ");
			textWriter_0.WriteLine(stringBuilder4.ToString());
		}
	}
}
