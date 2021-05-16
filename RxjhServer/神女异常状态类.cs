using RxjhServer.HelperTools;
using System;
using System.Timers;

namespace RxjhServer
{
	public class 神女异常状态类 : IDisposable
	{
		public System.Timers.Timer npcyd;

		public System.Timers.Timer yczt;

		public double ycztsl;

		public DateTime time;

		public Players Play;

		public NpcClass Npc;

		public int NpcPlayId;

		private int _FLD_PID;

		private double _FLD_NUM;

		private double _伤害;

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

		public double FLD_NUM
		{
			get
			{
				return _FLD_NUM;
			}
			set
			{
				_FLD_NUM = value;
			}
		}

		private double 伤害
		{
			get
			{
				return _伤害;
			}
			set
			{
				_伤害 = value;
			}
		}

		public void Dispose()
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-Dispose");
			}
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
			if (yczt != null)
			{
				yczt.Enabled = false;
				yczt.Close();
				yczt.Dispose();
				yczt = null;
			}
			Play = null;
			Npc = null;
		}

		public 神女异常状态类(Players Play_, int 时间, int 异常ID, double 异常数量, double 伤害)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-NEW");
			}
			FLD_PID = 异常ID;
			FLD_NUM = 异常数量;
			this.伤害 = 伤害;
			time = DateTime.Now;
			time = time.AddMilliseconds(时间);
			Play = Play_;
			npcyd = new System.Timers.Timer(时间);
			npcyd.Elapsed += 时间结束事件1;
			npcyd.Enabled = true;
			npcyd.AutoReset = false;
			状态效果(FLD_PID, 1, (int)异常数量, 时间 / 1000);
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
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
			if (Play != null && !Play.Client.挂机)
			{
				if (!Play.退出中 && Play.Client.Running)
				{
					try
					{
						switch (FLD_PID)
						{
						case 52:
							Play.FLD_神女_追加_攻击 -= (int)伤害;
							Play.FLD_神女_追加_防御 -= (int)伤害;
							Play.更新武功和状态();
							break;
						case 34:
							Play.FLD_神女_追加_攻击 += (int)伤害;
							Play.FLD_神女_追加_防御 += (int)伤害;
							Play.更新武功和状态();
							break;
						case 35:
							Play.FLD_神女_追加_攻击 += (int)伤害;
							Play.FLD_神女_追加_防御 += (int)伤害;
							Play.更新武功和状态();
							break;
						}
						Play.神女异常状态.Remove(FLD_PID);
						状态效果2(FLD_PID, 0, 0, 0);
						Dispose();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "异常状态类 时间结束事件  出错：[" + FLD_PID + "]" + ((ex != null) ? ex.ToString() : null));
					}
					finally
					{
						Dispose();
					}
					return;
				}
				if (Play.神女异常状态 != null)
				{
					Play.神女异常状态.Clear();
				}
				Dispose();
			}
			else
			{
				Dispose();
			}
		}

		public void 状态效果2(int 异常ID, int 开关, int 异常数量, int 时间)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-状态效果");
			}
			byte[] array = Converter.hexStringToByte("AA553E00250040153800000000002500000034000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(异常ID), 0, array, 18, 4);
			if (Play != null)
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(Play.人物全服ID), 0, array, 14, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(Play.人物全服ID), 0, array, 4, 2);
				if (Play.Client != null)
				{
					Play.Client.Send(array, array.Length);
				}
				Play.发送当前范围广播数据(array, array.Length);
			}
		}

		public void 状态效果(int 异常ID, int 开关, int 异常数量, int 时间)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-状态效果");
			}
			byte[] array = Converter.hexStringToByte("AA5546003527401538008C0300002C0100000900000001000000000000006016A2496016A2492600000014000000000000008C030000E80300000900000001000000000000000000000055AA");
			System.Buffer.BlockCopy(BitConverter.GetBytes(异常ID), 0, array, 18, 4);
			System.Buffer.BlockCopy(BitConverter.GetBytes(异常ID), 0, array, 58, 4);
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
			else if (Npc != null)
			{
				System.Buffer.BlockCopy(BitConverter.GetBytes(Npc.FLD_INDEX), 0, array, 14, 2);
				System.Buffer.BlockCopy(BitConverter.GetBytes(Npc.FLD_INDEX), 0, array, 4, 2);
				Npc.广播数据(array, array.Length);
			}
		}
	}
}
