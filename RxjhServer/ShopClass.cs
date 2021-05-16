using System.Collections.Generic;

namespace RxjhServer
{
	public class ShopClass
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private long long_0;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		public int FLD_NID
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

		public int FLD_INDEX
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

		public int FLD_PID
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

		public long FLD_MONEY
		{
			get
			{
				return long_0;
			}
			set
			{
				long_0 = value;
			}
		}

		public int FLD_MAGIC0
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

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
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

		public int 需要武勋
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

		public int FLD_MAGICZh
		{
			get
			{
				int num = 0;
				if (int_4 != 0)
				{
					num++;
				}
				if (int_5 != 0)
				{
					num++;
				}
				if (int_6 != 0)
				{
					num++;
				}
				if (int_7 != 0)
				{
					num++;
				}
				return num;
			}
		}

		public static List<ShopClass> GetShopListAll(int int_9)
		{
			List<ShopClass> list = new List<ShopClass>();
			foreach (ShopClass item in World.Shop)
			{
				if (item.FLD_NID == int_9)
				{
					list.Add(item);
				}
			}
			return list;
		}

		public static List<ShopClass> GetShopList(int int_9, int int_10)
		{
			List<ShopClass> list = new List<ShopClass>();
			List<ShopClass> list2 = new List<ShopClass>();
			if (int_10 == 0)
			{
				int num = 0;
				{
					foreach (ShopClass item in World.Shop)
					{
						num++;
						if (item.FLD_NID == int_9)
						{
							list.Add(item);
						}
						if (list.Count == 60)
						{
							return list;
						}
					}
					return list;
				}
			}
			foreach (ShopClass item2 in World.Shop)
			{
				if (item2.FLD_NID == int_9)
				{
					list.Add(item2);
				}
			}
			for (int i = int_10 * 60; i < list.Count; i++)
			{
				list2.Add(list[i]);
				if (list2.Count == 60)
				{
					break;
				}
			}
			return list2;
		}

		public static ShopClass Getwp(int int_9)
		{
			foreach (ShopClass item in World.Shop)
			{
				if (item.FLD_PID == int_9)
				{
					return item;
				}
			}
			return null;
		}

		public static int GetShop(int int_9)
		{
			int num = 0;
			foreach (ShopClass item in World.Shop)
			{
				if (item.FLD_NID == int_9)
				{
					num++;
				}
			}
			return num;
		}
	}
}
