using System.Collections.Generic;

namespace RxjhTool
{
	public class 任务类
	{
		private string string_0 = string.Empty;

		private string string_1 = string.Empty;

		private string string_2 = string.Empty;

		private string string_3 = string.Empty;

		private string string_4 = string.Empty;

		private List<任务奖励物品类> _奖励物品 = new List<任务奖励物品类>();

		private Coordinate _coordinate0 = new Coordinate();

		private List<任务需要物品类> _需要物品 = new List<任务需要物品类>();

		private string string_5 = string.Empty;

		private string string_6 = string.Empty;

		private List<任务阶段类> _任务阶段 = new List<任务阶段类>();

		public string 任务欢迎拒绝提示2 = string.Empty;

		public string 任务欢迎拒绝提示3 = string.Empty;

		public string 任务欢迎拒绝提示4 = string.Empty;

		public string 任务欢迎拒绝提示5 = string.Empty;

		public string 任务欢迎接受提示2 = string.Empty;

		public string 任务欢迎接受提示3 = string.Empty;

		public string 任务欢迎接受提示4 = string.Empty;

		public string 任务欢迎接受提示5 = string.Empty;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int 任务未知1;

		public int 任务未知2;

		public int 任务未知3;

		public int 任务未知4;

		public int 任务未知5;

		public int 任务未知6;

		public int 任务未知7;

		public int Npc未知1;

		public int 任务ID
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

		public string 任务名
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

		public int 任务等级
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

		public string 任务拒绝提示1
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

		public string 任务拒绝提示2
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

		public string 任务接受提示1
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

		public string 任务接受提示2
		{
			get
			{
				return string_4;
			}
			set
			{
				string_4 = value;
			}
		}

		public List<任务奖励物品类> 奖励物品
		{
			get
			{
				return _奖励物品;
			}
			set
			{
				_奖励物品 = value;
			}
		}

		public Coordinate Npc坐标
		{
			get
			{
				return _coordinate0;
			}
			set
			{
				_coordinate0 = value;
			}
		}

		public int NpcID
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

		public List<任务需要物品类> 需要物品
		{
			get
			{
				return _需要物品;
			}
			set
			{
				_需要物品 = value;
			}
		}

		public string 任务欢迎拒绝提示1
		{
			get
			{
				return string_5;
			}
			set
			{
				string_5 = value;
			}
		}

		public string 任务欢迎接受提示1
		{
			get
			{
				return string_6;
			}
			set
			{
				string_6 = value;
			}
		}

		public int 任务阶段数量
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

		public List<任务阶段类> 任务阶段
		{
			get
			{
				return _任务阶段;
			}
			set
			{
				_任务阶段 = value;
			}
		}
	}
}
