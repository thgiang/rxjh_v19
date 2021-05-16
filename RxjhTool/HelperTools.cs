using System;
using System.Text;

namespace RxjhTool
{
	public class HelperTools
	{
		public static byte[] hexStringToByte(string string_0)
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

		public static string ByteToString(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte value in byte_0)
			{
				stringBuilder.Append(Convert.ToString((short)value, 16).PadLeft(2, '0').ToUpper());
			}
			return stringBuilder.ToString();
		}
	}
}
