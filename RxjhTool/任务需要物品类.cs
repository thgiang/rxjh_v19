using System.ComponentModel;

namespace RxjhTool
{
	[DefaultProperty("物品ID")]
	public class 任务需要物品类
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		[Category("基本")]
		[Description("物品ID")]
		public int 物品ID
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

		[Description("物品数量")]
		[Category("基本")]
		public int 物品数量
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

		[Category("基本")]
		[Description("地图ID")]
		public int 地图ID
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

		[Description("坐标X")]
		[Category("基本")]
		public int 坐标X
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

		[Category("基本")]
		[Description("坐标Y")]
		public int 坐标Y
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
	}
}
