using System.Collections.Generic;

namespace RxjhServer
{
	public class 制作物品类
	{
		public List<制作需要物品类> 需要物品 = new List<制作需要物品类>();

		public int 物品ID;

		public string 物品名;

		public int 物品数量;

		public int 制作类型;

		public int 制作等级;

		public static List<int> Get制作物品类列表(int int_0, int int_1)
		{
			List<int> list = new List<int>();
			foreach (制作物品类 value in World.制作物品列表.Values)
			{
				if (value.制作类型 == int_0 && int_1 >= value.制作等级)
				{
					list.Add(value.物品ID);
				}
			}
			return list;
		}
	}
}
