using System.Text;

namespace loader
{
	public class DefaultFormatProvider : GInterface0
	{
		public static DefaultFormatProvider Instance = new DefaultFormatProvider();

		private DefaultFormatProvider()
		{
		}

		public virtual string Int32ToHex(int int32)
		{
			return int32.ToString("X8");
		}

		public virtual string Int16ToHex(int int16)
		{
			return int16.ToString("X4");
		}

		public virtual string Int8ToHex(int int8)
		{
			return int8.ToString("X2");
		}

		public virtual string Argument(int ordinal)
		{
			return string.Format("V_{0}", ordinal);
		}

		public virtual string Label(int offset)
		{
			return string.Format("IL_{0:x4}", offset);
		}

		public virtual string MultipleLabels(int[] offsets)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = offsets.Length;
			for (int i = 0; i < num; i++)
			{
				if (i == 0)
				{
					stringBuilder.AppendFormat("(");
				}
				else
				{
					stringBuilder.AppendFormat(", ");
				}
				stringBuilder.Append(Label(offsets[i]));
			}
			stringBuilder.AppendFormat(")");
			return stringBuilder.ToString();
		}

		public virtual string EscapedString(string str)
		{
			int length = str.Length;
			StringBuilder stringBuilder = new StringBuilder(length * 2);
			for (int i = 0; i < length; i++)
			{
				char c = str[i];
				if (c == '\t')
				{
					stringBuilder.Append("\\t");
				}
				else if (c == '\n')
				{
					stringBuilder.Append("\\n");
				}
				else if (c == '\r')
				{
					stringBuilder.Append("\\r");
				}
				else if (c == '"')
				{
					stringBuilder.Append("\\\"");
				}
				else if (c == '\\')
				{
					stringBuilder.Append("\\");
				}
				else if (c < ' ' || c >= '\u007f')
				{
					stringBuilder.AppendFormat("\\u{0:x4}", (int)c);
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return "\"" + stringBuilder.ToString() + "\"";
		}

		public virtual string SigByteArrayToString(byte[] sig)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = sig.Length;
			for (int i = 0; i < num; i++)
			{
				if (i == 0)
				{
					stringBuilder.AppendFormat("SIG [");
				}
				else
				{
					stringBuilder.AppendFormat(" ");
				}
				stringBuilder.Append(Int8ToHex(sig[i]));
			}
			stringBuilder.AppendFormat("]");
			return stringBuilder.ToString();
		}
	}
}
