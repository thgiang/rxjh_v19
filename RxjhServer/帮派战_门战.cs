using RxjhServer.DbClss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Timers;

namespace RxjhServer
{
	public class 帮派战_门战
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class0
		{
			public static readonly Class0 class0_0 = new Class0();

			public static Func<KeyValuePair<string, int>, int> func_0;

			internal int method_0(KeyValuePair<string, int> keyValuePair_0)
			{
				return keyValuePair_0.Value;
			}
		}

		private object AsyncLock = new object();

		private Dictionary<string, int> 比分表 = new Dictionary<string, int>();

		private System.Timers.Timer timer_0;

		private System.Timers.Timer timer_1;

		private System.Timers.Timer timer_2;

		private System.Timers.Timer timer_3;

		private DateTime dateTime_0;

		private DateTime dateTime_1;

		private DateTime dateTime_2;

		public 帮派战_门战()
		{
			try
			{
				World.新门战进程 = 1;
				World.帮战list = new Dictionary<int, 帮战Class>();
				dateTime_0 = DateTime.Now.AddMinutes(10.0);
				timer_0 = new System.Timers.Timer(60000.0);
				timer_0.Elapsed += 门主申请记时器结束事件;
				timer_0.Enabled = true;
				timer_0.AutoReset = true;
				foreach (Players value in World.allConnectedChars.Values)
				{
					value.滚动公告(4500);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "血帮战 准备记时器结束事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 门主申请记时器结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = (int)dateTime_0.Subtract(DateTime.Now).TotalSeconds;
				foreach (Players value in World.allConnectedChars.Values)
				{
					value.系统提示("离门战申请还剩下" + (num + 59) / 60 + "分钟。请帮主召集帮派成员从[韦大宝]移动[银币广 场]->[上官清]处申请", 6, "帮战提示");
				}
				if (num <= 0)
				{
					timer_0.Enabled = false;
					timer_0.Close();
					timer_0.Dispose();
					foreach (帮战Class value2 in World.帮战list.Values)
					{
						using (new Lock(value2.申请人物列表, "帮战申请人物列表"))
						{
							foreach (Players value3 in value2.申请人物列表.Values)
							{
								value3.系统公告("门战配对成功,请做好战斗准备,10秒后开始门战!");
							}
						}
					}
					dateTime_1 = DateTime.Now.AddSeconds(10.0);
					timer_1 = new System.Timers.Timer(5000.0);
					timer_1.Elapsed += 准备记时器结束事件;
					timer_1.Enabled = true;
					timer_1.AutoReset = true;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "帮战 申请记时器结束事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 准备记时器结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)dateTime_1.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					foreach (帮战Class value in World.帮战list.Values)
					{
						foreach (Players value2 in value.申请人物列表.Values)
						{
							if (value2.Player_Level < 100 || value2.人物坐标_地图 != 1201 || value2.人物_HP <= 0 || value2.Player死亡 || value2.退出中)
							{
								Form1.WriteLine(88, "帮派[" + value.申请帮派名称 + "]成员[" + value2.UserName + "]不符合参加门战条件|等级:" + value2.Player_Level + "|地图:" + value2.人物坐标_地图 + "|生命:" + value2.人物_HP + "|退出:" + value2.退出中 + "|进店:" + value2.进店中 + "|死亡:" + value2.Player死亡);
								value.申请人物列表.Remove(value2.人物全服ID);
								if (value.申请人物列表.Count < 5)
								{
									Form1.WriteLine(88, "帮派[" + value.申请帮派名称 + "]参战人数小于5人被取消参战资格。");
									using (new Lock(World.帮战list, "帮战list"))
									{
										World.帮战list.Remove(value.申请帮派ID);
										if (World.帮战Namelist != null && World.帮战Namelist.Count > 0 && World.帮战Namelist.ContainsKey(value.申请帮派ID))
										{
											World.帮战Namelist.Remove(value.申请帮派ID);
										}
									}
								}
							}
						}
					}
					if (World.帮战list.Count < 2)
					{
						Form1.WriteLine(88, "参加帮战门派数小于2个门派,帮战取消。");
						foreach (帮战Class value3 in World.帮战list.Values)
						{
							foreach (Players value4 in value3.申请人物列表.Values)
							{
								value4.安全模式 = 0;
								if (value4.帮派人物等级 == 6)
								{
									value4.系统提示("由于没有匹配的帮派无法进行帮战,系统返还" + World.申请门战需要元宝 + "元宝。", 6, "帮战提示");
									value4.查百宝阁元宝数();
									value4.检察元宝数据(World.申请门战需要元宝, 1);
									value4.保存元宝数据();
									Form1.WriteLine(88, "返回帮派帮主[" + value4.UserName + "]" + World.申请门战需要元宝 + "元宝");
								}
								else
								{
									value4.系统提示("由于没有匹配的帮派无法进行门战。", 6, "帮战提示");
								}
							}
						}
						World.胜利帮派ID = 0;
						if (World.帮战Namelist != null && World.帮战Namelist.Count > 0)
						{
							World.帮战Namelist.Clear();
						}
						Dispose();
					}
					else
					{
						World.新门战进程 = 2;
						World.是否开启门战系统 = 0;
						timer_1.Enabled = false;
						timer_1.Close();
						timer_1.Dispose();
						dateTime_2 = DateTime.Now.AddMinutes(30.0);
						timer_2 = new System.Timers.Timer(60000.0);
						timer_2.Elapsed += 开始对战记时器结束事件;
						timer_2.Enabled = true;
						timer_2.AutoReset = true;
						int num = 0;
						int num2 = 0;
						int num3 = 0;
						foreach (帮战Class value5 in World.帮战list.Values)
						{
							switch (num)
							{
							case 0:
								num2 = 0;
								num3 = 300;
								break;
							case 1:
								num2 = -300;
								num3 = 0;
								break;
							case 2:
								num2 = 300;
								num3 = 0;
								break;
							case 3:
								num2 = 0;
								num3 = -300;
								break;
							}
							using (new Lock(value5.申请人物列表, "帮战申请人物列表"))
							{
								foreach (Players value6 in value5.申请人物列表.Values)
								{
									value6.移动(num2, num3, 15f, 7301);
									value6.帮战开始提示(1, 0);
									value6.系统公告("帮战开始,尽情的厮杀吧。最后胜利帮派将有机会提升帮派等级！");
									value6.切换PK模式(2);
									value6.安全模式 = 0;
								}
							}
							num++;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "帮战 准备记时器结束事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 开始对战记时器结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				比分表.Clear();
				int num = (int)dateTime_2.Subtract(DateTime.Now).TotalSeconds;
				foreach (帮战Class value in World.帮战list.Values)
				{
					比分表.Add(value.申请帮派名称, value.当前分数);
				}
				int num2 = 0;
				string text = string.Empty;
				foreach (KeyValuePair<string, int> item in 比分表.OrderByDescending((KeyValuePair<string, int> keyValuePair_0) => keyValuePair_0.Value))
				{
					if (num2 >= 3)
					{
						break;
					}
					text = text + item.Key + ":" + item.Value + " ";
					num2++;
				}
				foreach (帮战Class value2 in World.帮战list.Values)
				{
					foreach (Players value3 in value2.申请人物列表.Values)
					{
						if (value3.人物坐标_地图 == 7301)
						{
							value3.系统提示(text, 7, "比分排行");
						}
					}
				}
				if (num <= 60)
				{
					foreach (帮战Class value4 in World.帮战list.Values)
					{
						foreach (Players value5 in value4.申请人物列表.Values)
						{
							if (value5.人物坐标_地图 == 7301)
							{
								value5.系统提示("混战时间最后剩余" + num + "秒,加油吧。", 6, "帮战提示");
							}
						}
					}
				}
				if (num <= 0)
				{
					World.新门战进程 = 3;
					World.是否开启门战系统 = 0;
					foreach (帮战Class value6 in World.帮战list.Values)
					{
						foreach (Players value7 in value6.申请人物列表.Values)
						{
							if (value7.人物坐标_地图 == 7301)
							{
								value7.安全模式 = 1;
								value7.系统提示("混战时间结束,请等待10秒公布混战结果!", 6, "帮战提示");
							}
						}
					}
					timer_2.Enabled = false;
					timer_2.Close();
					timer_2.Dispose();
					timer_3 = new System.Timers.Timer(10000.0);
					timer_3.Elapsed += 时间结束事件3;
					timer_3.Enabled = true;
					timer_3.AutoReset = false;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "帮战 开始对战记时器结束事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件3(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				foreach (帮战Class value in World.帮战list.Values)
				{
					if (value.当前分数 > num3)
					{
						num3 = value.当前分数;
						num2 = value.申请帮派ID;
						num = value.当前分数;
					}
				}
				if (num > 0)
				{
					int num4 = 0;
					foreach (帮战Class value2 in World.帮战list.Values)
					{
						if (value2.当前分数 == num)
						{
							num4++;
						}
					}
					if (num4 == 1)
					{
						foreach (帮战Class value3 in World.帮战list.Values)
						{
							if (value3.申请帮派ID == num2)
							{
								DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 门派武勋=门派武勋+5000,名声=名声+3,胜=胜+1 WHERE ID='{0}'", value3.申请帮派ID));
								Players players = World.检查玩家name(value3.帮派门主);
								if (players != null)
								{
									if (players.人物坐标_地图 == 7301)
									{
										try
										{
											int player_Job = players.Player_Job;
											int player_Zx = players.Player_Zx;
											players.更新门派等级(players.UserName);
											RxjhClass.Set帮派荣誉数据(value3.申请帮派名称, value3.帮派门主, value3.等级, player_Job, player_Zx, 1);
											players.系统提示("帮战胜利,胜利点数[+1] 门派武勋[+5000] 声望[+3]。", 6, "帮战提示");
											foreach (Players value4 in value3.申请人物列表.Values)
											{
												if (value4.人物坐标_地图 == 7301)
												{
													jlwp(value4, true);
												}
											}
											World.胜利帮派ID = value3.申请帮派ID;
											World.发送公告("[" + value3.申请帮派名称 + "]取得帮战胜利，获得5000门派武勋,所有参战人员获得获胜奖励");
										}
										catch (Exception ex)
										{
											Form1.WriteLine(1, "帮战 Set帮派荣誉数据() 出错：" + ((ex != null) ? ex.ToString() : null));
											Form1.WriteLine(100, "帮战 Set帮派荣誉数据()  出错：" + ((ex != null) ? ex.ToString() : null));
										}
									}
									else
									{
										foreach (Players value5 in value3.申请人物列表.Values)
										{
											if (value5.人物坐标_地图 == 7301)
											{
												value5.系统提示("帮战结束,因帮主离开帮战地图,取消奖励。", 6, "帮战提示");
											}
										}
										if (World.帮战Namelist != null && World.帮战Namelist.Count > 0 && World.帮战Namelist.ContainsKey(value3.申请帮派ID))
										{
											World.帮战Namelist.Remove(value3.申请帮派ID);
										}
										World.胜利帮派ID = 0;
									}
								}
								else
								{
									foreach (Players value6 in value3.申请人物列表.Values)
									{
										if (value6.人物坐标_地图 == 7301)
										{
											value6.系统提示("帮战结束,因帮主退出游戏,取消奖励。", 6, "帮战提示");
										}
									}
									if (World.帮战Namelist != null && World.帮战Namelist.Count > 0 && World.帮战Namelist.ContainsKey(value3.申请帮派ID))
									{
										World.帮战Namelist.Remove(value3.申请帮派ID);
									}
									World.胜利帮派ID = 0;
								}
							}
							else
							{
								DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 门派武勋=门派武勋+500,败=败+1 WHERE ID='{0}'", value3.申请帮派ID));
								foreach (Players value7 in value3.申请人物列表.Values)
								{
									jlwp(value7, false);
								}
								if (World.帮战Namelist != null && World.帮战Namelist.Count > 0 && World.帮战Namelist.ContainsKey(value3.申请帮派ID))
								{
									World.帮战Namelist.Remove(value3.申请帮派ID);
								}
							}
						}
					}
					else
					{
						World.胜利帮派ID = 0;
						World.发送公告("帮派混战结束,由于最高分相同无帮派获得胜利！");
						if (World.帮战Namelist != null && World.帮战Namelist.Count > 0)
						{
							World.帮战Namelist.Clear();
						}
					}
				}
				else
				{
					World.胜利帮派ID = 0;
					World.发送公告("帮派混战结束,无帮派获得胜利！");
					if (World.帮战Namelist != null && World.帮战Namelist.Count > 0)
					{
						World.帮战Namelist.Clear();
					}
				}
				if (timer_3 != null)
				{
					timer_3.Enabled = false;
					timer_3.Close();
					timer_3.Dispose();
				}
				Dispose();
			}
			catch
			{
				World.胜利帮派ID = 0;
				if (World.帮战Namelist != null && World.帮战Namelist.Count > 0)
				{
					World.帮战Namelist.Clear();
				}
				if (timer_3 != null)
				{
					timer_3.Enabled = false;
					timer_3.Close();
					timer_3.Dispose();
				}
				Dispose();
			}
			finally
			{
				Dispose();
			}
		}

		public void jlwp(Players players_0, bool bool_0)
		{
			try
			{
				if (players_0 != null)
				{
					byte[] bytes = Buffer.GetBytes(1008000389);
					if (bool_0)
					{
						bytes = Buffer.GetBytes(1008000388);
					}
					byte[] bytes2 = Buffer.GetBytes(1);
					byte[] bytes3 = Buffer.GetBytes(RxjhClass.GetDBItmeId());
					int num = players_0.得到包裹空位(players_0);
					if (num != -1)
					{
						players_0.增加物品(bytes3, bytes, num, bytes2, new byte[56]);
						players_0.系统提示("获得经验奖励道具。", 6, "帮战提示");
					}
					if (World.门战奖励物品ID != 0 && bool_0)
					{
						int num2 = players_0.得到包裹空位(players_0);
						if (num2 != -1)
						{
							players_0.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(World.门战奖励物品ID), num2, bytes2, new byte[56]);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "帮战 发放奖励物品 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void Dispose()
		{
			try
			{
				World.新门战进程 = 0;
				World.是否开启门战系统 = 0;
				if (World.帮战list.Count > 0)
				{
					foreach (帮战Class value in World.帮战list.Values)
					{
						foreach (Players value2 in value.申请人物列表.Values)
						{
							value2.系统倒计时(0, 0);
							value2.移动(value2.人物坐标_X, value2.人物坐标_Y, value2.人物坐标_Z, 1201);
							value2.安全模式 = 0;
						}
					}
				}
				if (timer_0 != null)
				{
					timer_0.Enabled = false;
					timer_0.Close();
					timer_0.Dispose();
				}
				if (timer_1 != null)
				{
					timer_1.Enabled = false;
					timer_1.Close();
					timer_1.Dispose();
				}
				if (timer_2 != null)
				{
					timer_2.Enabled = false;
					timer_2.Close();
					timer_2.Dispose();
				}
				if (timer_3 != null)
				{
					timer_3.Enabled = false;
					timer_3.Close();
					timer_3.Dispose();
				}
				if (World.帮战list.Count > 0)
				{
					World.帮战list.Clear();
				}
				World.帮战 = null;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "帮战 Dispose() 出错：" + ((ex != null) ? ex.ToString() : null));
			}
			finally
			{
				World.新门战进程 = 0;
				World.是否开启门战系统 = 0;
				if (timer_0 != null)
				{
					timer_0.Enabled = false;
					timer_0.Close();
					timer_0.Dispose();
				}
				if (timer_1 != null)
				{
					timer_1.Enabled = false;
					timer_1.Close();
					timer_1.Dispose();
				}
				if (timer_2 != null)
				{
					timer_2.Enabled = false;
					timer_2.Close();
					timer_2.Dispose();
				}
				if (timer_3 != null)
				{
					timer_3.Enabled = false;
					timer_3.Close();
					timer_3.Dispose();
				}
				if (World.帮战list.Count > 0)
				{
					World.帮战list.Clear();
				}
				World.帮战 = null;
			}
		}
	}
}
