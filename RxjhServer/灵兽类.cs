using RxjhServer.DbClss;
using RxjhServer.Network;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RxjhServer
{
	public class 灵兽类 : IDisposable
	{
		private object thisLock = new object();

		public 武功类[,] 武功新 = new 武功类[2, 17];

		private float _人物坐标_X;

		private float _人物坐标_Y;

		private float _人物坐标_Z;

		private int _人物坐标_MAP;

		private long _Id;

		private int _Bs;

		private string _ZrName;

		private string _Name;

		private int _FLD_ZCD;

		private long _FLD_EXP;

		private long _最大经验;

		private long _FLD_EXP_MAX;

		private int _FLD_LEVEL;

		private int _FLD_JOB;

		private int _FLD_JOB_LEVEL;

		private int _FLD_HP;

		private int _FLD_HP_MAX;

		private int _FLD_MP;

		private int _FLD_MP_MAX;

		private int _FLD_物品_追加_HP;

		private int _FLD_物品_追加_MP;

		private int _FLD_负重;

		private int _FLD_负重_MAX;

		private int _FLD_攻击;

		private int _FLD_防御;

		private int _FLD_命中;

		private int _FLD_回避;

		private int _骑;

		private int _FLD_装备_追加_攻击;

		private int _FLD_装备_追加_防御;

		private int _FLD_装备_追加_命中;

		private int _FLD_装备_追加_回避;

		private int _FLD_装备_追加_HP;

		private int _FLD_装备_追加_MP;

		private double _FLD_装备_武功攻击力增加百分比;

		private double _FLD_装备_武功防御力增加百分比;

		private double _FLD_追加百分比_攻击;

		private double _FLD_追加百分比_防御;

		private double _FLD_追加百分比_命中;

		private double _FLD_追加百分比_回避;

		private double _FLD_追加百分比_HP上限;

		private double _FLD_追加百分比_MP上限;

		private double _FLD_灵兽_武功攻击力增加百分比;

		private double _FLD_灵兽_武功防御力增加百分比;

		private double _FLD_灵兽_获得经验增加百分比;

		private int _FLD_MAGIC1;

		private int _FLD_MAGIC2;

		private int _FLD_MAGIC3;

		private int _FLD_MAGIC4;

		private int _FLD_MAGIC5;

		public int 全服ID;

		public 物品类[] 宠物装备栏;

		public 物品类[] 宠物以装备;

		public Players Playe;

		private NetState client;

		public List<攻击类> 攻击列表;

		public bool _死亡;

		public float 人物坐标_X
		{
			get
			{
				return _人物坐标_X;
			}
			set
			{
				_人物坐标_X = value;
			}
		}

		public float 人物坐标_Y
		{
			get
			{
				return _人物坐标_Y;
			}
			set
			{
				_人物坐标_Y = value;
			}
		}

		public float 人物坐标_Z
		{
			get
			{
				return _人物坐标_Z;
			}
			set
			{
				_人物坐标_Z = value;
			}
		}

		public int 人物坐标_MAP
		{
			get
			{
				return _人物坐标_MAP;
			}
			set
			{
				_人物坐标_MAP = value;
			}
		}

		public long Id
		{
			get
			{
				return _Id;
			}
			set
			{
				_Id = value;
			}
		}

		public int Bs
		{
			get
			{
				return _Bs;
			}
			set
			{
				_Bs = value;
			}
		}

		public string ZrName
		{
			get
			{
				return _ZrName;
			}
			set
			{
				_ZrName = value;
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

		public int FLD_ZCD
		{
			get
			{
				return _FLD_ZCD;
			}
			set
			{
				_FLD_ZCD = value;
			}
		}

		public long FLD_EXP
		{
			get
			{
				return _FLD_EXP;
			}
			set
			{
				_FLD_EXP = value;
			}
		}

		public long 最大经验
		{
			get
			{
				return _最大经验;
			}
			set
			{
				_最大经验 = value;
			}
		}

		public long FLD_EXP_MAX
		{
			get
			{
				return _FLD_EXP_MAX;
			}
			set
			{
				_FLD_EXP_MAX = value;
			}
		}

		public int FLD_LEVEL
		{
			get
			{
				return _FLD_LEVEL;
			}
			set
			{
				_FLD_LEVEL = value;
			}
		}

		public int FLD_JOB
		{
			get
			{
				return _FLD_JOB;
			}
			set
			{
				_FLD_JOB = value;
			}
		}

		public int FLD_JOB_LEVEL
		{
			get
			{
				return _FLD_JOB_LEVEL;
			}
			set
			{
				_FLD_JOB_LEVEL = value;
			}
		}

		public int FLD_HP
		{
			get
			{
				return _FLD_HP;
			}
			set
			{
				_FLD_HP = value;
			}
		}

		public int FLD_HP_MAX
		{
			get
			{
				return _FLD_HP_MAX;
			}
			set
			{
				_FLD_HP_MAX = value;
			}
		}

		public int FLD_MP
		{
			get
			{
				return _FLD_MP;
			}
			set
			{
				_FLD_MP = value;
			}
		}

		public int FLD_MP_MAX
		{
			get
			{
				return _FLD_MP_MAX;
			}
			set
			{
				_FLD_MP_MAX = value;
			}
		}

		public int FLD_物品_追加_HP
		{
			get
			{
				return _FLD_物品_追加_HP;
			}
			set
			{
				_FLD_物品_追加_HP = value;
			}
		}

		public int FLD_物品_追加_MP
		{
			get
			{
				return _FLD_物品_追加_MP;
			}
			set
			{
				_FLD_物品_追加_MP = value;
			}
		}

		public int 灵兽基本最大_HP
		{
			get
			{
				return (int)((double)(FLD_HP_MAX + FLD_物品_追加_HP + FLD_装备_追加_HP) * (1.0 + FLD_追加百分比_HP上限));
			}
		}

		public int 灵兽基本最大_MP
		{
			get
			{
				return (int)((double)(FLD_MP_MAX + FLD_物品_追加_MP + FLD_装备_追加_MP) * (1.0 + FLD_追加百分比_MP上限));
			}
		}

		public int 灵兽基本攻击
		{
			get
			{
				return (int)((double)(FLD_攻击 + FLD_装备_追加_攻击) * (1.0 + FLD_追加百分比_攻击));
			}
		}

		public int 灵兽基本防御
		{
			get
			{
				return (int)((double)(FLD_防御 + FLD_装备_追加_防御) * (1.0 + FLD_追加百分比_防御));
			}
		}

		public int 灵兽基本命中
		{
			get
			{
				return (int)((double)(FLD_命中 + FLD_装备_追加_命中) * (1.0 + FLD_追加百分比_命中));
			}
		}

		public int 灵兽基本回避
		{
			get
			{
				return (int)((double)(FLD_回避 + FLD_装备_追加_回避) * (1.0 + FLD_追加百分比_回避));
			}
		}

		public int FLD_负重
		{
			get
			{
				return _FLD_负重;
			}
			set
			{
				_FLD_负重 = value;
			}
		}

		public int FLD_负重_MAX
		{
			get
			{
				return _FLD_负重_MAX;
			}
			set
			{
				_FLD_负重_MAX = value;
			}
		}

		public int FLD_攻击
		{
			get
			{
				return _FLD_攻击;
			}
			set
			{
				_FLD_攻击 = value;
			}
		}

		public int FLD_防御
		{
			get
			{
				return _FLD_防御;
			}
			set
			{
				_FLD_防御 = value;
			}
		}

		public int FLD_命中
		{
			get
			{
				return _FLD_命中;
			}
			set
			{
				_FLD_命中 = value;
			}
		}

		public int FLD_回避
		{
			get
			{
				return _FLD_回避;
			}
			set
			{
				_FLD_回避 = value;
			}
		}

		public int 骑
		{
			get
			{
				return _骑;
			}
			set
			{
				_骑 = value;
			}
		}

		public int FLD_装备_追加_攻击
		{
			get
			{
				return _FLD_装备_追加_攻击;
			}
			set
			{
				_FLD_装备_追加_攻击 = value;
			}
		}

		public int FLD_装备_追加_防御
		{
			get
			{
				return _FLD_装备_追加_防御;
			}
			set
			{
				_FLD_装备_追加_防御 = value;
			}
		}

		public int FLD_装备_追加_命中
		{
			get
			{
				return _FLD_装备_追加_命中;
			}
			set
			{
				_FLD_装备_追加_命中 = value;
			}
		}

		public int FLD_装备_追加_回避
		{
			get
			{
				return _FLD_装备_追加_回避;
			}
			set
			{
				_FLD_装备_追加_回避 = value;
			}
		}

		public int FLD_装备_追加_HP
		{
			get
			{
				return _FLD_装备_追加_HP;
			}
			set
			{
				_FLD_装备_追加_HP = value;
			}
		}

		public int FLD_装备_追加_MP
		{
			get
			{
				return _FLD_装备_追加_MP;
			}
			set
			{
				_FLD_装备_追加_MP = value;
			}
		}

		public double FLD_装备_武功攻击力增加百分比
		{
			get
			{
				return _FLD_装备_武功攻击力增加百分比;
			}
			set
			{
				_FLD_装备_武功攻击力增加百分比 = value;
			}
		}

		public double FLD_装备_武功防御力增加百分比
		{
			get
			{
				return _FLD_装备_武功防御力增加百分比;
			}
			set
			{
				_FLD_装备_武功防御力增加百分比 = value;
			}
		}

		public double FLD_追加百分比_攻击
		{
			get
			{
				return _FLD_追加百分比_攻击;
			}
			set
			{
				_FLD_追加百分比_攻击 = value;
			}
		}

		public double FLD_追加百分比_防御
		{
			get
			{
				return _FLD_追加百分比_防御;
			}
			set
			{
				_FLD_追加百分比_防御 = value;
			}
		}

		public double FLD_追加百分比_命中
		{
			get
			{
				return _FLD_追加百分比_命中;
			}
			set
			{
				_FLD_追加百分比_命中 = value;
			}
		}

		public double FLD_追加百分比_回避
		{
			get
			{
				return _FLD_追加百分比_回避;
			}
			set
			{
				_FLD_追加百分比_回避 = value;
			}
		}

		public double FLD_追加百分比_HP上限
		{
			get
			{
				return _FLD_追加百分比_HP上限;
			}
			set
			{
				_FLD_追加百分比_HP上限 = value;
			}
		}

		public double FLD_追加百分比_MP上限
		{
			get
			{
				return _FLD_追加百分比_MP上限;
			}
			set
			{
				_FLD_追加百分比_MP上限 = value;
			}
		}

		public double FLD_灵兽_武功攻击力增加百分比
		{
			get
			{
				return _FLD_灵兽_武功攻击力增加百分比;
			}
			set
			{
				_FLD_灵兽_武功攻击力增加百分比 = value;
			}
		}

		public double FLD_灵兽_武功防御力增加百分比
		{
			get
			{
				return _FLD_灵兽_武功防御力增加百分比;
			}
			set
			{
				_FLD_灵兽_武功防御力增加百分比 = value;
			}
		}

		public double FLD_灵兽_获得经验增加百分比
		{
			get
			{
				return _FLD_灵兽_获得经验增加百分比;
			}
			set
			{
				_FLD_灵兽_获得经验增加百分比 = value;
			}
		}

		public int FLD_MAGIC1
		{
			get
			{
				return _FLD_MAGIC1;
			}
			set
			{
				_FLD_MAGIC1 = value;
			}
		}

		public int FLD_MAGIC2
		{
			get
			{
				return _FLD_MAGIC2;
			}
			set
			{
				_FLD_MAGIC2 = value;
			}
		}

		public int FLD_MAGIC3
		{
			get
			{
				return _FLD_MAGIC3;
			}
			set
			{
				_FLD_MAGIC3 = value;
			}
		}

		public int FLD_MAGIC4
		{
			get
			{
				return _FLD_MAGIC4;
			}
			set
			{
				_FLD_MAGIC4 = value;
			}
		}

		public int FLD_MAGIC5
		{
			get
			{
				return _FLD_MAGIC5;
			}
			set
			{
				_FLD_MAGIC5 = value;
			}
		}

		public bool 死亡
		{
			get
			{
				if (FLD_HP <= 0)
				{
					_死亡 = false;
				}
				return _死亡;
			}
			set
			{
				_死亡 = value;
			}
		}

		public void addFLD_追加百分比_攻击(double i)
		{
			using (new Lock(thisLock, "addFLD_追加百分比_攻击"))
			{
				FLD_追加百分比_攻击 += i;
			}
		}

		public void dllFLD_追加百分比_攻击(double i)
		{
			using (new Lock(thisLock, "dllFLD_追加百分比_攻击"))
			{
				FLD_追加百分比_攻击 -= i;
			}
		}

		public void addFLD_追加百分比_防御(double i)
		{
			using (new Lock(thisLock, "addFLD_追加百分比_防御"))
			{
				FLD_追加百分比_防御 += i;
			}
		}

		public void dllFLD_追加百分比_防御(double i)
		{
			using (new Lock(thisLock, "dllFLD_追加百分比_防御"))
			{
				FLD_追加百分比_防御 -= i;
			}
		}

		~灵兽类()
		{
		}

		public void Dispose()
		{
			Playe = null;
			client = null;
		}

		public bool 查找范围Npc(int far_, NpcClass Npc)
		{
			if (Npc.Rxjh_Map != 人物坐标_MAP)
			{
				return false;
			}
			float num = Npc.Rxjh_X - 人物坐标_X;
			float num2 = Npc.Rxjh_Y - 人物坐标_Y;
			return (double)(int)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) <= (double)far_;
		}

		public 灵兽类(long id, NetState clien, DataTable table2, Players Playe)
		{
			this.Playe = Playe;
			client = clien;
			_Id = id;
			ZrName = table2.Rows[0]["ZrName"].ToString();
			Name = table2.Rows[0]["Name"].ToString();
			FLD_ZCD = (int)table2.Rows[0]["FLD_ZCD"];
			FLD_EXP = long.Parse(table2.Rows[0]["FLD_EXP"].ToString());
			FLD_LEVEL = (int)table2.Rows[0]["FLD_LEVEL"];
			FLD_JOB = (int)table2.Rows[0]["FLD_JOB"];
			FLD_JOB_LEVEL = (int)table2.Rows[0]["FLD_JOB_LEVEL"];
			FLD_HP = (int)table2.Rows[0]["FLD_HP"];
			FLD_MP = (int)table2.Rows[0]["FLD_MP"];
			Bs = (int)table2.Rows[0]["FLD_BS"];
			FLD_MAGIC1 = (int)table2.Rows[0]["FLD_MAGIC1"];
			FLD_MAGIC2 = (int)table2.Rows[0]["FLD_MAGIC2"];
			FLD_MAGIC3 = (int)table2.Rows[0]["FLD_MAGIC3"];
			FLD_MAGIC4 = (int)table2.Rows[0]["FLD_MAGIC4"];
			FLD_MAGIC5 = (int)table2.Rows[0]["FLD_MAGIC5"];
			FLD_EXP_MAX = 100000L;
			FLD_攻击 = 1000;
			FLD_防御 = 1000;
			FLD_命中 = 1000;
			FLD_回避 = 1000;
			FLD_负重 = 0;
			FLD_负重_MAX = 100;
			FLD_物品_追加_HP = 0;
			FLD_物品_追加_MP = 0;
			FLD_装备_追加_攻击 = 0;
			FLD_装备_追加_防御 = 0;
			FLD_装备_追加_命中 = 0;
			FLD_装备_追加_回避 = 0;
			FLD_装备_追加_HP = 0;
			FLD_装备_追加_MP = 0;
			FLD_装备_武功攻击力增加百分比 = 0.0;
			FLD_装备_武功防御力增加百分比 = 0.0;
			FLD_追加百分比_命中 = 0.0;
			FLD_追加百分比_回避 = 0.0;
			FLD_追加百分比_攻击 = 0.0;
			FLD_追加百分比_防御 = 0.0;
			FLD_追加百分比_HP上限 = 0.0;
			FLD_追加百分比_MP上限 = 0.0;
			FLD_灵兽_武功防御力增加百分比 = 0.0;
			FLD_灵兽_武功攻击力增加百分比 = 0.0;
			FLD_灵兽_获得经验增加百分比 = 0.0;
			宠物装备栏 = new 物品类[16];
			宠物以装备 = new 物品类[5];
			武功新 = new 武功类[2, 16];
			攻击列表 = new List<攻击类>();
			byte[] src = (byte[])table2.Rows[0]["FLD_ITEM"];
			for (int i = 0; i < 16; i++)
			{
				byte[] array = new byte[World.数据库单个物品大小];
				try
				{
					System.Buffer.BlockCopy(src, i * World.数据库单个物品大小, array, 0, World.数据库单个物品大小);
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
				}
				宠物装备栏[i] = new 物品类(array, i);
				_FLD_负重 += 宠物装备栏[i].物品总重量;
			}
			byte[] src2 = (byte[])table2.Rows[0]["FLD_WEARITEM"];
			for (int j = 0; j < 5; j++)
			{
				byte[] array2 = new byte[World.数据库单个物品大小];
				try
				{
					System.Buffer.BlockCopy(src2, j * World.数据库单个物品大小, array2, 0, World.数据库单个物品大小);
				}
				catch (Exception value2)
				{
					Console.WriteLine(value2);
				}
				宠物以装备[j] = new 物品类(array2, j);
				_FLD_负重 += 宠物以装备[j].物品总重量;
			}
			byte[] array3 = (byte[])table2.Rows[0]["FLD_KONGFU"];
			for (int k = 0; k < 32; k++)
			{
				byte[] array4 = new byte[4];
				try
				{
					if (array3.Length >= k * 4 + 4)
					{
						System.Buffer.BlockCopy(array3, k * 4, array4, 0, 4);
						int num = Buffer.ToInt32(array4, 0);
						if (num != 0)
						{
							武功类 武功类 = new 武功类(num);
							if (武功类.FLD_JOB != 0)
							{
								switch (武功类.FLD_JOB)
								{
								case 7:
									if (FLD_JOB != 1)
									{
										continue;
									}
									break;
								case 8:
									if (FLD_JOB != 2)
									{
										continue;
									}
									break;
								case 9:
									if (FLD_JOB != 3)
									{
										continue;
									}
									break;
								case 10:
									if (FLD_JOB != 4)
									{
										continue;
									}
									break;
								}
							}
							if (FLD_JOB_LEVEL >= 武功类.FLD_JOBLEVEL && FLD_LEVEL >= 武功类.FLD_LEVEL)
							{
								武功新[武功类.FLD_武功类型, 武功类.FLD_INDEX] = 武功类;
							}
						}
						continue;
					}
				}
				catch (Exception value3)
				{
					Console.WriteLine(value3);
					continue;
				}
				break;
			}
			计算基本数据();
			计算灵兽装备数据();
		}

		public void 计算基本数据()
		{
			if (FLD_LEVEL > 99)
			{
				FLD_LEVEL = 99;
			}
			最大经验 = (long)World.lever[FLD_LEVEL];
			int fLD_LEVEL = FLD_LEVEL;
			while (FLD_LEVEL < 99)
			{
				if (client == null || !client.Running)
				{
					return;
				}
				int num;
				if (FLD_EXP < 最大经验)
				{
					if (FLD_LEVEL != 1 && (double)(FLD_EXP - Convert.ToInt64(World.lever[FLD_LEVEL - 1])) < 1.0)
					{
						num = --FLD_LEVEL;
						最大经验 = (long)World.lever[FLD_LEVEL];
					}
					break;
				}
				num = ++FLD_LEVEL;
				最大经验 = (long)World.lever[FLD_LEVEL];
			}
			if (FLD_LEVEL - fLD_LEVEL != 0)
			{
				if (FLD_LEVEL - fLD_LEVEL > 0 && client.Player.人物灵兽 != null)
				{
					client.Player.灵兽升级后的提示();
				}
				if (client.Player.人物灵兽 != null)
				{
					client.Player.更新灵兽HP_MP_SP();
					client.Player.更新灵兽武功和状态();
				}
			}
			FLD_负重_MAX = 500 + 20 * FLD_LEVEL;
			switch (_FLD_JOB)
			{
			case 1:
			{
				_FLD_HP_MAX = 133 + FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + FLD_LEVEL * 2;
				FLD_命中 = 8 + FLD_LEVEL;
				FLD_回避 = 8 + FLD_LEVEL;
				FLD_攻击 = 9;
				FLD_防御 = 16;
				for (int j = 2; j <= FLD_LEVEL; j++)
				{
					if (j % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						int num2 = ++FLD_攻击;
						num2 = ++FLD_防御;
					}
				}
				break;
			}
			case 2:
			{
				_FLD_HP_MAX = 133 + FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + FLD_LEVEL * 2;
				FLD_命中 = 8 + FLD_LEVEL;
				FLD_回避 = 8 + FLD_LEVEL;
				FLD_攻击 = 9;
				FLD_防御 = 16;
				for (int l = 2; l <= FLD_LEVEL; l++)
				{
					if (l % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						int num2 = ++FLD_攻击;
						num2 = ++FLD_防御;
					}
				}
				break;
			}
			case 3:
			{
				_FLD_HP_MAX = 133 + FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + FLD_LEVEL * 2;
				FLD_命中 = 8 + FLD_LEVEL;
				FLD_回避 = 8 + FLD_LEVEL;
				FLD_攻击 = 9;
				FLD_防御 = 16;
				for (int m = 2; m <= FLD_LEVEL; m++)
				{
					if (m % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						int num2 = ++FLD_攻击;
						num2 = ++FLD_防御;
					}
				}
				break;
			}
			case 4:
			{
				_FLD_HP_MAX = 133 + FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + FLD_LEVEL * 2;
				FLD_命中 = 8 + FLD_LEVEL;
				FLD_回避 = 8 + FLD_LEVEL;
				FLD_攻击 = 9;
				FLD_防御 = 16;
				for (int k = 2; k <= FLD_LEVEL; k++)
				{
					if (k % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						int num2 = ++FLD_攻击;
						num2 = ++FLD_防御;
					}
				}
				break;
			}
			case 5:
			{
				_FLD_HP_MAX = 133 + FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + FLD_LEVEL * 2;
				FLD_命中 = 8 + FLD_LEVEL;
				FLD_回避 = 8 + FLD_LEVEL;
				FLD_攻击 = 9;
				FLD_防御 = 16;
				for (int i = 2; i <= FLD_LEVEL; i++)
				{
					if (i % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						int num2 = ++FLD_攻击;
						num2 = ++FLD_防御;
					}
				}
				break;
			}
			}
			switch (_FLD_JOB_LEVEL)
			{
			case 1:
				FLD_攻击 += 5;
				FLD_防御 += 5;
				_FLD_HP_MAX += 85;
				_FLD_MP_MAX += 50;
				break;
			case 2:
				FLD_攻击 += 15;
				FLD_防御 += 15;
				_FLD_HP_MAX += 200;
				_FLD_MP_MAX += 150;
				break;
			case 3:
				FLD_攻击 += 35;
				FLD_防御 += 35;
				_FLD_HP_MAX += 400;
				_FLD_MP_MAX += 350;
				break;
			}
			if (FLD_JOB == 1)
			{
				Playe.FLD_宠物_追加_最大HP = (FLD_LEVEL + 1) * 3;
			}
			else if (FLD_JOB == 5)
			{
				Playe.FLD_宠物_追加_最大HP = (FLD_LEVEL + 1) * 2;
				Playe.FLD_宠物_追加_防御 = (int)((double)(FLD_LEVEL + 1) * 0.5);
				Playe.FLD_宠物_追加_攻击 = (int)((double)(FLD_LEVEL + 1) * 0.5);
			}
			else
			{
				Playe.FLD_宠物_追加_最大HP = (FLD_LEVEL + 1) * 2;
				Playe.FLD_宠物_追加_防御 = (int)((double)(FLD_LEVEL + 1) * 0.5);
			}
			Playe.更新HP_MP_SP();
			Playe.更新武功和状态();
		}

		public void 计算灵兽装备数据()
		{
			using (new Lock(thisLock, "计算宠物装备数据"))
			{
				FLD_装备_追加_攻击 = 0;
				FLD_装备_追加_防御 = 0;
				FLD_装备_追加_命中 = 0;
				FLD_装备_追加_回避 = 0;
				FLD_装备_追加_HP = 0;
				FLD_装备_追加_MP = 0;
				FLD_装备_武功攻击力增加百分比 = 0.0;
				FLD_装备_武功防御力增加百分比 = 0.0;
				FLD_灵兽_获得经验增加百分比 = 0.0;
				for (int i = 0; i < 4; i++)
				{
					if (宠物以装备[i].Get物品ID != 0L)
					{
						宠物以装备[i].得到物品属性方法(0, 0);
						FLD_装备_追加_攻击 += (宠物以装备[i].物品攻击力 + 宠物以装备[i].物品攻击力MAX) / 2;
						FLD_装备_追加_防御 += 宠物以装备[i].物品防御力;
						FLD_装备_追加_命中 += 宠物以装备[i].物品属性_命中率增加;
						FLD_装备_追加_回避 += 宠物以装备[i].物品属性_回避率增加;
						FLD_装备_追加_HP += 宠物以装备[i].物品属性_生命力增加;
						FLD_装备_追加_MP += 宠物以装备[i].物品属性_内功力增加;
						double num = 宠物以装备[i].物品属性_武功攻击力;
						double num2 = (double)宠物以装备[i].物品属性_武功防御力增加 * (1.0 - World.武功防降低百分比);
						FLD_装备_武功攻击力增加百分比 += num * 0.01;
						FLD_装备_武功防御力增加百分比 += num2 * 0.01;
						int fLD_RESIDE = 宠物以装备[i].FLD_RESIDE2;
					}
				}
				得到兽灵丹属性(FLD_MAGIC1.ToString());
				得到兽灵丹属性(FLD_MAGIC2.ToString());
				得到兽灵丹属性(FLD_MAGIC3.ToString());
				得到兽灵丹属性(FLD_MAGIC4.ToString());
				得到兽灵丹属性(FLD_MAGIC5.ToString());
			}
		}

		public void 得到兽灵丹属性(string ysqh)
		{
			try
			{
				if (!Buffer.IsEquals(ysqh, "0"))
				{
					string s;
					switch (ysqh.Length)
					{
					default:
						return;
					case 9:
						s = ysqh.Substring(0, 2);
						break;
					case 8:
						s = ysqh.Substring(0, 1);
						break;
					}
					int num = int.Parse(ysqh.Substring(ysqh.Length - 2, 2));
					switch (int.Parse(s))
					{
					case 8:
					case 9:
					case 10:
					case 12:
					case 13:
					case 14:
						break;
					case 1:
						FLD_装备_追加_攻击 += num;
						break;
					case 2:
						FLD_装备_追加_防御 += num;
						break;
					case 3:
						FLD_装备_追加_HP += num;
						break;
					case 4:
						FLD_装备_追加_MP += num;
						break;
					case 5:
						FLD_装备_追加_命中 += num;
						break;
					case 6:
						FLD_装备_追加_回避 += num;
						break;
					case 7:
						FLD_装备_武功攻击力增加百分比 += (double)num * 0.01;
						break;
					case 11:
						FLD_装备_武功防御力增加百分比 += (double)num * 0.01;
						break;
					case 15:
						FLD_灵兽_获得经验增加百分比 += (double)num * 0.01;
						break;
					}
				}
			}
			catch
			{
			}
		}

		public void 保存数据()
		{
			SqlParameter[] prams = new SqlParameter[18]
			{
				SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, _Id.ToString()),
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, Name),
				SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, FLD_LEVEL),
				SqlDBA.MakeInParam("@zcd", SqlDbType.Int, 10, FLD_ZCD),
				SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, FLD_JOB),
				SqlDBA.MakeInParam("@job_level", SqlDbType.Int, 0, FLD_JOB_LEVEL),
				SqlDBA.MakeInParam("@exp", SqlDbType.VarChar, 50, FLD_EXP.ToString()),
				SqlDBA.MakeInParam("@hp", SqlDbType.Int, 0, FLD_HP),
				SqlDBA.MakeInParam("@mp", SqlDbType.Int, 0, FLD_MP),
				SqlDBA.MakeInParam("@strWearitem", SqlDbType.VarBinary, 385, GetWEARITEMCodes()),
				SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 1232, GetFLD_ITEMCodes()),
				SqlDBA.MakeInParam("@strKongfu", SqlDbType.VarBinary, 128, GetFLD_KONGFUCodes()),
				SqlDBA.MakeInParam("@bs", SqlDbType.Int, 0, Bs),
				SqlDBA.MakeInParam("@MAGIC1", SqlDbType.Int, 0, FLD_MAGIC1),
				SqlDBA.MakeInParam("@MAGIC2", SqlDbType.Int, 0, FLD_MAGIC2),
				SqlDBA.MakeInParam("@MAGIC3", SqlDbType.Int, 0, FLD_MAGIC3),
				SqlDBA.MakeInParam("@MAGIC4", SqlDbType.Int, 0, FLD_MAGIC4),
				SqlDBA.MakeInParam("@MAGIC5", SqlDbType.Int, 0, FLD_MAGIC5)
			};
			World.SqlPool.Enqueue(new DbPoolClass
			{
				Conn = DBA.getstrConnection(null),
				Prams = prams,
				Sql = "XWWL_UPDATE_Cw_DATA"
			});
		}

		public byte[] GetWEARITEMCodes()
		{
			byte[] array = new byte[World.数据库单个物品大小 * 5];
			for (int i = 0; i < 5; i++)
			{
				byte[] src;
				try
				{
					src = 宠物以装备[i].物品_byte;
				}
				catch
				{
					src = new byte[World.数据库单个物品大小];
				}
				System.Buffer.BlockCopy(src, 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
			}
			return array;
		}

		public byte[] GetFLD_ITEMCodes()
		{
			byte[] array = new byte[World.数据库单个物品大小 * 16];
			for (int i = 0; i < 16; i++)
			{
				byte[] src;
				try
				{
					src = 宠物装备栏[i].物品_byte;
				}
				catch
				{
					src = new byte[World.数据库单个物品大小];
				}
				System.Buffer.BlockCopy(src, 0, array, i * World.数据库单个物品大小, World.数据库单个物品大小);
			}
			return array;
		}

		public byte[] GetFLD_KONGFUCodes()
		{
			发包类 发包类 = new 发包类();
			try
			{
				for (int i = 0; i < 2; i++)
				{
					for (int j = 0; j < 17; j++)
					{
						if (武功新[i, j] != null)
						{
							发包类.Write4(武功新[i, j].FLD_PID);
						}
					}
				}
			}
			catch
			{
			}
			return 发包类.ToArray3();
		}
	}
}
