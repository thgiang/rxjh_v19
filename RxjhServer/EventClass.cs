using RxjhServer.DbClss;
using System;
using System.Data;
using System.Timers;

namespace RxjhServer
{
	public class EventClass : IDisposable
	{
		private string jlsqlzj = string.Empty;

		private System.Timers.Timer 时间1;

		private System.Timers.Timer 时间2;

		private System.Timers.Timer 时间3;

		private System.Timers.Timer 时间4;

		private System.Timers.Timer 时间5;

		private DateTime kssj;

		private DateTime kssjgj;

		private int kssjint;

		private int 势力战sj;

		public EventClass()
		{
			try
			{
				World.EventTop.Clear();
				kssj = DateTime.Now.AddMinutes(World.势力战预备时间);
				World.势力战进程 = 1;
				World.势力战正分数 = 0;
				World.势力战邪分数 = 0;
				时间1 = new System.Timers.Timer(60000.0);
				时间1.Elapsed += 时间结束事件1;
				时间1.Enabled = true;
				时间1.AutoReset = true;
				时间结束事件1(null, null);
				World.conn.发送("势力战进程|" + World.势力战进程);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "势力战 EventClass 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件1(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = (int)kssj.Subtract(DateTime.Now).TotalSeconds;
				if (num <= 0)
				{
					World.势力战进程 = 2;
					World.势力战正分数 = 0;
					World.势力战邪分数 = 0;
					World.conn.发送("势力战进程|" + World.势力战进程);
					num = 0;
				}
				kssjint = num;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.人物坐标_地图 == 801)
					{
						value.发送势力战快开始消息(kssjint);
						value.发送势力战开始倒计时(kssjint);
					}
					else if (value.Player_Job_leve >= 2 && value.人物坐标_地图 != 801)
					{
						value.发送势力战系统封包(1, 1, 2);
					}
				}
				if (kssjint <= 0)
				{
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					bool flag = true;
					foreach (Players value2 in World.allConnectedChars.Values)
					{
						switch (num2)
						{
						case 0:
							num3 = 0;
							num4 = 140;
							break;
						case 1:
							num3 = -140;
							num4 = 0;
							break;
						case 2:
							num3 = 140;
							num4 = 0;
							break;
						case 3:
							num3 = 0;
							num4 = -140;
							break;
						}
						if (value2.人物坐标_地图 == 801)
						{
							value2.移动(num3, num4, 15f, 801);
							value2.切换PK模式(2);
							flag = false;
						}
						num2++;
						if (num2 >= 4)
						{
							num2 = 0;
						}
					}
					if (flag)
					{
						Dispose();
					}
					else
					{
						时间1.Enabled = false;
						时间1.Close();
						时间1.Dispose();
						World.势力战进程 = 3;
						World.conn.发送("势力战进程|" + World.势力战进程);
						kssjgj = DateTime.Now.AddMinutes(World.势力战时长);
						时间2 = new System.Timers.Timer(10000.0);
						时间2.Elapsed += 时间结束事件2;
						时间2.Enabled = true;
						时间2.AutoReset = true;
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "势力战 时间结束事件1 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件2(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = World.势力战时间 = (int)kssjgj.Subtract(DateTime.Now).TotalSeconds;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.人物坐标_地图 == 801)
					{
						value.发送势力战消息2();
						value.发送势力战消息();
					}
				}
				if (num <= 0)
				{
					时间2.Enabled = false;
					时间2.Close();
					时间2.Dispose();
					World.势力战进程 = 4;
					World.conn.发送("势力战进程|" + World.势力战进程);
					时间3 = new System.Timers.Timer(30000.0);
					时间3.Elapsed += 时间结束事件3;
					时间3.Enabled = true;
					时间3.AutoReset = false;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "势力战 时间结束事件2 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件3(object sender, ElapsedEventArgs e)
		{
			try
			{
				foreach (EventTopClass value in World.EventTop.Values)
				{
					try
					{
						string 人物名 = value.人物名;
						DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT 人物名 from [EventTop] where 人物名 ='{0}'", 人物名));
						if (dBToDataTable != null && dBToDataTable.Rows.Count > 0)
						{
							DBA.ExeSqlCommand(string.Format("UPDATE EventTop SET 帮派='{1}',等级={2},杀人数=杀人数+{3},死亡数=死亡数+{4} WHERE 人物名='{0}'", 人物名, value.帮派, value.等级, value.杀人数, value.死亡数));
						}
						else
						{
							DBA.ExeSqlCommand(string.Format("INSERT INTO EventTop (人物名,帮派,势力,等级,杀人数,死亡数)values('{0}','{1}','{2}',{3},{4},{5})", 人物名, value.帮派, value.势力, value.等级, value.杀人数, value.死亡数));
						}
						dBToDataTable.Dispose();
						Players players = World.检查玩家name(人物名);
						int int_ = 1;
						if (players != null)
						{
							int_ = players.Player_Zx;
						}
						RxjhClass.Set个人荣誉数据(1, 人物名, value.职业, value.等级, int_, value.帮派, string.Empty, value.杀人数);
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "势力战 Set个人荣誉数据() 出错：" + ((ex != null) ? ex.ToString() : null));
						Form1.WriteLine(100, "势力战 Set个人荣誉数据()   出错：" + ((ex != null) ? ex.ToString() : null));
					}
				}
				World.EventTop.Clear();
				if (World.势力战正分数 > World.势力战邪分数)
				{
					势力战sj = 1;
					jlsqlzj = "仙族";
					World.发送公告("仙魔战结束仙族胜利");
				}
				else if (World.势力战正分数 == World.势力战邪分数)
				{
					势力战sj = 3;
					jlsqlzj = string.Empty;
					World.发送公告("仙魔战结束双方平局");
				}
				else
				{
					势力战sj = 2;
					jlsqlzj = "魔族";
					World.发送公告("仙魔战结束魔族胜利");
				}
				try
				{
					foreach (Players value2 in World.allConnectedChars.Values)
					{
						if (value2.人物坐标_地图 == 801)
						{
							value2.发送势力战结束消息(势力战sj);
							if (value2.势力战派别 == jlsqlzj)
							{
								if (value2.势力战杀人数 != 0)
								{
									value2.赠送系统(4);
									int num = value2.得到包裹空位(value2);
									if (num != -1)
									{
										value2.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1008000388), num, Buffer.GetBytes(1), new byte[56]);
										value2.系统提示("获得[胜利的庆祝]道具[30分钟经验300%]。");
									}
									else
									{
										value2.系统提示("背包没空位了。");
									}
								}
							}
							else if (value2.势力战杀人数 != 0)
							{
								int num2 = value2.得到包裹空位(value2);
								if (num2 != -1)
								{
									value2.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1008000389), num2, Buffer.GetBytes(1), new byte[56]);
									value2.系统提示("获得[崛起的斗志]道具[30分钟经验150%]。");
								}
								else
								{
									value2.系统提示("背包没空位了。");
								}
							}
						}
					}
					string text = string.Empty;
					foreach (Players value3 in World.allConnectedChars.Values)
					{
						if (value3.人物坐标_地图 == 801 && value3.势力战派别 == jlsqlzj && value3.势力战杀人数 != 0)
						{
							value3.增加物品带属性(World.势力战随机奖励盒子ID, value3.得到包裹空位(value3), 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
							text = value3.UserName;
							break;
						}
					}
					if (text.Length != 0)
					{
						World.全局提示("系统提示", 7, "恭喜玩家[" + text + "]在仙魔战中获得系统[百宝箱]！");
					}
				}
				catch (Exception ex2)
				{
					Form1.WriteLine(1, "势力战 奖励随机盒子 出错：" + ((ex2 != null) ? ex2.ToString() : null));
					Form1.WriteLine(100, "势力战 奖励随机盒子   出错：" + ((ex2 != null) ? ex2.ToString() : null));
				}
				try
				{
					奖励前三名();
				}
				catch (Exception ex3)
				{
					Form1.WriteLine(1, "势力战 奖励前三名() 出错：" + ((ex3 != null) ? ex3.ToString() : null));
					Form1.WriteLine(100, "势力战 奖励前三名()   出错：" + ((ex3 != null) ? ex3.ToString() : null));
				}
				World.势力战进程 = 5;
				foreach (Players value4 in World.allConnectedChars.Values)
				{
					if (value4.人物坐标_地图 == 801)
					{
						value4.系统提示("请胜方[" + jlsqlzj + "]等待30秒，准备好击杀超级BOSS。");
					}
				}
				World.conn.发送("势力战进程|" + World.势力战进程);
				kssjgj = DateTime.Now.AddSeconds(330.0);
				时间3.Enabled = false;
				时间3.Close();
				时间3.Dispose();
				时间4 = new System.Timers.Timer(15000.0);
				时间4.Elapsed += 时间结束事件4;
				时间4.Enabled = true;
				时间4.AutoReset = true;
				时间5 = new System.Timers.Timer(15000.0);
				时间5.Elapsed += 时间结束事件5;
				时间5.Enabled = true;
				时间5.AutoReset = true;
			}
			catch (Exception ex4)
			{
				Form1.WriteLine(1, "势力战 时间结束事件3 出错：" + ((ex4 != null) ? ex4.ToString() : null));
			}
		}

		public void 奖励前三名()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("Select * from [EventTop] Order By 杀人数 Desc"));
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count > 0)
			{
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Players players = World.检查玩家name(dBToDataTable.Rows[i]["人物名"].ToString());
					if (players != null)
					{
						switch (i)
						{
						case 0:
							players.查百宝阁元宝数();
							players.检察元宝数据(World.第一名奖励元宝, 1);
							RxjhClass.百宝记录(players.Userid, players.UserName, 0.0, "势力战第一名奖励", 1, World.第一名奖励元宝);
							players.保存元宝数据();
							break;
						case 1:
							players.查百宝阁元宝数();
							players.检察元宝数据(World.第一名奖励元宝 - 100 * i, 1);
							RxjhClass.百宝记录(players.Userid, players.UserName, 0.0, "第二名奖励元宝", 1, World.第一名奖励元宝 - 100 * i);
							players.保存元宝数据();
							break;
						case 2:
							players.查百宝阁元宝数();
							players.检察元宝数据(World.第一名奖励元宝 - 100 * i, 1);
							RxjhClass.百宝记录(players.Userid, players.UserName, 0.0, "第三名奖励元宝", 1, World.第一名奖励元宝 - 100 * i);
							players.保存元宝数据();
							break;
						case 3:
							players.查百宝阁元宝数();
							players.检察元宝数据(World.第一名奖励元宝 - 100 * i, 1);
							RxjhClass.百宝记录(players.Userid, players.UserName, 0.0, "第四名奖励元宝", 1, World.第一名奖励元宝 - 100 * i);
							players.保存元宝数据();
							break;
						case 4:
							players.查百宝阁元宝数();
							players.检察元宝数据(World.第一名奖励元宝 - 100 * i, 1);
							RxjhClass.百宝记录(players.Userid, players.UserName, 0.0, "第五名奖励元宝", 1, World.第一名奖励元宝 - 100 * i);
							players.保存元宝数据();
							break;
						}
					}
				}
			}
			dBToDataTable.Dispose();
		}

		public void 时间结束事件4(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = World.势力战时间 = (int)kssjgj.Subtract(DateTime.Now).TotalSeconds;
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.人物坐标_地图 == 801)
					{
						value.发送势力战消息();
						if (value.势力战派别 != jlsqlzj)
						{
							value.势力战派别 = string.Empty;
							value.势力战杀人数 = 0;
							value.势力战死亡数 = 0;
							value.移动(-5f, -8f, 15f, 1201);
						}
					}
				}
				if (num <= 0)
				{
					时间4.Enabled = false;
					时间4.Close();
					时间4.Dispose();
					World.势力战进程 = 6;
					World.conn.发送("势力战进程|" + World.势力战进程);
					foreach (Players value2 in World.allConnectedChars.Values)
					{
						if (value2.人物坐标_地图 == 801)
						{
							value2.势力战派别 = string.Empty;
							value2.势力战杀人数 = 0;
							value2.势力战死亡数 = 0;
							value2.移动(-5f, -8f, 15f, 1201);
						}
					}
					Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "势力战 时间结束事件4 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件5(object sender, ElapsedEventArgs e)
		{
			try
			{
				时间5.Enabled = false;
				时间5.Close();
				时间5.Dispose();
				World.AddNpc(15584, 0f, 0f, 801);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "势力战 时间结束事件5 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void Dispose()
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (value.人物坐标_地图 == 801)
					{
						value.势力战派别 = string.Empty;
						value.势力战杀人数 = 0;
						value.势力战死亡数 = 0;
						value.移动(-5f, -50f, 15f, 1201);
					}
				}
				World.势力战进程 = 0;
				World.势力战时间 = 0;
				World.势力战正分数 = 0;
				World.势力战邪分数 = 0;
				World.势力战正人数 = 0;
				World.势力战邪人数 = 0;
				if (World.势力战掉线玩家.Count > 0)
				{
					World.势力战掉线玩家.Clear();
				}
				if (时间1 != null)
				{
					时间1.Enabled = false;
					时间1.Close();
					时间1.Dispose();
					时间1 = null;
				}
				if (时间2 != null)
				{
					时间2.Enabled = false;
					时间2.Close();
					时间2.Dispose();
					时间2 = null;
				}
				if (时间3 != null)
				{
					时间3.Enabled = false;
					时间3.Close();
					时间3.Dispose();
					时间3 = null;
				}
				if (时间4 != null)
				{
					时间4.Enabled = false;
					时间4.Close();
					时间4.Dispose();
					时间4 = null;
				}
				if (时间5 != null)
				{
					时间5.Enabled = false;
					时间5.Close();
					时间5.Dispose();
					时间5 = null;
				}
				if (World.eve != null)
				{
					World.eve = null;
				}
			}
			catch
			{
			}
			finally
			{
				World.conn.发送("势力战进程|" + World.势力战进程);
				World.conn.发送("势力战人数|" + World.势力战正人数 + "|" + World.势力战邪人数);
				World.势力战进程 = 0;
				World.势力战时间 = 0;
				World.势力战正分数 = 0;
				World.势力战邪分数 = 0;
				World.势力战正人数 = 0;
				World.势力战邪人数 = 0;
				if (World.势力战掉线玩家.Count > 0)
				{
					World.势力战掉线玩家.Clear();
				}
				if (时间1 != null)
				{
					时间1.Enabled = false;
					时间1.Close();
					时间1.Dispose();
					时间1 = null;
				}
				if (时间2 != null)
				{
					时间2.Enabled = false;
					时间2.Close();
					时间2.Dispose();
					时间2 = null;
				}
				if (时间3 != null)
				{
					时间3.Enabled = false;
					时间3.Close();
					时间3.Dispose();
					时间3 = null;
				}
				if (时间4 != null)
				{
					时间4.Enabled = false;
					时间4.Close();
					时间4.Dispose();
					时间4 = null;
				}
				if (时间5 != null)
				{
					时间5.Enabled = false;
					时间5.Close();
					时间5.Dispose();
					时间5 = null;
				}
				if (World.eve != null)
				{
					World.eve = null;
				}
			}
		}
	}
}
