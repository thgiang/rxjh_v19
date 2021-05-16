using System.Collections.Generic;

namespace RxjhServer
{
	public class 攻城战
	{
		public string 帮主名称 = "";

		public Dictionary<int, Players> 攻城人物列表 = new Dictionary<int, Players>();

		public string 申请帮派名称 = "";

		public int 攻城分数;

		public int 申请帮派ID;

		public int 申请地图;
	}
}
