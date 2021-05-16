using System.ComponentModel;

namespace RxjhTool
{
	[DefaultProperty("物品ID")]
	public class TaskRewardItems
	{
		private int _int0;

		private int _int1;

		[Description("物品ID")]
		[Category("基本")]
		public int 物品ID
		{
			get
			{
				return _int0;
			}
			set
			{
				_int0 = value;
			}
		}

		[Description("物品数量")]
		[Category("基本")]
		public int 物品数量
		{
			get
			{
				return _int1;
			}
			set
			{
				_int1 = value;
			}
		}
	}
}
