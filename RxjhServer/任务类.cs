using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class 任务类
	{
		private string string_0 = string.Empty;

		private 坐标类 坐标类_0 = new 坐标类();

		private List<任务需要物品类> 任务需要物品_ = new List<任务需要物品类>();

		private List<任务获得物品类> 任务获得物品_ = new List<任务获得物品类>();

		private List<任务阶段类> _任务阶段 = new List<任务阶段类>();

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private string string_1;

		private int int_6;

		private int int_7;

		private byte[] _执行阶段数据;

		private byte[] _任务_byte;

		private string string_2;

		public byte[] 任务_byte
		{
			get
			{
				return _任务_byte;
			}
			set
			{
				_任务_byte = value;
			}
		}

		public int 任务ID
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(_任务_byte, 0, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, _任务_byte, 0, 2);
			}
		}

		public int 任务阶段ID
		{
			get
			{
				byte[] array = new byte[2];
				System.Buffer.BlockCopy(_任务_byte, 2, array, 0, 2);
				return Buffer.ToInt16(array, 0);
			}
			set
			{
				System.Buffer.BlockCopy(Buffer.GetBytes(value), 0, _任务_byte, 2, 2);
			}
		}

		public byte[] 执行阶段数据
		{
			get
			{
				return _执行阶段数据;
			}
			set
			{
				_执行阶段数据 = value;
			}
		}

		public int 任务开关
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

		public int 任务类型
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

		public string 任务传书
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

		public int RwID
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

		public int 任务正邪
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

		public int 职业
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

		public 坐标类 Npc坐标
		{
			get
			{
				return 坐标类_0;
			}
			set
			{
				坐标类_0 = value;
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

		public string NPCNAME
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

		public List<任务需要物品类> 任务需要物品
		{
			get
			{
				return 任务需要物品_;
			}
			set
			{
				任务需要物品_ = value;
			}
		}

		public List<任务获得物品类> 任务获得物品
		{
			get
			{
				return 任务获得物品_;
			}
			set
			{
				任务获得物品_ = value;
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

		public 任务类(byte[] byte_0)
		{
			任务_byte = byte_0;
		}

		public 任务类()
		{
			任务_byte = new byte[30];
		}

		public 任务类 GetRW(int int_8)
		{
			foreach (任务类 value in World.任务list.Values)
			{
				if (value.RwID == int_8)
				{
					return value;
				}
			}
			return null;
		}
	}
}
