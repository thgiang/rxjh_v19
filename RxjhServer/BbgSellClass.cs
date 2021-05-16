namespace RxjhServer
{
	public class BbgSellClass
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private string string_0;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		private int int_14;

		private int int_15;

		public int FLD_NJ
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

		public int FLD_中级附魂
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

		public int FLD_绑定
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

		public int 使用天数
		{
			get
			{
				return int_15;
			}
			set
			{
				int_15 = value;
			}
		}

		public string Name
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

		public int PID
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

		public int MAGIC1
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

		public int MAGIC2
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

		public int MAGIC3
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

		public int MAGIC5
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

		public int MAGIC4
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

		public int FLD_觉醒
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

		public int FLD_进化
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

		public int Price
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

		public int number
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

		public int retrun
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

		public static BbgSellClass 取物品数据(string string_1)
		{
			foreach (BbgSellClass value in World.百宝阁数据.Values)
			{
				if (value.Name == string_1)
				{
					return value;
				}
			}
			return null;
		}

		public static BbgSellClass GetItem(int int_16)
		{
			BbgSellClass value;
			if (World.百宝阁数据.TryGetValue(int_16, out value))
			{
				return value;
			}
			return null;
		}

		public static string b1(int int_16)
		{
			BbgSellClass value;
			if (World.百宝阁数据.TryGetValue(int_16, out value))
			{
				return value.Name;
			}
			return string.Empty;
		}
	}
}
