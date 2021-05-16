using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class 交易类 : IDisposable
	{
		public Dictionary<long, 交易物品类> 交易物品1;

		public bool 交易中;

		public long 交易钱;

		private bool _交易接受;

		private Players _交易人;

		public bool 交易接受
		{
			get
			{
				return _交易接受;
			}
			set
			{
				_交易接受 = value;
			}
		}

		public Players 交易人
		{
			get
			{
				return _交易人;
			}
			set
			{
				_交易人 = value;
			}
		}

		public 交易类()
		{
		}

		~交易类()
		{
		}

		public void Dispose()
		{
			try
			{
				交易中 = false;
				if (交易人 != null)
				{
					交易人.打开仓库中 = false;
					交易人.交易.交易人.打开仓库中 = false;
					交易人.交易.交易中 = false;
					交易人.交易.交易人 = null;
					交易人 = null;
				}
			}
			catch (Exception)
			{
			}
		}

		public 交易类(Players 交易人_)
		{
			交易人 = 交易人_;
			交易接受 = false;
			交易钱 = 0L;
			交易物品1 = new Dictionary<long, 交易物品类>();
		}

		public void 关闭交易()
		{
			Dispose();
		}
	}
}
