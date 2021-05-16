using RxjhServer.DbClss;
using System;
using System.Timers;

namespace RxjhServer
{
	public class Wedding : IDisposable
	{
		private string 婚宴厅名 = string.Empty;

		private Players 新郎;

		private Players 新娘;

		private DateTime kssj;

		private DateTime kssjgj;

		private DateTime 整场结束时间;

		private int kssjint;

		public int FLD_MAP;

		public int 婚礼模式;

		public int 婚礼进程;

		private System.Timers.Timer 准备计时器;

		private System.Timers.Timer 开始计时器;

		private System.Timers.Timer 新娘入场计时器;

		private System.Timers.Timer 致辞计时器;

		private System.Timers.Timer 提问新娘计时器;

		private System.Timers.Timer 提问新郎计时器;

		private System.Timers.Timer 回答结果计时器;

		private System.Timers.Timer 交换戒指计时器;

		private System.Timers.Timer 酬谢嘉宾计时器;

		private System.Timers.Timer 结束计时器1;

		private System.Timers.Timer 结束计时器2;

		private System.Timers.Timer 结束计时器3;

		private System.Timers.Timer 结束计时器4;

		public Wedding(Players 新郎, Players 新娘, int 地图, int 模式)
		{
			this.新郎 = 新郎;
			this.新娘 = 新娘;
			FLD_MAP = 地图;
			婚礼模式 = 模式;
			婚礼进程 = 0;
			switch (地图)
			{
			case 9201:
				婚宴厅名 = "圣礼殿";
				break;
			case 9101:
				婚宴厅名 = "龙赡殿";
				break;
			case 9001:
				婚宴厅名 = "华婚殿";
				break;
			}
			kssj = DateTime.Now.AddMinutes(10.0);
			准备计时器 = new System.Timers.Timer(60000.0);
			准备计时器.Elapsed += 准备时间结束事件;
			准备计时器.Enabled = true;
			准备计时器.AutoReset = true;
			准备时间结束事件(null, null);
			整场结束时间 = DateTime.Now.AddMinutes(30.0);
			结束计时器4 = new System.Timers.Timer(60000.0);
			结束计时器4.Elapsed += 整场时间结束事件;
			结束计时器4.Enabled = true;
			结束计时器4.AutoReset = true;
			if (this.新郎.预备申请仪式计时器 != null)
			{
				this.新郎.预备申请仪式计时器.Enabled = false;
				this.新郎.预备申请仪式计时器.Close();
				this.新郎.预备申请仪式计时器.Dispose();
			}
		}

		public bool 是否在线()
		{
			if (新郎.Client != null && 新郎.Client.Running && 新娘.Client != null)
			{
				return 新娘.Client.Running;
			}
			return false;
		}

		public void 整场时间结束事件(object sender, ElapsedEventArgs e)
		{
			if ((int)整场结束时间.Subtract(DateTime.Now).TotalSeconds <= 0)
			{
				Wedding value;
				try
				{
					if (FLD_MAP == 9101)
					{
						World.龙赡殿是否在使用中 = false;
					}
					else if (FLD_MAP == 9001)
					{
						World.华婚殿是否在使用中 = false;
					}
					else if (FLD_MAP == 9201)
					{
						World.圣礼殿是否在使用中 = false;
					}
					if (结束计时器4 != null)
					{
						结束计时器4.Enabled = false;
						结束计时器4.Close();
						结束计时器4.Dispose();
					}
					if (World.婚礼list.TryGetValue(FLD_MAP, out value))
					{
						World.婚礼list.Remove(FLD_MAP);
					}
					Form1.WriteLine(1, "[" + 婚宴厅名 + "]婚礼全部结束[" + 新郎.UserName + "][ " + 新娘.UserName + "]");
					Dispose();
				}
				catch
				{
					if (FLD_MAP == 9101)
					{
						World.龙赡殿是否在使用中 = false;
					}
					else if (FLD_MAP == 9001)
					{
						World.华婚殿是否在使用中 = false;
					}
					else if (FLD_MAP == 9201)
					{
						World.圣礼殿是否在使用中 = false;
					}
					if (结束计时器4 != null)
					{
						结束计时器4.Enabled = false;
						结束计时器4.Close();
						结束计时器4.Dispose();
					}
					if (World.婚礼list.TryGetValue(FLD_MAP, out value))
					{
						World.婚礼list.Remove(FLD_MAP);
					}
					Dispose();
				}
				finally
				{
					if (FLD_MAP == 9101)
					{
						World.龙赡殿是否在使用中 = false;
					}
					else if (FLD_MAP == 9001)
					{
						World.华婚殿是否在使用中 = false;
					}
					else if (FLD_MAP == 9201)
					{
						World.圣礼殿是否在使用中 = false;
					}
					if (结束计时器4 != null)
					{
						结束计时器4.Enabled = false;
						结束计时器4.Close();
						结束计时器4.Dispose();
					}
					if (World.婚礼list.TryGetValue(FLD_MAP, out value))
					{
						World.婚礼list.Remove(FLD_MAP);
					}
					Dispose();
				}
			}
		}

		private void 清空行走状态(Players play)
		{
			try
			{
				if (play.GetAddState(601101))
				{
					play.追加状态列表[601101].时间结束事件();
				}
				if (play.GetAddState(601102))
				{
					play.追加状态列表[601102].时间结束事件();
				}
				if (play.GetAddState(601103))
				{
					play.追加状态列表[601103].时间结束事件();
				}
				if (play.GetAddState(1001101))
				{
					play.追加状态列表[1001101].时间结束事件();
				}
				if (play.GetAddState(1001102))
				{
					play.追加状态列表[1001102].时间结束事件();
				}
				if (play.GetAddState(1001201))
				{
					play.追加状态列表[1001201].时间结束事件();
				}
				if (play.GetAddState(1001202))
				{
					play.追加状态列表[1001202].时间结束事件();
				}
				if (play.GetAddState(1001202))
				{
					play.追加状态列表[1001202].时间结束事件();
				}
				play.行走状态id = 1;
			}
			catch
			{
			}
		}

		public void 准备时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = (int)kssj.Subtract(DateTime.Now).TotalSeconds;
				if (num <= 0)
				{
					婚礼进程 = 1;
				}
				kssjint = num;
				World.发送公告((num + 59) / 60 + "分钟后," + 新郎.UserName + "和" + 新娘.UserName + "将举行隆重婚礼仪式。参加可用命令 !移动 " + 婚宴厅名);
				if (kssjint <= 0)
				{
					if (!是否在线())
					{
						准备计时器.Enabled = false;
						准备计时器.Close();
						准备计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(9.0);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
					else
					{
						foreach (Players value in World.allConnectedChars.Values)
						{
							if (value.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value);
								value.情侣提示(74, 新郎.UserName, 新娘.UserName);
							}
						}
						if (FLD_MAP == 9201)
						{
							新郎.移动(-59f, 53f, 15f, 9201);
							新娘.移动(-48f, -104f, 15f, 9201);
						}
						else if (FLD_MAP == 9101)
						{
							新郎.移动(5f, -170f, 15f, 9101);
							新娘.移动(-5f, 137f, 15f, 9101);
						}
						else if (FLD_MAP == 9001)
						{
							新郎.移动(-10f, 33f, 15f, 9001);
							新娘.移动(10f, -101f, 15f, 9001);
						}
						int num2 = 100;
						if (FLD_MAP == 9001 || FLD_MAP == 9101)
						{
							num2 = 80;
						}
						新郎.系统提示("仪式正式开始 婚礼进行期间请停止外挂，切勿操作鼠标和键盘。", 6, "月下老人");
						新娘.系统提示("仪式正式开始 婚礼进行期间请停止外挂，切勿操作鼠标和键盘。", 6, "月下老人");
						婚礼进程 = 1;
						准备计时器.Enabled = false;
						准备计时器.Close();
						准备计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(num2);
						开始计时器 = new System.Timers.Timer(5000.0);
						开始计时器.Elapsed += 开始时间结束事件;
						开始计时器.Enabled = true;
						开始计时器.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 开始时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (!是否在线())
					{
						开始计时器.Enabled = false;
						开始计时器.Close();
						开始计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(9.0);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
					else
					{
						婚礼进程 = 2;
						foreach (Players value in World.allConnectedChars.Values)
						{
							if (value.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value);
								value.情侣提示(75, 新郎.UserName, 新娘.UserName);
							}
						}
						int num = 30;
						if (FLD_MAP == 9101)
						{
							num = 35;
						}
						else if (FLD_MAP == 9001)
						{
							num = 30;
						}
						开始计时器.Enabled = false;
						开始计时器.Close();
						开始计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(num);
						新娘入场计时器 = new System.Timers.Timer(3000.0);
						新娘入场计时器.Elapsed += 新娘入场时间结束事件;
						新娘入场计时器.Enabled = true;
						新娘入场计时器.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 新娘入场时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (!是否在线())
					{
						新娘入场计时器.Enabled = false;
						新娘入场计时器.Close();
						新娘入场计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(9.0);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
					else
					{
						婚礼进程 = 3;
						foreach (Players value in World.allConnectedChars.Values)
						{
							if (value.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value);
								value.情侣提示(76, 新郎.UserName, 新娘.UserName);
							}
						}
						新娘入场计时器.Enabled = false;
						新娘入场计时器.Close();
						新娘入场计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(60.0);
						致辞计时器 = new System.Timers.Timer(3000.0);
						致辞计时器.Elapsed += 致辞时间结束事件;
						致辞计时器.Enabled = true;
						致辞计时器.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 致辞时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (!是否在线())
					{
						致辞计时器.Enabled = false;
						致辞计时器.Close();
						致辞计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(9.0);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
					else
					{
						婚礼进程 = 4;
						foreach (Players value in World.allConnectedChars.Values)
						{
							if (value.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value);
								value.情侣提示(77, 新郎.UserName, 新娘.UserName, 1);
							}
						}
						致辞计时器.Enabled = false;
						致辞计时器.Close();
						致辞计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(60.0);
						提问新郎计时器 = new System.Timers.Timer(1000.0);
						提问新郎计时器.Elapsed += 提问新郎时间结束事件;
						提问新郎计时器.Enabled = true;
						提问新郎计时器.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 提问新郎时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if (!是否在线())
				{
					提问新郎计时器.Enabled = false;
					提问新郎计时器.Close();
					提问新郎计时器.Dispose();
					kssjgj = DateTime.Now.AddSeconds(9.0);
					结束计时器1 = new System.Timers.Timer(3000.0);
					结束计时器1.Elapsed += 时间结束事件1;
					结束计时器1.Enabled = true;
					结束计时器1.AutoReset = true;
				}
				else if (新郎.证婚人提问答案 == 1)
				{
					婚礼进程 = 5;
					foreach (Players value in World.allConnectedChars.Values)
					{
						if (value.人物坐标_地图 == FLD_MAP)
						{
							清空行走状态(value);
							value.情侣提示(77, 新郎.UserName, 新娘.UserName, 2);
						}
					}
					提问新郎计时器.Enabled = false;
					提问新郎计时器.Close();
					提问新郎计时器.Dispose();
					kssjgj = DateTime.Now.AddSeconds(60.0);
					提问新娘计时器 = new System.Timers.Timer(1000.0);
					提问新娘计时器.Elapsed += 提问新娘时间结束事件;
					提问新娘计时器.Enabled = true;
					提问新娘计时器.AutoReset = true;
				}
				else if (新郎.证婚人提问答案 == 0)
				{
					婚礼进程 = 11;
					foreach (Players value2 in World.allConnectedChars.Values)
					{
						if (value2.人物坐标_地图 == FLD_MAP)
						{
							清空行走状态(value2);
							value2.情侣提示(83, 新郎.UserName, 新娘.UserName);
						}
					}
					提问新郎计时器.Enabled = false;
					提问新郎计时器.Close();
					提问新郎计时器.Dispose();
					kssjgj = DateTime.Now.AddSeconds(60.0);
					结束计时器3 = new System.Timers.Timer(3000.0);
					结束计时器3.Elapsed += 时间结束事件3;
					结束计时器3.Enabled = true;
					结束计时器3.AutoReset = true;
				}
				else if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (新郎.证婚人提问答案 == 2)
					{
						foreach (Players value3 in World.allConnectedChars.Values)
						{
							if (value3.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value3);
								value3.情侣提示(77, 新郎.UserName, 新娘.UserName, 2);
							}
						}
						提问新郎计时器.Enabled = false;
						提问新郎计时器.Close();
						提问新郎计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(60.0);
						提问新娘计时器 = new System.Timers.Timer(1000.0);
						提问新娘计时器.Elapsed += 提问新娘时间结束事件;
						提问新娘计时器.Enabled = true;
						提问新娘计时器.AutoReset = true;
					}
					else
					{
						婚礼进程 = 11;
						foreach (Players value4 in World.allConnectedChars.Values)
						{
							if (value4.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value4);
								value4.情侣提示(83, 新郎.UserName, 新娘.UserName);
							}
						}
						提问新娘计时器.Enabled = false;
						提问新娘计时器.Close();
						提问新娘计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(60.0);
						结束计时器3 = new System.Timers.Timer(3000.0);
						结束计时器3.Elapsed += 时间结束事件3;
						结束计时器3.Enabled = true;
						结束计时器3.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 提问新娘时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if (!是否在线())
				{
					提问新娘计时器.Enabled = false;
					提问新娘计时器.Close();
					提问新娘计时器.Dispose();
					kssjgj = DateTime.Now.AddSeconds(9.0);
					结束计时器1 = new System.Timers.Timer(3000.0);
					结束计时器1.Elapsed += 时间结束事件1;
					结束计时器1.Enabled = true;
					结束计时器1.AutoReset = true;
				}
				else if (新娘.证婚人提问答案 == 1)
				{
					婚礼进程 = 6;
					foreach (Players value2 in World.allConnectedChars.Values)
					{
						if (value2.人物坐标_地图 == FLD_MAP)
						{
							清空行走状态(value2);
							value2.情侣提示(78, 新郎.UserName, 新娘.UserName);
							if (value2.GetAddState(242))
							{
								value2.追加状态列表[242].时间结束事件();
							}
							追加状态类 value = new 追加状态类(value2, 3600000, 242, 0);
							value2.追加状态列表.Add(242, value);
							value2.状态效果(242, 1, 1, 3600000);
							value2.FLD_人物_追加_攻击 += 15;
							value2.FLD_人物_追加_防御 += 15;
							value2.人物追加最大_HP += 300;
							value2.人物追加最大_MP += 300;
							value2.FLD_人物_追加_经验百分比 += 0.2;
							value2.FLD_结婚礼物_追加_属性石 = 1;
							value2.更新武功和状态();
							value2.更新HP_MP_SP();
						}
					}
					颁发婚礼奖励();
					新郎.更新人物数据(新郎);
					新娘.更新人物数据(新娘);
					新娘.更新广播人物数据();
					新郎.更新广播人物数据();
					提问新娘计时器.Enabled = false;
					提问新娘计时器.Close();
					提问新娘计时器.Dispose();
					kssjgj = DateTime.Now.AddSeconds(25.0);
					回答结果计时器 = new System.Timers.Timer(3000.0);
					回答结果计时器.Elapsed += 回答时间结束事件;
					回答结果计时器.Enabled = true;
					回答结果计时器.AutoReset = true;
				}
				else if (新娘.证婚人提问答案 == 0)
				{
					婚礼进程 = 11;
					foreach (Players value3 in World.allConnectedChars.Values)
					{
						if (value3.人物坐标_地图 == FLD_MAP)
						{
							清空行走状态(value3);
							value3.情侣提示(83, 新郎.UserName, 新娘.UserName);
						}
					}
					提问新娘计时器.Enabled = false;
					提问新娘计时器.Close();
					提问新娘计时器.Dispose();
					kssjgj = DateTime.Now.AddSeconds(60.0);
					结束计时器3 = new System.Timers.Timer(3000.0);
					结束计时器3.Elapsed += 时间结束事件3;
					结束计时器3.Enabled = true;
					结束计时器3.AutoReset = true;
				}
				else if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (新娘.证婚人提问答案 == 2)
					{
						foreach (Players value4 in World.allConnectedChars.Values)
						{
							if (value4.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value4);
								value4.情侣提示(78, 新郎.UserName, 新娘.UserName);
							}
						}
						颁发婚礼奖励();
						提问新娘计时器.Enabled = false;
						提问新娘计时器.Close();
						提问新娘计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(25.0);
						回答结果计时器 = new System.Timers.Timer(3000.0);
						回答结果计时器.Elapsed += 回答时间结束事件;
						回答结果计时器.Enabled = true;
						回答结果计时器.AutoReset = true;
					}
					else
					{
						婚礼进程 = 11;
						foreach (Players value5 in World.allConnectedChars.Values)
						{
							if (value5.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value5);
								value5.情侣提示(83, 新郎.UserName, 新娘.UserName);
							}
						}
						提问新娘计时器.Enabled = false;
						提问新娘计时器.Close();
						提问新娘计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(60.0);
						结束计时器3 = new System.Timers.Timer(3000.0);
						结束计时器3.Elapsed += 时间结束事件3;
						结束计时器3.Enabled = true;
						结束计时器3.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 回答时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (!是否在线())
					{
						回答结果计时器.Enabled = false;
						回答结果计时器.Close();
						回答结果计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(9.0);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
					else
					{
						婚礼进程 = 7;
						foreach (Players value in World.allConnectedChars.Values)
						{
							if (value.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value);
								value.情侣提示(79, 新郎.UserName, 新娘.UserName);
							}
						}
						回答结果计时器.Enabled = false;
						回答结果计时器.Close();
						回答结果计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(10.0);
						交换戒指计时器 = new System.Timers.Timer(1000.0);
						交换戒指计时器.Elapsed += 交换戒指时间结束事件;
						交换戒指计时器.Enabled = true;
						交换戒指计时器.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 交换戒指时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (!是否在线())
					{
						交换戒指计时器.Enabled = false;
						交换戒指计时器.Close();
						交换戒指计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(9.0);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
					else
					{
						婚礼进程 = 8;
						foreach (Players value in World.allConnectedChars.Values)
						{
							if (value.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value);
								value.情侣提示(80, 新郎.UserName, 新娘.UserName);
							}
						}
						交换戒指计时器.Enabled = false;
						交换戒指计时器.Close();
						交换戒指计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(10.0);
						酬谢嘉宾计时器 = new System.Timers.Timer(1000.0);
						酬谢嘉宾计时器.Elapsed += 酬谢嘉宾时间结束事件;
						酬谢嘉宾计时器.Enabled = true;
						酬谢嘉宾计时器.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 酬谢嘉宾时间结束事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					if (!是否在线())
					{
						酬谢嘉宾计时器.Enabled = false;
						酬谢嘉宾计时器.Close();
						酬谢嘉宾计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(9.0);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
					else
					{
						婚礼进程 = 9;
						foreach (Players value in World.allConnectedChars.Values)
						{
							if (value.人物坐标_地图 == FLD_MAP)
							{
								清空行走状态(value);
								value.情侣提示(81, 新郎.UserName, 新娘.UserName);
							}
						}
						int num = 30;
						if (FLD_MAP == 9101)
						{
							num = 35;
						}
						酬谢嘉宾计时器.Enabled = false;
						酬谢嘉宾计时器.Close();
						酬谢嘉宾计时器.Dispose();
						kssjgj = DateTime.Now.AddSeconds(num);
						结束计时器1 = new System.Timers.Timer(3000.0);
						结束计时器1.Elapsed += 时间结束事件1;
						结束计时器1.Enabled = true;
						结束计时器1.AutoReset = true;
					}
				}
			}
			catch
			{
			}
		}

		public void 时间结束事件1(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					婚礼进程 = 10;
					foreach (Players value in World.allConnectedChars.Values)
					{
						if (value.人物坐标_地图 == FLD_MAP)
						{
							清空行走状态(value);
							value.情侣提示(82, 新郎.UserName, 新娘.UserName);
						}
					}
					结束计时器1.Enabled = false;
					结束计时器1.Close();
					结束计时器1.Dispose();
					kssjgj = DateTime.Now.AddMinutes(2.0);
					结束计时器2 = new System.Timers.Timer(5000.0);
					结束计时器2.Elapsed += 时间结束事件2;
					结束计时器2.Enabled = true;
					结束计时器2.AutoReset = true;
				}
			}
			catch
			{
			}
		}

		public void 时间结束事件2(object sender, ElapsedEventArgs e)
		{
			try
			{
				if ((int)kssjgj.Subtract(DateTime.Now).TotalSeconds <= 0)
				{
					婚礼进程 = 11;
					结束计时器2.Enabled = false;
					结束计时器2.Close();
					结束计时器2.Dispose();
					Dispose();
				}
			}
			catch
			{
			}
		}

		public void 时间结束事件3(object sender, ElapsedEventArgs e)
		{
			try
			{
				结束计时器3.Enabled = false;
				结束计时器3.Close();
				结束计时器3.Dispose();
				Dispose();
			}
			catch
			{
			}
		}

		public void 颁发婚礼奖励()
		{
			try
			{
				物品类 物品类 = 新郎.得到包裹物品(1000000416);
				if (物品类 != null)
				{
					新郎.减去物品(物品类.物品位置, 1);
				}
				物品类 物品类2 = 新娘.得到包裹物品(1000000416);
				if (物品类2 != null)
				{
					新娘.减去物品(物品类2.物品位置, 1);
				}
				int num = 新郎.得到包裹空位(新郎);
				if (num != -1)
				{
					新郎.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1000000415), num, Buffer.GetBytes(1), new byte[56]);
				}
				int num2 = 新郎.得到包裹空位(新郎);
				if (num2 != -1)
				{
					新郎.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1000000200), num2, Buffer.GetBytes(1), new byte[56]);
				}
				int num3 = 新郎.得到包裹空位(新郎);
				if (num3 != -1)
				{
					新郎.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1000000213), num3, Buffer.GetBytes(1), new byte[56]);
				}
				int num4 = 新娘.得到包裹空位(新娘);
				if (num4 != -1)
				{
					新娘.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1000000415), num4, Buffer.GetBytes(1), new byte[56]);
				}
				int num5 = 新娘.得到包裹空位(新娘);
				if (num5 != -1)
				{
					新娘.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1000000200), num5, Buffer.GetBytes(1), new byte[56]);
				}
				int num6 = 新娘.得到包裹空位(新娘);
				if (num6 != -1)
				{
					新娘.增加物品(Buffer.GetBytes(RxjhClass.GetDBItmeId()), Buffer.GetBytes(1000000213), num6, Buffer.GetBytes(1), new byte[56]);
				}
				DateTime now = DateTime.Now;
				新郎.FLD_结婚纪念日 = now;
				新娘.FLD_结婚纪念日 = now;
				新郎.是否已婚 = 1;
				新娘.是否已婚 = 1;
				新郎.婚戒刻字 = 新娘.UserName + ",我爱你一生一世!!!";
				新娘.婚戒刻字 = 新郎.UserName + ",我爱你一生一世!!!";
			}
			catch
			{
			}
		}

		public void Dispose()
		{
			try
			{
				婚礼进程 = 0;
				新郎.婚礼地图 = 0;
				新郎.婚礼入场券 = 0;
				新郎.婚礼模式 = 0;
				新娘.婚礼地图 = 0;
				新娘.婚礼入场券 = 0;
				新娘.婚礼模式 = 0;
				if (准备计时器 != null)
				{
					准备计时器.Enabled = false;
					准备计时器.Close();
					准备计时器.Dispose();
				}
				if (开始计时器 != null)
				{
					开始计时器.Enabled = false;
					开始计时器.Close();
					开始计时器.Dispose();
				}
				if (新娘入场计时器 != null)
				{
					新娘入场计时器.Enabled = false;
					新娘入场计时器.Close();
					新娘入场计时器.Dispose();
				}
				if (致辞计时器 != null)
				{
					致辞计时器.Enabled = false;
					致辞计时器.Close();
					致辞计时器.Dispose();
				}
				if (提问新娘计时器 != null)
				{
					提问新娘计时器.Enabled = false;
					提问新娘计时器.Close();
					提问新娘计时器.Dispose();
				}
				if (提问新郎计时器 != null)
				{
					提问新郎计时器.Enabled = false;
					提问新郎计时器.Close();
					提问新郎计时器.Dispose();
				}
				if (回答结果计时器 != null)
				{
					回答结果计时器.Enabled = false;
					回答结果计时器.Close();
					回答结果计时器.Dispose();
				}
				if (交换戒指计时器 != null)
				{
					交换戒指计时器.Enabled = false;
					交换戒指计时器.Close();
					交换戒指计时器.Dispose();
				}
				if (酬谢嘉宾计时器 != null)
				{
					酬谢嘉宾计时器.Enabled = false;
					酬谢嘉宾计时器.Close();
					酬谢嘉宾计时器.Dispose();
				}
				if (结束计时器1 != null)
				{
					结束计时器1.Enabled = false;
					结束计时器1.Close();
					结束计时器1.Dispose();
				}
				if (结束计时器2 != null)
				{
					结束计时器2.Enabled = false;
					结束计时器2.Close();
					结束计时器2.Dispose();
				}
				if (结束计时器3 != null)
				{
					结束计时器3.Enabled = false;
					结束计时器3.Close();
					结束计时器3.Dispose();
				}
				Wedding value;
				if (World.婚礼list.TryGetValue(FLD_MAP, out value))
				{
					World.婚礼list.Remove(FLD_MAP);
				}
				foreach (Players value2 in World.allConnectedChars.Values)
				{
					int num = RNG.Next(1, 30);
					if (value2.人物坐标_地图 == FLD_MAP)
					{
						int num2 = RNG.Next(1, 30);
						value2.移动(num, num2, 15f, 101);
					}
				}
			}
			catch
			{
			}
		}
	}
}
