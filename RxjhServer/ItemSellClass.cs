namespace RxjhServer
{
	public class ItemSellClass
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

		private string string_0;

		private int int_12;

		private string string_1;

		private int int_13;

		private int int_14;

		public int 中级附魂
		{
			get
			{
				return int_12;
			}
			set
			{
				int_12 = value;
			}
		}

		public string name
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public string sql
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public int NJ
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

		public int DAYS
		{
			get
			{
				return int_13;
			}
			set
			{
				int_13 = value;
			}
		}

		public int BD
		{
			get
			{
				return int_14;
			}
			set
			{
				int_14 = value;
			}
		}

		public int Magic0
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

		public int ID
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

		public int Magic4
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

		public int Type
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

		public int Magic1
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

		public int Magic2
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

		public int Magic5
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

		public int Magic3
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

		public int 觉醒
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

		public int 进化
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

		public int Reside
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

		public static ItemSellClass 取物品数据(int int_15, int int_16)
		{
			foreach (ItemSellClass item in World.套装数据)
			{
				if (item.Type == int_15 && item.Reside == int_16)
				{
					return item;
				}
			}
			return null;
		}
	}
}
