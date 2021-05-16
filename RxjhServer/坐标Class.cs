using System;

namespace RxjhServer
{
	public class 坐标Class : IDisposable
	{
		private float _Rxjh_X;

		private float _Rxjh_Y;

		private float _Rxjh_Z;

		private int _Rxjh_Map;

		private string _Rxjh_name;

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

		public string Rxjh_name
		{
			get
			{
				return _Rxjh_name;
			}
			set
			{
				_Rxjh_name = value;
			}
		}

		public static string getmapname(int id)
		{
			foreach (坐标Class item in World.移动)
			{
				if (item.Rxjh_Map == id)
				{
					return item.Rxjh_name;
				}
			}
			return string.Empty;
		}

		public static int getmapid(string mapname)
		{
			foreach (坐标Class item in World.移动)
			{
				if (item.Rxjh_name == mapname)
				{
					return item.Rxjh_Map;
				}
			}
			return 0;
		}

		public static string GetMapName(int id)
		{
			string value;
			if (World.Maplist.TryGetValue(id, out value))
			{
				return value;
			}
			return string.Empty;
		}

		public void Dispose()
		{
		}

		public 坐标Class(float Rxjh__X, float Rxjh__Y, float Rxjh__Z, int Rxjh__Map)
		{
			Rxjh_X = Rxjh__X;
			Rxjh_Y = Rxjh__Y;
			Rxjh_Z = Rxjh__Z;
			Rxjh_Map = Rxjh__Map;
		}

		public static string getname(int mapid)
		{
			switch (mapid)
			{
			case 201:
				return "三邪关";
			case 101:
				return "泫勃派";
			case 401:
				return "无天阁1层";
			case 402:
				return "无天阁2层";
			case 403:
				return "无天阁3层";
			case 301:
				return "柳正关";
			case 601:
				return "渊竹林";
			case 501:
				return "万寿阁1层";
			case 502:
				return "万寿阁2层";
			case 503:
				return "万寿阁3层";
			case 901:
				return "荤捧包";
			case 801:
				return "义斗关";
			case 701:
				return "竹火林";
			case 1101:
				return "柳善提督府";
			case 1001:
				return "神武门";
			case 1301:
				return "南明湖";
			case 1201:
				return "银币广场";
			case 1501:
				return "血魔洞2层";
			case 1401:
				return "血魔洞1层";
			case 1801:
				return "地灵洞2层";
			case 1701:
				return "地灵洞1层";
			case 1601:
				return "血魔洞3层";
			case 2001:
				return "南明洞";
			case 1901:
				return "地灵洞3层";
			case 2201:
				return "百武关";
			case 2101:
				return "松月关";
			case 2501:
				return "失落之地";
			case 2401:
				return "梅花迷宫";
			case 2711:
				return "迷宫第二层";
			case 2701:
				return "迷宫第一层";
			case 2601:
				return "钥匙房";
			case 2801:
				return "三界玄门";
			case 2721:
				return "迷宫第三层";
			case 5001:
				return "北海冰宫";
			case 3201:
				return "女王宫殿";
			case 2901:
				return "修炼之地";
			case 5201:
				return "北海玄冰宫";
			case 5101:
				return "北海水宫";
			default:
				return string.Empty;
			case 5601:
				return "植物大战僵尸";
			case 5501:
				return "北海冰宫幻影";
			case 5401:
				return "玄冰地宫";
			}
		}

		public 坐标Class()
		{
		}
	}
}
