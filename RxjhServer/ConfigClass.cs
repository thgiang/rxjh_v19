using System.Collections;

namespace RxjhServer
{
	public class ConfigClass
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private int int_10;

		private int int_11;

		public int 组队
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

		public int 交易
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

		public int 传音
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

		public int 原著衣服
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

		public int 查装备
		{
			get
			{
				return int_4;
			}
			set
			{
				int_4 = value;
			}
		}

		public int 宠物经验
		{
			get
			{
				return int_5;
			}
			set
			{
				int_5 = value;
			}
		}

		public int 武勋开关
		{
			get
			{
				return int_6;
			}
			set
			{
				int_6 = value;
			}
		}

		public int 头发开关
		{
			get
			{
				return int_7;
			}
			set
			{
				int_7 = value;
			}
		}

		public int 告白开关
		{
			get
			{
				return int_8;
			}
			set
			{
				int_8 = value;
			}
		}

		public int 搜索开关
		{
			get
			{
				return int_9;
			}
			set
			{
				int_9 = value;
			}
		}

		public int 蔬菜武器开关
		{
			get
			{
				return int_10;
			}
			set
			{
				int_10 = value;
			}
		}

		public int 荣誉排名效果
		{
			get
			{
				return int_11;
			}
			set
			{
				int_11 = value;
			}
		}

		public static int GetConfig(ConfigClass configClass_0, int int_12)
		{
			int int_13 = 0;
			if (configClass_0.头发开关 == 1)
			{
				SetFlags(ref int_13, 7, true);
			}
			else if (configClass_0.头发开关 == 3)
			{
				SetFlags(ref int_13, 7, true);
			}
			if (int_12 == 801)
			{
				SetFlags(ref int_13, 4, true);
			}
			else if (configClass_0.原著衣服 == 1)
			{
				SetFlags(ref int_13, 4, true);
			}
			else if (configClass_0.原著衣服 == 2)
			{
				SetFlags(ref int_13, 6, true);
			}
			return int_13;
		}

		public static void SetFlags(ref int int_12, int int_13, bool bool_0)
		{
			BitArray bitArray = new BitArray(new int[1]
			{
				int_12
			});
			bitArray.Set(int_13, bool_0);
			int_12 = 0;
			for (int i = 0; i < bitArray.Length; i++)
			{
				if (bitArray.Get(i))
				{
					int_12 |= 1 << i;
				}
			}
		}
	}
}
