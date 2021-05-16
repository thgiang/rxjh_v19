using System.Collections;

namespace RxjhServer
{
	public class OpenClass
	{
		private int int_0;

		private string string_0;

		private int int_1;

		private string string_1;

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

		private int int_12;

		private int int_13;

		public int FLD_PID
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

		public string FLD_NAME
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

		public int FLD_PIDX
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

		public string FLD_NAMEX
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

		public int FLD_NUMBER
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

		public int FLD_PP
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

		public int FLD_MAGIC5
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

		public int FLD_觉醒
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

		public int FLD_进化
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

		public int FLD_中级附魂
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

		public int FLD_BD
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

		public int FLD_DAYS
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

		public static OpenClass GetOpen(int int_14, int int_15, int int_16)
		{
			ArrayList arrayList = new ArrayList();
			if (int_14 == 1000000071)
			{
				foreach (ItmeClass value in World.Itme.Values)
				{
					if ((value.FLD_RESIDE2 == 19 || value.FLD_RESIDE2 == 1792) && (value.FLD_RESIDE1 == int_15 || value.FLD_RESIDE1 == 0) && (value.FLD_ZX == 0 || value.FLD_ZX == int_16) && value.FLD_LEVEL != 100 && value.FLD_LEVEL != 104 && value.FLD_LEVEL != 108 && value.FLD_PID != 1000000200 && value.FLD_PID != 1000000213)
					{
						arrayList.Add(new OpenClass
						{
							FLD_PID = 1000000071,
							FLD_PIDX = value.FLD_PID,
							FLD_NAME = "上古宝箱",
							FLD_NAMEX = value.ItmeNAME
						});
					}
				}
			}
			else
			{
				int num = RNG.Next(1, 500);
				foreach (OpenClass item in World.Open)
				{
					if (item.FLD_PID == int_14 && item.FLD_PP >= num)
					{
						arrayList.Add(item);
					}
				}
				if (arrayList.Count == 0)
				{
					return null;
				}
			}
			return (OpenClass)arrayList[RNG.Next(0, arrayList.Count - 1)];
		}
	}
}
