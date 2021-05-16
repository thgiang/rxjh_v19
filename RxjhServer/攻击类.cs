using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class 攻击类 : IDisposable
	{
		public List<群攻击类> 群攻;

		private int _人物ID;

		private int _武功ID;

		private int _攻击力;

		private int _攻击类型;

		public int 人物ID
		{
			get
			{
				return _人物ID;
			}
			set
			{
				_人物ID = value;
			}
		}

		public int 武功ID
		{
			get
			{
				return _武功ID;
			}
			set
			{
				_武功ID = value;
			}
		}

		public int 攻击力
		{
			get
			{
				return _攻击力;
			}
			set
			{
				_攻击力 = value;
			}
		}

		public int 攻击类型
		{
			get
			{
				return _攻击类型;
			}
			set
			{
				_攻击类型 = value;
			}
		}

		public 攻击类(int 人物ID_, int 武功ID_, int 攻击力_, int 攻击类型_, int 群攻l, bool 卢风郎)
		{
			人物ID = 人物ID_;
			武功ID = 武功ID_;
			攻击力 = 攻击力_;
			攻击类型 = 攻击类型_;
			if (群攻l == 4 || 卢风郎)
			{
				群攻 = new List<群攻击类>();
			}
		}

		public void Dispose()
		{
			if (群攻 != null)
			{
				群攻.Clear();
				群攻 = null;
			}
		}

		public 攻击类(int 人物ID_, int 武功ID_, int 攻击力_, int 攻击类型_)
		{
			人物ID = 人物ID_;
			武功ID = 武功ID_;
			攻击力 = 攻击力_;
			攻击类型 = 攻击类型_;
		}
	}
}
