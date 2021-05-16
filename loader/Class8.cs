namespace loader
{
	internal class Class8
	{
		public struct Struct8
		{
			public int int_0;

			public int int_1;

			public byte[] m;
		}

		public static void smethod_0(ref Struct8 struct8_0, byte[] byte_0, int int_0)
		{
			struct8_0.int_0 = 0;
			struct8_0.int_1 = 0;
			struct8_0.m = new byte[256];
			for (int i = 0; i < 256; i++)
			{
				struct8_0.m[i] = (byte)i;
			}
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < 256; i++)
			{
				byte b = struct8_0.m[i];
				num2 = (byte)(num2 + b + byte_0[num]);
				struct8_0.m[i] = struct8_0.m[num2];
				struct8_0.m[num2] = b;
				if (++num >= int_0)
				{
					num = 0;
				}
			}
		}

		public static int smethod_1(ref Struct8 struct8_0, byte[] byte_0, ref byte[] byte_1, int int_0)
		{
			int num = struct8_0.int_0;
			int num2 = struct8_0.int_1;
			for (int i = 0; i < int_0; i++)
			{
				num = (byte)(num + 1);
				byte b = struct8_0.m[num];
				num2 = (byte)(num2 + b);
				byte b2;
				struct8_0.m[num] = (b2 = struct8_0.m[num2]);
				struct8_0.m[num2] = b;
				byte_1[i] = (byte)(byte_0[i] ^ struct8_0.m[(byte)(b + b2)]);
			}
			struct8_0.int_0 = num;
			struct8_0.int_1 = num2;
			return int_0;
		}
	}
}
