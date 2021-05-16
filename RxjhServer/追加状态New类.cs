using System;
using System.Timers;

namespace RxjhServer
{
	public class 追加状态New类 : IDisposable
	{
		public System.Timers.Timer npcyd;

		public DateTime time;

		public Players Play;

		private int _FLD_PID;

		private int _数量;

		private int _数量类型;

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

		public int 数量
		{
			get
			{
				return _数量;
			}
			set
			{
				_数量 = value;
			}
		}

		public int 数量类型
		{
			get
			{
				return _数量类型;
			}
			set
			{
				_数量类型 = value;
			}
		}

		public int FLD_sj
		{
			get
			{
				return getsj();
			}
		}

		public int getsj()
		{
			return (int)time.Subtract(DateTime.Now).TotalMilliseconds;
		}

		public void Dispose()
		{
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
			Play = null;
		}

		public 追加状态New类(Players Play_, int 物品ID, int 时间, int 数量, int 数量类型)
		{
			FLD_PID = 物品ID;
			this.数量 = 数量;
			this.数量类型 = 数量类型;
			time = DateTime.Now;
			time = time.AddMilliseconds(时间);
			Play = Play_;
			npcyd = new System.Timers.Timer(时间);
			npcyd.Elapsed += 时间结束事件2;
			npcyd.Enabled = true;
			npcyd.AutoReset = false;
		}

		public void 时间结束事件2(object sender, ElapsedEventArgs e)
		{
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
			if (Play == null)
			{
				Dispose();
				return;
			}
			if (!Play.退出中 && Play.Client.Running)
			{
				try
				{
					switch (FLD_PID)
					{
					case 1:
						if (数量类型 == 2)
						{
							Play.delFLD_追加百分比_攻击(0.01 * (double)数量);
							if (Play.FLD_追加百分比_攻击 < 0.0)
							{
								Play.FLD_追加百分比_攻击 = 0.0;
							}
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_攻击 -= 数量;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
						}
						Play.更新武功和状态();
						break;
					case 2:
						if (数量类型 == 2)
						{
							Play.delFLD_追加百分比_防御(0.01 * (double)数量);
							if (Play.FLD_追加百分比_防御 < 0.0)
							{
								Play.FLD_追加百分比_防御 = 0.0;
							}
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_防御 -= 数量;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
						}
						Play.更新武功和状态();
						break;
					case 3:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_HP上限 -= 0.01 * (double)数量;
							if (Play.FLD_追加百分比_HP上限 < 0.0)
							{
								Play.FLD_追加百分比_HP上限 = 0.0;
							}
						}
						else if (数量类型 == 1)
						{
							Play.人物追加最大_HP -= 数量;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
						}
						if (Play.人物_HP > Play.人物最大_HP)
						{
							Play.人物_HP = Play.人物最大_HP;
						}
						Play.更新HP_MP_SP();
						break;
					case 4:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_MP上限 -= 0.01 * (double)数量;
							if (Play.FLD_追加百分比_MP上限 < 0.0)
							{
								Play.FLD_追加百分比_MP上限 = 0.0;
							}
						}
						else if (数量类型 == 1)
						{
							Play.人物追加最大_MP -= 数量;
							if (Play.人物追加最大_MP < 0)
							{
								Play.人物追加最大_MP = 0;
							}
						}
						if (Play.人物_MP > Play.人物最大_MP)
						{
							Play.人物_MP = Play.人物最大_MP;
						}
						Play.更新HP_MP_SP();
						break;
					case 5:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_命中 -= 0.01 * (double)数量;
							if (Play.FLD_追加百分比_命中 < 0.0)
							{
								Play.FLD_追加百分比_命中 = 0.0;
							}
							Play.更新武功和状态();
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_命中 -= 数量;
							if (Play.FLD_人物_追加_命中 < 0)
							{
								Play.FLD_人物_追加_命中 = 0;
							}
							Play.更新武功和状态();
						}
						break;
					case 6:
						if (数量类型 == 2)
						{
							Play.FLD_人物_追加百分比_回避 -= 0.01 * (double)数量;
							if (Play.FLD_人物_追加百分比_回避 < 0.0)
							{
								Play.FLD_人物_追加百分比_回避 = 0.0;
							}
							Play.更新武功和状态();
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_回避 -= 数量;
							if (Play.FLD_人物_追加_回避 < 0)
							{
								Play.FLD_人物_追加_回避 = 0;
							}
							Play.更新武功和状态();
						}
						break;
					case 7:
						if (数量类型 == 2)
						{
							Play.FLD_人物_武功攻击力增加百分比 -= 0.01 * (double)数量;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
						}
						Play.更新武功和状态();
						break;
					case 8:
						if (数量类型 == 2)
						{
							Play.FLD_人物_武功防御力增加百分比 -= 0.01 * (double)数量;
							if (Play.FLD_人物_武功防御力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功防御力增加百分比 = 0.0;
							}
						}
						Play.更新武功和状态();
						break;
					case 9:
						if (数量类型 == 2)
						{
							Play.FLD_人物_追加_经验百分比 -= 0.01 * (double)数量;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
						}
						break;
					case 10:
						if (数量类型 == 2)
						{
							Play.FLD_人物_追加_合成成功率百分比 -= 0.01 * (double)数量;
						}
						break;
					case 12:
						if (数量类型 == 2)
						{
							Play.FLD_人物_追加_获得游戏币百分比 -= 0.01 * (double)数量;
						}
						break;
					case 13:
						if (数量类型 == 2)
						{
							Play.FLD_人物_追加_物品掉落概率百分比 -= 0.01 * (double)数量;
						}
						break;
					case 14:
						Play.FLD_人物_追加_气功 -= 数量;
						Play.更新气功();
						Play.更新武功和状态();
						break;
					case 15:
						if (数量类型 == 2)
						{
							Play.FLD_人物_追加_历练百分比 -= 0.01 * (double)数量;
							if (Play.FLD_人物_追加_历练百分比 < 0.0)
							{
								Play.FLD_人物_追加_历练百分比 = 0.0;
							}
						}
						break;
					}
					if (Play.追加状态New列表 != null)
					{
						Play.追加状态New列表.Remove(FLD_PID);
					}
					Play.状态效果New(FLD_PID, 0, FLD_sj, 数量, 数量类型);
					Dispose();
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "追加状态New类 时间结束事件 出错：[" + FLD_PID + "]" + ((ex != null) ? ex.ToString() : null));
				}
				finally
				{
					Dispose();
				}
				return;
			}
			if (Play.追加状态New列表 != null)
			{
				Play.追加状态New列表.Clear();
			}
			Dispose();
		}
	}
}
