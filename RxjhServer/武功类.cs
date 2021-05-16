using System;

namespace RxjhServer
{
	public class 武功类 : IDisposable
	{
		private int _武功_等级;

		private int _FLD_PID;

		private string _FLD_NAME;

		private string _FLD_每级危害;

		private int _FLD_ZX;

		private int _FLD_JOB;

		private int _FLD_JOBLEVEL;

		private int _FLD_LEVEL;

		private int _FLD_MP;

		private int _FLD_NEEDEXP;

		private int _FLD_AT;

		public int FLD_TYPE;

		private int _FLD_EFFERT;

		private int _FLD_INDEX;

		private int _FLD_攻击数量;

		private int _FLD_武功类型;

		private int _FLD_TIME;

		private int _FLD_DEATHTIME;

		private int _FLD_CDTIME;

		private int _FLD_武功最高级别;

		private int _FLD_每级加MP;

		private int _FLD_每级加历练;

		private int _FLD_每级加危害;

		private int _FLD_每级武功点数;

		private int _FLD_每级加修炼等级;

		public int 武功_等级
		{
			get
			{
				return _武功_等级;
			}
			set
			{
				_武功_等级 = value;
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

		public string FLD_NAME
		{
			get
			{
				return _FLD_NAME;
			}
			set
			{
				_FLD_NAME = value;
			}
		}

		public string FLD_每级危害
		{
			get
			{
				return _FLD_每级危害;
			}
			set
			{
				_FLD_每级危害 = value;
			}
		}

		public int FLD_ZX
		{
			get
			{
				return _FLD_ZX;
			}
			set
			{
				_FLD_ZX = value;
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

		public int FLD_JOBLEVEL
		{
			get
			{
				return _FLD_JOBLEVEL;
			}
			set
			{
				_FLD_JOBLEVEL = value;
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

		public int FLD_NEEDEXP
		{
			get
			{
				return _FLD_NEEDEXP;
			}
			set
			{
				_FLD_NEEDEXP = value;
			}
		}

		public int FLD_AT
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

		public int FLD_EFFERT
		{
			get
			{
				return _FLD_EFFERT;
			}
			set
			{
				_FLD_EFFERT = value;
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

		public int FLD_攻击数量
		{
			get
			{
				return _FLD_攻击数量;
			}
			set
			{
				_FLD_攻击数量 = value;
			}
		}

		public int FLD_武功类型
		{
			get
			{
				return _FLD_武功类型;
			}
			set
			{
				_FLD_武功类型 = value;
			}
		}

		public int FLD_TIME
		{
			get
			{
				return _FLD_TIME;
			}
			set
			{
				_FLD_TIME = value;
			}
		}

		public int FLD_DEATHTIME
		{
			get
			{
				return _FLD_DEATHTIME;
			}
			set
			{
				_FLD_DEATHTIME = value;
			}
		}

		public int FLD_CDTIME
		{
			get
			{
				return _FLD_CDTIME;
			}
			set
			{
				_FLD_CDTIME = value;
			}
		}

		public int FLD_武功最高级别
		{
			get
			{
				return _FLD_武功最高级别;
			}
			set
			{
				_FLD_武功最高级别 = value;
			}
		}

		public int FLD_每级加MP
		{
			get
			{
				return _FLD_每级加MP;
			}
			set
			{
				_FLD_每级加MP = value;
			}
		}

		public int FLD_每级加历练
		{
			get
			{
				return _FLD_每级加历练;
			}
			set
			{
				_FLD_每级加历练 = value;
			}
		}

		public int FLD_每级加危害
		{
			get
			{
				return _FLD_每级加危害;
			}
			set
			{
				_FLD_每级加危害 = value;
			}
		}

		public int FLD_每级武功点数
		{
			get
			{
				return _FLD_每级武功点数;
			}
			set
			{
				_FLD_每级武功点数 = value;
			}
		}

		public int FLD_每级加修炼等级
		{
			get
			{
				return _FLD_每级加修炼等级;
			}
			set
			{
				_FLD_每级加修炼等级 = value;
			}
		}

		public byte[] 武功ID_byte
		{
			get
			{
				return Buffer.GetBytes(FLD_PID);
			}
		}

		public 武功类()
		{
		}

		public 武功类(int FLD_PID_)
		{
			FLD_PID = FLD_PID_;
			初始化武功(FLD_PID);
		}

		public void Dispose()
		{
		}

		public void 初始化武功(int id)
		{
			武功类 value;
			if (World.TBL_KONGFU.TryGetValue(id, out value))
			{
				FLD_NAME = value.FLD_NAME;
				FLD_AT = value.FLD_AT;
				FLD_EFFERT = value.FLD_EFFERT;
				FLD_INDEX = value.FLD_INDEX;
				FLD_JOB = value.FLD_JOB;
				FLD_JOBLEVEL = value.FLD_JOBLEVEL;
				FLD_LEVEL = value.FLD_LEVEL;
				FLD_MP = value.FLD_MP;
				FLD_NEEDEXP = value.FLD_NEEDEXP;
				FLD_PID = value.FLD_PID;
				FLD_TYPE = value.FLD_TYPE;
				FLD_ZX = value.FLD_ZX;
				FLD_攻击数量 = value.FLD_攻击数量;
				FLD_武功类型 = value.FLD_武功类型;
				FLD_每级加MP = value.FLD_每级加MP;
				FLD_每级加历练 = value.FLD_每级加历练;
				FLD_每级加危害 = value.FLD_每级加危害;
				FLD_每级武功点数 = value.FLD_每级武功点数;
				FLD_DEATHTIME = value.FLD_DEATHTIME;
				FLD_CDTIME = value.FLD_CDTIME;
				FLD_武功最高级别 = value.FLD_武功最高级别;
				FLD_每级加修炼等级 = value.FLD_每级加修炼等级;
				FLD_每级危害 = value.FLD_每级危害;
			}
		}

		public int GetAt(int pid, int Level)
		{
			try
			{
				武功类 value;
				if (World.TBL_KONGFU.TryGetValue(pid, out value))
				{
					return int.Parse(value.FLD_每级危害.Split(';')[Level - 1]);
				}
			}
			catch
			{
			}
			return 0;
		}

		public static 武功类 GetWg(int 人物正邪, int 人物职业, int FLD_武功类型, int FLD_INDEX)
		{
			foreach (武功类 value in World.TBL_KONGFU.Values)
			{
				if (value.FLD_ZX == 0)
				{
					if (value.FLD_JOB == 人物职业 && value.FLD_INDEX == FLD_INDEX && value.FLD_武功类型 == FLD_武功类型)
					{
						return value;
					}
				}
				else if (value.FLD_ZX == 人物正邪 && value.FLD_JOB == 人物职业 && value.FLD_INDEX == FLD_INDEX && value.FLD_武功类型 == FLD_武功类型)
				{
					return value;
				}
			}
			return null;
		}

		public static 武功类 GetWg(int 武功ID)
		{
			foreach (武功类 value in World.TBL_KONGFU.Values)
			{
				if (value.FLD_PID == 武功ID)
				{
					return value;
				}
			}
			return null;
		}

		public static 武功类 Getsfewg(Players Playe, int wgid)
		{
			武功类 value;
			if (World.TBL_KONGFU.TryGetValue(wgid, out value) && value != null && Playe.武功新[value.FLD_武功类型, value.FLD_INDEX] != null && Playe.武功新[value.FLD_武功类型, value.FLD_INDEX].FLD_PID == wgid)
			{
				return Playe.武功新[value.FLD_武功类型, value.FLD_INDEX];
			}
			return null;
		}

		public static bool GetsfeWg(Players Playe, int wgid)
		{
			武功类 value;
			if (World.TBL_KONGFU.TryGetValue(wgid, out value) && value != null)
			{
				return Playe.武功新[value.FLD_武功类型, value.FLD_INDEX].FLD_PID == wgid;
			}
			return false;
		}

		public static 武功类 GetWg2(Players Playe, int FLD_武功类型, int FLD_INDEX)
		{
			foreach (武功类 value in World.TBL_KONGFU.Values)
			{
				if (value.FLD_JOB == Playe.Player_Job && value.FLD_INDEX == FLD_INDEX && value.FLD_武功类型 == FLD_武功类型)
				{
					return value;
				}
			}
			return null;
		}

		public static bool 检查修炼条件(Players Playe, int FLD_武功类型, int FLD_INDEX)
		{
			武功类 wg = GetWg(Playe.Player_Zx, Playe.Player_Job, FLD_武功类型, FLD_INDEX);
			if (wg != null)
			{
				if ((wg.FLD_ZX != 0 && Playe.Player_Zx != wg.FLD_ZX) || (wg.FLD_JOB != 0 && Playe.Player_Job != wg.FLD_JOB) || (wg.FLD_JOBLEVEL != 0 && Playe.Player_Job_leve < wg.FLD_JOBLEVEL) || (wg.FLD_LEVEL != 0 && Playe.Player_Level < wg.FLD_LEVEL))
				{
					return false;
				}
				if (Playe.武功新[FLD_武功类型, FLD_INDEX] != null)
				{
					Playe.系统提示("武功 " + wg.FLD_NAME + " 不能重复修炼。");
					return false;
				}
			}
			return true;
		}

		public static void 学习武功书(Players Playe, int FLD_武功类型, int FLD_INDEX)
		{
			武功类 wg = GetWg(Playe.Player_Zx, Playe.Player_Job, FLD_武功类型, FLD_INDEX);
			if (wg != null)
			{
				Playe.武功新[wg.FLD_武功类型, wg.FLD_INDEX] = new 武功类(wg.FLD_PID);
				if (wg.FLD_武功类型 == 3)
				{
					Playe.武功新[wg.FLD_武功类型, wg.FLD_INDEX].武功_等级 = 1;
				}
				if ((Playe.Player_Job == 8 || Playe.Player_Job == 9) && (wg.FLD_武功类型 == 0 || wg.FLD_武功类型 == 3))
				{
					Playe.武功新[wg.FLD_武功类型, wg.FLD_INDEX].武功_等级 = 1;
				}
			}
		}
	}
}
