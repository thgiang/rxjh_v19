using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class DropClass
	{
		public List<DropShuXClass> DropShuX = new List<DropShuXClass>();

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int FLD_PIDNew;

		public int FLD_MAGICNew0;

		public int FLD_MAGICNew1;

		public int FLD_MAGICNew2;

		public int FLD_MAGICNew3;

		public int FLD_MAGICNew4;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private string string_0;

		private int int_9;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		public int _是否开启公告;

		public int FLD_LEVEL1
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

		public int FLD_LEVEL2
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

		public int FLD_MAGIC0
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

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
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

		public int FLD_NJ
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

		public int FLD_初级附魂
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

		public int 是否开启公告
		{
			get
			{
				return _是否开启公告;
			}
			set
			{
				_是否开启公告 = value;
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

		public int FLD_绑定
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

		public static List<DropClass> GetBossDrop(int int_14)
		{
			try
			{
				List<DropClass> list = new List<DropClass>();
				List<DropClass> list2 = new List<DropClass>();
				Random random = new Random(DateTime.Now.Millisecond);
				RNG.Next(1, 8000);
				foreach (DropClass item in World.BossDrop)
				{
					int num = RNG.Next(1, 8000);
					if (item.FLD_PP != 0 && item.FLD_LEVEL1 <= int_14 && item.FLD_LEVEL2 >= int_14 && item.FLD_PP >= num)
					{
						list.Add(item);
					}
				}
				if (list.Count == 0)
				{
					return null;
				}
				int num2 = random.Next(1, 2);
				int num3 = 0;
				foreach (DropClass item2 in list)
				{
					DropClass dropClass = item2;
					if (num3 >= num2)
					{
						break;
					}
					list2.Add(list[RNG.Next(0, list.Count - 1)]);
					num3++;
				}
				return (list2.Count == 0) ? null : list2;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "BOSS掉落出错leve[" + int_14 + "]" + ex.Message);
				return null;
			}
		}

		public static List<DropClass> GetGSDrop(int int_14, int int_15, int int_16)
		{
			try
			{
				List<DropClass> list = new List<DropClass>();
				List<DropClass> list2 = new List<DropClass>();
				Random random = new Random(DateTime.Now.Millisecond);
				int num = RNG.Next(1, 8000);
				foreach (DropClass drop_G in World.Drop_GS)
				{
					if (drop_G.FLD_PP != 0 && drop_G.FLD_LEVEL1 <= int_14 && drop_G.FLD_LEVEL2 >= int_14 && drop_G.FLD_PP >= num)
					{
						list.Add(drop_G);
					}
				}
				if (list.Count == 0)
				{
					return null;
				}
				int num2 = random.Next(1, 2);
				int num3 = 0;
				foreach (DropClass item in list)
				{
					DropClass dropClass = item;
					if (num3 >= num2)
					{
						break;
					}
					list2.Add(list[RNG.Next(0, list.Count - 1)]);
					num3++;
				}
				return (list2.Count == 0) ? null : list2;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "高手怪掉落出错leve[" + int_14 + "]" + ex.Message);
				return null;
			}
		}

		public static DropClass GetDrop(int int_14)
		{
			try
			{
				List<DropClass> list = new List<DropClass>();
				int num = RNG.Next(1, 8000);
				foreach (DropClass item in World.Drop)
				{
					if (item.FLD_PP != 0 && item.FLD_LEVEL1 <= int_14 && item.FLD_LEVEL2 >= int_14 && item.FLD_PP >= num)
					{
						list.Add(item);
					}
				}
				return (list.Count == 0) ? null : list[RNG.Next(0, list.Count - 1)];
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "普通怪掉落出错leve[" + int_14 + "]" + ex.Message);
				return null;
			}
		}

		public static DropClass GetVipDrop(int int_14)
		{
			try
			{
				List<DropClass> list = new List<DropClass>();
				new Random(DateTime.Now.Millisecond);
				int num = RNG.Next(1, 8000);
				foreach (DropClass item in World.Drop)
				{
					if (item.FLD_PP != 0 && item.FLD_LEVEL1 <= int_14 && item.FLD_LEVEL2 >= int_14 && item.FLD_PP >= num)
					{
						list.Add(item);
					}
				}
				return (list.Count == 0) ? null : list[RNG.Next(0, list.Count - 1)];
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "VIP掉落出错leve[" + int_14 + "]" + ex.Message);
				return null;
			}
		}
	}
}
