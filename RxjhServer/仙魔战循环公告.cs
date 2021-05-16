using System;
using System.Timers;

namespace RxjhServer
{
	public class 仙魔战循环公告 : IDisposable
	{
		private System.Timers.Timer 时间1;

		private DateTime kssj;

		private int kssjint;

		public 仙魔战循环公告()
		{
			try
			{
				kssj = DateTime.Now.AddMinutes(3.0);
				时间1 = new System.Timers.Timer(20000.0);
				时间1.Elapsed += 时间结束事件1;
				时间1.Enabled = true;
				时间1.AutoReset = true;
				时间结束事件1(null, null);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "仙魔战循环公告 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 时间结束事件1(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = (int)kssj.Subtract(DateTime.Now).TotalSeconds;
				if (num <= 0)
				{
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
					Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "仙魔战循环公告 时间结束事件1 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void Dispose()
		{
			try
			{
				if (时间1 != null)
				{
					时间1.Enabled = false;
					时间1.Close();
					时间1.Dispose();
					时间1 = null;
				}
				if (World.仙魔战公告 != null)
				{
					World.仙魔战公告 = null;
				}
			}
			catch
			{
			}
		}
	}
}
