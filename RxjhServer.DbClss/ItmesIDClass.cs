using System;
using System.Collections.Generic;

namespace RxjhServer.DbClss
{
	public class ItmesIDClass
	{
		private object AsyncLocksw = new object();

		private long long_0;

		private long long_1;

		public ItmesIDClass()
		{
			try
			{
				long_0 = 0L;
				long_1 = 0L;
				long_0 = long.Parse(DBA.GetDBValue_3("EXEC   XWWL_GetItemSerial2   1000").ToString());
				long_1 = long_0 + 1000L;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "全局ID出错" + ex.Message);
				World.conn.Dispose();
				List<Players> list = new List<Players>();
				foreach (Players value in World.allConnectedChars.Values)
				{
					list.Add(value);
				}
				foreach (Players item in list)
				{
					try
					{
						if (item.Client != null)
						{
							item.Client.Dispose();
						}
					}
					catch (Exception ex2)
					{
						Form1.WriteLine(1, "保存人物的数据   错误" + ex2.Message);
					}
				}
				list.Clear();
			}
		}

		public long AcquireBuffer()
		{
			using (new Lock(AsyncLocksw, "AcquireBuffer"))
			{
				if (long_0 < long_1)
				{
					return long_0++;
				}
				long_0 = long.Parse(DBA.GetDBValue_3("EXEC   XWWL_GetItemSerial2   1000").ToString());
				long_1 = long_0 + 1000L;
				return long_0++;
			}
		}
	}
}
