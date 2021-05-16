using System;

namespace RxjhServer
{
	public class 人物模板类
	{
		public byte[] 人物模板_byte;

		public byte 脸型1
		{
			get
			{
				return 人物模板_byte[0];
			}
			set
			{
				人物模板_byte[0] = value;
			}
		}

		public short 发色
		{
			get
			{
				return BitConverter.ToInt16(人物模板_byte, 1);
			}
			set
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(value), 0, 人物模板_byte, 1, 2);
			}
		}

		public byte 发型11
		{
			get
			{
				return 人物模板_byte[3];
			}
			set
			{
				人物模板_byte[3] = value;
			}
		}

		public byte 声音
		{
			get
			{
				return 人物模板_byte[4];
			}
			set
			{
				人物模板_byte[4] = value;
			}
		}

		public byte 性别
		{
			get
			{
				return 人物模板_byte[5];
			}
			set
			{
				人物模板_byte[5] = value;
			}
		}

		public short 发型
		{
			get
			{
				return BitConverter.ToInt16(人物模板_byte, 6);
			}
			set
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(value), 0, 人物模板_byte, 6, 2);
			}
		}

		public short 脸型
		{
			get
			{
				return BitConverter.ToInt16(人物模板_byte, 8);
			}
			set
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(value), 0, 人物模板_byte, 8, 2);
			}
		}

		public 人物模板类(byte[] byte_0)
		{
			人物模板_byte = byte_0;
		}
	}
}
