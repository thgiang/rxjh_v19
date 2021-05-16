using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace RxjhTool
{
	public class 任务阶段类
	{
		private string string_0 = string.Empty;

		private List<任务需要物品类> _需要物品 = new List<任务需要物品类>();

		private string string_1 = string.Empty;

		public string 任务条件符合提示2 = string.Empty;

		public string 任务条件符合提示3 = string.Empty;

		public string 任务条件符合提示4 = string.Empty;

		public string 任务条件符合提示5 = string.Empty;

		private string string_2 = string.Empty;

		public string 任务条件不符合提示2 = string.Empty;

		public string 任务条件不符合提示3 = string.Empty;

		public string 任务条件不符合提示4 = string.Empty;

		public string 任务条件不符合提示5 = string.Empty;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int Npc未知1;

		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		[Category("阶段内容")]
		[Description("当前阶段提示内容")]
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

		[Description("NpcID")]
		[Category("基本")]
		public int NpcID
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

		[Description("地图ID")]
		[Category("基本")]
		public int Npc地图ID
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
		[Description("坐标X")]
		public int Npc坐标X
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

		[Category("基本")]
		[Description("坐标Y")]
		public int Npc坐标Y
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

		[Category("需要物品")]
		[Editor(typeof(My需要物品CollectionEditor), typeof(UITypeEditor))]
		[Description("要完成当前阶段任务需要的物品")]
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

		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		[Category("提示内容")]
		[Description("坐标Y")]
		public string 任务条件符合提示1
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

		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		[Description("坐标Y")]
		[Category("提示内容")]
		public string 任务条件不符合提示1
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
	}
}
