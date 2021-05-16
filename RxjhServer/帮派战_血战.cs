using RxjhServer.DbClss;
using System;
using System.Timers;

namespace RxjhServer
{
	public class 帮派战_血战
	{
		private object AsyncLock = new object();

		private System.Timers.Timer timer_0;

		private System.Timers.Timer timer_1;

		private DateTime dateTime_0;

		private DateTime dateTime_1;

		public 帮战Class 帮战主方;

		public 帮战Class 帮战客方;

		public int 主方分数;

		public int 客方分数;

		public int 结束;

		public int 结束2;

		public 帮派战_血战(帮战Class 帮战Class_0, 帮战Class 帮战Class_1)
		{
			try
			{
				帮战主方 = 帮战Class_0;
				帮战客方 = 帮战Class_1;
				主方分数 = 0;
				客方分数 = 0;
				结束 = 0;
				using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value in 帮战主方.申请人物列表.Values)
					{
						value.帮战配对成功公告提示(0);
					}
				}
				using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value2 in 帮战客方.申请人物列表.Values)
					{
						value2.帮战配对成功公告提示(0);
					}
				}
				dateTime_0 = DateTime.Now.AddMinutes(1.0);
				timer_0 = new System.Timers.Timer(60000.0);
				timer_0.Elapsed += 准备记时器结束事件;
				timer_0.Enabled = true;
				timer_0.AutoReset = true;
				准备记时器结束事件(null, null);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "血帮战 准备记时器结束事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 准备记时器结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				TimeSpan timeSpan = dateTime_0.Subtract(DateTime.Now);
				int num = (int)timeSpan.TotalSeconds;
				using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value in 帮战主方.申请人物列表.Values)
					{
						value.帮战准备公告提示(timeSpan.Minutes.ToString());
					}
				}
				using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value2 in 帮战客方.申请人物列表.Values)
					{
						value2.帮战准备公告提示(timeSpan.Minutes.ToString());
					}
				}
				if (num <= 0)
				{
					timer_0.Enabled = false;
					timer_0.Close();
					timer_0.Dispose();
					dateTime_1 = DateTime.Now.AddMinutes(10.0);
					timer_1 = new System.Timers.Timer(1000.0);
					timer_1.Elapsed += 开始对战记时器结束事件;
					timer_1.Enabled = true;
					timer_1.AutoReset = true;
					using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
					{
						foreach (Players value3 in 帮战主方.申请人物列表.Values)
						{
							value3.移动(787f, -787f, 15f, 7101);
							value3.帮战开始提示(0, 0);
						}
					}
					using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
					{
						foreach (Players value4 in 帮战客方.申请人物列表.Values)
						{
							value4.移动(-787f, 787f, 15f, 7101);
							value4.帮战开始提示(0, 0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "血帮战 准备记时器结束事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 开始对战记时器结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = 0;
				int num2 = 0;
				using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value in 帮战主方.申请人物列表.Values)
					{
						if (value.关起来 == 1)
						{
							num++;
						}
						value.帮战更新分数(主方分数, 客方分数);
					}
				}
				using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value2 in 帮战客方.申请人物列表.Values)
					{
						if (value2.关起来 == 1)
						{
							num2++;
						}
						value2.帮战更新分数(主方分数, 客方分数);
					}
				}
				if ((int)dateTime_1.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					结束 = 1;
					timer_1.Enabled = false;
					timer_1.Close();
					timer_1.Dispose();
					Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "血帮战 开始对战记时器结束事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void Dispose()
		{
			if (结束2 != 1)
			{
				try
				{
					if (主方分数 > 客方分数)
					{
						using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value in 帮战主方.申请人物列表.Values)
							{
								if (value.帮派人物等级 == 6)
								{
									value.查百宝阁元宝数();
									value.检察元宝数据(100, 1);
									value.Player_Money += 90000000L;
									RxjhClass.帮战赌注删除(value.Userid, value.UserName, 帮战主方.申请帮派ID, 1);
									value.保存元宝数据();
									value.更新金钱和负重();
								}
								if (结束 == 1)
								{
									value.帮战开始提示(13, 1);
								}
								else if (结束 == 2)
								{
									value.系统提示("其中一方的帮主退出地图，帮战强制结束。", 9, "系统提示");
								}
								value.帮战开始提示(12, 3);
								value.移动(0f, 0f, 15f, 1201);
							}
						}
						using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value2 in 帮战客方.申请人物列表.Values)
							{
								if (value2.帮派人物等级 == 6)
								{
									RxjhClass.帮战赌注删除(value2.Userid, value2.UserName, 帮战客方.申请帮派ID, -1);
								}
								if (结束 == 1)
								{
									value2.帮战开始提示(13, -1);
								}
								else if (结束 == 2)
								{
									value2.系统提示("其中一方的帮主退出地图，帮战强制结束。", 9, "系统提示");
								}
								value2.帮战开始提示(12, 3);
								value2.移动(0f, 0f, 15f, 1201);
							}
						}
					}
					else if (客方分数 > 主方分数)
					{
						using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value3 in 帮战主方.申请人物列表.Values)
							{
								if (value3.帮派人物等级 == 6)
								{
									RxjhClass.帮战赌注删除(value3.Userid, value3.UserName, 帮战主方.申请帮派ID, -1);
								}
								if (结束 == 1)
								{
									value3.帮战开始提示(13, -1);
								}
								else if (结束 == 2)
								{
									value3.系统提示("其中一方的帮主退出地图，帮战强制结束。", 9, "系统提示");
								}
								value3.帮战开始提示(12, 3);
								value3.移动(0f, 0f, 15f, 1201);
							}
						}
						using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value4 in 帮战客方.申请人物列表.Values)
							{
								if (value4.帮派人物等级 == 6)
								{
									value4.查百宝阁元宝数();
									value4.检察元宝数据(100, 1);
									value4.Player_Money += 90000000L;
									RxjhClass.帮战赌注删除(value4.Userid, value4.UserName, 帮战客方.申请帮派ID, 1);
									value4.保存元宝数据();
									value4.更新金钱和负重();
								}
								if (结束 == 1)
								{
									value4.帮战开始提示(13, 1);
								}
								else if (结束 == 2)
								{
									value4.系统提示("其中一方的帮主退出地图，帮战强制结束。", 9, "系统提示");
								}
								value4.帮战开始提示(12, 3);
								value4.移动(0f, 0f, 15f, 1201);
							}
						}
					}
					else if (客方分数 == 主方分数)
					{
						using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value5 in 帮战主方.申请人物列表.Values)
							{
								if (value5.帮派人物等级 == 6)
								{
									value5.查百宝阁元宝数();
									value5.检察元宝数据(50, 1);
									value5.Player_Money += 45000000L;
									RxjhClass.帮战赌注删除(value5.Userid, value5.UserName, 帮战主方.申请帮派ID, 0);
									value5.保存元宝数据();
									value5.更新金钱和负重();
								}
								if (结束 == 1)
								{
									value5.帮战开始提示(13, 0);
								}
								else if (结束 == 2)
								{
									value5.系统提示("其中一方的帮主退出地图，帮战强制结束。", 9, "系统提示");
								}
								value5.帮战开始提示(12, 3);
								value5.移动(0f, 0f, 15f, 1201);
							}
						}
						using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value6 in 帮战客方.申请人物列表.Values)
							{
								if (value6.帮派人物等级 == 6)
								{
									value6.查百宝阁元宝数();
									value6.检察元宝数据(50, 1);
									value6.Player_Money += 45000000L;
									RxjhClass.帮战赌注删除(value6.Userid, value6.UserName, 帮战客方.申请帮派ID, 0);
									value6.保存元宝数据();
									value6.更新金钱和负重();
								}
								if (结束 == 1)
								{
									value6.帮战开始提示(13, 0);
								}
								else if (结束 == 2)
								{
									value6.系统提示("其中一方的帮主退出地图，帮战强制结束。", 9, "系统提示");
								}
								value6.帮战开始提示(12, 3);
								value6.移动(0f, 0f, 15f, 1201);
							}
						}
					}
					Form1.WriteLine(88, "帮战结束 地图ID:7101 结束ID:" + 结束 + " 主帮派ID:" + 帮战主方.申请帮派ID + " 主帮派名字:" + 帮战主方.申请帮派名称 + " 帮主:" + 帮战主方.帮主名称 + " 人数:" + 帮战主方.申请人物列表.Count + " 分数:" + 主方分数 + " ---- 客帮派ID:" + 帮战客方.申请帮派ID + " 客帮派名字:" + 帮战客方.申请帮派名称 + " 帮主:" + 帮战客方.帮主名称 + " 人数:" + 帮战客方.申请人物列表.Count + " 分数:" + 客方分数);
					结束2 = 1;
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
					if (帮战主方 != null)
					{
						if (帮战主方.申请人物列表 != null)
						{
							帮战主方.申请人物列表.Clear();
							帮战主方.申请人物列表 = null;
						}
						帮战主方 = null;
					}
					if (帮战客方 != null)
					{
						if (帮战客方.申请人物列表 != null)
						{
							帮战客方.申请人物列表.Clear();
							帮战客方.申请人物列表 = null;
						}
						帮战客方 = null;
					}
					World.血战 = null;
					结束2 = 1;
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "血帮战 Dispose() 出错：" + ((ex != null) ? ex.ToString() : null));
				}
			}
		}
	}
}
