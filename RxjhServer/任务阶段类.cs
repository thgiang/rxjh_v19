using System.Collections.Generic;

namespace RxjhServer
{
	public class 任务阶段类
	{
		private string string_0 = string.Empty;

		private string string_1 = string.Empty;

		private int int_0 = -1;

		public Dictionary<int, 阶段需要物品类> 阶段需要物品_ = new Dictionary<int, 阶段需要物品类>();

		public Dictionary<int, 阶段奖励物品类> 阶段奖励物品_ = new Dictionary<int, 阶段奖励物品类>();

		private string string_2 = string.Empty;

		public string 任务条件符合提示2 = string.Empty;

		public string 任务条件符合提示3 = string.Empty;

		public string 任务条件符合提示4 = string.Empty;

		public string 任务条件符合提示5 = string.Empty;

		private string string_3 = string.Empty;

		public string 任务条件不符合提示2 = string.Empty;

		public string 任务条件不符合提示3 = string.Empty;

		public string 任务条件不符合提示4 = string.Empty;

		public string 任务条件不符合提示5 = string.Empty;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		public int Npc未知1;

		public string NPCNAME
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

		public string 任务阶段内容
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

		public int 阶段ID
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

		public int 阶段状态
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

		public int 难度系数
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

		public int NpcID
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

		public int Npc地图ID
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

		public int Npc坐标X
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

		public int Npc坐标Y
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

		public string 任务条件符合提示1
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public string 任务条件不符合提示1
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}

		public 任务阶段类 GetRWJD(int int_7, int int_8)
		{
			try
			{
				foreach (任务类 value in World.任务list.Values)
				{
					if (value.RwID == int_7)
					{
						return value.任务阶段[int_8];
					}
				}
				return null;
			}
			catch
			{
				return null;
			}
		}
	}
}
