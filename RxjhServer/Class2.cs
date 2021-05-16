using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RxjhServer
{
	public class Class2
	{
		private string string_0 = "<RSAKeyValue><Modulus>y+XGM4lAnEKsEb23uoadipw11QLSSLrcqLR4jZqAPAMGVsVlMi+SUJOTMFO+QsN2mDzCSaAdOxH7Cn9+MqH3wO+FwFuILmIdlXG9ZNARH8hwheRJrCD9X5cENXYHKRIXSVu+INbyicjQXGiJ/ycf9e35OBHOZJgy7FBqjC6m/u8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

		public string EncryptByPublicKey(string string_1)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
			rSACryptoServiceProvider.FromXmlString(string_0);
			RSAParameters rSAParameters = rSACryptoServiceProvider.ExportParameters(false);
			byte[] modulus = rSAParameters.Modulus;
			byte[] exponent = rSAParameters.Exponent;
			BigInteger bigInteger_ = new BigInteger(modulus);
			BigInteger bigInteger_2 = new BigInteger(exponent);
			int num4 = 1024 / 8;
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			int num = 86;
			int num2 = bytes.Length;
			int num3 = num2 / 86;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i <= num3; i++)
			{
				byte[] array = new byte[(num2 - num * i > num) ? num : (num2 - num * i)];
				System.Buffer.BlockCopy(bytes, num * i, array, 0, array.Length);
				byte[] array2 = method_0(array, bigInteger_2, bigInteger_);
				Array.Reverse(array2);
				stringBuilder.Append(Convert.ToBase64String(array2));
			}
			return stringBuilder.ToString();
		}

		public string DecryptByPublicKey(string string_1)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
			rSACryptoServiceProvider.FromXmlString(string_0);
			RSAParameters rSAParameters = rSACryptoServiceProvider.ExportParameters(false);
			byte[] modulus = rSAParameters.Modulus;
			byte[] exponent = rSAParameters.Exponent;
			BigInteger bigInteger_ = new BigInteger(modulus);
			BigInteger bigInteger_2 = new BigInteger(exponent);
			int num = 172;
			int num2 = string_1.Length / 172;
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < num2; i++)
			{
				byte[] array = Convert.FromBase64String(string_1.Substring(num * i, num));
				Array.Reverse(array);
				arrayList.AddRange(method_1(array, bigInteger_2, bigInteger_));
			}
			return Encoding.UTF8.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
		}

		private byte[] method_0(byte[] byte_0, BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			int num = byte_0.Length;
			int num2 = 0;
			int num3 = 0;
			num2 = ((num % 120 != 0) ? (num / 120 + 1) : (num / 120));
			List<byte> list = new List<byte>();
			for (int i = 0; i < num2; i++)
			{
				num3 = ((num < 120) ? num : 120);
				byte[] array = new byte[num3];
				Array.Copy(byte_0, i * 120, array, 0, num3);
				Encoding.UTF8.GetString(array);
				string text = new BigInteger(array).modPow(bigInteger_0, bigInteger_1).ToHexString();
				if (text.Length < 256)
				{
					while (text.Length != 256)
					{
						text = "0" + text;
					}
				}
				byte[] array2 = new byte[128];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Convert.ToByte(text.Substring(j * 2, 2), 16);
				}
				list.AddRange(array2);
				num -= num3;
			}
			return list.ToArray();
		}

		private byte[] method_1(byte[] byte_0, BigInteger bigInteger_0, BigInteger bigInteger_1)
		{
			int num = byte_0.Length;
			int num2 = 0;
			int num3 = 0;
			num2 = ((num % 128 != 0) ? (num / 128 + 1) : (num / 128));
			List<byte> list = new List<byte>();
			for (int i = 0; i < num2; i++)
			{
				num3 = ((num < 128) ? num : 128);
				byte[] array = new byte[num3];
				Array.Copy(byte_0, i * 128, array, 0, num3);
				byte[] bytes = new BigInteger(array).modPow(bigInteger_0, bigInteger_1).getBytes();
				Encoding.UTF8.GetString(bytes);
				list.AddRange(bytes);
				num -= num3;
			}
			return list.ToArray();
		}
	}
}
