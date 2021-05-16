namespace RxjhServer
{
	public class ItmeClass
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

		private int int_12;

		private int int_13;

		private int int_14;

		private int int_15;

		private string string_0;

		private int int_16;

		private int int_17;

		private int int_18;

		private int int_19;

		private int int_20;

		private int int_21;

		private int int_22;

		private int int_23;

		private int int_24;

		private int int_25;

		private int int_26;

		private int int_27;

		private int int_28;

		private int int_29;

		public int FLD_QUESTITEM
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

		public int FLD_PID
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

		public int FLD_RESIDE1
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

		public int FLD_RESIDE2
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

		public int FLD_SEX
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

		public int FLD_DF
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

		public int FLD_LEVEL
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

		public int FLD_JOB_LEVEL
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

		public int FLD_ZX
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

		public int FLD_AT
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

		public int FLD_AT_Max
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

		public int FLD_RECYCLE_MONEY
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

		public int FLD_SALE_MONEY
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

		public int FLD_SIDE
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

		public int FLD_TYPE
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

		public int FLD_WEIGHT
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

		public string ItmeNAME
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

		public int FLD_MAGIC0
		{
			get
			{
				return int_16;
			}
			set
			{
				int_16 = value;
			}
		}

		public int FLD_MAGIC1
		{
			get
			{
				return int_17;
			}
			set
			{
				int_17 = value;
			}
		}

		public int FLD_MAGIC2
		{
			get
			{
				return int_18;
			}
			set
			{
				int_18 = value;
			}
		}

		public int FLD_MAGIC3
		{
			get
			{
				return int_19;
			}
			set
			{
				int_19 = value;
			}
		}

		public int FLD_MAGIC4
		{
			get
			{
				return int_20;
			}
			set
			{
				int_20 = value;
			}
		}

		public int FLD_NEED_MONEY
		{
			get
			{
				return int_21;
			}
			set
			{
				int_21 = value;
			}
		}

		public int FLD_NEED_FIGHTEXP
		{
			get
			{
				return int_22;
			}
			set
			{
				int_22 = value;
			}
		}

		public int FLD_INTEGRATION
		{
			get
			{
				return int_23;
			}
			set
			{
				int_23 = value;
			}
		}

		public int FLD_SERIES
		{
			get
			{
				return int_24;
			}
			set
			{
				int_24 = value;
			}
		}

		public int FLD_UP_LEVEL
		{
			get
			{
				return int_25;
			}
			set
			{
				int_25 = value;
			}
		}

		public int FLD_LOCK
		{
			get
			{
				return int_26;
			}
			set
			{
				int_26 = value;
			}
		}

		public int FLD_XW
		{
			get
			{
				return int_27;
			}
			set
			{
				int_27 = value;
			}
		}

		public int FLD_XWJD
		{
			get
			{
				return int_28;
			}
			set
			{
				int_28 = value;
			}
		}

		public int FLD_NJ
		{
			get
			{
				return int_29;
			}
			set
			{
				int_29 = value;
			}
		}

		public static ItmeClass GetItme(string string_1)
		{
			foreach (ItmeClass value in World.Itme.Values)
			{
				if (value.ItmeNAME == string_1)
				{
					return value;
				}
			}
			return null;
		}

		public static string 得到物品名称(int int_30)
		{
			ItmeClass value;
			if (World.Itme.TryGetValue(int_30, out value))
			{
				return value.ItmeNAME;
			}
			return string.Empty;
		}

		public static ItmeClass GetItmeID(int int_30)
		{
			ItmeClass value;
			if (World.Itme.TryGetValue(int_30, out value))
			{
				return value;
			}
			return null;
		}
	}
}
