using System;
using System.ComponentModel.Design;

namespace RxjhTool
{
	public class My任务阶段CollectionEditor : CollectionEditor
	{
		public My任务阶段CollectionEditor(Type type_0)
			: base(type_0)
		{
		}

		protected override string GetDisplayText(object value)
		{
			if (value is 任务阶段类)
			{
				return ((任务阶段类)value).任务阶段内容;
			}
			return value.ToString();
		}
	}
}
