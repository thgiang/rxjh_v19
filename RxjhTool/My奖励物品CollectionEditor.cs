using System;
using System.ComponentModel.Design;

namespace RxjhTool
{
	public class My奖励物品CollectionEditor : CollectionEditor
	{
		public My奖励物品CollectionEditor(Type type_0)
			: base(type_0)
		{
		}

		protected override string GetDisplayText(object value)
		{
			if (!(value is 任务奖励物品类))
			{
				return value.ToString();
			}
			任务奖励物品类 任务奖励物品类 = (任务奖励物品类)value;
			return 任务奖励物品类.物品ID + " 数量 " + 任务奖励物品类.物品数量;
		}
	}
}
