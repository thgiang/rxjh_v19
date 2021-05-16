using System.Collections.Generic;

namespace RxjhServer
{
	public class 帮战Class
	{
		public string 申请帮派名称 = string.Empty;

		public Dictionary<int, Players> 申请人物列表 = new Dictionary<int, Players>();

		public int 申请帮派ID;

		public int 申请地图;

		public int 等级;

		public string 帮派门主;

		public string 帮主名称;

		public int 胜利;

		public int 门主死亡次数;

		public int 当前分数;
	}
}
