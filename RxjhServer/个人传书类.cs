using System;

namespace RxjhServer
{
	public class 个人传书类
	{
		private int int_0;

		private string string_0;

		private string string_1;

		private DateTime dateTime_0;

		private int int_1;

		private int int_2;

		public int 传书ID
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

		public string 传书发送人
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

		public string 传书内容
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

		public DateTime 传书时间
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

		public int 是否已读
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

		public int 是否NPC
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
	}
}
