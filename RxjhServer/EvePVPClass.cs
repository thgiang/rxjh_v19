using RxjhServer.DbClss;
using System;
using System.Timers;

namespace RxjhServer
{
	public class EvePVPClass : IDisposable
	{
		private ThreadSafeDictionary<int, Players> playlist = new ThreadSafeDictionary<int, Players>();

		private System.Timers.Timer 时间1;

		private System.Timers.Timer 时间2;

		private System.Timers.Timer 时间3;

		private System.Timers.Timer 时间4;

		private System.Timers.Timer 时间5;

		private System.Timers.Timer 时间6;

		private DateTime kssj;

		private DateTime kssjgj;

		private int kssjint;

		private Players PlayerA;

		private Players PlayerB;

		public EvePVPClass(ThreadSafeDictionary<int, Players> players)
		{
			try
			{
				foreach (Players value in players.Values)
				{
					playlist.Add(value.人物全服ID, value);
					if (PlayerA == null)
					{
						PlayerA = value;
						PlayerA.PVP分数 = 0;
						PlayerA.PVP逃跑次数 = 0;
					}
					else if (PlayerB == null)
					{
						PlayerB = value;
						PlayerB.PVP分数 = 0;
						PlayerB.PVP逃跑次数 = 0;
					}
				}
				kssj = DateTime.Now.AddMinutes(3.0);
				World.Eve90进程 = 1;
				时间1 = new System.Timers.Timer(60000.0);
				时间1.Elapsed += 时间结束事件1;
				时间1.Enabled = true;
				时间1.AutoReset = true;
				时间结束事件1(null, null);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "PVP EveClass 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件1(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = (int)kssj.Subtract(DateTime.Now).TotalSeconds;
				if (num <= 0)
				{
					World.Eve90进程 = 2;
					num = 0;
				}
				kssjint = num;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (!value.Client.挂机)
					{
						value.系统提示("[" + PlayerA.UserName + "] 和 [" + PlayerB.UserName + "]即将在高级竞技场较量,系统将在" + kssjint + "秒后计分。", 2, "PVP战报");
						value.系统提示("玩家可以输入指令[!高级押注 单]或者[!高级押注 双]下注.本次下注数量为" + World.允许玩家押注数量 + "元宝", 13, "系统公告");
					}
				}
				if (kssjint <= 0)
				{
					if (PlayerA.检查玩家是否在对练区内(PlayerA))
					{
						PlayerA.移动(120f, 0f, 15f, 2301);
					}
					if (PlayerB.检查玩家是否在对练区内(PlayerB))
					{
						PlayerB.移动(120f, 0f, 15f, 2301);
					}
					PlayerA.系统公告("开始计分...");
					PlayerB.系统公告("开始计分...");
					时间1.Enabled = false;
					时间1.Close();
					时间1.Dispose();
					World.Eve90进程 = 3;
					kssjgj = DateTime.Now.AddMinutes(10.0);
					时间2 = new System.Timers.Timer(10000.0);
					时间2.Elapsed += 时间结束事件2;
					时间2.Enabled = true;
					时间2.AutoReset = true;
					时间6 = new System.Timers.Timer(1000.0);
					时间6.Elapsed += 时间结束事件6;
					时间6.Enabled = true;
					时间6.AutoReset = true;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "PVP 时间结束事件1 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件2(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = World.Eve90时间 = (int)kssjgj.Subtract(DateTime.Now).TotalSeconds;
				foreach (Players value in playlist.Values)
				{
					value.系统提示(PlayerA.UserName + "->[" + PlayerA.PVP分数 + "] VS " + PlayerB.UserName + "->[" + PlayerA.PVP分数 + "] 比赛结束倒计时" + World.Eve90时间 + "秒！", 13, "比赛实况");
				}
				if (num <= 0 || !PlayerA.Client.Running || !PlayerB.Client.Running)
				{
					时间2.Enabled = false;
					时间2.Close();
					时间2.Dispose();
					时间6.Enabled = false;
					时间6.Close();
					时间6.Dispose();
					World.Eve90进程 = 4;
					时间3 = new System.Timers.Timer(10000.0);
					时间3.Elapsed += 时间结束事件3;
					时间3.Enabled = true;
					时间3.AutoReset = false;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "PVP 时间结束事件2 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件3(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = (int)((double)(World.进场最低费用 * 2) * (1.0 - World.场地佣金百分比));
				if (!PlayerA.Client.Running && !PlayerB.Client.Running)
				{
					foreach (Players value in World.allConnectedChars.Values)
					{
						if (!value.Client.挂机)
						{
							value.系统提示("很遗憾！由于双方中场退出,比赛结束!", 7, "PVP战报");
						}
					}
					DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, 0, 0, "双方弃权"));
				}
				else if (!PlayerA.Client.Running)
				{
					PlayerB.查百宝阁元宝数();
					PlayerB.检察元宝数据(num, 1);
					RxjhClass.百宝记录(PlayerB.Userid, PlayerB.UserName, 0.0, "90PVP胜利", 1, num);
					PlayerB.保存元宝数据();
					foreach (Players value2 in World.allConnectedChars.Values)
					{
						if (!value2.Client.挂机)
						{
							value2.系统提示("很遗憾！由于[" + PlayerA.UserName + "]中场退出,[" + PlayerB.UserName + "]获胜,高级竞技比赛结束!", 2, "PVP战报");
						}
					}
					DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, 0, num, PlayerA.UserName + " 退出比赛"));
					RxjhClass.Set个人荣誉数据(2, PlayerB.UserName, PlayerB.Player_Job, PlayerB.Player_Level, PlayerB.Player_Zx, PlayerB.帮派名字, string.Empty, PlayerB.PVP分数);
				}
				else if (!PlayerB.Client.Running)
				{
					PlayerA.查百宝阁元宝数();
					PlayerA.检察元宝数据(num, 1);
					RxjhClass.百宝记录(PlayerA.Userid, PlayerA.UserName, 0.0, "PVP胜利", 1, num);
					PlayerA.保存元宝数据();
					foreach (Players value3 in World.allConnectedChars.Values)
					{
						if (!value3.Client.挂机)
						{
							value3.系统提示("很遗憾！由于[" + PlayerB.UserName + "]中场退出,[" + PlayerA.UserName + "]获胜,高级竞技比赛结束!", 2, "PVP战报");
						}
					}
					DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, num, 0, PlayerB.UserName + " 退出比赛"));
					RxjhClass.Set个人荣誉数据(2, PlayerA.UserName, PlayerA.Player_Job, PlayerA.Player_Level, PlayerA.Player_Zx, PlayerA.帮派名字, string.Empty, PlayerA.PVP分数);
				}
				else if (PlayerA.PVP分数 > PlayerB.PVP分数)
				{
					PlayerA.查百宝阁元宝数();
					PlayerA.检察元宝数据(num, 1);
					RxjhClass.百宝记录(PlayerA.Userid, PlayerA.UserName, 0.0, "90PVP胜利", 1, num);
					PlayerA.保存元宝数据();
					foreach (Players value4 in World.allConnectedChars.Values)
					{
						if (!value4.Client.挂机)
						{
							value4.系统提示("高级竞技比赛结束,[" + PlayerA.UserName + "][" + PlayerA.PVP分数 + "] VS [" + PlayerB.UserName + "][" + PlayerB.PVP分数 + "] 获胜方获得" + num + "元宝。", 2, "PVP战报");
						}
					}
					int num2 = ++PlayerA.FLD_PVP_Piont;
					DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, num, 0, PlayerA.UserName + " 获胜"));
					RxjhClass.Set个人荣誉数据(2, PlayerA.UserName, PlayerA.Player_Job, PlayerA.Player_Level, PlayerA.Player_Zx, PlayerA.帮派名字, string.Empty, PlayerA.PVP分数);
				}
				else if (PlayerA.PVP分数 == PlayerB.PVP分数)
				{
					if (PlayerA.PVP逃跑次数 > PlayerB.PVP逃跑次数)
					{
						PlayerB.查百宝阁元宝数();
						PlayerB.检察元宝数据(num, 1);
						RxjhClass.百宝记录(PlayerB.Userid, PlayerB.UserName, 0.0, "90PVP胜利", 1, num);
						PlayerB.保存元宝数据();
						foreach (Players value5 in World.allConnectedChars.Values)
						{
							if (!value5.Client.挂机)
							{
								value5.系统提示("高级竞技比赛结束，双方分数相同。因" + PlayerA.UserName + "逃跑次数过多 系统判定" + PlayerB.UserName + "胜出,获得" + num + "元宝！", 2, "PVP战报");
							}
						}
						int num2 = ++PlayerB.FLD_PVP_Piont;
						DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, 0, num, "分数相同," + PlayerB.UserName + " 获胜"));
						RxjhClass.Set个人荣誉数据(2, PlayerB.UserName, PlayerB.Player_Job, PlayerB.Player_Level, PlayerB.Player_Zx, PlayerB.帮派名字, string.Empty, PlayerB.PVP分数);
					}
					else if (PlayerA.PVP逃跑次数 == PlayerB.PVP逃跑次数)
					{
						PlayerA.查百宝阁元宝数();
						PlayerA.检察元宝数据((int)((double)World.进场最低费用 * (1.0 - World.场地佣金百分比)), 1);
						RxjhClass.百宝记录(PlayerA.Userid, PlayerA.UserName, 0.0, "90PVP返还", 1, (int)((double)World.进场最低费用 * (1.0 - World.场地佣金百分比)));
						PlayerA.保存元宝数据();
						PlayerB.查百宝阁元宝数();
						PlayerB.检察元宝数据((int)((double)World.进场最低费用 * (1.0 - World.场地佣金百分比)), 1);
						RxjhClass.百宝记录(PlayerB.Userid, PlayerB.UserName, 0.0, "90PVP返还", 1, (int)((double)World.进场最低费用 * (1.0 - World.场地佣金百分比)));
						PlayerB.保存元宝数据();
						foreach (Players value6 in World.allConnectedChars.Values)
						{
							if (!value6.Client.挂机)
							{
								value6.系统提示("高级竞技比赛结束，双方打成平局。下次再较量过吧！", 2, "PVP战报");
							}
						}
						DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, (int)((double)World.进场最低费用 * (1.0 - World.场地佣金百分比)), (int)((double)World.进场最低费用 * (1.0 - World.场地佣金百分比)), "平局"));
						RxjhClass.Set个人荣誉数据(2, PlayerA.UserName, PlayerA.Player_Job, PlayerA.Player_Level, PlayerA.Player_Zx, PlayerA.帮派名字, string.Empty, PlayerA.PVP分数);
						RxjhClass.Set个人荣誉数据(2, PlayerB.UserName, PlayerB.Player_Job, PlayerB.Player_Level, PlayerB.Player_Zx, PlayerB.帮派名字, string.Empty, PlayerB.PVP分数);
					}
					else
					{
						PlayerA.查百宝阁元宝数();
						PlayerA.检察元宝数据(num, 1);
						RxjhClass.百宝记录(PlayerA.Userid, PlayerA.UserName, 0.0, "90PVP获得", 1, num);
						PlayerA.保存元宝数据();
						foreach (Players value7 in World.allConnectedChars.Values)
						{
							if (!value7.Client.挂机)
							{
								value7.系统提示("高级竞技比赛结束，双方分数相同。因" + PlayerB.UserName + "逃跑次数过多 系统判定" + PlayerA.UserName + "胜出,获得" + num + "元宝！", 2, "PVP战报");
							}
						}
						int num2 = ++PlayerA.FLD_PVP_Piont;
						DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, num, 0, "分数相同," + PlayerA.UserName + " 获胜"));
						RxjhClass.Set个人荣誉数据(2, PlayerA.UserName, PlayerA.Player_Job, PlayerA.Player_Level, PlayerA.Player_Zx, PlayerA.帮派名字, string.Empty, PlayerA.PVP分数);
					}
				}
				else
				{
					PlayerB.查百宝阁元宝数();
					PlayerB.检察元宝数据(num, 1);
					RxjhClass.百宝记录(PlayerB.Userid, PlayerB.UserName, 0.0, "90PVP获得", 1, num);
					PlayerB.保存元宝数据();
					foreach (Players value8 in World.allConnectedChars.Values)
					{
						if (!value8.Client.挂机)
						{
							value8.系统提示("高级竞技比赛结束,[" + PlayerB.UserName + "][" + PlayerB.PVP分数 + "] VS [" + PlayerA.UserName + "][" + PlayerA.PVP分数 + "] 获胜方获得" + num + "元宝。", 2, "PVP战报");
						}
					}
					int num2 = ++PlayerB.FLD_PVP_Piont;
					DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_PVP (场地代号,A玩家,B玩家,A杀人数,B杀人数,A逃跑次数,B逃跑次数,A获得元宝,B获得元宝,比赛结果)values({0},'{1}','{2}',{3},{4},{5},{6},{7},{8},'{9}')", 90, PlayerA.UserName, PlayerB.UserName, PlayerA.PVP分数, PlayerB.PVP分数, PlayerA.PVP逃跑次数, PlayerB.PVP逃跑次数, 0, num, PlayerB.UserName + " 获胜"));
					RxjhClass.Set个人荣誉数据(2, PlayerB.UserName, PlayerB.Player_Job, PlayerB.Player_Level, PlayerB.Player_Zx, PlayerB.帮派名字, string.Empty, PlayerB.PVP分数);
				}
				int num3 = World.计算玩家下注结果(PlayerA.PVP分数, PlayerB.PVP分数, 90);
				foreach (Players value9 in World.allConnectedChars.Values)
				{
					if (!value9.Client.挂机)
					{
						value9.系统提示("普通竞技比赛结束,本场比赛幸运数字为: " + num3 + string.Empty, 3, "单双数公布");
					}
				}
				World.Eve90进程 = 5;
				kssjgj = DateTime.Now.AddMinutes(1.0);
				时间3.Enabled = false;
				时间3.Close();
				时间3.Dispose();
				时间4 = new System.Timers.Timer(30000.0);
				时间4.Elapsed += 时间结束事件4;
				时间4.Enabled = true;
				时间4.AutoReset = true;
				时间5 = new System.Timers.Timer(30000.0);
				时间5.Elapsed += 时间结束事件5;
				时间5.Enabled = true;
				时间5.AutoReset = true;
				时间6.Enabled = false;
				时间6.Close();
				时间6.Dispose();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "PVP 时间结束事件3 出错：" + ((ex != null) ? ex.ToString() : null));
				Dispose();
			}
		}

		public void 时间结束事件4(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((World.Eve90时间 = (int)kssjgj.Subtract(DateTime.Now).TotalSeconds) <= 0 || !PlayerA.Client.Running || !PlayerB.Client.Running)
				{
					时间4.Enabled = false;
					时间4.Close();
					时间4.Dispose();
					World.Eve90进程 = 6;
					Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "PVP 时间结束事件4 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件5(object sender, ElapsedEventArgs e)
		{
			try
			{
				时间5.Enabled = false;
				时间5.Close();
				时间5.Dispose();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "PVP 时间结束事件5 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件6(object sender, ElapsedEventArgs e)
		{
			try
			{
				if (PlayerA.Client != null && PlayerA.Client.Running && PlayerB.Client != null && PlayerB.Client.Running)
				{
					if (PlayerA.检查玩家是否在对练区内(PlayerA))
					{
						if (PlayerA.人物PK模式 != 2)
						{
							PlayerA.切换PK模式(2);
						}
					}
					else
					{
						if (PlayerA.PVP逃跑次数 > World.允许逃跑次数)
						{
							if (PlayerA.PVP分数 > 0)
							{
								PlayerA.PVP分数--;
								PlayerA.系统提示("你已累计逃跑" + PlayerA.PVP逃跑次数 + "次,超过系统限制的" + World.允许逃跑次数 + "次,扣除一分！", 13, "系统警告");
							}
							else if (PlayerA.PVP分数 == 0)
							{
								PlayerA.查百宝阁元宝数();
								if (PlayerA.FLD_RXPIONT >= World.分数扣完扣除元宝)
								{
									PlayerA.检察元宝数据(World.分数扣完扣除元宝, 0);
									RxjhClass.百宝记录(PlayerA.Userid, PlayerA.UserName, 0.0, "90PVP逃跑扣除", 1, World.分数扣完扣除元宝);
									PlayerA.保存元宝数据();
									PlayerA.系统提示("你当前分数为0且已累计逃跑" + PlayerA.PVP逃跑次数 + "次,超过系统限制的" + World.允许逃跑次数 + "次,扣除" + World.分数扣完扣除元宝 + "元宝！", 13, "系统警告");
								}
								else if (PlayerA.Player_Money >= World.分数扣完扣除金钱)
								{
									PlayerA.Player_Money -= World.分数扣完扣除金钱;
									PlayerA.更新金钱和负重();
									PlayerA.系统提示("你当前分数为0且已累计逃跑" + PlayerA.PVP逃跑次数 + "次,超过系统限制的" + World.允许逃跑次数 + "次,扣除" + World.分数扣完扣除金钱 + "金钱！", 13, "系统警告");
								}
							}
						}
						else if (PlayerA.PVP逃跑次数 >= 5)
						{
							PlayerA.系统提示("你已累计逃跑" + PlayerA.PVP逃跑次数 + "次,超过" + World.允许逃跑次数 + "次后每次逃跑将扣除一分。分数为0将扣除元宝或金钱！", 13, "系统警告");
						}
						PlayerA.PVP逃跑次数++;
						PlayerA.移动(120f, 0f, 15f, 2301);
					}
					if (PlayerB.检查玩家是否在对练区内(PlayerB))
					{
						if (PlayerB.人物PK模式 != 2)
						{
							PlayerB.切换PK模式(2);
						}
					}
					else
					{
						if (PlayerB.PVP逃跑次数 > World.允许逃跑次数)
						{
							if (PlayerB.PVP分数 > 0)
							{
								PlayerB.PVP分数--;
								PlayerB.系统提示("你已累计逃跑" + PlayerB.PVP逃跑次数 + "次,超过系统限制的" + World.允许逃跑次数 + "次,扣除一分！", 13, "警告");
							}
							else if (PlayerB.PVP分数 == 0)
							{
								PlayerB.查百宝阁元宝数();
								if (PlayerB.FLD_RXPIONT >= World.分数扣完扣除元宝)
								{
									PlayerB.检察元宝数据(World.分数扣完扣除元宝, 0);
									RxjhClass.百宝记录(PlayerB.Userid, PlayerB.UserName, 0.0, "90PVP逃跑扣除", 1, World.分数扣完扣除元宝);
									PlayerB.保存元宝数据();
									PlayerB.系统提示("你当前分数为0且已累计逃跑" + PlayerB.PVP逃跑次数 + "次,超过系统限制的" + World.允许逃跑次数 + "次,扣除" + World.分数扣完扣除元宝 + "元宝！", 13, "警告");
								}
								else if (PlayerB.Player_Money >= World.分数扣完扣除金钱)
								{
									PlayerB.Player_Money -= World.分数扣完扣除金钱;
									PlayerB.更新金钱和负重();
									PlayerB.系统提示("你当前分数为0且已累计逃跑" + PlayerB.PVP逃跑次数 + "次,超过系统限制的" + World.允许逃跑次数 + "次,扣除" + World.分数扣完扣除金钱 + "金钱！", 13, "警告");
								}
							}
						}
						else if (PlayerB.PVP逃跑次数 >= 5)
						{
							PlayerB.系统提示("你已累计逃跑" + PlayerB.PVP逃跑次数 + "次,超过" + World.允许逃跑次数 + "次后每次逃跑将扣除一分。分数为0将扣除元宝或金钱！", 13, "警告");
						}
						PlayerB.PVP逃跑次数++;
						PlayerB.移动(120f, 0f, 15f, 2301);
					}
					foreach (Players value in World.allConnectedChars.Values)
					{
						if (value.人物坐标_地图 == 2301 && value.人物全服ID != PlayerA.人物全服ID && value.人物全服ID != PlayerB.人物全服ID)
						{
							value.移动(529f, 1528f, 15f, 101);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "PVP 时间结束事件6 出错：" + ((ex != null) ? ex.ToString() : null));
				Dispose();
			}
		}

		public void Dispose()
		{
			World.Eve90进程 = 0;
			World.Eve90时间 = 0;
			if (时间1 != null)
			{
				时间1.Enabled = false;
				时间1.Close();
				时间1.Dispose();
			}
			if (时间2 != null)
			{
				时间2.Enabled = false;
				时间2.Close();
				时间2.Dispose();
			}
			if (时间3 != null)
			{
				时间3.Enabled = false;
				时间3.Close();
				时间3.Dispose();
			}
			if (时间4 != null)
			{
				时间4.Enabled = false;
				时间4.Close();
				时间4.Dispose();
			}
			if (时间6 != null)
			{
				时间6.Enabled = false;
				时间6.Close();
				时间6.Dispose();
			}
			foreach (Players value in World.allConnectedChars.Values)
			{
				if (value.人物坐标_地图 == 2301)
				{
					value.移动(529f, 1528f, 15f, 101);
					value.切换PK模式(0);
				}
			}
			PlayerA = null;
			PlayerB = null;
			World.evePlayers.Clear();
			World.evePlayers = null;
			World.EVEPVP = null;
		}
	}
}
