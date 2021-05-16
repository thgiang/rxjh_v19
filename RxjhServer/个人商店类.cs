using System;

namespace RxjhServer
{
	public class 个人商店类 : IDisposable
	{
		public Players 进入人;

		public int 商店类型;

		private bool _个人商店是否开启;

		private bool _个人商店是否使用中;

		private byte[] _商店名;

		private ThreadSafeDictionary<long, 个人商店物品类> _商店物品列表;

		public bool 个人商店是否开启
		{
			get
			{
				return _个人商店是否开启;
			}
			set
			{
				_个人商店是否开启 = value;
			}
		}

		public bool 个人商店是否使用中
		{
			get
			{
				return _个人商店是否使用中;
			}
			set
			{
				_个人商店是否使用中 = value;
			}
		}

		public byte[] 商店名
		{
			get
			{
				return _商店名;
			}
			set
			{
				_商店名 = value;
			}
		}

		public ThreadSafeDictionary<long, 个人商店物品类> 商店物品列表
		{
			get
			{
				return _商店物品列表;
			}
			set
			{
				_商店物品列表 = value;
			}
		}

		public 个人商店类()
		{
			_商店物品列表 = new ThreadSafeDictionary<long, 个人商店物品类>();
		}

		~个人商店类()
		{
		}

		public void Dispose()
		{
			if (商店物品列表 != null)
			{
				商店物品列表.Clear();
				商店物品列表.Dispose();
				商店物品列表 = null;
			}
			商店名 = null;
			进入人 = null;
		}
	}
}
