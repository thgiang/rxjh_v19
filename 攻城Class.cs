using RxjhServer;
using RxjhServer.DbClss;
using System;
using System.Threading;
using System.Timers;

public class 攻城Class : IDisposable
{
	private System.Timers.Timer 时间1;

	private System.Timers.Timer 攻城中每分钟执行;

	private System.Timers.Timer 时间2;

	private DateTime 天魔攻城准备时间;

	private DateTime 天魔攻城总时间;

	private int 开始倒计时;

	private int 申请人物数量;

	private int 申请人物数量2;

	public 攻城Class()
	{
		try
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass-");
			}
			World.攻城战list.Clear();
			天魔攻城准备时间 = DateTime.Now.AddMinutes(3.0);
			World.攻城战进程 = 1;
			foreach (Players value in World.allConnectedChars.Values)
			{
				if (value.人物坐标_地图 == 42101)
				{
					value.发送势力战开始倒计时(开始倒计时);
					value.天魔神宫显示图标(value, World.申请攻城人物列表.Count);
				}
				else if (value.帮派名字 != string.Empty && value.人物坐标_地图 != 42101)
				{
					value.发送天魔神宫邀请();
				}
			}
			时间1 = new System.Timers.Timer(4000.0);
			时间1.Elapsed += 时间结束事件1;
			时间1.Enabled = true;
			时间1.AutoReset = true;
			时间结束事件1(null, null);
			World.天魔神宫大门是否死亡 = 0;
			World.添加天魔怪物(16431, 57f, 470f, 42101, 0);
			Thread.Sleep(1000);
			World.添加天魔怪物(16430, -430f, -393f, 42101, 0);
			Thread.Sleep(1000);
			World.添加天魔怪物(16435, -435f, 523f, 42101, 0);
		}
		catch (Exception ex)
		{
			Form1.WriteLine(1, "攻城战      EventClass      出错：" + ((ex != null) ? ex.ToString() : null));
		}
	}

	public void 时间结束事件1(object sender, ElapsedEventArgs e)
	{
		if (World.jlMsg == 1)
		{
			Form1.WriteLine(0, "EventClass_时间结束事件1");
		}
		try
		{
			TimeSpan timeSpan = 天魔攻城准备时间.Subtract(DateTime.Now);
			int num = (int)timeSpan.TotalSeconds;
			int minute = timeSpan.Minutes;
			if (num <= 0)
			{
				World.攻城战进程 = 2;
				num = 0;
			}
			开始倒计时 = num;
			foreach (Players value in World.allConnectedChars.Values)
			{
				if (value.人物坐标_地图 == 42101)
				{
					value.发送势力战开始倒计时(开始倒计时);
					value.天魔神宫显示图标(value, World.申请攻城人物列表.Count);
				}
			}
			if (开始倒计时 <= 0)
			{
				时间1.Enabled = false;
				时间1.Close();
				时间1.Dispose();
				World.攻城战进程 = 3;
				foreach (Players value2 in World.allConnectedChars.Values)
				{
					if (value2.人物坐标_地图 == 42101)
					{
						value2.切换PK模式(2);
						value2.天魔神宫开始消息();
					}
				}
				天魔攻城总时间 = DateTime.Now.AddMinutes(30.0);
				攻城中每分钟执行 = new System.Timers.Timer(4000.0);
				攻城中每分钟执行.Elapsed += 时间结束事件2;
				攻城中每分钟执行.Enabled = true;
				攻城中每分钟执行.AutoReset = true;
				时间结束事件2(null, null);
			}
		}
		catch (Exception ex)
		{
			Form1.WriteLine(1, "攻城战      时间结束事件1      出错：" + ((ex != null) ? ex.ToString() : null));
		}
	}

	public void 时间结束事件2(object sender, ElapsedEventArgs e)
	{
		if (World.jlMsg == 1)
		{
			Form1.WriteLine(0, "EventClass_时间结束事件2");
		}
		try
		{
			TimeSpan timeSpan = 天魔攻城总时间.Subtract(DateTime.Now);
			int minute = timeSpan.Minutes;
			int num = (int)timeSpan.TotalSeconds;
			foreach (Players value in World.allConnectedChars.Values)
			{
				if (value.人物坐标_地图 == 42101)
				{
					value.天魔神宫显示图标(value, World.申请攻城人物列表.Count);
					if (World.天魔神宫雕像是否死亡 == 1)
					{
						value.加载攻城数据();
						World.天魔神宫雕像击杀添加怪物();
						World.天魔神宫雕像是否死亡 = 0;
					}
				}
			}
			if (num <= 0)
			{
				攻城中每分钟执行.Enabled = false;
				攻城中每分钟执行.Close();
				攻城中每分钟执行.Dispose();
				World.攻城战进程 = 4;
				foreach (Players value2 in World.allConnectedChars.Values)
				{
					if (value2.人物坐标_地图 == 42101)
					{
						value2.天魔神宫守城胜利结束包(value2);
					}
				}
				更新城主信息();
				攻城结束奖励();
				Dispose();
			}
		}
		catch (Exception ex)
		{
			Form1.WriteLine(1, "攻城战 时间结束事件2  出错：" + ((ex != null) ? ex.ToString() : null));
		}
	}

	public void 更新城主信息()
	{
		DateTime now2 = DateTime.Now;
		DateTime now = DateTime.Now;
		DBA.ExeSqlCommand(string.Format("UPDATE 攻城城主 SET 攻城奖励时间='{0}'", DateTime.Now.AddDays(2.0)));
		DBA.ExeSqlCommand(string.Format("UPDATE 攻城城主 SET 攻城时间='{0}' ", now));
	}

	public void 攻城结束奖励()
	{
		foreach (Players value in World.allConnectedChars.Values)
		{
			foreach (攻城数据 value2 in World.攻城数据list.Values)
			{
				if (value.人物坐标_地图 == 42101)
				{
					if (value2.行会名字 == value.帮派名字)
					{
						if (value.追加状态列表.ContainsKey(1008002169))
						{
							value.追加状态列表[1008002169].时间结束事件();
						}
						追加状态类 追加状态类 = new 追加状态类(value, 172800000, 1008002169, 1);
						value.追加状态列表.Add(追加状态类.FLD_PID, 追加状态类);
						value.状态效果(BitConverter.GetBytes(1008002169), 1, 172800000);
						value.Player_WuXun += 2000;
						value.查百宝阁元宝数();
						value.检察元宝数据(50, 1);
						value.计算人物基本数据();
						value.更新武功和状态();
						value.更新HP_MP_SP();
						RxjhClass.百宝记录(value.Userid, value.UserName, 0.0, "攻城战获得", 1, 50);
						value.保存元宝数据();
						value.系统提示("系统奖励攻城战胜利者每人" + 2000 + "点的武勋", 10, "奖励提示");
						value.系统提示("系统奖励攻城战胜利者每人" + 50 + "元宝", 10, "奖励提示");
					}
					else
					{
						value.Player_WuXun += 500;
						value.查百宝阁元宝数();
						value.检察元宝数据(10, 1);
						value.计算人物基本数据();
						value.更新武功和状态();
						value.更新HP_MP_SP();
						value.保存元宝数据();
						RxjhClass.百宝记录(value.Userid, value.UserName, 0.0, "攻城战获得", 1, 50);
						value.系统提示("系统奖励攻城战参与者每人" + 500 + "点的武勋", 10, "奖励提示");
						value.系统提示("系统奖励攻城战胜利者每人" + 10 + "元宝", 10, "奖励提示");
					}
				}
			}
		}
	}

	public void Dispose()
	{
		if (World.jlMsg == 1)
		{
			Form1.WriteLine(0, "EventClass-Dispose");
		}
		World.攻城战进程 = 0;
		申请人物数量2 = 0;
		申请人物数量 = 0;
		World.delNpc(42101, 16431);
		Thread.Sleep(500);
		World.delNpc(42101, 16430);
		Thread.Sleep(1000);
		World.delNpc(42101, 16435);
		if (时间1 != null)
		{
			时间1.Enabled = false;
			时间1.Close();
			时间1.Dispose();
		}
		if (攻城中每分钟执行 != null)
		{
			攻城中每分钟执行.Enabled = false;
			攻城中每分钟执行.Close();
			攻城中每分钟执行.Dispose();
		}
		if (时间2 != null)
		{
			时间2.Enabled = false;
			时间2.Close();
			时间2.Dispose();
		}
		World.申请攻城人物列表.Clear();
		World.攻城战list.Clear();
		World.攻城 = null;
	}
}
