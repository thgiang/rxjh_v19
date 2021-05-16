using System;
using System.Timers;

namespace RxjhServer
{
	public class 追加状态类 : IDisposable
	{
		public System.Timers.Timer npcyd;

		public DateTime time;

		public Players Play;

		private double _vale;

		private int _FLD_PID;

		private int _FLD_RESIDE1;

		private double vale
		{
			get
			{
				return _vale;
			}
			set
			{
				_vale = value;
			}
		}

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

		public int FLD_RESIDE1
		{
			get
			{
				return _FLD_RESIDE1;
			}
			set
			{
				_FLD_RESIDE1 = value;
			}
		}

		public int FLD_sj
		{
			get
			{
				return getsj();
			}
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
			if (Play != null)
			{
				Play = null;
			}
		}

		~追加状态类()
		{
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
		}

		public 追加状态类(Players Play_, int 时间, int 物品ID, int FLD_RESIDE1)
		{
			FLD_PID = 物品ID;
			this.FLD_RESIDE1 = FLD_RESIDE1;
			time = DateTime.Now;
			time = time.AddMilliseconds(时间);
			Play = Play_;
			npcyd = new System.Timers.Timer(时间);
			npcyd.Elapsed += 时间结束事件2;
			npcyd.Enabled = true;
			npcyd.AutoReset = false;
		}

		public 追加状态类(Players Play_, double 时间, double 物品ID, double FLD_RESIDE1)
		{
			FLD_PID = (int)物品ID;
			this.FLD_RESIDE1 = (int)FLD_RESIDE1;
			time = DateTime.Now;
			time = time.AddMilliseconds(时间);
			Play = Play_;
			npcyd = new System.Timers.Timer(时间);
			npcyd.Elapsed += 时间结束事件3;
			npcyd.Enabled = true;
			npcyd.AutoReset = false;
		}

		public 追加状态类(Players Play_, int 时间, int 物品ID, int FLD_RESIDE1, double vale)
		{
			FLD_PID = 物品ID;
			this.FLD_RESIDE1 = FLD_RESIDE1;
			this.vale = vale;
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

		public void 时间结束事件3(object sender, ElapsedEventArgs e)
		{
			时间结束事件1();
		}

		public void 时间结束事件1()
		{
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
			int num = 25;
			if (Play != null && !Play.Client.挂机)
			{
				if (!Play.退出中 && Play.Client.Running)
				{
					try
					{
						if (Play.GetAddState(FLD_PID))
						{
							Play.追加状态列表.Remove(FLD_PID);
						}
						num = 10;
						Dispose();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "追加武功状态类   时间结束事件   出错：" + num + "[" + FLD_PID + "]" + ((ex != null) ? ex.ToString() : null));
					}
					finally
					{
						Dispose();
					}
					return;
				}
				if (Play.追加状态列表 != null)
				{
					Play.追加状态列表.Clear();
				}
				Dispose();
			}
			else
			{
				Dispose();
			}
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
			int num = 25;
			if (Play != null && !Play.Client.挂机)
			{
				if (!Play.退出中 && Play.Client.Running)
				{
					try
					{
						switch (FLD_PID)
						{
						case 1000000815:
						case 1000000816:
							return;
						case 201201:
							Play.delFLD_追加百分比_攻击(0.05);
							Play.更新武功和状态();
							break;
						case 242:
							Play.FLD_人物_追加_攻击 -= 15;
							Play.FLD_人物_追加_防御 -= 15;
							Play.人物追加最大_HP -= 300;
							Play.人物追加最大_MP -= 300;
							Play.FLD_人物_追加_经验百分比 -= 0.2;
							Play.FLD_结婚礼物_追加_属性石 = 0;
							Play.更新武功和状态();
							Play.更新HP_MP_SP();
							break;
						case 401203:
							Play.FLD_人物_追加_命中 += 20;
							Play.FLD_人物_追加_回避 -= 40;
							Play.更新武功和状态();
							break;
						case 401202:
							Play.FLD_人物_追加_回避 += 20;
							Play.FLD_人物_追加_命中 -= 40;
							Play.更新武功和状态();
							break;
						case 301201:
							Play.delFLD_追加百分比_攻击(0.1);
							Play.FLD_追加百分比_HP上限 -= 0.05;
							if (Play.FLD_追加百分比_HP上限 < 0.0)
							{
								Play.FLD_追加百分比_HP上限 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新武功和状态();
							break;
						case 501301:
							Play.delFLD_追加百分比_攻击(vale);
							Play.更新武功和状态();
							break;
						case 501302:
							Play.delFLD_追加百分比_防御(vale);
							Play.更新武功和状态();
							break;
						case 501303:
							Play.delFLD_追加百分比_防御(vale);
							Play.更新武功和状态();
							break;
						case 401401:
							Play.FLD_追加百分比_命中 -= 0.4;
							Play.FLD_追加百分比_HP上限 -= 0.2;
							if (Play.FLD_追加百分比_HP上限 < 0.0)
							{
								Play.FLD_追加百分比_HP上限 = 0.0;
							}
							if (Play.FLD_追加百分比_命中 < 0.0)
							{
								Play.FLD_追加百分比_命中 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 401301:
							Play.FLD_人物_武功攻击力增加百分比 -= 0.1;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 401302:
							Play.FLD_人物_武功防御力增加百分比 -= 0.1;
							if (Play.FLD_人物_武功防御力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功防御力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 401303:
							switch (Play.Player_Job)
							{
							case 1:
								Play.真武绝击 -= 10.0;
								if (Play.真武绝击 < 0.0)
								{
									Play.真武绝击 = 0.0;
								}
								break;
							case 2:
								Play.剑_怒海狂澜 -= 10.0;
								if (Play.剑_怒海狂澜 < 0.0)
								{
									Play.剑_怒海狂澜 = 0.0;
								}
								break;
							case 3:
								Play.枪_怒意之吼 -= 10.0;
								if (Play.枪_怒意之吼 < 0.0)
								{
									Play.枪_怒意之吼 = 0.0;
								}
								break;
							case 4:
								Play.弓_致命绝杀 -= 10.0;
								if (Play.弓_致命绝杀 < 0.0)
								{
									Play.弓_致命绝杀 = 0.0;
								}
								break;
							case 5:
								Play.真武绝击 -= 10.0;
								if (Play.真武绝击 < 0.0)
								{
									Play.真武绝击 = 0.0;
								}
								break;
							case 6:
								Play.刺_心神凝聚 -= 10.0;
								if (Play.刺_心神凝聚 < 0.0)
								{
									Play.刺_心神凝聚 = 0.0;
								}
								break;
							case 7:
								Play.琴师_升天二气功_三潭映月 -= 10.0;
								if (Play.琴师_升天二气功_三潭映月 < 0.0)
								{
									Play.琴师_升天二气功_三潭映月 = 0.0;
								}
								break;
							case 8:
								Play.真武绝击 -= 10.0;
								if (Play.真武绝击 < 0.0)
								{
									Play.真武绝击 = 0.0;
								}
								break;
							case 9:
								Play.谭_怒海狂澜 -= 10.0;
								if (Play.谭_怒海狂澜 < 0.0)
								{
									Play.谭_怒海狂澜 = 0.0;
								}
								break;
							case 12:
								Play.真武绝击 -= 10.0;
								if (Play.真武绝击 < 0.0)
								{
									Play.真武绝击 = 0.0;
								}
								break;
							}
							break;
						case 501502:
							Play.delFLD_追加百分比_防御(vale);
							Play.更新武功和状态();
							break;
						case 501501:
							Play.delFLD_追加百分比_攻击(vale);
							Play.更新武功和状态();
							break;
						case 501401:
							Play.FLD_追加百分比_命中 -= vale;
							if (Play.FLD_追加百分比_命中 < 0.0)
							{
								Play.FLD_追加百分比_命中 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 501402:
							Play.FLD_人物_追加百分比_回避 -= vale;
							if (Play.FLD_人物_追加百分比_回避 < 0.0)
							{
								Play.FLD_人物_追加百分比_回避 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 501403:
							Play.FLD_追加百分比_HP上限 -= vale;
							if (Play.FLD_追加百分比_HP上限 < 0.0)
							{
								Play.FLD_追加百分比_HP上限 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 601101:
							Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
							Play.行走状态id = 1;
							Play.追加状态列表.Remove(FLD_PID);
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新移动速度();
							Dispose();
							return;
						case 601102:
							Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
							Play.行走状态id = 1;
							Play.追加状态列表.Remove(FLD_PID);
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新移动速度();
							Dispose();
							return;
						case 601103:
							Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
							Play.行走状态id = 1;
							Play.追加状态列表.Remove(FLD_PID);
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新移动速度();
							Dispose();
							return;
						case 501601:
							Play.FLD_追加百分比_HP上限 -= vale;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 501602:
							Play.FLD_追加百分比_命中 -= vale;
							Play.更新武功和状态();
							break;
						case 501603:
							Play.FLD_人物_追加百分比_回避 -= vale;
							Play.更新武功和状态();
							break;
						case 700014:
							Play.怒 = false;
							Play.追加状态列表.Remove(FLD_PID);
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							if (Play.检查红月狂风状态())
							{
								Play.FLD_人物_追加_攻击 -= 150;
								Play.FLD_人物_追加_防御 -= 150;
							}
							if (Play.Player_Job == 3)
							{
								Play.delFLD_追加百分比_攻击(vale);
								Play.delFLD_追加百分比_防御(vale);
							}
							else if (Play.Player_Job == 5)
							{
								Play.delFLD_追加百分比_攻击(0.15);
								Play.delFLD_追加百分比_防御(0.2);
							}
							else if (Play.Player_Job == 10)
							{
								Play.delFLD_追加百分比_攻击(vale);
								Play.delFLD_追加百分比_防御(vale);
								Play.拳师会心一击威力 = 0.3;
							}
							else if (Play.Player_Job == 11)
							{
								Play.delFLD_追加百分比_攻击(0.2);
								Play.人物基本最大_障力 = (int)((double)Play.人物基本最大_障力 / 1.2 + 0.5);
								Play.梅_障力运用 -= vale;
								Play.更新HP_MP_SP();
							}
							else
							{
								Play.delFLD_追加百分比_防御(0.25);
								Play.delFLD_追加百分比_攻击(0.25);
							}
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 601202:
							Play.FLD_夫妻辅助_追加_武器_属性 = 0;
							Play.计算人物装备数据();
							Play.更新武功和状态();
							break;
						case 601201:
							Play.FLD_夫妻辅助_追加_防具_属性 = 0;
							Play.计算人物装备数据();
							Play.更新武功和状态();
							break;
						case 700310:
							Play.追加状态列表.Remove(FLD_PID);
							Play.delFLD_追加百分比_防御(0.1);
							Play.FLD_人物_气功_武功攻击力增加百分比 -= 0.3;
							if (Play.FLD_人物_气功_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_气功_武功攻击力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							Dispose();
							return;
						case 700301:
							Play.人物灵兽.FLD_追加百分比_HP上限 -= 0.1;
							Play.人物灵兽.FLD_追加百分比_MP上限 -= 0.1;
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新灵兽HP_MP_SP();
							break;
						case 700302:
							Play.人物灵兽.FLD_灵兽_武功攻击力增加百分比 -= 0.1;
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
							break;
						case 700303:
							Play.人物灵兽.FLD_灵兽_武功防御力增加百分比 -= 0.1;
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
							break;
						case 700201:
							Play.人物灵兽.FLD_追加百分比_回避 -= 0.1;
							Play.人物灵兽.FLD_追加百分比_命中 -= 0.1;
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新灵兽武功和状态();
							break;
						case 700202:
							Play.人物灵兽.dllFLD_追加百分比_攻击(0.1);
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新灵兽武功和状态();
							break;
						case 700203:
							Play.人物灵兽.dllFLD_追加百分比_防御(0.1);
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新灵兽武功和状态();
							break;
						case 801201:
							Play.FLD_攻击速度 = 100;
							Play.更新武功和状态();
							Play.更新攻击速度();
							break;
						case 700401:
							Play.行走状态人物灵兽(BitConverter.GetBytes(FLD_PID), 1);
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 300000);
							break;
						case 700402:
							Play.行走状态人物灵兽(BitConverter.GetBytes(FLD_PID), 1);
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 300000);
							break;
						case 700403:
							Play.行走状态人物灵兽(BitConverter.GetBytes(FLD_PID), 1);
							Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 300000);
							break;
						case 700350:
							Play.追加状态列表.Remove(FLD_PID);
							Play.delFLD_追加百分比_防御(0.2);
							Play.更新武功和状态();
							Dispose();
							return;
						case 900401:
							Play.琴师状态 = 0;
							Play.追加状态列表.Remove(900401);
							Play.更新人物数据(Play);
							Play.状态效果(BitConverter.GetBytes(900401), 0, 0);
							Dispose();
							return;
						case 900402:
							Play.琴师状态 = 0;
							Play.追加状态列表.Remove(900402);
							Play.更新人物数据(Play);
							Play.状态效果(BitConverter.GetBytes(900402), 0, 0);
							Dispose();
							return;
						case 900403:
							Play.琴师状态 = 0;
							Play.追加状态列表.Remove(900403);
							Play.更新人物数据(Play);
							Play.状态效果(BitConverter.GetBytes(900403), 0, 0);
							Dispose();
							return;
						case 801302:
						{
							Play.addFLD_追加百分比_防御(0.2);
							double num4 = Play.FLD_人物_追加百分比_回避 -= 1.0;
							if (Play.FLD_人物_追加百分比_回避 < 0.0)
							{
								Play.FLD_人物_追加百分比_回避 = 0.0;
							}
							Play.更新武功和状态();
							Play.更新攻击速度();
							break;
						}
						case 1001201:
							if (Play.GetAddState(1001101))
							{
								Play.行走状态id = 6;
								Play.行走状态(BitConverter.GetBytes(1001101), 6);
								Play.最大移动速度 = 78f;
							}
							else if (Play.GetAddState(1001102))
							{
								Play.行走状态id = 7;
								Play.行走状态(BitConverter.GetBytes(1001102), 7);
								Play.最大移动速度 = 90f;
							}
							else
							{
								Play.行走状态id = 1;
								Play.行走状态(BitConverter.GetBytes(1001101), 1);
								Play.最大移动速度 = 50f;
								Play.更新移动速度();
							}
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							break;
						case 1001102:
							Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
							Play.行走状态id = 1;
							Play.追加状态列表.Remove(FLD_PID);
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新移动速度();
							Dispose();
							return;
						case 1001101:
							Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
							Play.行走状态id = 1;
							Play.追加状态列表.Remove(FLD_PID);
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							Play.更新移动速度();
							Dispose();
							return;
						case 2001301:
							Play.delFLD_追加百分比_攻击(0.03);
							Play.更新武功和状态();
							break;
						case 1001301:
							Play.FLD_人物_武功攻击力增加百分比 -= 0.05;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 1001302:
							Play.FLD_人物_武功攻击力增加百分比 -= 0.1;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 1001303:
							Play.FLD_人物_武功攻击力增加百分比 -= 0.15;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 1001202:
							if (Play.GetAddState(1001101))
							{
								Play.行走状态id = 6;
								Play.行走状态(BitConverter.GetBytes(1001101), 6);
								Play.最大移动速度 = 78f;
							}
							else if (Play.GetAddState(1001102))
							{
								Play.行走状态id = 7;
								Play.行走状态(BitConverter.GetBytes(1001102), 7);
								Play.最大移动速度 = 90f;
							}
							else
							{
								Play.行走状态id = 1;
								Play.行走状态(BitConverter.GetBytes(1001101), 1);
								Play.最大移动速度 = 50f;
							}
							Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
							break;
						case 9000088:
						case 9000104:
						case 9000105:
						case 9000144:
						case 9000145:
						case 9000168:
						case 9001214:
						case 9009077:
						case 9009092:
						case 9009151:
						case 9009788:
						case 9009789:
						case 9009790:
						case 9009820:
						case 9009964:
							Play.FLD_人物_追加_历练百分比 -= 0.5;
							break;
						case 9000085:
						case 9000120:
						case 9000121:
						case 9000165:
						case 9000166:
						case 9000317:
						case 9001207:
						case 9001211:
						case 9001215:
						case 9009076:
						case 9009150:
						case 9009217:
						case 9009309:
						case 9009839:
						case 9009941:
						case 9009943:
						case 9009965:
						case 9009966:
						case 9009970:
							Play.FLD_人物_追加_经验百分比 -= 0.2;
							break;
						case 900000619:
							Play.安全模式 = 0;
							break;
						case 1000000167:
						case 1000000168:
						case 1000000170:
						case 1000000171:
						case 1000000173:
						case 1000000174:
						case 1000000176:
						case 1000000177:
							if (Play.人物灵兽 != null)
							{
								if (FLD_PID != 1000000167 && FLD_PID != 1000000170 && FLD_PID != 1000000173 && FLD_PID != 1000000176)
								{
									Play.人物灵兽.FLD_物品_追加_HP -= 200;
									Play.人物灵兽.FLD_物品_追加_MP -= 100;
									if (Play.人物灵兽.FLD_HP > Play.人物灵兽.灵兽基本最大_HP)
									{
										Play.人物灵兽.FLD_HP = Play.人物灵兽.灵兽基本最大_HP;
									}
									if (Play.人物灵兽.FLD_MP > Play.人物灵兽.灵兽基本最大_MP)
									{
										Play.人物灵兽.FLD_MP = Play.人物灵兽.灵兽基本最大_MP;
									}
								}
								else
								{
									Play.人物灵兽.FLD_物品_追加_HP -= 100;
									Play.人物灵兽.FLD_物品_追加_MP -= 90;
									if (Play.人物灵兽.FLD_HP > Play.人物灵兽.灵兽基本最大_HP)
									{
										Play.人物灵兽.FLD_HP = Play.人物灵兽.灵兽基本最大_HP;
									}
									if (Play.人物灵兽.FLD_MP > Play.人物灵兽.灵兽基本最大_MP)
									{
										Play.人物灵兽.FLD_MP = Play.人物灵兽.灵兽基本最大_MP;
									}
								}
								Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
								Play.更新灵兽HP_MP_SP();
								if (Play.追加状态列表 != null)
								{
									Play.追加状态列表.Remove(FLD_PID);
								}
								Dispose();
							}
							return;
						case 1000000030:
						{
							double num4 = Play.FLD_人物_追加_历练百分比 -= 1.0;
							if (Play.FLD_人物_追加_历练百分比 < 0.0)
							{
								Play.FLD_人物_追加_历练百分比 = 0.0;
							}
							break;
						}
						case 900000072:
						case 900000073:
						case 900000074:
						case 900000258:
						case 999000163:
						case 999000164:
						case 999000165:
							if (Play.查询天关地图(Play.人物坐标_地图))
							{
								Play.移动(529f, 1528f, 15f, 101);
							}
							break;
						case 1000000776:
							Play.FLD_人物_武功攻击力增加百分比 -= 0.05;
							Play.FLD_人物_武功防御力增加百分比 -= 0.1;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							if (Play.FLD_人物_武功防御力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功防御力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 1000000775:
							Play.FLD_人物_追加_防御 -= 20;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							Play.更新武功和状态();
							break;
						case 1000000408:
							Play.delFLD_追加百分比_攻击(0.1);
							Play.更新武功和状态();
							break;
						case 1000000409:
							Play.人物追加最大_HP -= 500;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1000000410:
							Play.人物追加最大_MP -= 500;
							if (Play.人物_MP > Play.人物最大_MP)
							{
								Play.人物_MP = Play.人物最大_MP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1000000411:
							Play.delFLD_追加百分比_防御(0.1);
							Play.更新武功和状态();
							break;
						case 1000000412:
							Play.delFLD_追加百分比_攻击(0.05);
							Play.更新武功和状态();
							break;
						case 1000000413:
							Play.delFLD_追加百分比_防御(0.05);
							Play.更新武功和状态();
							break;
						case 1000000414:
							Play.FLD_人物_追加百分比_回避 -= 0.05;
							Play.更新武功和状态();
							break;
						case 1000000830:
							Play.人物追加最大_HP -= 100;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1000000831:
							Play.人物追加最大_HP -= 50;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1000000832:
							Play.人物追加最大_HP -= 100;
							Play.人物追加最大_HP -= 100;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							if (Play.人物_MP > Play.人物最大_MP)
							{
								Play.人物_MP = Play.人物最大_MP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1000000835:
							Play.FLD_追加百分比_MP上限 -= 0.05;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1000000836:
							Play.FLD_追加百分比_HP上限 -= 0.05;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1008000016:
							Play.delFLD_追加百分比_攻击(0.1);
							Play.更新武功和状态();
							break;
						case 1008000017:
							Play.delFLD_追加百分比_防御(0.1);
							Play.更新武功和状态();
							break;
						case 1008000018:
							Play.delFLD_装备_追加_武器_强化(2);
							Play.追加状态列表.Remove(FLD_PID);
							num = 1;
							Play.计算人物装备数据();
							num = 2;
							Play.更新武功和状态();
							num = 3;
							break;
						case 1008000019:
							num = 4;
							Play.delFLD_装备_追加_防具_强化(1);
							Play.追加状态列表.Remove(FLD_PID);
							num = 5;
							Play.计算人物装备数据();
							num = 6;
							Play.更新武功和状态();
							num = 7;
							break;
						case 1007000005:
							Play.人物追加最大_HP -= 300;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1007000006:
							Play.人物追加最大_HP -= 500;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1007000007:
							Play.人物追加最大_HP -= 700;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							break;
						case 1008000054:
							Play.FLD_人物_武功防御力增加百分比 -= 0.1;
							if (Play.FLD_人物_武功防御力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功防御力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 1008000053:
							Play.FLD_人物_武功攻击力增加百分比 -= 0.1;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.更新武功和状态();
							break;
						case 1008000183:
							Play.追加状态列表.Remove(1008000183);
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.delFLD_追加百分比_防御(0.05);
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 1008000156:
							Play.追加状态列表.Remove(1008000156);
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 1008000095:
							Play.FLD_人物_追加_经验百分比 -= 0.2;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008000096:
							Play.FLD_人物_追加_经验百分比 -= 0.3;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008000097:
							Play.FLD_人物_追加_经验百分比 -= 0.4;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008000195:
						{
							Play.追加状态列表.Remove(1008000195);
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.delFLD_追加百分比_防御(0.05);
							int num3 = --Play.FLD_人物_追加_气功;
							if (Play.FLD_人物_追加_气功 < 0)
							{
								Play.FLD_人物_追加_气功 = 0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新气功();
							Play.更新HP_MP_SP();
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						}
						case 1008000188:
							Play.追加状态列表.Remove(1008000188);
							Play.delFLD_追加百分比_攻击(0.15);
							Play.delFLD_追加百分比_防御(0.15);
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.人物追加最大_MP -= 300;
							if (Play.人物追加最大_MP < 0)
							{
								Play.人物追加最大_MP = 0;
							}
							Play.FLD_人物_追加_经验百分比 -= 0.1;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 1008000187:
						{
							Play.追加状态列表.Remove(1008000187);
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							int num3 = --Play.FLD_人物_追加_气功;
							if (Play.FLD_人物_追加_气功 < 0)
							{
								Play.FLD_人物_追加_气功 = 0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新气功();
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Play.更新HP_MP_SP();
							Dispose();
							return;
						}
						case 1008000321:
							Play.FLD_人物_追加_经验百分比 -= 0.4;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008000322:
							Play.FLD_人物_追加_经验百分比 -= 0.4;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008000323:
						{
							double num4 = Play.FLD_人物_追加_经验百分比 -= 1.0;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						}
						case 1008000324:
						{
							double num4 = Play.FLD_人物_追加_经验百分比 -= 1.0;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						}
						case 1008000325:
							Play.FLD_人物_追加_经验百分比 -= 0.1;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 40;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_追加_防御 -= 40;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.05;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.妖花青草 = false;
							Play.更新HP_MP_SP();
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000326:
							Play.FLD_人物_追加_经验百分比 -= 0.1;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 40;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_追加_防御 -= 40;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.05;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.妖花青草 = false;
							Play.更新HP_MP_SP();
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000304:
							Play.FLD_人物_追加_经验百分比 -= 0.05;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 30;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_追加_防御 -= 30;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.03;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000305:
							Play.FLD_人物_追加_经验百分比 -= 0.05;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 30;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_追加_防御 -= 30;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.03;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000306:
							Play.FLD_人物_追加_经验百分比 -= 0.1;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 40;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_追加_防御 -= 40;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.05;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000307:
							Play.FLD_人物_追加_经验百分比 -= 0.1;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 40;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_追加_防御 -= 40;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.05;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000232:
							Play.追加状态列表.Remove(1008000232);
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.FLD_人物_追加_经验百分比 -= 0.1;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_获得游戏币百分比 -= 0.4;
							if (Play.FLD_人物_追加_获得游戏币百分比 < 0.0)
							{
								Play.FLD_人物_追加_获得游戏币百分比 = 0.0;
							}
							Play.FLD_人物_追加_物品掉落概率百分比 -= 0.2;
							if (Play.FLD_人物_追加_物品掉落概率百分比 < 0.0)
							{
								Play.FLD_人物_追加_物品掉落概率百分比 = 0.0;
							}
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 1008000239:
						{
							double num4 = Play.FLD_人物_追加_经验百分比 -= 1.0;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						}
						case 1008000240:
							Play.FLD_人物_追加_经验百分比 -= 0.05;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 30;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.03;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000241:
							Play.FLD_人物_追加_经验百分比 -= 0.05;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 30;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.03;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000242:
							Play.FLD_人物_追加_经验百分比 -= 0.05;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 30;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.03;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000243:
							Play.delFLD_追加百分比_攻击(0.2);
							Play.delFLD_追加百分比_防御(0.2);
							Play.人物追加最大_HP -= 200;
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.FLD_人物_追加_经验百分比 -= 0.15;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.05;
							break;
						case 1008000245:
						{
							Play.追加状态列表.Remove(1008000245);
							Play.人物追加最大_HP -= 300;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.FLD_人物_追加_回避 -= (int)((double)Play.FLD_回避 * 0.05);
							if (Play.FLD_人物_追加_回避 < 0)
							{
								Play.FLD_人物_追加_回避 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.1;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							int num3 = --Play.FLD_人物_追加_气功;
							if (Play.FLD_人物_追加_气功 < 0)
							{
								Play.FLD_人物_追加_气功 = 0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新气功();
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Play.更新HP_MP_SP();
							Dispose();
							return;
						}
						case 1008000248:
						{
							double num4 = Play.FLD_人物_追加_经验百分比 -= 1.0;
							num4 = (Play.FLD_人物_追加_获得游戏币百分比 -= 1.0);
							num4 = (Play.FLD_人物_追加_物品掉落概率百分比 -= 1.0);
							num4 = (Play.FLD_人物_追加_历练百分比 -= 1.0);
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						}
						case 1008000250:
							Play.FLD_人物_追加_经验百分比 -= 0.05;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 30;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.03;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000251:
							Play.FLD_人物_追加_经验百分比 -= 0.05;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							Play.FLD_人物_追加_攻击 -= 30;
							if (Play.FLD_人物_追加_攻击 < 0)
							{
								Play.FLD_人物_追加_攻击 = 0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.03;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							Play.妖花青草 = false;
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008000252:
						{
							Play.追加状态列表.Remove(1008000252);
							int num3 = --Play.FLD_人物_追加_防御;
							if (Play.FLD_人物_追加_防御 < 0)
							{
								Play.FLD_人物_追加_防御 = 0;
							}
							num3 = --Play.人物追加最大_HP;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							num3 = --Play.FLD_人物_追加_回避;
							if (Play.FLD_人物_追加_回避 < 0)
							{
								Play.FLD_人物_追加_回避 = 0;
							}
							Play.FLD_人物_武功防御力增加百分比 -= 0.01;
							if (Play.FLD_人物_武功防御力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功防御力增加百分比 = 0.0;
							}
							Play.FLD_人物_武功攻击力增加百分比 -= 0.2;
							if (Play.FLD_人物_武功攻击力增加百分比 < 0.0)
							{
								Play.FLD_人物_武功攻击力增加百分比 = 0.0;
							}
							if (Play.人物_HP > Play.人物最大_HP)
							{
								Play.人物_HP = Play.人物最大_HP;
							}
							Play.更新HP_MP_SP();
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						}
						case 1008000388:
							Play.FLD_人物_追加_经验百分比 -= 3.0;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008000363:
							Play.FLD_人物_追加_经验百分比 -= 1.5;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008000362:
							Play.FLD_人物_追加_经验百分比 -= 1.5;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1008001111:
							Play.人物追加最大_HP -= 500;
							Play.人物追加最大_MP -= 500;
							Play.FLD_人物_追加_经验百分比 -= 0.04;
							Play.FLD_人物_追加_攻击 -= 50;
							Play.FLD_人物_追加_防御 -= 100;
							Play.FLD_人物_武功攻击力增加百分比 -= 0.1;
							Play.妖花青草 = false;
							Play.更新HP_MP_SP();
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008001021:
						case 1008001022:
						case 1008001023:
						case 1008001024:
						case 1008001025:
						case 1008001026:
						case 1008001027:
						case 1008001028:
						case 1008001029:
						case 1008001030:
							Play.追加状态列表.Remove(FLD_PID);
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Play.计算人物装备数据();
							break;
						case 1008000389:
							Play.FLD_人物_追加_经验百分比 -= 1.5;
							if (Play.FLD_人物_追加_经验百分比 < 0.0)
							{
								Play.FLD_人物_追加_经验百分比 = 0.0;
							}
							break;
						case 1000000891:
						case 1000000892:
						case 1000000893:
						case 1008001382:
						case 1008001383:
						case 1008001384:
						case 1008001385:
							switch (Play.FLD_爱情度等级)
							{
							case 1:
							{
								Play.人物追加最大_HP -= 150;
								Play.FLD_人物_追加_攻击 -= 15;
								Play.FLD_人物_追加_防御 -= 15;
								int num2 = --Play.FLD_人物_追加_气功;
								Play.FLD_人物_追加_经验百分比 -= 0.05;
								Play.更新气功();
								break;
							}
							case 2:
							{
								Play.人物追加最大_HP -= 150;
								Play.FLD_人物_追加_攻击 -= 15;
								Play.FLD_人物_追加_防御 -= 15;
								int num2 = --Play.FLD_人物_追加_气功;
								Play.更新气功();
								break;
							}
							case 3:
								Play.人物追加最大_HP -= 150;
								Play.FLD_人物_追加_攻击 -= 15;
								Play.FLD_人物_追加_防御 -= 15;
								break;
							case 4:
								Play.人物追加最大_HP -= 150;
								Play.FLD_人物_追加_攻击 -= 10;
								Play.FLD_人物_追加_防御 -= 10;
								break;
							case 5:
								Play.人物追加最大_HP -= 150;
								Play.FLD_人物_追加_攻击 -= 10;
								Play.FLD_人物_追加_防御 -= 5;
								break;
							case 6:
								Play.人物追加最大_HP -= 150;
								Play.FLD_人物_追加_攻击 -= 5;
								Play.FLD_人物_追加_防御 -= 5;
								break;
							case 7:
								Play.人物追加最大_HP -= 150;
								Play.FLD_人物_追加_攻击 -= 5;
								break;
							case 8:
								Play.人物追加最大_HP -= 150;
								break;
							case 9:
								Play.人物追加最大_HP -= 100;
								break;
							case 10:
								Play.人物追加最大_HP -= 50;
								break;
							}
							Play.更新武功和状态();
							Play.更新HP_MP_SP();
							break;
						case 1008001169:
							Play.追加状态列表.Remove(FLD_PID);
							Play.addFLD_追加百分比_防御(0.15);
							Play.更新武功和状态();
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 1008001170:
							Play.追加状态列表.Remove(FLD_PID);
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 1008001171:
							Play.怒 = false;
							Play.追加状态列表.Remove(FLD_PID);
							Play.delFLD_追加百分比_防御(0.25);
							Play.delFLD_追加百分比_攻击(0.25);
							Play.状态效果(BitConverter.GetBytes(700014), 0, 0);
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Play.更新武功和状态();
							Dispose();
							return;
						case 1008001172:
							if (Play.怒)
							{
								Play.FLD_人物_追加_攻击 -= 150;
								Play.FLD_人物_追加_防御 -= 150;
								Play.更新武功和状态();
							}
							break;
						case 1008001173:
							Play.FLD_人物_追加_攻击 -= 100;
							Play.FLD_人物_追加_防御 -= 100;
							Play.人物追加最大_HP -= 1000;
							Play.人物追加最大_MP -= 1000;
							Play.更新HP_MP_SP();
							Play.更新武功和状态();
							break;
						case 1008001174:
							Play.人物追加最大_HP -= 1000;
							if (Play.人物追加最大_HP < 0)
							{
								Play.人物追加最大_HP = 0;
							}
							Play.更新HP_MP_SP();
							break;
						case 1008001175:
							Play.delFLD_追加百分比_防御(0.1);
							Play.更新武功和状态();
							break;
						case 1008001176:
							Play.FLD_追加哀鸿片野_HP上限 += 0.15;
							Play.追加状态列表.Remove(FLD_PID);
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Play.更新HP_MP_SP();
							Dispose();
							return;
						case 1008001112:
							Play.人物追加最大_HP -= 800;
							Play.FLD_人物_追加_回避 -= 10;
							Play.FLD_人物_追加_武功防御力 -= 100.0 / World.武功防御力控制;
							Play.FLD_人物_追加_攻击 -= 100;
							Play.FLD_人物_追加_防御 -= 50;
							Play.FLD_人物_武功攻击力增加百分比 -= 0.1;
							Play.妖花青草 = false;
							Play.更新HP_MP_SP();
							Play.更新广播人物数据();
							Play.更新人物数据(Play);
							Play.更新装备效果();
							break;
						case 1008002169:
							Play.更新武功和状态();
							break;
						case 1008002012:
							Play.追加状态列表.Remove(FLD_PID);
							Play.更新人物数据(Play);
							Play.更新广播人物数据();
							Dispose();
							return;
						case 1008001814:
							Play.FLD_追加百分比_攻击 -= 0.28;
							Play.FLD_人物_追加_攻击 -= 80;
							Play.FLD_追加百分比_防御 -= 0.3;
							Play.FLD_人物_追加_防御 -= 80;
							Play.人物追加最大_HP -= 3000;
							Play.FLD_人物_武功攻击力增加百分比 -= 0.35;
							Play.FLD_人物_武功防御力增加百分比 -= 0.23;
							Play.FLD_人物_追加_经验百分比 -= 2.1;
							Play.FLD_人物_追加_吸魂几率百分比 -= 10.0;
							Play.更新武功和状态();
							break;
						}
						num = 8;
						num = 9;
						if (Play.GetAddState(FLD_PID))
						{
							Play.追加状态列表.Remove(FLD_PID);
						}
						num = 10;
						Play.状态效果(BitConverter.GetBytes(FLD_PID), 0, 0);
						num = 11;
						Dispose();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "追加状态类 时间结束事件 出错：" + num + "[" + FLD_PID + "]" + ((ex != null) ? ex.ToString() : null));
					}
					finally
					{
						Dispose();
					}
					return;
				}
				if (Play.追加状态列表 != null)
				{
					Play.追加状态列表.Clear();
				}
				Dispose();
			}
			else
			{
				Dispose();
			}
		}

		public int getsj()
		{
			return (int)time.Subtract(DateTime.Now).TotalMilliseconds;
		}
	}
}
