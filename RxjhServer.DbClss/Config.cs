using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RxjhServer.DbClss
{
	public class Config
	{
		private static string string_0 = Application.StartupPath + "\\config\\config.ini";

		public static string Path
		{
			set
			{
				string_0 = value;
			}
		}

		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string string_1, string string_2, string string_3, string string_4);

		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string string_1, string string_2, string string_3, StringBuilder stringBuilder_0, int int_0, string string_4);

		public static void IniWriteValue(string string_1, string string_2, string string_3)
		{
			WritePrivateProfileString(string_1, string_2, string_3, string_0);
		}

		public static string IniReadValue(string string_1, string string_2)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			GetPrivateProfileString(string_1, string_2, string.Empty, stringBuilder, 1024, string_0);
			return stringBuilder.ToString();
		}
	}
}
