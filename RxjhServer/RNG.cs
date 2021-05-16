using System.Security.Cryptography;

namespace RxjhServer
{
	public static class RNG
	{
		private static RNGCryptoServiceProvider rngcryptoServiceProvider_0 = new RNGCryptoServiceProvider();

		private static byte[] rb = new byte[4];

		public static int Next()
		{
			rngcryptoServiceProvider_0.GetBytes(rb);
			int num = Buffer.ToInt32(rb, 0);
			if (num < 0)
			{
				num = -num;
			}
			return num;
		}

		public static int Next(int int_0)
		{
			rngcryptoServiceProvider_0.GetBytes(rb);
			int num = Buffer.ToInt32(rb, 0) % (int_0 + 1);
			if (num < 0)
			{
				num = -num;
			}
			return num;
		}

		public static int Next(int int_0, int int_1)
		{
			return Next(int_1 - int_0) + int_0;
		}
	}
}
