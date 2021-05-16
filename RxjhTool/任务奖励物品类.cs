using System.ComponentModel;

namespace RxjhTool
{
	[DefaultProperty("物品ID")]
	public class 任务奖励物品类
	{
		private int int_0;

		private int int_1;

		[Description("物品ID")]
		[Category("基本")]
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
	}
}
