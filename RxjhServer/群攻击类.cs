namespace RxjhServer
{
	public class 群攻击类
	{
		public int 剩余血量;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

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

		public int 武功ID
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

		public int 攻击力
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

		public int 总血量
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

		public 群攻击类(int int_5, int int_6, int int_7, int int_8)
		{
			人物ID = int_5;
			武功ID = int_6;
			攻击力 = int_7;
			攻击类型 = int_8;
		}
	}
}
