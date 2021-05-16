using System;

namespace RxjhServer
{
	public class 交易物品类 : IDisposable
	{
		private int _物品数量;

		private 物品类 _物品;

		public int 物品数量
		{
			get
			{
				return _物品数量;
			}
			set
			{
				_物品数量 = value;
			}
		}

		public 物品类 物品
		{
			get
			{
				return _物品;
			}
			set
			{
				_物品 = value;
			}
		}

		public void Dispose()
		{
			物品 = null;
		}
	}
}
