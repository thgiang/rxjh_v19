using RxjhServer.DbClss;
using RxjhServer.HelperTools;
using RxjhServer.Network;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;

namespace RxjhServer
{
	public class NpcClass : IDisposable
	{
		private static PlayGjClass asfd = new PlayGjClass();

		private object AsyncLocksw = new object();

		private ArrayList tem = new ArrayList();

		public Reverser<PlayGjClass> reverser = new Reverser<PlayGjClass>(asfd.GetType(), "Gjsl", ReverserInfo.Direction.DESC);

		private List<PlayGjClass> PlayGjList = new List<PlayGjClass>();

		private ThreadSafeDictionary<int, Players> PlayList;

		public System.Timers.Timer 自动移动;

		public System.Timers.Timer 自动攻击;

		public System.Timers.Timer 自动复活;

		private static Random Ran;

		public Dictionary<int, 异常状态类> 异常状态;

		public Dictionary<int, 异常掉血状态类> 异常掉血状态;

		private 灵兽类 _PlayCw;

		private float _FLD_FACE1;

		private float _FLD_FACE2;

		private int _IsNpc;

		private string _Name;

		private int _FLD_INDEX;

		private int _FLD_PID;

		private double _FLD_AT;

		private float _Rxjh_X;

		private float _Rxjh_Y;

		private float _Rxjh_Z;

		private float _Rxjh_cs_X;

		private float _Rxjh_cs_Y;

		private float _Rxjh_cs_Z;

		private int _Rxjh_Map;

		private int _Rxjh_Exp;

		private int _Max_Rxjh_HP;

		private int _Rxjh_HP;

		private int _Level;

		private double _FLD_DF;

		private int _FLD_AUTO;

		private int _FLD_BOSS;

		private int _FLD_NEWTIME;

		private bool _NPC死亡;

		private bool _一次性怪;

		public 灵兽类 PlayCw
		{
			get
			{
				return _PlayCw;
			}
			set
			{
				_PlayCw = value;
			}
		}

		public ThreadSafeDictionary<int, Players> _PlayList
		{
			get
			{
				return PlayList;
			}
		}

		public List<PlayGjClass> PlayGj
		{
			get
			{
				return PlayGjList;
			}
			set
			{
				PlayGjList = value;
			}
		}

		public int PlayerWid
		{
			get
			{
				if (PlayGjList.Count <= 0)
				{
					return 0;
				}
				try
				{
					PlayGjList.Sort(new Reverser<PlayGjClass>(new PlayGjClass().GetType(), "Gjsl", ReverserInfo.Direction.DESC));
					return PlayGjList[0].PlayID;
				}
				catch (Exception)
				{
					return 0;
				}
			}
		}

		public int BossPlayerWid
		{
			get
			{
				if (PlayGjList.Count <= 0)
				{
					return 0;
				}
				try
				{
					int num = 0;
					int index;
					while (true)
					{
						index = RNG.Next(0, PlayGjList.Count - 1);
						if (PlayGjList[index].Gjxl >= 100000)
						{
							break;
						}
						num++;
						if (num >= PlayGjList.Count)
						{
							PlayGjList.Sort(new Reverser<PlayGjClass>(new PlayGjClass().GetType(), "Gjsl", ReverserInfo.Direction.DESC));
							return PlayGjList[0].PlayID;
						}
					}
					return PlayGjList[index].PlayID;
				}
				catch (Exception)
				{
					return 0;
				}
			}
		}

		public float FLD_FACE1
		{
			get
			{
				return _FLD_FACE1;
			}
			set
			{
				_FLD_FACE1 = value;
			}
		}

		public float FLD_FACE2
		{
			get
			{
				return _FLD_FACE2;
			}
			set
			{
				_FLD_FACE2 = value;
			}
		}

		public int IsNpc
		{
			get
			{
				return _IsNpc;
			}
			set
			{
				_IsNpc = value;
			}
		}

		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
			}
		}

		public int FLD_INDEX
		{
			get
			{
				return _FLD_INDEX;
			}
			set
			{
				_FLD_INDEX = value;
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

		public double FLD_AT
		{
			get
			{
				return _FLD_AT;
			}
			set
			{
				_FLD_AT = value;
			}
		}

		public float Rxjh_X
		{
			get
			{
				return _Rxjh_X;
			}
			set
			{
				_Rxjh_X = value;
			}
		}

		public float Rxjh_Y
		{
			get
			{
				return _Rxjh_Y;
			}
			set
			{
				_Rxjh_Y = value;
			}
		}

		public float Rxjh_Z
		{
			get
			{
				return _Rxjh_Z;
			}
			set
			{
				_Rxjh_Z = value;
			}
		}

		public float Rxjh_cs_X
		{
			get
			{
				return _Rxjh_cs_X;
			}
			set
			{
				_Rxjh_cs_X = value;
			}
		}

		public float Rxjh_cs_Y
		{
			get
			{
				return _Rxjh_cs_Y;
			}
			set
			{
				_Rxjh_cs_Y = value;
			}
		}

		public float Rxjh_cs_Z
		{
			get
			{
				return _Rxjh_cs_Z;
			}
			set
			{
				_Rxjh_cs_Z = value;
			}
		}

		public int Rxjh_Map
		{
			get
			{
				return _Rxjh_Map;
			}
			set
			{
				_Rxjh_Map = value;
			}
		}

		public int Rxjh_Exp
		{
			get
			{
				return _Rxjh_Exp;
			}
			set
			{
				_Rxjh_Exp = value;
			}
		}

		public int Max_Rxjh_HP
		{
			get
			{
				return _Max_Rxjh_HP;
			}
			set
			{
				_Max_Rxjh_HP = value;
			}
		}

		public int Rxjh_HP
		{
			get
			{
				return _Rxjh_HP;
			}
			set
			{
				_Rxjh_HP = value;
			}
		}

		public int Level
		{
			get
			{
				return _Level;
			}
			set
			{
				_Level = value;
			}
		}

		public double FLD_DF
		{
			get
			{
				return _FLD_DF;
			}
			set
			{
				_FLD_DF = value;
			}
		}

		public int FLD_AUTO
		{
			get
			{
				return _FLD_AUTO;
			}
			set
			{
				_FLD_AUTO = value;
			}
		}

		public int FLD_BOSS
		{
			get
			{
				return _FLD_BOSS;
			}
			set
			{
				_FLD_BOSS = value;
			}
		}

		public int FLD_NEWTIME
		{
			get
			{
				return _FLD_NEWTIME;
			}
			set
			{
				_FLD_NEWTIME = value;
			}
		}

		public bool NPC死亡
		{
			get
			{
				return _NPC死亡;
			}
			set
			{
				_NPC死亡 = value;
			}
		}

		public bool 一次性怪
		{
			get
			{
				return _一次性怪;
			}
			set
			{
				_一次性怪 = value;
			}
		}

		public NpcClass()
		{
			Ran = new Random(DateTime.Now.Millisecond);
			PlayList = new ThreadSafeDictionary<int, Players>();
			double interval = Ran.Next(3000, 15000);
			自动移动 = new System.Timers.Timer(interval);
			自动移动.Elapsed += 自动移动事件;
			自动移动.AutoReset = true;
			自动移动.Enabled = true;
			自动攻击 = new System.Timers.Timer(1000.0);
			自动攻击.Elapsed += 自动攻击事件;
			自动攻击.AutoReset = true;
			异常状态 = new Dictionary<int, 异常状态类>();
			异常掉血状态 = new Dictionary<int, 异常掉血状态类>();
		}

		public void Cw_Add(灵兽类 灵兽)
		{
			foreach (PlayGjClass playGj in PlayGjList)
			{
				if (playGj.PlayID == 灵兽.全服ID)
				{
					int num = ++playGj.Gjsl;
					return;
				}
			}
			PlayGjList.Add(new PlayGjClass
			{
				Gjsl = 1,
				PlayID = 灵兽.全服ID
			});
			PlayCw = 灵兽;
		}

		public void PlayList_Add(Players Play)
		{
			if (!Play.Client.挂机 && !Contains(Play))
			{
				PlayList.Add(Play.人物全服ID, Play);
			}
		}

		public void PlayList_Remove(Players payer)
		{
			if (Contains(payer))
			{
				PlayList.Remove(payer.人物全服ID);
			}
		}

		public bool Contains(Players payer)
		{
			Players value;
			if (PlayList != null && PlayList.Count != 0)
			{
				return PlayList.TryGetValue(payer.人物全服ID, out value);
			}
			return false;
		}

		public void Play_dell(Players payer)
		{
		}

		public void Play_Add(Players payer, int 血量)
		{
			if (血量 >= 0 && IsNpc != 1)
			{
				using (new Lock(AsyncLocksw, "Play_Add"))
				{
					foreach (PlayGjClass playGj in PlayGjList)
					{
						if (playGj.PlayID == payer.人物全服ID)
						{
							int num = ++playGj.Gjsl;
							playGj.Gjxl += 血量;
							if (playGj.Gjxl >= Max_Rxjh_HP)
							{
								playGj.Gjxl = Max_Rxjh_HP;
							}
							return;
						}
					}
					PlayGjClass playGjClass = new PlayGjClass();
					playGjClass.Gjsl = 1;
					playGjClass.Gjxl = 血量;
					if (playGjClass.Gjxl >= Max_Rxjh_HP)
					{
						playGjClass.Gjxl = Max_Rxjh_HP;
					}
					playGjClass.PlayID = payer.人物全服ID;
					PlayGjList.Add(playGjClass);
					if (PlayGjList[0].PlayID == payer.人物全服ID && playGjClass.Gjxl > 0)
					{
						发送移动数据(payer.人物坐标_X, payer.人物坐标_Y, 10, 2);
					}
				}
			}
		}

		public void Play_null()
		{
			if (PlayGjList != null && PlayGjList.Count > 0)
			{
				PlayGjList.Clear();
			}
		}

		public void 获取范围玩家发送增加数据包()
		{
			try
			{
				foreach (Players value in World.allConnectedChars.Values)
				{
					if (查找范围玩家(400, value))
					{
						value.获取复查范围Npc();
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "获取范围玩家发送地面增加Npc数据包   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void Dispose()
		{
			try
			{
				MapClass.delnpc(Rxjh_Map, FLD_INDEX);
				if (自动攻击 != null)
				{
					自动攻击.Enabled = false;
					自动攻击.Close();
					自动攻击.Dispose();
				}
				if (自动移动 != null)
				{
					自动移动.Enabled = false;
					自动移动.Close();
					自动移动.Dispose();
				}
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
				Play_null();
				if (PlayCw != null)
				{
					PlayCw = null;
				}
				获取范围玩家发送消失数据包();
				if (tem != null)
				{
					tem.Clear();
				}
				if (PlayList != null)
				{
					PlayList.Dispose();
					PlayList = null;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "NPC   关闭数据Dispose()   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 获取范围玩家发送消失数据包()
		{
			try
			{
				foreach (Players value in PlayList.Values)
				{
					if (value.Client != null)
					{
						value.获取复查范围Npc();
					}
				}
				if (PlayList != null)
				{
					PlayList.Clear();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "NPC   获取范围玩家发送消失数据包3   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		~NpcClass()
		{
		}

		public bool ContainsKeyInAbnormalState(int Key)
		{
			异常状态类 value;
			if (异常状态 != null && 异常状态.Count != 0)
			{
				return 异常状态.TryGetValue(Key, out value);
			}
			return false;
		}

		public void getbl()
		{
			if (PlayList.Count > 0)
			{
				Form1.WriteLine(2, _Name + "   人物：" + PlayList.Count);
				if (自动移动 != null)
				{
					Form1.WriteLine(2, _Name + "   人物_自动移动：" + 自动移动.Enabled);
				}
				if (自动攻击 != null)
				{
					Form1.WriteLine(2, _Name + "   人物_自动攻击：" + 自动攻击.Enabled);
				}
				if (自动复活 != null)
				{
					Form1.WriteLine(2, _Name + "   人物_自动复活：" + 自动复活.Enabled);
				}
			}
			if (PlayGjList.Count > 0)
			{
				Form1.WriteLine(2, _Name + "   攻击：" + PlayGjList.Count);
			}
			if (PlayCw != null)
			{
				Form1.WriteLine(2, _Name + "   灵兽：" + PlayCw.Name + "主人名：" + PlayCw.ZrName);
			}
		}

		public int 获得经验()
		{
			int num = Rxjh_Exp * World.经验倍数;
			int num2 = num / 3;
			return new Random(DateTime.Now.Millisecond).Next(num - num2, num + num2);
		}

		public int 获得钱()
		{
			int num = Rxjh_Exp * World.钱倍数 / 10;
			int num2 = num / 3;
			return new Random(DateTime.Now.Millisecond).Next(num - num2, num + num2);
		}

		public int 获得历练()
		{
			try
			{
				int num = Rxjh_Exp * World.历练倍数 / Level / 2;
				int num2 = num / 3;
				return (int)((double)new Random().Next(num - num2, num + num2) * (1.0 - World.历练获得降低百分比));
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "获得历练()错误" + ex.Message);
				return 0;
			}
		}

		public int 获得升天历练()
		{
			try
			{
				int num = (int)((double)Rxjh_Exp * World.升天历练倍数);
				int num2 = num / 3;
				return new Random().Next(num - num2, num + num2);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "获得升天历练()   错误" + ex.Message);
				return 0;
			}
		}

		private void 自动移动事件(object sender, ElapsedEventArgs e)
		{
			if (World.jlMsg == 1)
			{
				Form1.WriteLine(0, "自动移动事件");
			}
			try
			{
				if (IsNpc != 0)
				{
					自动移动.Enabled = false;
				}
				else if (PlayList.Count >= 1 && !NPC死亡)
				{
					if (IsNpc != 1 && FLD_AT > 0.0)
					{
						自动移动.Interval = new Random(DateTime.Now.Millisecond).Next(3000, 15000);
						if (FLD_AUTO == 1 && 获取范围玩家())
						{
							自动移动.Enabled = false;
							自动攻击.Enabled = true;
						}
						else if (FLD_PID != 16431 && FLD_PID != 16430 && FLD_PID != 16435)
						{
							发送移动数据(Rxjh_cs_X, Rxjh_cs_Y, (FLD_PID != 5) ? 50 : 20, 1);
						}
						else
						{
							自动移动.Enabled = false;
							自动攻击.Enabled = false;
						}
					}
					else
					{
						自动移动.Interval = 20000.0;
						foreach (Players value in PlayList.Values)
						{
							if (value.Client != null)
							{
								if (!World.allConnectedChars.ContainsKey(value.Client.WorldId))
								{
									tem.Add(value);
								}
							}
							else
							{
								tem.Add(value);
							}
						}
						foreach (Players item in tem)
						{
							Form1.WriteLine(2, "NPC广播数据 删除卡号人物：[" + item.Userid + "] [" + item.UserName + "]");
							if (item.Client != null)
							{
								item.Client.Dispose();
							}
							PlayList.Remove(item.人物全服ID);
						}
						tem.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "自动移动事件 出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		private void 自动复活事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if (IsNpc == 1)
				{
					自动复活.Enabled = false;
				}
				else
				{
					自动移动.Enabled = true;
					if (NPC死亡)
					{
						更新NPC复活数据();
					}
				}
			}
			catch (Exception ex)
			{
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
				Form1.WriteLine(1, "自动复活事件1   出错：" + ((ex != null) ? ex.ToString() : null));
			}
			finally
			{
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
			}
		}

		private void 自动攻击事件(object sender, ElapsedEventArgs e)
		{
			try
			{
				if (IsNpc != 0)
				{
					自动攻击.Enabled = false;
				}
				else if (Rxjh_HP < 0)
				{
					自动攻击.Enabled = false;
				}
				else if (!(FLD_AT <= 0.0))
				{
					int num = (int)(FLD_AT * 0.8);
					Random random = new Random(DateTime.Now.Millisecond);
					自动攻击.Interval = random.Next(1000, 3000);
					int num2 = random.Next(num - 8, num + 8);
					Players value;
					if (PlayList.TryGetValue(PlayerWid, out value))
					{
						if (value.人物_HP > 0 && !value.Player死亡 && value.GM模式 != 8)
						{
							int num3 = 28;
							if (!value.检查毒蛇出洞状态() && value.Player_Job == 12)
							{
								value.触发属性提升 = 0;
								if (value.牢不可破 >= (double)RNG.Next(0, 100))
								{
									value.触发属性提升 = 1;
									value.计算人物装备数据();
									value.显示大字(value.人物全服ID, 1010);
								}
							}
							double num4 = (double)(value.FLD_人物基本_防御New + value.装备追加对怪防御 + value.药品追加对怪攻击) + value.升天五式_魔魂之力;
							bool flag = false;
							if (value.FLD_装备_追加_降低百分比攻击 > 0.0)
							{
								num2 = (int)((double)num2 * (1.0 - value.FLD_装备_追加_降低百分比攻击));
							}
							if (Level >= 60)
							{
								switch (RNG.Next(0, 10))
								{
								case 1:
									num3 = 28;
									break;
								case 2:
									num3 = 29;
									break;
								case 4:
									num3 = 29;
									break;
								}
								if (num3 == 29)
								{
									num2 = (int)((double)num2 * 1.2);
								}
							}
							if (value.中级附魂_移星 != 0 && (double)RNG.Next(1, 79) <= (double)value.中级附魂_移星)
							{
								value.显示大字(value.人物全服ID, 405);
							}
							if (value.Player_Job == 3 && (double)RNG.Next(0, 100) <= value.枪_转攻为守)
							{
								value.显示大字(value.人物全服ID, 130);
								num4 += (double)value.FLD_攻击;
							}
							if (value.Player_Job == 12 && (double)RNG.Next(0, 100) <= value.卢_转攻为守)
							{
								value.显示大字(value.人物全服ID, 130);
								num4 += (double)value.FLD_攻击 / 2.0;
							}
							if (value.Player_Job == 10)
							{
								if ((double)RNG.Next(0, 100) <= value.拳师_转攻为守)
								{
									value.显示大字(value.人物全服ID, 130);
									num4 += (double)value.FLD_攻击;
								}
								if (num3 == 29 && (double)RNG.Next(1, 100) <= value.拳师_金刚不坏)
								{
									value.显示大字(value.人物全服ID, 554);
									num2 = (int)((double)num2 * 0.1);
								}
								if ((double)RNG.Next(1, 100) <= value.升天五式_不死之躯)
								{
									value.显示大字(value.人物全服ID, 1021);
									num2 = 0;
								}
							}
							if (value.中级附魂_护体 != 0 && RNG.Next(1, 50) <= value.中级附魂_护体)
							{
								value.显示大字(value.人物全服ID, 406);
								value.人物_MP += num2;
								value.更新HP_MP_SP();
								num2 = 0;
							}
							int num5 = (!((double)num2 > num4)) ? 1 : (num2 - (int)num4);
							if (查找范围玩家(20, value))
							{
								if (value.中级附魂_混元 != 0 && RNG.Next(1, 50) <= value.中级附魂_混元)
								{
									value.显示大字(value.人物全服ID, 407);
									num5 = (int)((double)num5 * 0.5);
								}
								if (value.FLD_装备_降低_伤害值 > 0.0)
								{
									num5 -= (int)value.FLD_装备_降低_伤害值;
								}
								if (value.Player_Job == 2)
								{
									double num6 = num5;
									if ((double)RNG.Next(1, 110) <= value.剑_升天三气功_护身罡气)
									{
										value.显示大字(value.人物全服ID, 25);
										num5 = (int)(num6 * 0.5);
									}
									if ((double)RNG.Next(1, 100) <= value.剑_回柳身法)
									{
										num5 = 0;
									}
								}
								else if (value.Player_Job == 6)
								{
									if ((double)RNG.Next(1, 110) <= value.刺_三花聚顶)
									{
										value.刺_连消带打数量 = (double)num5 * value.刺_连消带打;
										num5 = 0;
									}
									if ((double)RNG.Next(1, 110) <= value.刺_升天一气功_夜魔缠身)
									{
										num5 = (int)((double)num5 * 0.7);
										value.显示大字(value.人物全服ID, 370);
									}
									if ((double)RNG.Next(1, 100) <= value.刺_升天二气功_顺水推舟)
									{
										value.加血((int)((double)num5 * 0.2));
										value.显示大字(value.人物全服ID, 371);
									}
								}
								else if (value.Player_Job == 9)
								{
									double num7 = num5;
									if ((double)RNG.Next(1, 100) <= value.谭_护身罡气)
									{
										value.显示大字(value.人物全服ID, 25);
										num5 = (int)(num7 * 0.5);
									}
									if ((double)RNG.Next(1, 100) <= value.谭_回柳身法)
									{
										num5 = 0;
									}
								}
								if (num5 <= 0)
								{
									num5 = RNG.Next(0, 5);
								}
								int num8 = 0;
								if (value.Player_Job == 11 && value.梅_障力激活 > 0.0)
								{
									num8 = (int)((double)num5 * (value.梅_障力激活 * 2.0 * 0.01));
									if (num8 > value.人物_AP)
									{
										num8 = value.人物_AP;
									}
									value.人物_AP -= num8;
								}
								int num9 = num5 - num8;
								发送攻击数据(num9, num3, value.人物全服ID, num8);
								value.人物_HP -= num9;
								if (value.Player_Job != 1 && value.Player_Job != 7)
								{
									if (value.Player_Job == 2)
									{
										if ((double)RNG.Next(1, 100) <= value.剑_升天三气功_火凤临朝 && value.人物_HP <= 0)
										{
											value.人物_HP = 10;
											value.显示大字(value.人物全服ID, 322);
										}
										if ((double)num9 <= num4)
										{
											if (!value.怒)
											{
												int num10 = ++value.人物_SP;
											}
										}
										else if (!value.怒)
										{
											value.人物_SP += 2;
										}
									}
									else if (value.Player_Job == 3)
									{
										if (value.枪_狂神降世 != 0.0)
										{
											if (!value.怒)
											{
												value.人物_SP += (int)(3.0 + (double)(value.Player_Level * 2) * value.枪_狂神降世);
											}
										}
										else if ((double)num9 <= num4)
										{
											if (!value.怒)
											{
												int num10 = ++value.人物_SP;
											}
										}
										else if (!value.怒)
										{
											value.人物_SP += 2;
										}
									}
									else if (value.Player_Job == 6)
									{
										if (value.刺_荆轲之怒 != 0.0)
										{
											value.人物_SP += (int)(3.0 + (double)value.Player_Level * 0.5 * 0.01 * value.刺_荆轲之怒);
										}
										else if ((double)num9 <= num4)
										{
											int num10 = ++value.人物_SP;
										}
										else
										{
											value.人物_SP += 2;
										}
									}
									else if (value.Player_Job == 8)
									{
										if ((double)num9 <= num4)
										{
											if (!value.怒)
											{
												int num10 = ++value.人物_SP;
											}
										}
										else if (!value.怒)
										{
											value.人物_SP += 2;
										}
										try
										{
											if ((double)RNG.Next(1, 100) <= value.韩_追骨吸元)
											{
												double num11 = (double)num9 * value.韩_追骨吸元 * 0.01;
												if (num11 <= 0.0)
												{
													num11 = 1.0;
												}
												value.加血((int)num11);
												if (Rxjh_HP > (int)num11)
												{
													Play_Add(value, (int)num11);
													Rxjh_HP -= (int)num11;
												}
												else
												{
													Play_Add(value, Rxjh_HP);
													Rxjh_HP = 0;
												}
												if (Rxjh_HP <= 0)
												{
													double 金钱 = (uint)获得钱();
													double num12 = 获得经验();
													double 历练 = 获得历练();
													if (value.中级附魂_奇缘 != 0 && RNG.Next(1, 100) <= value.中级附魂_奇缘)
													{
														num12 *= 2.0;
														value.显示大字(value.人物全服ID, 403);
													}
													value.分配经验历练金钱(this, num12, 历练, 金钱, 0.0);
													flag = true;
												}
											}
										}
										catch (Exception ex)
										{
											Form1.WriteLine(1, "自动攻击事件   韩飞官追骨吸元反伤   出错：" + ((ex != null) ? ex.ToString() : null));
										}
									}
									else if (value.Player_Job == 9)
									{
										if ((double)RNG.Next(1, 100) <= value.谭_升天三气功_火凤临朝 && value.人物_HP <= 0)
										{
											value.人物_HP = 10;
											value.显示大字(value.人物全服ID, 322);
										}
										if ((double)num9 <= num4)
										{
											if (!value.怒)
											{
												int num10 = ++value.人物_SP;
											}
										}
										else if (!value.怒)
										{
											value.人物_SP += 2;
										}
									}
									else if (value.Player_Job == 10)
									{
										if (value.拳师_狂神降世 != 0.0)
										{
											if (!value.怒)
											{
												value.人物_SP += (int)(3.0 + (double)(value.Player_Level * 2) * value.拳师_狂神降世);
											}
										}
										else if ((double)num9 <= num4)
										{
											if (!value.怒)
											{
												int num10 = ++value.人物_SP;
											}
										}
										else if (!value.怒)
										{
											value.人物_SP += 2;
										}
									}
									else if (value.Player_Job == 11)
									{
										if ((double)num9 <= num4)
										{
											if (!value.怒)
											{
												int num10 = ++value.人物_SP;
											}
										}
										else if (!value.怒)
										{
											value.人物_SP += 2;
										}
										if (value.梅_障力恢复 > 0.0 && value.人物_AP * 2 < value.人物最大_AP && (double)RNG.Next(1, 100) <= value.梅_障力恢复)
										{
											value.人物_AP = value.人物最大_AP;
											value.显示大字(value.人物全服ID, 801);
										}
										if (value.梅_愤怒爆发 > 0.0 && RNG.Next(1, 100) <= 40 && value.怒点 < 3)
										{
											value.怒点++;
										}
									}
									else if ((double)num9 <= num4)
									{
										if (!value.怒)
										{
											int num10 = ++value.人物_SP;
										}
									}
									else if (!value.怒)
									{
										value.人物_SP += 2;
									}
								}
								else
								{
									if ((double)num9 <= num4)
									{
										if (!value.怒)
										{
											int num10 = ++value.人物_SP;
										}
									}
									else if (!value.怒)
									{
										value.人物_SP += 2;
									}
									try
									{
										if ((double)RNG.Next(1, 120) <= ((value.Player_Job != 1) ? (value.琴师_升天二气功_三潭映月 + 10.0) : (value.怪反伤几率 + 10.0)) && num9 > 0)
										{
											if (value.Player_Job == 7)
											{
												value.显示大字(value.人物全服ID, 391);
											}
											else
											{
												发送反伤攻击数据(num9, value.人物全服ID);
											}
											if (num9 <= 0)
											{
												num9 = 1;
											}
											if (Rxjh_HP > num9)
											{
												Play_Add(value, num9);
												Rxjh_HP -= num9;
											}
											else
											{
												Play_Add(value, Rxjh_HP);
												Rxjh_HP = 0;
											}
											if (Rxjh_HP <= 0 && !NPC死亡)
											{
												flag = true;
												double 金钱2 = (uint)获得钱();
												double num13 = 获得经验();
												double 历练2 = 获得历练();
												if (value.中级附魂_奇缘 != 0 && RNG.Next(1, 100) <= value.中级附魂_奇缘)
												{
													num13 *= 2.0;
													value.显示大字(value.人物全服ID, 403);
												}
												value.分配经验历练金钱(this, num13, 历练2, 金钱2, 0.0);
											}
										}
									}
									catch (Exception ex2)
									{
										Form1.WriteLine(1, "自动攻击事件   琴师/刀客反伤   出错：" + ((ex2 != null) ? ex2.ToString() : null));
									}
								}
								if (value.FLD_装备_追加_愤怒 > 0 && !value.怒)
								{
									value.人物_SP += value.FLD_装备_追加_愤怒;
								}
								if (value.FLD_装备_追加_中毒概率百分比 > 0.0 && (double)RNG.Next(1, 100) <= value.FLD_装备_追加_中毒概率百分比 && !ContainsKeyInAbnormalState(3))
								{
									异常状态.Add(3, new 异常状态类(this, PlayerWid, 60000, 3, 0.0));
								}
								if (value.人物_HP <= 0)
								{
									if (World.是否开启死亡掉经验 == 1 && value.人物坐标_地图 != 801 && value.Player_Level >= 65)
									{
										long num14 = ((long)World.lever[value.Player_Level + 1] - (long)World.lever[value.Player_Level]) / 1000L;
										if (value.公有药品 != null)
										{
											if (value.检查符() || value.检查符2())
											{
												num14 = num14;
											}
										}
										else
										{
											int num15 = RNG.Next(1, 100);
											num14 = ((num15 >= 1 && num15 <= 10) ? num14 : ((num15 >= 11 && num15 <= 20) ? (num14 * 2L) : ((num15 >= 21 && num15 <= 30) ? (num14 * 3L) : ((num15 >= 31 && num15 <= 40) ? (num14 * 4L) : ((num15 >= 41 && num15 <= 50) ? (num14 * 5L) : ((num15 >= 51 && num15 <= 60) ? (num14 * 6L) : ((num15 >= 61 && num15 <= 70) ? (num14 * 7L) : ((num15 >= 71 && num15 <= 80) ? (num14 * 8L) : ((num15 < 81 || num15 > 90) ? (num14 * 10L) : (num14 * 9L))))))))));
										}
										if (value.FLD_装备_追加_死亡损失经验减少 > 0.0)
										{
											num14 = (long)((double)num14 * (1.0 - value.FLD_装备_追加_死亡损失经验减少));
											if (num14 < 0L)
											{
												num14 = 0L;
											}
										}
										for (int i = 0; i < 15; i++)
										{
											if (Buffer.ToInt32(value.装备栏已穿装备[i].物品ID, 0) == 700004)
											{
												num14 = 0L;
												value.装备栏已穿装备[i].物品_byte = new byte[World.数据库单个物品大小];
												value.初始化已装备物品();
												break;
											}
										}
										if (value.GetAddState(1008000160) || value.GetAddState(1008000159))
										{
											num14 = 0L;
										}
										value.人物经验 -= num14;
										value.计算人物基本数据3();
										value.更新经验和历练();
									}
									自动攻击.Enabled = false;
									自动移动.Enabled = true;
									Rxjh_X = Rxjh_cs_X;
									Rxjh_Y = Rxjh_cs_Y;
									Rxjh_Z = Rxjh_cs_Z;
									发送移动数据(Rxjh_cs_X, Rxjh_cs_Y, 50, 1);
									value.人物_HP = 0;
									value.死亡();
									PlayCw = null;
									Play_null();
								}
								if (flag)
								{
									发送死亡数据(value.人物全服ID);
								}
								value.更新HP_MP_SP();
							}
							else if (查找范围玩家(80, value))
							{
								发送移动数据(value.人物坐标_X, value.人物坐标_Y, 10, 2);
							}
							else
							{
								PlayCw = null;
								Play_null();
								自动攻击.Enabled = false;
								自动移动.Enabled = true;
								Rxjh_X = Rxjh_cs_X;
								Rxjh_Y = Rxjh_cs_Y;
								Rxjh_Z = Rxjh_cs_Z;
								发送移动数据(Rxjh_cs_X, Rxjh_cs_Y, 50, 1);
							}
						}
						else
						{
							if (value.自动攻击 != null)
							{
								value.自动攻击.Enabled = false;
								value.自动攻击.Close();
								value.自动攻击.Dispose();
								value.自动攻击 = null;
							}
							if (value.自动恢复 != null)
							{
								value.自动恢复.Enabled = false;
								value.自动恢复.Close();
								value.自动恢复.Dispose();
								value.自动恢复 = null;
							}
							if (value.无敌时间计数器 != null)
							{
								value.无敌时间计数器.Enabled = false;
								value.无敌时间计数器.Close();
								value.无敌时间计数器.Dispose();
							}
							PlayCw = null;
							Play_null();
							自动攻击.Enabled = false;
							自动移动.Enabled = true;
							Rxjh_X = Rxjh_cs_X;
							Rxjh_Y = Rxjh_cs_Y;
							Rxjh_Z = Rxjh_cs_Z;
							发送移动数据(Rxjh_cs_X, Rxjh_cs_Y, 50, 1);
						}
					}
					else
					{
						PlayCw = null;
						Play_null();
						自动攻击.Enabled = false;
						自动移动.Enabled = true;
						Rxjh_X = Rxjh_cs_X;
						Rxjh_Y = Rxjh_cs_Y;
						Rxjh_Z = Rxjh_cs_Z;
						发送移动数据(Rxjh_cs_X, Rxjh_cs_Y, 50, 1);
					}
				}
			}
			catch (Exception)
			{
				PlayCw = null;
				Play_null();
				自动攻击.Enabled = false;
				自动移动.Enabled = true;
				Rxjh_X = Rxjh_cs_X;
				Rxjh_Y = Rxjh_cs_Y;
				Rxjh_Z = Rxjh_cs_Z;
				发送移动数据(Rxjh_cs_X, Rxjh_cs_Y, 50, 1);
			}
		}

		public List<NpcClass> 群攻查找范围Npc2(Players player, int 数量)
		{
			try
			{
				List<NpcClass> list = new List<NpcClass>();
				int num = 0;
				foreach (NpcClass value in player.NpcList.Values)
				{
					if (!value.NPC死亡 && value.IsNpc == 0 && 查找范围Npc(25, value) && value._FLD_INDEX != _FLD_INDEX)
					{
						list.Add(value);
						if (num >= 数量)
						{
							break;
						}
						num++;
					}
				}
				return list;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "群攻查找范围Npc   出错：" + ((ex != null) ? ex.ToString() : null));
				return null;
			}
		}

		public static void 更新NPC数据(Dictionary<int, NpcClass> NpcList, Players Playe)
		{
			if (NpcList != null && NpcList.Count > 0)
			{
				using (发包类 发包类 = new 发包类())
				{
					发包类.Write4(NpcList.Count);
					foreach (NpcClass value in NpcList.Values)
					{
						发包类.Write2(value.FLD_INDEX);
						发包类.Write2(value.FLD_INDEX);
						发包类.Write2(value.FLD_PID);
						发包类.Write4(1);
						发包类.Write4(value.Rxjh_HP);
						发包类.Write4(value.Max_Rxjh_HP);
						发包类.Write(value.Rxjh_X);
						发包类.Write(value.Rxjh_Z);
						发包类.Write(value.Rxjh_Y);
						发包类.Write4(1082130432);
						发包类.Write(value.FLD_FACE1);
						发包类.Write(value.FLD_FACE2);
						发包类.Write(value.Rxjh_X);
						发包类.Write(value.Rxjh_Z);
						发包类.Write(value.Rxjh_Y);
						发包类.Write4(0);
						发包类.Write4(0);
						发包类.Write4(10);
						发包类.Write4(0);
						发包类.Write4(2359296);
						发包类.Write4(uint.MaxValue);
						if (value.NPC死亡)
						{
							value.更新NPC删除数据(Playe);
							value.更新NPC死亡数据(Playe);
						}
					}
					if (Playe.Client != null)
					{
						Playe.Client.SendPak(发包类, 26368, Playe.人物全服ID);
					}
				}
			}
		}

		public static void 更新NPC删除数据(Dictionary<int, NpcClass> NpcList, Players Playe)
		{
			if (NpcList != null && NpcList.Count > 0)
			{
				using (发包类 发包类 = new 发包类())
				{
					发包类.Write4(NpcList.Count);
					foreach (NpcClass value in NpcList.Values)
					{
						发包类.Write2(value.FLD_INDEX);
						发包类.Write2(value.FLD_INDEX);
						发包类.Write2(value.FLD_PID);
						发包类.Write4(1);
						发包类.Write4(value.Rxjh_HP);
						发包类.Write4(value.Max_Rxjh_HP);
						发包类.Write(value.Rxjh_X);
						发包类.Write(value.Rxjh_Z);
						发包类.Write(value.Rxjh_Y);
						发包类.Write4(1082130432);
						发包类.Write(value.FLD_FACE1);
						发包类.Write(value.FLD_FACE2);
						发包类.Write(value.Rxjh_X);
						发包类.Write(value.Rxjh_Z);
						发包类.Write(value.Rxjh_Y);
						发包类.Write4(0);
						发包类.Write4(0);
						发包类.Write4(10);
						发包类.Write4(0);
						发包类.Write4(2359296);
						发包类.Write4(uint.MaxValue);
					}
					if (Playe.Client != null)
					{
						Playe.Client.SendPak(发包类, 26624, Playe.人物全服ID);
					}
				}
			}
		}

		public void 更新NPC数据(Players Playe)
		{
			using (发包类 发包类 = new 发包类())
			{
				发包类.Write4(1);
				发包类.Write2(FLD_INDEX);
				发包类.Write2(FLD_INDEX);
				发包类.Write2(FLD_PID);
				发包类.Write4(1);
				发包类.Write4(Rxjh_HP);
				发包类.Write4(Max_Rxjh_HP);
				发包类.Write(Rxjh_X);
				发包类.Write(Rxjh_Z);
				发包类.Write(Rxjh_Y);
				发包类.Write4(1082130432);
				发包类.Write(FLD_FACE1);
				发包类.Write(FLD_FACE2);
				发包类.Write(Rxjh_X);
				发包类.Write(Rxjh_Z);
				发包类.Write(Rxjh_Y);
				发包类.Write4(0);
				发包类.Write4(0);
				发包类.Write4(10);
				发包类.Write4(0);
				发包类.Write4(2359296);
				发包类.Write4(uint.MaxValue);
				if (Playe.Client != null)
				{
					Playe.Client.SendPak(发包类, 26368, FLD_INDEX);
				}
			}
			if (NPC死亡)
			{
				更新NPC删除数据(Playe);
				更新NPC死亡数据(Playe);
			}
		}

		public void 更新NPC删除数据(Players Playe)
		{
			using (发包类 发包类 = new 发包类())
			{
				发包类.Write4(1);
				发包类.Write2(FLD_INDEX);
				发包类.Write2(FLD_INDEX);
				发包类.Write2(FLD_PID);
				发包类.Write4(1);
				发包类.Write4(Rxjh_HP);
				发包类.Write4(Max_Rxjh_HP);
				发包类.Write(Rxjh_X);
				发包类.Write(Rxjh_Z);
				发包类.Write(Rxjh_Y);
				发包类.Write4(1082130432);
				发包类.Write(FLD_FACE1);
				发包类.Write(FLD_FACE2);
				发包类.Write(Rxjh_X);
				发包类.Write(Rxjh_Z);
				发包类.Write(Rxjh_Y);
				发包类.Write4(0);
				发包类.Write4(0);
				发包类.Write4(10);
				发包类.Write4(0);
				发包类.Write4(2359296);
				发包类.Write4(uint.MaxValue);
				if (Playe.Client != null)
				{
					Playe.Client.SendPak(发包类, 26624, Playe.人物全服ID);
				}
			}
		}

		private void 更新NPC复活数据()
		{
			try
			{
				NPC死亡 = false;
				Rxjh_HP = Max_Rxjh_HP;
				if (_FLD_PID != 15349 && _FLD_PID != 15350)
				{
					if (_FLD_PID != 15121 && _FLD_PID != 15122)
					{
						Random random = new Random();
						int num = random.Next(0, 2);
						double num2 = random.NextDouble() * 50.0;
						double num3 = random.NextDouble() * 50.0;
						if (num == 0)
						{
							Rxjh_X = Rxjh_cs_X + (float)num2;
							Rxjh_Y = Rxjh_cs_Y + (float)num3;
						}
						else
						{
							Rxjh_X = Rxjh_cs_X - (float)num2;
							Rxjh_Y = Rxjh_cs_Y - (float)num3;
						}
					}
					else
					{
						Rxjh_X = Rxjh_cs_X;
						Rxjh_Y = Rxjh_cs_Y;
					}
				}
				else
				{
					Rxjh_X = Rxjh_cs_X;
					Rxjh_Y = Rxjh_cs_Y;
				}
				Rxjh_Z = Rxjh_cs_Z;
				using (发包类 发包类 = new 发包类())
				{
					发包类.Write4(1);
					发包类.Write2(FLD_INDEX);
					发包类.Write2(FLD_INDEX);
					发包类.Write2(FLD_PID);
					发包类.Write4(1);
					发包类.Write4(Rxjh_HP);
					发包类.Write4(Max_Rxjh_HP);
					发包类.Write(Rxjh_X);
					发包类.Write(Rxjh_Z);
					发包类.Write(Rxjh_Y);
					发包类.Write4(0);
					发包类.Write(FLD_FACE1);
					发包类.Write(FLD_FACE2);
					发包类.Write(Rxjh_X);
					发包类.Write(Rxjh_Z);
					发包类.Write(Rxjh_Y);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(10);
					发包类.Write4(0);
					发包类.Write4(2359296);
					发包类.Write4(uint.MaxValue);
					发送当前范围广播数据(发包类, 31488, FLD_INDEX);
				}
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
			}
			catch (Exception ex)
			{
				if (自动复活 != null)
				{
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
				Form1.WriteLine(1, "更新NPC复活数据   出错" + FLD_PID + "|" + Name + "   " + ex.Message);
			}
			finally
			{
				if (自动复活 != null)
				{
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
			}
		}

		private void 更新NPC死亡数据(Players Playe)
		{
			using (发包类 pak = new 发包类())
			{
				if (Playe.Client != null)
				{
					Playe.Client.SendPak(pak, 34816, FLD_INDEX);
				}
			}
		}

		private void 广播NPC死亡数据()
		{
			using (发包类 pak = new 发包类())
			{
				发送当前范围广播数据(pak, 34816, FLD_INDEX);
			}
		}

		public void 发送移动数据(float X, float Y, int sl, int 移动方式)
		{
			try
			{
				using (发包类 发包类 = new 发包类())
				{
					Random random = new Random(DateTime.Now.Millisecond);
					int num = RNG.Next(0, 1);
					double num2 = random.NextDouble() * (double)sl;
					double num3 = random.NextDouble() * (double)sl;
					if (num == 0)
					{
						Rxjh_X = X + (float)num2;
						Rxjh_Y = Y + (float)num3;
					}
					else
					{
						Rxjh_X = X - (float)num2;
						Rxjh_Y = Y - (float)num3;
					}
					发包类.Write(Rxjh_X);
					发包类.Write(Rxjh_Y);
					发包类.Write(Rxjh_Z);
					发包类.Write4(-1);
					if (FLD_PID == 5)
					{
						发包类.Write4(0);
					}
					else
					{
						发包类.Write4(RNG.Next(0, 2));
					}
					发包类.Write((float)num2);
					发包类.Write4(Rxjh_HP);
					发包类.Write(Rxjh_X);
					发包类.Write(Rxjh_Z);
					发包类.Write(Rxjh_Y);
					发包类.Write4(0);
					发包类.Write2(0);
					发送当前范围广播数据(发包类, 29696, FLD_INDEX);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送移动数据   出错" + FLD_PID + "|" + Name + "   " + ex.Message);
			}
		}

		public void 发送攻击数据(int 攻击力, int 攻击类型, int 人物全服ID, int 恢复障力)
		{
			try
			{
				using (发包类 发包类 = new 发包类())
				{
					发包类.Write2(人物全服ID);
					发包类.Write2(1);
					发包类.Write4(0);
					发包类.Write4(攻击力);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(恢复障力);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(攻击类型);
					发包类.Write(Rxjh_X);
					发包类.Write(15f);
					发包类.Write(Rxjh_Y);
					发包类.Write(0);
					发包类.Write(1);
					发包类.Write2(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(-1);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发包类.Write4(0);
					发送当前范围广播数据(发包类, 3072, FLD_INDEX);
				}
			}
			catch (Exception ex)
			{
				string[] obj = new string[6]
				{
					"发送攻击数据   出错",
					FLD_PID.ToString(),
					"|",
					Name,
					"   ",
					null
				};
				obj[5] = ((ex != null) ? ex.ToString() : null);
				Form1.WriteLine(1, string.Concat(obj));
			}
		}

		public void 发送当前范围广播数据(发包类 pak, int id, int wordid)
		{
			try
			{
				if (PlayList != null)
				{
					foreach (Players value in PlayList.Values)
					{
						if (value.Client != null && value.Client.Running)
						{
							if (!value.Client.挂机)
							{
								value.Client.SendPak(pak, id, wordid);
							}
						}
						else
						{
							if (Contains(value))
							{
								PlayList.Remove(value.人物全服ID);
							}
							if (value.NpcList != null && value.NpcList.Count > 0)
							{
								foreach (NpcClass value2 in value.NpcList.Values)
								{
									if (value2.Contains(value))
									{
										value2.PlayList.Remove(value.人物全服ID);
									}
								}
							}
							if (value.Client != null)
							{
								Form1.WriteLine(2, "NPC发送当前范围广播数据   删除卡号人物：[" + value.Userid + "]   [" + value.UserName + "]");
								value.Client.Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "NPC广播数据   出错3：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 更新死亡数据()
		{
			try
			{
				if (!NPC死亡)
				{
					NPC死亡 = true;
					if (_一次性怪)
					{
						if (PlayCw != null)
						{
							PlayCw = null;
						}
						Play_null();
						广播NPC死亡数据();
						Dispose();
					}
					else
					{
						if (自动攻击 != null)
						{
							自动攻击.Enabled = false;
						}
						if (自动移动 != null)
						{
							自动移动.Enabled = false;
						}
						if (自动复活 != null)
						{
							自动复活.Interval = FLD_NEWTIME * 1000;
							自动复活.Enabled = true;
						}
						else
						{
							自动复活 = new System.Timers.Timer(FLD_NEWTIME * 1000);
							自动复活.Elapsed += 自动复活事件;
							自动复活.Enabled = true;
						}
						if (PlayCw != null)
						{
							PlayCw = null;
						}
						Play_null();
						广播NPC死亡数据();
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "更新死亡数据   出错" + FLD_PID + "|" + Name + "   " + ex.Message);
			}
		}

		public void 发送采药数据()
		{
			if (IsNpc == 2)
			{
				if (自动复活 != null)
				{
					自动复活.Interval = FLD_NEWTIME * 1000;
					自动复活.Enabled = true;
				}
				else
				{
					自动复活 = new System.Timers.Timer(FLD_NEWTIME * 1000);
					自动复活.Elapsed += 自动复活事件;
					自动复活.Enabled = true;
				}
				PlayCw = null;
				Play_null();
				广播NPC死亡数据();
			}
		}

		public void 发送怪物一次性死亡数据()
		{
			try
			{
				异常状态列表();
				结束异常掉血状态列表();
				if (IsNpc != 1 && !NPC死亡)
				{
					if (PlayCw != null)
					{
						PlayCw = null;
					}
					Play_null();
					广播NPC死亡数据();
					Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送死亡数据   出错" + FLD_PID + "|" + Name + "   " + ex.Message);
			}
		}

		public void 发送死亡数据(int UserWorldId)
		{
			int num = 0;
			Players value;
			if (PlayList.TryGetValue(UserWorldId, out value))
			{
				try
				{
					foreach (任务类 value4 in value.任务.Values)
					{
						foreach (任务阶段类 item in value4.任务阶段)
						{
							if (item.阶段状态 == 1 && item.阶段需要物品_.Count > 0)
							{
								int num2 = 15;
								任务类 rW = new 任务类().GetRW(value4.RwID);
								foreach (任务阶段类 item2 in rW.任务阶段)
								{
									if (item2.阶段ID == item.阶段ID)
									{
										num2 = item2.难度系数;
										item.阶段需要物品_ = item2.阶段需要物品_;
										break;
									}
								}
								num = value4.RwID;
								if (num == 45 && 15062 == FLD_PID)
								{
									value.设置任务物品(900000099, 1);
								}
								if (num == 46 && 15072 == FLD_PID)
								{
									value.设置任务物品(900000101, 1);
								}
								foreach (阶段需要物品类 value5 in item.阶段需要物品_.Values)
								{
									if (value5.怪物ID == FLD_PID && !value.CheckItem(value5.物品ID, value5.物品总数) && RNG.Next(1, 100) >= num2)
									{
										value.设置任务物品(value5.物品ID, 1);
										组队Class value2;
										if (value.组队id != 0 && value.组队阶段 == 2 && World.W组队.TryGetValue(value.组队id, out value2))
										{
											foreach (Players value6 in value2.队员列表.Values)
											{
												if (查找范围玩家(1000, value6) && value6.人物_HP > 0 && !value6.Player死亡 && value.人物全服ID != value6.人物全服ID)
												{
													foreach (任务类 value7 in value6.任务.Values)
													{
														foreach (任务阶段类 item3 in value7.任务阶段)
														{
															if (item3.阶段需要物品_.Count > 0 && item3.阶段状态 == 1)
															{
																foreach (任务阶段类 item4 in rW.任务阶段)
																{
																	if (item4.阶段ID == item3.阶段ID)
																	{
																		item3.阶段需要物品_ = item4.阶段需要物品_;
																		break;
																	}
																}
																foreach (阶段需要物品类 value8 in item3.阶段需要物品_.Values)
																{
																	if (value8.怪物ID == FLD_PID && !value6.CheckItem(value8.物品ID, value8.物品总数))
																	{
																		value6.设置任务物品(value8.物品ID, 1);
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(2, "掉落任务物品出错   怪物ID-" + FLD_PID + "|任务ID-" + num + "|" + ex.Message);
				}
				try
				{
					异常状态列表();
					结束异常掉血状态列表();
					if (IsNpc != 1 && !NPC死亡)
					{
						if (FLD_BOSS == 1 && Rxjh_Map == 101)
						{
							int num3 = RNG.Next(6, 10);
							for (int i = 0; i < num3; i++)
							{
								if (World.allConnectedChars.TryGetValue(BossPlayerWid, out value) && 查找范围玩家(1000, value))
								{
									Boss暴物品(value);
								}
							}
						}
						else if (PlayList.TryGetValue(UserWorldId, out value))
						{
							if (value.Player_Level - Level < World.获得经验等级差 || FLD_BOSS != 0)
							{
								暴物品(value);
							}
						}
						else
						{
							Math.Abs(PlayCw.Playe.Player_Level - Level);
							if (UserWorldId > 40000 && PlayCw != null && PlayCw.Playe != null && PlayCw.Playe.Player_Level - Level < World.获得经验等级差)
							{
								暴物品(PlayCw.Playe);
							}
							else
							{
								暴物品(null);
							}
						}
						foreach (Players value9 in World.allConnectedChars.Values)
						{
							Players value3;
							if (World.allConnectedChars.TryGetValue(UserWorldId, out value3))
							{
								if (FLD_PID == 16430)
								{
									value9.天魔神宫正城门已开启();
									World.天魔神宫大门是否死亡 = 1;
								}
								if (FLD_PID == 16431)
								{
									value9.天魔神宫东城门已开启();
									World.天魔神宫大门是否死亡 = 1;
								}
								if (FLD_PID == 16435)
								{
									DBA.ExeSqlCommand("DELETE FROM 攻城城主");
									value3.天魔神宫雕像击杀();
									value9.天魔神宫攻城胜利包(value3);
									value9.天魔神宫雕像击杀移动(value9);
									World.天魔神宫雕像是否死亡 = 1;
								}
							}
						}
						NPC死亡 = true;
						if (_一次性怪)
						{
							if (PlayCw != null)
							{
								PlayCw = null;
							}
							Play_null();
							广播NPC死亡数据();
							Dispose();
						}
						else
						{
							if (自动攻击 != null)
							{
								自动攻击.Enabled = false;
							}
							if (自动移动 != null)
							{
								自动移动.Enabled = true;
							}
							if (World.势力战进程 == 3 && (_FLD_PID == 15121 || _FLD_PID == 15122))
							{
								if (_FLD_PID == 15122)
								{
									World.势力战正分数 += 500;
								}
								else
								{
									World.势力战邪分数 += 500;
								}
							}
							if (自动复活 != null)
							{
								自动复活.Interval = FLD_NEWTIME * 1000;
								自动复活.Enabled = true;
							}
							else
							{
								自动复活 = new System.Timers.Timer(FLD_NEWTIME * 1000);
								自动复活.Elapsed += 自动复活事件;
								自动复活.Enabled = true;
							}
							if (PlayCw != null)
							{
								PlayCw = null;
							}
							Play_null();
							广播NPC死亡数据();
						}
					}
				}
				catch (Exception ex2)
				{
					Form1.WriteLine(1, "发送死亡数据   出错" + FLD_PID + "|" + Name + "   " + ex2.Message);
				}
			}
		}

		public void 发送反伤攻击数据(int 攻击力, int 人物ID)
		{
			byte[] array = Converter.hexStringToByte("AA551C0000A42789000C002C0100000F0000000100000000000000000000000055AA");
			System.Buffer.BlockCopy(Buffer.GetBytes(FLD_INDEX), 0, array, 5, 2);
			System.Buffer.BlockCopy(Buffer.GetBytes(人物ID), 0, array, 11, 2);
			System.Buffer.BlockCopy(Buffer.GetBytes(攻击力), 0, array, 19, 2);
			广播数据(array, array.Length);
		}

		public byte[] 掉出物品(DropClass drop, Players yxqname)
		{
			try
			{
				long dBItmeId = RxjhClass.GetDBItmeId();
				byte[] array = new byte[World.数据库单个物品大小];
				byte[] bytes = Buffer.GetBytes(dBItmeId);
				byte[] array2 = new byte[56];
				ItmeClass value;
				if (!World.Itme.TryGetValue(drop.FLD_PID, out value))
				{
					return null;
				}
				if (value.FLD_QUESTITEM != 1)
				{
					try
					{
						if (World.Droplog)
						{
							Form1.WriteLine(4, "物品掉落--物品名:" + drop.FLD_NAME + "   属性1[" + drop.FLD_MAGIC0 + "]属性2[" + drop.FLD_MAGIC1 + "]属性3[" + drop.FLD_MAGIC2 + "]属性4[" + drop.FLD_MAGIC3 + "]属性5[" + drop.FLD_MAGIC4 + "]");
						}
						if (drop.是否开启公告 == 1)
						{
							string text = "恭喜玩家[" + yxqname.UserName + "]在->" + 坐标Class.getmapname(yxqname.人物坐标_地图) + "<-" + Name + "获得->" + drop.FLD_NAME + "<-";
							World.conn.发送("刷怪掉宝|" + 22 + "|" + text + "|" + World.服务器ID);
						}
						System.Buffer.BlockCopy(Buffer.GetBytes(drop.FLD_MAGIC0), 0, array2, 0, 4);
						System.Buffer.BlockCopy(Buffer.GetBytes(drop.FLD_MAGIC1), 0, array2, 4, 4);
						System.Buffer.BlockCopy(Buffer.GetBytes(drop.FLD_MAGIC2), 0, array2, 8, 4);
						System.Buffer.BlockCopy(Buffer.GetBytes(drop.FLD_MAGIC3), 0, array2, 12, 4);
						System.Buffer.BlockCopy(Buffer.GetBytes(drop.FLD_MAGIC4), 0, array2, 16, 4);
						System.Buffer.BlockCopy(bytes, 0, array, 0, 4);
						System.Buffer.BlockCopy(array2, 0, array, 16, 20);
						System.Buffer.BlockCopy(Buffer.GetBytes(drop.FLD_PID), 0, array, 8, 4);
						System.Buffer.BlockCopy(Buffer.GetBytes(1), 0, array, 12, 4);
						if (value.FLD_NJ > 0 && (value.FLD_RESIDE2 == 1 || value.FLD_RESIDE2 == 2 || value.FLD_RESIDE2 == 5 || value.FLD_RESIDE2 == 4 || value.FLD_RESIDE2 == 6))
						{
							System.Buffer.BlockCopy(Buffer.GetBytes(1000), 0, array, 60, 2);
						}
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "掉出物品1   出错   " + FLD_PID + "|" + Name + "   " + ex.Message);
						return null;
					}
					地面物品类 地面物品类;
					地面物品类 value2;
					try
					{
						if (FLD_BOSS == 0)
						{
							地面物品类 = new 地面物品类(array, Rxjh_X, Rxjh_Y, Rxjh_Z, Rxjh_Map, yxqname, 0);
						}
						else
						{
							Random random = new Random();
							int num = random.Next(0, 2);
							double num2 = random.NextDouble() * 25.0;
							double num3 = random.NextDouble() * 25.0;
							地面物品类 = ((num != 0) ? new 地面物品类(array, Rxjh_X - (float)num2, Rxjh_Y - (float)num3, Rxjh_Z, Rxjh_Map, yxqname, 0) : new 地面物品类(array, Rxjh_X + (float)num2, Rxjh_Y + (float)num3, Rxjh_Z, Rxjh_Map, yxqname, 0));
						}
						if (地面物品类 == null)
						{
							Form1.WriteLine(1, "掉出物品2   出错   " + FLD_PID + "|" + Name);
							return null;
						}
						if (!World.ItmeTeM.TryGetValue(dBItmeId, out value2))
						{
							World.ItmeTeM.Add(dBItmeId, 地面物品类);
						}
					}
					catch (Exception ex2)
					{
						Form1.WriteLine(1, "掉出物品3   出错   " + FLD_PID + "|" + Name + "   " + ex2.Message);
						return null;
					}
					try
					{
						if (World.ItmeTeM.TryGetValue(dBItmeId, out value2))
						{
							地面物品类.获取范围玩家发送地面增加物品数据包();
						}
						return array;
					}
					catch (Exception ex3)
					{
						Form1.WriteLine(1, "掉出物品4   出错   " + FLD_PID + "|" + Name + "   " + ex3.Message);
						return null;
					}
				}
				if (yxqname != null)
				{
					int num4 = yxqname.得到包裹空位(yxqname);
					if (num4 != -1)
					{
						yxqname.增加物品(bytes, Buffer.GetBytes(drop.FLD_PID), num4, Buffer.GetBytes(1), new byte[56]);
					}
				}
				return null;
			}
			catch (Exception ex4)
			{
				Form1.WriteLine(1, "掉出物品5   出错   " + FLD_PID + "|" + Name + "   " + ex4.Message);
				return null;
			}
			finally
			{
				drop.FLD_PID = drop.FLD_PIDNew;
				drop.FLD_MAGIC0 = drop.FLD_MAGICNew0;
				drop.FLD_MAGIC1 = drop.FLD_MAGICNew1;
				drop.FLD_MAGIC2 = drop.FLD_MAGICNew2;
				drop.FLD_MAGIC3 = drop.FLD_MAGICNew3;
				drop.FLD_MAGIC4 = drop.FLD_MAGICNew4;
			}
		}

		public void 暴物品(Players yxqname)
		{
			try
			{
				if (Rxjh_Map == 801)
				{
					yxqname = null;
				}
				switch (FLD_BOSS)
				{
				case 0:
					暴物品2(yxqname);
					break;
				case 1:
					Boss暴物品(yxqname);
					break;
				case 2:
					GS暴物品(1, 9, yxqname);
					break;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "暴物品   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void GS暴物品(int sl, int maxsl, Players yxqname)
		{
			try
			{
				if (Rxjh_Exp > 0)
				{
					List<DropClass> gSDrop = DropClass.GetGSDrop(Level, sl, maxsl);
					if (gSDrop != null)
					{
						foreach (DropClass item in gSDrop)
						{
							if (item != null)
							{
								switch (item.FLD_PID)
								{
								case 800000002:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC4 = 0;
										int num4 = RNG.Next(1, 100);
										foreach (DropShuXClass item2 in item.DropShuX)
										{
											if (num4 <= item2.Max)
											{
												fLD_MAGIC4 = RNG.Next(item2.ShuXMin, item2.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC4;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								case 800000001:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC10 = 0;
										int num10 = RNG.Next(1, 100);
										foreach (DropShuXClass item3 in item.DropShuX)
										{
											if (num10 <= item3.Max)
											{
												fLD_MAGIC10 = RNG.Next(item3.ShuXMin, item3.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC10;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								case 800000023:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC2 = 0;
										int num2 = RNG.Next(1, 100);
										foreach (DropShuXClass item4 in item.DropShuX)
										{
											if (num2 <= item4.Max)
											{
												fLD_MAGIC2 = RNG.Next(item4.ShuXMin, item4.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC2;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								case 800000024:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC8 = 0;
										int num8 = RNG.Next(1, 100);
										foreach (DropShuXClass item5 in item.DropShuX)
										{
											if (num8 <= item5.Max)
											{
												fLD_MAGIC8 = RNG.Next(item5.ShuXMin, item5.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC8;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								case 800000025:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC3 = 0;
										int num3 = RNG.Next(1, 100);
										foreach (DropShuXClass item6 in item.DropShuX)
										{
											if (num3 <= item6.Max)
											{
												fLD_MAGIC3 = RNG.Next(item6.ShuXMin, item6.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC3;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								case 800000026:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC7 = 0;
										int num7 = RNG.Next(1, 100);
										foreach (DropShuXClass item7 in item.DropShuX)
										{
											if (num7 <= item7.Max)
											{
												fLD_MAGIC7 = RNG.Next(item7.ShuXMin, item7.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC7;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								case 800000028:
									item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									break;
								case 800000030:
									item.FLD_MAGIC0 = World.GetValue(800000030, 5);
									break;
								case 800000031:
									item.FLD_MAGIC0 = World.GetValue(800000031, 5);
									break;
								case 800000032:
									item.FLD_MAGIC0 = World.GetValue(800000032, 5);
									break;
								case 800000033:
									item.FLD_MAGIC0 = World.GetValue(800000033, 5);
									break;
								case 800000013:
									item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									break;
								case 800000047:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC9 = 0;
										int num9 = RNG.Next(1, 100);
										foreach (DropShuXClass item8 in item.DropShuX)
										{
											if (num9 <= item8.Max)
											{
												fLD_MAGIC9 = RNG.Next(item8.ShuXMin, item8.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC9;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = RNG.Next(23, 51);
									}
									break;
								case 800000046:
									if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = RNG.Next(1, 22);
									}
									break;
								case 1000000321:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(10, 50);
									break;
								case 1000000323:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(100, 150);
									break;
								case 1000000325:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(400, 699);
									break;
								default:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC6 = 0;
										int num6 = RNG.Next(1, 100);
										foreach (DropShuXClass item9 in item.DropShuX)
										{
											if (num6 <= item9.Max)
											{
												fLD_MAGIC6 = RNG.Next(item9.ShuXMin, item9.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC6;
									}
									break;
								case 1000000327:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(2000, 2499);
									break;
								case 800000062:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC5 = 0;
										int num5 = RNG.Next(1, 100);
										foreach (DropShuXClass item10 in item.DropShuX)
										{
											if (num5 <= item10.Max)
											{
												fLD_MAGIC5 = RNG.Next(item10.ShuXMin, item10.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC5;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								case 800000061:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC = 0;
										int num = RNG.Next(1, 100);
										foreach (DropShuXClass item11 in item.DropShuX)
										{
											if (num <= item11.Max)
											{
												fLD_MAGIC = RNG.Next(item11.ShuXMin, item11.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 5);
									}
									break;
								}
								掉出物品(item, yxqname);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "暴物品   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void Boss暴物品(Players yxqname)
		{
			try
			{
				if (Rxjh_Exp <= 0)
				{
					Form1.WriteLine(1, "Boss暴物品   出错：this.Rxjh_Exp   <=   0");
				}
				else
				{
					int 暴率 = World.暴率;
					if (yxqname != null)
					{
						if (yxqname.FLD_人物_追加_物品掉落概率百分比 > 0.0)
						{
							暴率 += (int)((double)暴率 * yxqname.FLD_人物_追加_物品掉落概率百分比);
						}
						if (yxqname.查询天关地图(yxqname.人物坐标_地图))
						{
							yxqname.得到天关福利加成(1, yxqname.人物坐标_地图);
						}
					}
					List<DropClass> bossDrop = DropClass.GetBossDrop(Level);
					if (bossDrop == null)
					{
						Form1.WriteLine(1, "Boss暴物品   出错：bossdrop   ==   null");
					}
					else
					{
						foreach (DropClass item in bossDrop)
						{
							if (item != null)
							{
								switch (item.FLD_PID)
								{
								case 800000002:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC4 = 0;
										int num4 = RNG.Next(1, 100);
										foreach (DropShuXClass item2 in item.DropShuX)
										{
											if (num4 <= item2.Max)
											{
												fLD_MAGIC4 = RNG.Next(item2.ShuXMin, item2.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC4;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								case 800000001:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC10 = 0;
										int num10 = RNG.Next(1, 100);
										foreach (DropShuXClass item3 in item.DropShuX)
										{
											if (num10 <= item3.Max)
											{
												fLD_MAGIC10 = RNG.Next(item3.ShuXMin, item3.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC10;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								case 800000023:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC2 = 0;
										int num2 = RNG.Next(1, 100);
										foreach (DropShuXClass item4 in item.DropShuX)
										{
											if (num2 <= item4.Max)
											{
												fLD_MAGIC2 = RNG.Next(item4.ShuXMin, item4.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC2;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								case 800000024:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC8 = 0;
										int num8 = RNG.Next(1, 100);
										foreach (DropShuXClass item5 in item.DropShuX)
										{
											if (num8 <= item5.Max)
											{
												fLD_MAGIC8 = RNG.Next(item5.ShuXMin, item5.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC8;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								case 800000025:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC3 = 0;
										int num3 = RNG.Next(1, 100);
										foreach (DropShuXClass item6 in item.DropShuX)
										{
											if (num3 <= item6.Max)
											{
												fLD_MAGIC3 = RNG.Next(item6.ShuXMin, item6.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC3;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								case 800000026:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC7 = 0;
										int num7 = RNG.Next(1, 100);
										foreach (DropShuXClass item7 in item.DropShuX)
										{
											if (num7 <= item7.Max)
											{
												fLD_MAGIC7 = RNG.Next(item7.ShuXMin, item7.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC7;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								case 800000028:
									item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									break;
								case 800000030:
									item.FLD_MAGIC0 = World.GetValue(800000030, 4);
									break;
								case 800000031:
									item.FLD_MAGIC0 = World.GetValue(800000031, 4);
									break;
								case 800000032:
									item.FLD_MAGIC0 = World.GetValue(800000032, 4);
									break;
								case 800000033:
									item.FLD_MAGIC0 = World.GetValue(800000033, 4);
									break;
								case 800000013:
									item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									break;
								case 800000047:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC9 = 0;
										int num9 = RNG.Next(1, 100);
										foreach (DropShuXClass item8 in item.DropShuX)
										{
											if (num9 <= item8.Max)
											{
												fLD_MAGIC9 = RNG.Next(item8.ShuXMin, item8.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC9;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = RNG.Next(23, 51);
									}
									break;
								case 800000046:
									if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = RNG.Next(1, 22);
									}
									break;
								case 1000000321:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(10, 50);
									break;
								case 1000000323:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(100, 150);
									break;
								case 1000000325:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(400, 699);
									break;
								default:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC6 = 0;
										int num6 = RNG.Next(1, 100);
										foreach (DropShuXClass item9 in item.DropShuX)
										{
											if (num6 <= item9.Max)
											{
												fLD_MAGIC6 = RNG.Next(item9.ShuXMin, item9.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC6;
									}
									break;
								case 1000000327:
									item.FLD_MAGIC0 = RNG.Next(1001, 2999);
									item.FLD_MAGIC1 = RNG.Next(2000, 2499);
									break;
								case 800000062:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC5 = 0;
										int num5 = RNG.Next(1, 100);
										foreach (DropShuXClass item10 in item.DropShuX)
										{
											if (num5 <= item10.Max)
											{
												fLD_MAGIC5 = RNG.Next(item10.ShuXMin, item10.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC5;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								case 800000061:
									if (item.FLD_MAGIC0 == 10)
									{
										int fLD_MAGIC = 0;
										int num = RNG.Next(1, 100);
										foreach (DropShuXClass item11 in item.DropShuX)
										{
											if (num <= item11.Max)
											{
												fLD_MAGIC = RNG.Next(item11.ShuXMin, item11.ShuXMax - 1);
												break;
											}
										}
										item.FLD_MAGIC0 = fLD_MAGIC;
									}
									else if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = World.GetValue(item.FLD_PID, 4);
									}
									break;
								}
								if (yxqname != null)
								{
									int num11 = yxqname.得到包裹空位(yxqname);
									if (num11 != -1)
									{
										yxqname.增加物品带属性(item.FLD_PID, num11, 1, item.FLD_MAGIC0, item.FLD_MAGIC1, item.FLD_MAGIC2, item.FLD_MAGIC3, item.FLD_MAGIC4, item.FLD_初级附魂, item.FLD_中级附魂, item.FLD_进化, item.FLD_绑定, 0);
										World.全局提示("系统提示", 7, "恭喜[" + yxqname.UserName + "]在与BOSS决战中获得战利品[" + item.FLD_NAME + "]。");
									}
									else
									{
										Form1.WriteLine(1, "Boss暴物品   出错：背包没空位了");
										yxqname.系统提示("背包没空位了。");
									}
								}
								else
								{
									掉出物品(item, yxqname);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "暴物品   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 暴物品2(Players yxqname)
		{
			try
			{
				DropClass dropClass;
				if (Rxjh_Exp > 0)
				{
					int num = RNG.Next(1, 8000);
					int num2 = World.暴率;
					if (yxqname != null)
					{
						if (yxqname.Player_Level <= World.双倍暴率等级上限)
						{
							num2 *= (int)World.双倍等级上限倍数;
						}
						if (yxqname.FLD_人物_追加_物品掉落概率百分比 > 0.0)
						{
							num2 += (int)((double)num2 * yxqname.FLD_人物_追加_物品掉落概率百分比);
						}
						if (yxqname.查询天关地图(yxqname.人物坐标_地图))
						{
							num2 += (int)yxqname.得到天关福利加成(1, yxqname.人物坐标_地图);
						}
					}
					if (num <= num2)
					{
						Players value;
						if (World.allConnectedChars.TryGetValue(yxqname.人物全服ID, out value))
						{
							if (value.FLD_VIP == 0)
							{
								dropClass = DropClass.GetDrop(Level);
								if (dropClass != null)
								{
									goto IL_00d5;
								}
							}
							else
							{
								dropClass = DropClass.GetVipDrop(Level);
								if (dropClass != null)
								{
									goto IL_00d5;
								}
							}
						}
						else
						{
							dropClass = DropClass.GetDrop(Level);
							if (dropClass != null)
							{
								goto IL_00d5;
							}
						}
					}
				}
				goto end_IL_0000;
				IL_00d5:
				switch (dropClass.FLD_PID)
				{
				case 800000002:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC4 = 0;
						int num6 = RNG.Next(1, 100);
						foreach (DropShuXClass item in dropClass.DropShuX)
						{
							if (num6 <= item.Max)
							{
								fLD_MAGIC4 = RNG.Next(item.ShuXMin, item.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC4;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				case 800000001:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC10 = 0;
						int num12 = RNG.Next(1, 100);
						foreach (DropShuXClass item2 in dropClass.DropShuX)
						{
							if (num12 <= item2.Max)
							{
								fLD_MAGIC10 = RNG.Next(item2.ShuXMin, item2.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC10;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				case 800000023:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC2 = 0;
						int num4 = RNG.Next(1, 100);
						foreach (DropShuXClass item3 in dropClass.DropShuX)
						{
							if (num4 <= item3.Max)
							{
								fLD_MAGIC2 = RNG.Next(item3.ShuXMin, item3.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC2;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				case 800000024:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC8 = 0;
						int num10 = RNG.Next(1, 100);
						foreach (DropShuXClass item4 in dropClass.DropShuX)
						{
							if (num10 <= item4.Max)
							{
								fLD_MAGIC8 = RNG.Next(item4.ShuXMin, item4.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC8;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				case 800000025:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC3 = 0;
						int num5 = RNG.Next(1, 100);
						foreach (DropShuXClass item5 in dropClass.DropShuX)
						{
							if (num5 <= item5.Max)
							{
								fLD_MAGIC3 = RNG.Next(item5.ShuXMin, item5.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC3;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				case 800000026:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC7 = 0;
						int num9 = RNG.Next(1, 100);
						foreach (DropShuXClass item6 in dropClass.DropShuX)
						{
							if (num9 <= item6.Max)
							{
								fLD_MAGIC7 = RNG.Next(item6.ShuXMin, item6.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC7;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				case 800000028:
					dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					break;
				case 800000030:
					dropClass.FLD_MAGIC0 = World.GetValue(800000030, 3);
					break;
				case 800000031:
					dropClass.FLD_MAGIC0 = World.GetValue(800000031, 3);
					break;
				case 800000032:
					dropClass.FLD_MAGIC0 = World.GetValue(800000032, 3);
					break;
				case 800000033:
					dropClass.FLD_MAGIC0 = World.GetValue(800000033, 3);
					break;
				case 800000013:
					dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					break;
				case 800000047:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC9 = 0;
						int num11 = RNG.Next(1, 100);
						foreach (DropShuXClass item7 in dropClass.DropShuX)
						{
							if (num11 <= item7.Max)
							{
								fLD_MAGIC9 = RNG.Next(item7.ShuXMin, item7.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC9;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = RNG.Next(23, 51);
					}
					break;
				case 800000046:
					if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = RNG.Next(1, 22);
					}
					break;
				case 1000000321:
					dropClass.FLD_MAGIC0 = RNG.Next(1001, 2999);
					dropClass.FLD_MAGIC1 = RNG.Next(10, 50);
					break;
				case 1000000323:
					dropClass.FLD_MAGIC0 = RNG.Next(1001, 2999);
					dropClass.FLD_MAGIC1 = RNG.Next(100, 150);
					break;
				case 1000000325:
					dropClass.FLD_MAGIC0 = RNG.Next(1001, 2999);
					dropClass.FLD_MAGIC1 = RNG.Next(400, 699);
					break;
				default:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC6 = 0;
						int num8 = RNG.Next(1, 100);
						foreach (DropShuXClass item8 in dropClass.DropShuX)
						{
							if (num8 <= item8.Max)
							{
								fLD_MAGIC6 = RNG.Next(item8.ShuXMin, item8.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC6;
					}
					break;
				case 1000000327:
					dropClass.FLD_MAGIC0 = RNG.Next(1001, 2999);
					dropClass.FLD_MAGIC1 = RNG.Next(2000, 2499);
					break;
				case 800000062:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC5 = 0;
						int num7 = RNG.Next(1, 100);
						foreach (DropShuXClass item9 in dropClass.DropShuX)
						{
							if (num7 <= item9.Max)
							{
								fLD_MAGIC5 = RNG.Next(item9.ShuXMin, item9.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC5;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				case 800000061:
					if (dropClass.FLD_MAGIC0 == 10)
					{
						int fLD_MAGIC = 0;
						int num3 = RNG.Next(1, 100);
						foreach (DropShuXClass item10 in dropClass.DropShuX)
						{
							if (num3 <= item10.Max)
							{
								fLD_MAGIC = RNG.Next(item10.ShuXMin, item10.ShuXMax - 1);
								break;
							}
						}
						dropClass.FLD_MAGIC0 = fLD_MAGIC;
					}
					else if (dropClass.FLD_MAGIC0 == 0)
					{
						dropClass.FLD_MAGIC0 = World.GetValue(dropClass.FLD_PID, 3);
					}
					break;
				}
				掉出物品(dropClass, yxqname);
				end_IL_0000:;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "暴物品   出错：" + ((ex != null) ? ex.ToString() : null));
			}
		}

		public void 异常状态列表()
		{
			if (异常状态 != null && 异常状态.Count != 0)
			{
				Queue queue = Queue.Synchronized(new Queue());
				try
				{
					foreach (异常状态类 value in 异常状态.Values)
					{
						queue.Enqueue(value);
					}
					while (queue.Count > 0)
					{
						异常状态类 异常状态类 = (异常状态类)queue.Dequeue();
						异常状态类.时间结束事件();
						if (异常状态 != null)
						{
							异常状态.Remove(异常状态类.FLD_PID);
						}
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "MPC异常状态列表出错![" + FLD_INDEX + "]-[" + Name + "]" + ex.Message);
				}
			}
		}

		public void 结束异常掉血状态列表()
		{
			if (异常掉血状态 != null)
			{
				Queue queue = Queue.Synchronized(new Queue());
				try
				{
					foreach (异常掉血状态类 value in 异常掉血状态.Values)
					{
						queue.Enqueue(value);
					}
					while (queue.Count > 0)
					{
						if (World.jlMsg == 1)
						{
							Form1.WriteLine(0, "异常掉血状态列表");
						}
						异常掉血状态类 异常掉血状态类 = (异常掉血状态类)queue.Dequeue();
						异常掉血状态类.时间结束事件();
						if (异常掉血状态 != null)
						{
							异常掉血状态.Remove(异常掉血状态类.FLD_PID);
						}
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "MPC异常掉血状态列表列表出错![" + FLD_INDEX + "]-[" + Name + "]" + ex.Message);
				}
				finally
				{
					queue = null;
				}
			}
		}

		public bool 查找范围Npc(int far_, NpcClass Npc)
		{
			if (Npc.Rxjh_Map != Rxjh_Map)
			{
				return false;
			}
			float num = Npc.Rxjh_X - Rxjh_X;
			float num2 = Npc.Rxjh_Y - Rxjh_Y;
			return (double)(int)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) <= (double)far_;
		}

		public bool 查找范围玩家(int far_, Players Playe)
		{
			if (Playe.人物坐标_地图 != Rxjh_Map)
			{
				return false;
			}
			if (Playe.人物坐标_地图 == 7101)
			{
				far_ = 1000;
			}
			float num = Playe.人物坐标_X - Rxjh_X;
			float num2 = Playe.人物坐标_Y - Rxjh_Y;
			return (double)(int)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) <= (double)far_;
		}

		public bool 查找范围玩家(int far_, 灵兽类 Playe)
		{
			if (Playe.人物坐标_MAP != Rxjh_Map)
			{
				return false;
			}
			float num = Playe.人物坐标_X - Rxjh_X;
			float num2 = Playe.人物坐标_Y - Rxjh_Y;
			return (double)(int)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) <= (double)far_;
		}

		public bool 获取范围玩家()
		{
			try
			{
				foreach (Players value in PlayList.Values)
				{
					if (value.人物_HP > 0 && 查找范围玩家(80, value))
					{
						Play_Add(value, 0);
						return true;
					}
				}
			}
			catch (Exception)
			{
				return false;
			}
			return false;
		}

		public void 广播数据(byte[] data, int length)
		{
			try
			{
				foreach (Players value2 in PlayList.Values)
				{
					if (value2.Client != null)
					{
						if (value2.Client.Running)
						{
							value2.Client.Send(data, length);
						}
						else
						{
							value2.Client.Dispose();
							PlayList.Remove(value2.人物全服ID);
						}
					}
					Players value;
					if (!World.allConnectedChars.TryGetValue(value2.Client.WorldId, out value))
					{
						Form1.WriteLine(2, "NPC   广播数据   删除卡号人物：[" + value2.Userid + "]   [" + value2.UserName + "]");
						if (value2.Client != null)
						{
							value2.Client.Dispose();
						}
						PlayList.Remove(value2.人物全服ID);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "NPC广播数据2   出错2：" + ((ex != null) ? ex.ToString() : null));
			}
		}
	}
}
