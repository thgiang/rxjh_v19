namespace RxjhServer
{
	public class Itimesx
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int 数量
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public int 属性类型
		{
			get
			{
				return int_1;
			}
			set
			{
				int_1 = value;
			}
		}

		public int 气功属性类型
		{
			get
			{
				return int_2;
			}
			set
			{
				int_2 = value;
			}
		}

		public int 属性数量
		{
			get
			{
				return int_3;
			}
			set
			{
				int_3 = value;
			}
		}

		public Itimesx(byte[] byte_0)
		{
			属性阶段(byte_0);
		}

		public void 属性阶段(byte[] byte_0)
		{
			string text = Buffer.ToInt32(byte_0, 0).ToString();
			switch (text.Length)
			{
			case 8:
				数量 = 1;
				属性类型 = int.Parse(text.Substring(0, 1));
				if (属性类型 == 8)
				{
					气功属性类型 = int.Parse(text.Substring(4, 2));
				}
				if (World.是否支持扩展物品属性位数 == 0)
				{
					属性数量 = int.Parse(text.Substring(6, 2));
				}
				else
				{
					属性数量 = int.Parse(text) - int.Parse(text.Substring(0, 1)) * 10000000;
				}
				break;
			case 9:
				数量 = 1;
				属性类型 = int.Parse(text.Substring(0, 2));
				if (World.是否支持扩展物品属性位数 == 0)
				{
					属性数量 = int.Parse(text.Substring(7, 2));
				}
				else
				{
					属性数量 = int.Parse(text) - int.Parse(text.Substring(0, 2)) * 10000000;
				}
				break;
			case 10:
				数量 = 1;
				属性类型 = int.Parse(text.Substring(0, 2));
				if (World.是否支持扩展物品属性位数 == 0)
				{
					属性数量 = int.Parse(text.Substring(7, 2));
				}
				else
				{
					属性数量 = int.Parse(text) - int.Parse(text.Substring(0, 3)) * 10000000;
				}
				break;
			}
		}
	}
}
