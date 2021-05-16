using System;

namespace RxjhServer
{
	public class 攻击确认类
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private bool bool_0;

		private int int_3;

		private DateTime dateTime_0;

		private int int_4;

		public int 人物ID
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

		public int 被攻击人物ID
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

		public int 武功ID
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

		public bool 攻击状态
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public int 攻击类型
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

		public DateTime 攻击时间
		{
			get
			{
				return dateTime_0;
			}
			set
			{
				dateTime_0 = value;
			}
		}

		public int 攻击间隔
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

		public 攻击确认类()
		{
			人物ID = 0;
			被攻击人物ID = 0;
			武功ID = 0;
			攻击状态 = false;
			攻击类型 = 0;
			攻击间隔 = 0;
			攻击时间 = DateTime.Now;
		}

		public void 初始化(int int_5, int int_6, int int_7, int int_8, int int_9)
		{
			人物ID = int_5;
			被攻击人物ID = int_6;
			武功ID = int_7;
			攻击类型 = int_8;
			攻击间隔 = int_9;
			攻击时间 = DateTime.Now;
			攻击状态 = true;
		}
	}
}
