using System;

namespace RxjhServer
{
	public class 任务物品类
	{
		public byte[] 物品_byte;

		public int 物品ID
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 0, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 0, 4);
			}
		}

		public int 物品数量
		{
			get
			{
				byte[] array = new byte[4];
				System.Buffer.BlockCopy(物品_byte, 4, array, 0, 4);
				return Buffer.ToInt32(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, 物品_byte, 4, 4);
			}
		}

		public 任务物品类(byte[] byte_0)
		{
			物品_byte = byte_0;
		}
	}
}
