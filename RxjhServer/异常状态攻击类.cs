using RxjhServer.HelperTools;
using System;
using System.Timers;

namespace RxjhServer
{
	public class 异常状态攻击类 : IDisposable
	{
		public System.Timers.Timer 人物状态;

		public DateTime time;

		public Players Play;

		private int _FLD_PID;

		public int FLD_PID
		{
			get
			{
				return _FLD_PID;
			}
			set
			{
				_FLD_PID = value;
			}
		}

		public void Dispose()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-Dispose");
			}
			if (人物状态 != null)
			{
				人物状态.Enabled = false;
				人物状态.Close();
				人物状态.Dispose();
				人物状态 = null;
			}
			Play = null;
		}

		public 异常状态攻击类(Players Play_, int 时间, int 异常ID, int 异常数量)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-NEW");
			}
			FLD_PID = 异常ID;
			time = DateTime.Now;
			time = time.AddMilliseconds(时间);
			Play = Play_;
			人物状态 = new System.Timers.Timer(时间);
			人物状态.Elapsed += 时间结束事件1;
			人物状态.Enabled = true;
			人物状态.AutoReset = false;
			状态效果(FLD_PID, 1, 异常数量, 时间 / 1000);
		}

		public void 时间结束事件1(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "时间结束事件1");
			}
			时间结束事件();
		}

		public void 时间结束事件()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-时间结束事件");
			}
			try
			{
				if (Play != null)
				{
					if (FLD_PID == 1)
					{
						Play.FLD_药品_减少攻击 += 0.2;
						Play.更新武功和状态();
					}
					if (FLD_PID == 13)
					{
						Play.FLD_药品_减少攻击 += 0.1;
						Play.更新武功和状态();
					}
					if (Play.异常攻击状态 != null)
					{
						Play.异常攻击状态.Remove(FLD_PID);
					}
					状态效果(FLD_PID, 0, 0, 0);
					Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "异常状态类 时间结束事件 出错：[" + FLD_PID + "]" + ((ex != null) ? ex.ToString() : null));
			}
			finally
			{
				Dispose();
			}
		}

		public void 状态效果(int 异常ID, int 开关, int 异常数量, int 时间)
		{
			byte[] array = Converter.hexStringToByte("AA5546003527401538008C0300002C0100000900000001000000000000006016A2496016A2492600000014000000000000008C030000E80300000900000001000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(异常ID), 0, array, 18, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(异常ID), 0, array, 58, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(开关), 0, array, 22, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(开关), 0, array, 62, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(时间), 0, array, 38, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(异常数量), 0, array, 42, 4);
			if (Play != null)
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(Play.人物全服ID), 0, array, 14, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(Play.人物全服ID), 0, array, 4, 2);
				if (Play.Client != null)
				{
					Play.Client.Send多包(array, array.Length);
				}
				Play.发送当前范围广播数据多包(array, array.Length);
			}
		}
	}
}
