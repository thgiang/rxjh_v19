using System.Collections.Generic;

namespace RxjhServer
{
	public class MapClass
	{
		public Dictionary<int, NpcClass> npcTemplate = new Dictionary<int, NpcClass>();

		private int int_0;

		public int MapID
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public static int GetNpcConn()
		{
			int num = 0;
			foreach (MapClass value in World.Map.Values)
			{
				num += value.npcTemplate.Count;
			}
			return num;
		}

		public static Dictionary<int, NpcClass> GetnpcTemplate(int int_1)
		{
			MapClass value;
			if (World.Map.TryGetValue(int_1, out value))
			{
				return value.npcTemplate;
			}
			return new Dictionary<int, NpcClass>();
		}

		public static NpcClass GetNpc(int int_1, int int_2)
		{
			MapClass value;
			if (!World.Map.TryGetValue(int_1, out value))
			{
				return null;
			}
			NpcClass value2;
			if (value.npcTemplate.TryGetValue(int_2, out value2))
			{
				return value2;
			}
			return null;
		}

		public static void delnpc(int int_1, int int_2)
		{
			MapClass value;
			if (World.Map.TryGetValue(int_1, out value))
			{
				value.del(int_2);
			}
		}

		public void del(int int_1)
		{
			using (new Lock(npcTemplate, "MapClass-del"))
			{
				npcTemplate.Remove(int_1);
			}
		}

		public void add(NpcClass npcClass_0)
		{
			int num = 10000;
			while (true)
			{
				if (num < 30000)
				{
					if (!npcTemplate.ContainsKey(num))
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			npcClass_0.FLD_INDEX = num;
			if (!npcTemplate.ContainsKey(npcClass_0.FLD_INDEX))
			{
				npcTemplate.Add(npcClass_0.FLD_INDEX, npcClass_0);
			}
		}
	}
}
