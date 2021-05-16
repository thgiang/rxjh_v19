using System.Threading;

namespace RxjhServer
{
	public class ThreadWithState
	{
		private Players players_0;

		private 武功类 武功类_0;

		private NpcClass npcClass_0;

		private int int_0;

		private int int_1;

		private string string_0;

		private int int_2;

		private string string_1;

		private string string_2;

		public ThreadWithState(Players players_1, 武功类 武功类_1, NpcClass npcClass_1, int int_3, int int_4)
		{
			players_0 = players_1;
			武功类_0 = 武功类_1;
			npcClass_0 = npcClass_1;
			int_0 = int_3;
			int_1 = int_4;
		}

		public ThreadWithState(Players players_1, string string_3, string string_4, string string_5, int int_3)
		{
			players_0 = players_1;
			string_0 = string_3;
			int_2 = int_3;
			string_1 = string_4;
			string_2 = string_5;
		}

		public void ThreadProc()
		{
			Thread.Sleep(1100);
			players_0.攻击计算(武功类_0, npcClass_0, 武功类_0.FLD_PID, int_0, int_1);
			players_0.武功连击记数器++;
		}

		public void ThreadProc2()
		{
			players_0.换线人物登陆(string_0, string_1, string_2, int_2);
		}
	}
}
