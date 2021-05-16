using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RxjhServer
{
	public class SymmetricMethod
	{
		public string Key;

		private SymmetricAlgorithm symmetricAlgorithm_0;

		public SymmetricMethod()
		{
			symmetricAlgorithm_0 = new RijndaelManaged();
			Key = method_0() + Hasher.GetIP();
		}

		internal string method_0()
		{
			return "123kj1l23kj1lkuji12123O5$k2F89TEEg&9QoRKa7imTCue2gMMHGRwGm9S2iWR&eQsduuKJ60qX33J@yw*#LeQT#i&eU%z7kD!lixj123123f123asdx7SLy&I%as$DUnp6fAAUOdrW3kzS$AafLLCpxN#7T$hl!FgO*&Ffdemsx^kCeVRANs1ygFQMLF#c%1UnmeaApX#ry9uVBjRXnNN$#72pOBchm^peWQrsUYWiPc8g";
		}

		public string Decrypto(string string_0)
		{
			try
			{
				byte[] array = Convert.FromBase64String(string_0);
				MemoryStream stream = new MemoryStream(array, 0, array.Length);
				string text = "";
				int length = string_0.Length;
				text = "";
				int num = Convert.ToInt32(string_0.ToCharArray(0, 1)[0]) % 10;
				for (int i = 2; i < length; i += 2)
				{
					int num2 = Convert.ToInt32(string_0.ToCharArray(i, 1)[0]);
					string str = (Convert.ToInt32(string_0.ToCharArray(i - 1, 1)[0]) % 2 != 0) ? ((char)(num2 - (i - 1) / 2 - num)).ToString() : ((char)(num2 + (i - 1) / 2 + num)).ToString();
					text += str;
				}
				symmetricAlgorithm_0.Key = method_3();
				symmetricAlgorithm_0.IV = method_2();
				ICryptoTransform transform = symmetricAlgorithm_0.CreateDecryptor();
				return new StreamReader(new CryptoStream(stream, transform, CryptoStreamMode.Read)).ReadToEnd();
			}
			catch
			{
				return "";
			}
		}

		public string Encrypto(string string_0)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			MemoryStream memoryStream = new MemoryStream();
			symmetricAlgorithm_0.Key = method_3();
			symmetricAlgorithm_0.IV = method_2();
			ICryptoTransform transform = symmetricAlgorithm_0.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			memoryStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		internal string method_1()
		{
			return "123123123f123123zqz5zPLRwQA!I%8GyL#Mn58Ds^s#%aRC3u#8B%nb1Z^jVmbBicXSReT1Pon6bd8spx34211dfcgMoo9qM%&kUUTEfgE5ulmKqw%hlQCpoG0YDfP5fF$s9K8%dzeFhICB2j9*FoWLx1hR^NpXMVN5sQFEowaUB8#tuGuN@ctREM9st$CPlMi!K7dPg$ChSvJbHh@eAj^$8x*Pwsj";
		}

		private byte[] method_2()
		{
			string text = method_1();
			symmetricAlgorithm_0.GenerateIV();
			int num = symmetricAlgorithm_0.IV.Length;
			if (text.Length > num)
			{
				text = text.Substring(text.Length - num, num);
			}
			else if (text.Length < num)
			{
				text = text.PadRight(num, ' ');
			}
			return Encoding.ASCII.GetBytes(text);
		}

		private byte[] method_3()
		{
			string text = Key;
			symmetricAlgorithm_0.GenerateKey();
			int num = symmetricAlgorithm_0.Key.Length;
			if (text.Length > num)
			{
				text = text.Substring(text.Length - num, num);
			}
			else if (text.Length < num)
			{
				text = text.PadRight(num, ' ');
			}
			return Encoding.ASCII.GetBytes(text);
		}
	}
}
