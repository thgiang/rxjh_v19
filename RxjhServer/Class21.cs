using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RxjhServer
{
	public class Class21
	{
		private static string string_0 = "abcd";

		public string Encrypt(string string_1)
		{
			try
			{
				byte[] bytes = Encoding.Unicode.GetBytes(string_0);
				byte[] bytes2 = Encoding.Unicode.GetBytes(string_1);
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
				cryptoStream.Write(bytes2, 0, bytes2.Length);
				cryptoStream.FlushFinalBlock();
				byte[] inArray = memoryStream.ToArray();
				cryptoStream.Close();
				memoryStream.Close();
				return Convert.ToBase64String(inArray);
			}
			catch
			{
				return string_1;
			}
		}

		public string Decrypt(string string_1)
		{
			try
			{
				byte[] bytes = Encoding.Unicode.GetBytes(string_0);
				byte[] array = Convert.FromBase64String(string_1);
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte[] bytes2 = memoryStream.ToArray();
				cryptoStream.Close();
				memoryStream.Close();
				return Encoding.Unicode.GetString(bytes2);
			}
			catch
			{
				return string_1;
			}
		}
	}
}
