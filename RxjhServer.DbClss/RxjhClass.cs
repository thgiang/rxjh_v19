using RxjhServer.HelperTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace RxjhServer.DbClss
{
	public class RxjhClass
	{
		private static ItmesIDClass itmesIDClass_0 = new ItmesIDClass();

		public static string md5(string string_0)
		{
			return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(string_0))).Replace("-", string.Empty).ToLower();
		}

		public static long GetDBItmeId()
		{
			return itmesIDClass_0.AcquireBuffer();
		}

		public static void 变更门服(int int_0, int int_1, int int_2)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Guild  SET  门服字={1},门服颜色={2}  WHERE  ID='{0}'", int_0, int_1, int_2));
		}

		public static void msglog(string string_0, string string_1, string string_2, string string_3, int int_0)
		{
			DBA.ExeSqlCommand(string.Format("INSERT  INTO  MsgLog  (userid,username,ToUserName,msg,msgType)  VALUES      ('{0}','{1}','{2}','{3}',{4})", string_0, string_1, string_2, string_3, int_0));
		}

		public static void 掉落记录(string string_0, string string_1, long long_0, int int_0, string string_2, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, string string_3)
		{
			if (World.掉落记录 == 1)
			{
				string sql = string.Format("INSERT  INTO  掉落记录  (FLD_ID,FLD_NAME,FLD_QJID,FLD_PID,FLD_INAME,FLD_MAGIC0,FLD_MAGIC1,FLD_MAGIC2,FLD_MAGIC3,FLD_MAGIC4,FLD_MAP,FLD_X,FLD_Y,FLD_TYPE)      VALUES      (@UserId,@UserName,@qjid,@pid,@iname,@magic0,@magic1,@magic2,@magic3,@magic4,@map,@x,@y,@type)");
				SqlParameter[] prams = new SqlParameter[14]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@qjid", SqlDbType.Int, 4, long_0),
					SqlDBA.MakeInParam("@pid", SqlDbType.Int, 4, int_0),
					SqlDBA.MakeInParam("@iname", SqlDbType.VarChar, 30, string_2),
					SqlDBA.MakeInParam("@magic0", SqlDbType.Int, 4, int_1),
					SqlDBA.MakeInParam("@magic1", SqlDbType.Int, 4, int_2),
					SqlDBA.MakeInParam("@magic2", SqlDbType.Int, 4, int_3),
					SqlDBA.MakeInParam("@magic3", SqlDbType.Int, 4, int_4),
					SqlDBA.MakeInParam("@magic4", SqlDbType.Int, 4, int_5),
					SqlDBA.MakeInParam("@map", SqlDbType.Int, 4, int_6),
					SqlDBA.MakeInParam("@x", SqlDbType.Int, 4, int_7),
					SqlDBA.MakeInParam("@y", SqlDbType.Int, 4, int_8),
					SqlDBA.MakeInParam("@type", SqlDbType.VarChar, 30, string_3)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = sql,
					Type = 1
				});
			}
		}

		public static void 商店记录(string string_0, string string_1, int int_0, string string_2, string string_3, int int_1, long long_0, int int_2, int int_3, int int_4, int int_5, int int_6)
		{
			if (World.商店记录 == 1)
			{
				string sql = string.Format("INSERT  INTO  商店记录  (FLD_ID,FLD_NAME,FLD_PID,FLD_INAME,FLD_TYPE,FLD_NUM,FLD_PRICE,FLD_MAGIC0,FLD_MAGIC1,FLD_MAGIC2,FLD_MAGIC3,FLD_MAGIC4)      VALUES      (@UserId,@UserName,@pid,@iname,@type,@number,@price,@magic0,@magic1,@magic2,@magic3,@magic4)");
				SqlParameter[] prams = new SqlParameter[12]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@pid", SqlDbType.Int, 4, int_0),
					SqlDBA.MakeInParam("@iname", SqlDbType.VarChar, 30, string_2),
					SqlDBA.MakeInParam("@type", SqlDbType.VarChar, 30, string_3),
					SqlDBA.MakeInParam("@number", SqlDbType.Int, 4, int_1),
					SqlDBA.MakeInParam("@price", SqlDbType.VarChar, 50, long_0.ToString()),
					SqlDBA.MakeInParam("@magic0", SqlDbType.Int, 4, int_2),
					SqlDBA.MakeInParam("@magic1", SqlDbType.Int, 4, int_3),
					SqlDBA.MakeInParam("@magic2", SqlDbType.Int, 4, int_4),
					SqlDBA.MakeInParam("@magic3", SqlDbType.Int, 4, int_5),
					SqlDBA.MakeInParam("@magic4", SqlDbType.Int, 4, int_6)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = sql,
					Type = 1
				});
			}
		}

		public static void 药品记录(string string_0, string string_1, int int_0, string string_2, int int_1)
		{
			if (World.药品记录 == 1)
			{
				string sql = string.Format("INSERT  INTO  药品记录  (FLD_ID,FLD_NAME,FLD_PID,FLD_INAME,FLD_NUM)  VALUES  (@UserId,@UserName,@pid,@iname,@number)");
				SqlParameter[] prams = new SqlParameter[5]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@pid", SqlDbType.Int, 4, int_0),
					SqlDBA.MakeInParam("@iname", SqlDbType.VarChar, 30, string_2),
					SqlDBA.MakeInParam("@number", SqlDbType.Int, 4, int_1)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = sql,
					Type = 1
				});
			}
		}

		public static void 合成记录(string string_0, string string_1, string string_2, int int_0, string string_3, string string_4, 物品类 物品类_0)
		{
			if (World.合成记录 == 1)
			{
				string sql = string.Format("INSERT  INTO  合成记录  (FLD_ID,FLD_NAME,FLD_QJID,FLD_PID,FLD_INAME,FLD_MAGIC0,FLD_MAGIC1,FLD_MAGIC2,FLD_MAGIC3,FLD_MAGIC4,FLD_TYPE,FLD_CZID,FLD_SUCCESS,FLD_QHJD)      VALUES      (@UserId,@UserName,@qjid,@pid,@iname,@magic0,@magic1,@magic2,@magic3,@magic4,@type,@czid,@success,@qhjd)");
				SqlParameter[] prams = new SqlParameter[14]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@qjid", SqlDbType.Int, 4, (int)物品类_0.Get物品全局ID),
					SqlDBA.MakeInParam("@pid", SqlDbType.Int, 4, (int)物品类_0.Get物品ID),
					SqlDBA.MakeInParam("@iname", SqlDbType.VarChar, 30, 物品类_0.得到物品名称()),
					SqlDBA.MakeInParam("@magic0", SqlDbType.Int, 4, 物品类_0.FLD_MAGIC0),
					SqlDBA.MakeInParam("@magic1", SqlDbType.Int, 4, 物品类_0.FLD_MAGIC1),
					SqlDBA.MakeInParam("@magic2", SqlDbType.Int, 4, 物品类_0.FLD_MAGIC2),
					SqlDBA.MakeInParam("@magic3", SqlDbType.Int, 4, 物品类_0.FLD_MAGIC3),
					SqlDBA.MakeInParam("@magic4", SqlDbType.Int, 4, 物品类_0.FLD_MAGIC4),
					SqlDBA.MakeInParam("@type", SqlDbType.VarChar, 30, string_3),
					SqlDBA.MakeInParam("@czid", SqlDbType.Int, 4, int_0),
					SqlDBA.MakeInParam("@success", SqlDbType.VarChar, 30, string_4),
					SqlDBA.MakeInParam("@qhjd", SqlDbType.Int, 4, 物品类_0.FLD_强化数量)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = sql,
					Type = 1
				});
			}
		}

		public static void 百宝记录(string string_0, string string_1, double double_0, string string_2, int int_0, int int_1)
		{
			DBA.ExeSqlCommand(string.Format("INSERT  INTO  百宝记录  (UserId,UserName,物品ID,物品名,物品数量,元宝数)  VALUES  ('{0}','{1}','{2}','{3}',{4},{5})", string_0, string_1, double_0, string_2, int_0, int_1));
		}

		public static void 登陆记录(string string_0, string string_1, string string_2, string string_3)
		{
			if (World.登陆记录 == 1)
			{
				string sql = string.Format("INSERT  INTO  登陆记录  (UserId,UserName,UserIp,类型)  VALUES  (@UserId,@UserName,@UserIp,@类型)");
				SqlParameter[] prams = new SqlParameter[4]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@UserIp", SqlDbType.VarChar, 30, string_2),
					SqlDBA.MakeInParam("@类型", SqlDbType.VarChar, 30, string_3)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = sql,
					Type = 1
				});
			}
		}

		public static void 物品记录(string string_0, string string_1, string string_2, string string_3, double double_0, int int_0, string string_4, int int_1, string string_5, int int_2, string string_6)
		{
			if (World.物品记录 == 1)
			{
				string sql = string.Format("INSERT  INTO  物品记录  (UserId,UserName,ToUserId,ToUserName,全局ID,物品ID,物品名,物品数量,物品属性,钱数,类型)      VALUES      (@UserId,@UserName,@ToUserId,@ToUserName,@全局ID,@物品ID,@物品名,@物品数量,@物品属性,@钱数,@类型)");
				SqlParameter[] prams = new SqlParameter[11]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@ToUserId", SqlDbType.VarChar, 30, string_2),
					SqlDBA.MakeInParam("@ToUserName", SqlDbType.VarChar, 30, string_3),
					SqlDBA.MakeInParam("@全局ID", SqlDbType.VarChar, 30, double_0),
					SqlDBA.MakeInParam("@物品ID", SqlDbType.VarChar, 30, int_0),
					SqlDBA.MakeInParam("@物品名", SqlDbType.VarChar, 30, string_4),
					SqlDBA.MakeInParam("@物品数量", SqlDbType.Int, 4, int_1),
					SqlDBA.MakeInParam("@物品属性", SqlDbType.VarChar, 100, string_5),
					SqlDBA.MakeInParam("@钱数", SqlDbType.Int, 4, int_2),
					SqlDBA.MakeInParam("@类型", SqlDbType.VarChar, 10, string_6)
				};
				World.SqlPool.Enqueue(new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = sql,
					Type = 1
				});
			}
		}

		public static void 帮战赌注(string string_0, string string_1, int int_0, int int_1)
		{
			DBA.ExeSqlCommand(string.Format("INSERT  INTO  帮战赌注  (UserId,UserName,帮派ID,元宝数)  VALUES  ('{0}','{1}',{2},{3})", string_0, string_1, int_0, int_1));
		}

		public static void 帮战赌注删除(string string_0, string string_1, int int_0, int int_1)
		{
			DBA.ExeSqlCommand(string.Format("DELETE  FROM  帮战赌注  WHERE  UserId  =  '{0}'  and  UserName='{1}'  and  UserName='{2}'", string_0, string_1, int_0));
			switch (int_1)
			{
			case -1:
				DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Guild  SET  败=败+1  WHERE  ID='{0}'", int_0));
				百宝记录(string_0, string_1, 0.0, "帮战失败输掉", 1, 50);
				break;
			case 0:
				DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Guild  SET  平=平+1  WHERE  ID='{0}'", int_0));
				break;
			case 1:
				DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Guild  SET  胜=胜+1  WHERE  ID='{0}'", int_0));
				百宝记录(string_0, string_1, 0.0, "帮战胜利得到", 1, 50);
				break;
			}
		}

		public static void 申请门徽(int int_0, byte[] byte_0)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Guild  SET  门徽={1}  WHERE  ID='{0}'", int_0, Converter.ToString1(byte_0)));
		}

		public static byte[] 得到门徽(int int_0)
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_Guild  WHERE  ID  =  {0}", int_0));
				if (dBToDataTable == null)
				{
					return null;
				}
				if (dBToDataTable.Rows.Count == 0)
				{
					dBToDataTable.Dispose();
					return null;
				}
				if (Buffer.IsEquals(dBToDataTable.Rows[0]["门徽"].GetType().ToString(), "System.DBNull"))
				{
					dBToDataTable.Dispose();
					return null;
				}
				byte[] array = (byte[])dBToDataTable.Rows[0]["门徽"];
				if (array != null)
				{
					dBToDataTable.Dispose();
					return array;
				}
				dBToDataTable.Dispose();
				return null;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到门徽出错      " + ex.Message);
				return null;
			}
		}

		public static void 帮派赋予职位(int int_0, string string_0)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_GuildMember  SET  Leve=@zw  WHERE  FLD_NAME=@Username"), new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, int_0),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_0)
			});
		}

		public static void 赋予帮主职位(string string_0, string string_1, string string_2)
		{
			string string_3 = string.Format("UPDATE  TBL_XWWL_GuildMember  SET  Leve=@zw  WHERE  FLD_NAME=@Username");
			SqlParameter[] sqlParameter_ = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, 5),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_1)
			};
			string string_4 = string.Format("UPDATE  TBL_XWWL_Guild  SET  G_Master=@Uname  WHERE  G_Name=@Gname");
			SqlParameter[] sqlParameter_2 = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@Uname", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@Gname", SqlDbType.VarChar, 30, string_2)
			};
			DBA.ExeSqlCommand(string_3, sqlParameter_);
			DBA.ExeSqlCommand(string_4, sqlParameter_2);
		}

		public static int 创建帮派确认(string string_0)
		{
			return (int)DBA.GetDBValue_3(string.Format("EXEC  XWWL_SELECT_Guild_DATA  @bpnamea"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@bpnamea", SqlDbType.VarChar, 30, string_0)
			});
		}

		public static int 创建帮派(string string_0, string string_1, int int_0)
		{
			return (int)DBA.GetDBValue_3(string.Format("EXEC  XWWL_INT_Guild_DATA_New  @name,  @bpname,@leve"), new SqlParameter[3]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_1),
				SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, int_0)
			});
		}

		public static int 加入帮派(string string_0, string string_1, int int_0)
		{
			return (int)DBA.GetDBValue_3(string.Format("EXEC  XWWL_JR_Guild_DATA_New  @name,  @bpname,@leve", string_0, string_1, int_0), new SqlParameter[3]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_1),
				SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, int_0)
			});
		}

		public static int 退出门派(string string_0)
		{
			return (int)DBA.GetDBValue_3(string.Format("EXEC  XWWL_Out_Guild_DATA  @name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
		}

		public static int 逐出门派(string string_0, string string_1)
		{
			return (int)DBA.GetDBValue_3(string.Format("EXEC  XWWL_OutBz_Guild_DATA  @name,  @bpname"), new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_1)
			});
		}

		public static int GetUserName(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  FLD_NAME  FROM  TBL_XWWL_Char  WHERE  FLD_NAME=@name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return -1;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				dBToDataTable.Dispose();
				return 1;
			}
			dBToDataTable.Dispose();
			return -1;
		}

		public static DataTable 得到帮派人数(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_GuildMember  WHERE  G_Name  =@name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				return null;
			}
			return dBToDataTable;
		}

		public static DataTable 得到帮派数据(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_Guild  WHERE  G_Name  =  @name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			return null;
		}

		public static DataTable 得到门战帮派数据(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_GuildPVP  WHERE  帮派  =  @name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				return null;
			}
			return dBToDataTable;
		}

		public static DataTable GetUserNameBp(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("EXEC  XWWL_LOAD_Guild  @name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				return null;
			}
			return dBToDataTable;
		}

		public static DataTable GetUserWarehouse(string string_0, string string_1)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select  *  from    [TBL_XWWL_Warehouse]    where  FLD_ID=@Userid  and  FLD_NAME  =@Username"), new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_1)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			DBA.ExeSqlCommand(string.Format("EXEC  XWWL_CREATE_USER_BANK  @Userid,@Username,@aa,@zb"), new SqlParameter[4]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_1),
				SqlDBA.MakeInParam("@aa", SqlDbType.Int, 0, 0),
				SqlDBA.MakeInParam("@zb", SqlDbType.VarBinary, World.数据库单个物品大小 * 60, new byte[World.数据库单个物品大小 * 60])
			});
			DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("select  *  from  [TBL_XWWL_Warehouse]  where  FLD_ID=@Userid  and  FLD_NAME  =@Username"), new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, string_1)
			});
			if (dBToDataTable2 == null)
			{
				return null;
			}
			if (dBToDataTable2.Rows.Count == 0)
			{
				return null;
			}
			return dBToDataTable2;
		}

		public static DataTable GetUserPublicWarehouse(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select  *  from  [TBL_XWWL_PublicWarehouse]  where  FLD_ID=@Userid"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			Converter.ToString1(new byte[World.数据库单个物品大小 * 60]);
			Converter.ToString1(new byte[60]);
			DBA.ExeSqlCommand(string.Format("EXEC  XWWL_CREATE_ID_BANK      @Userid,@aaa,@ck,@ck1"), new SqlParameter[4]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@aaa", SqlDbType.Int, 0, 0),
				SqlDBA.MakeInParam("@ck", SqlDbType.VarBinary, World.数据库单个物品大小 * 60, new byte[World.数据库单个物品大小 * 60]),
				SqlDBA.MakeInParam("@ck1", SqlDbType.VarBinary, 50, new byte[50])
			});
			DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("select  *  from  [TBL_XWWL_PublicWarehouse]  where  FLD_ID='{0}'", string_0), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable2 == null)
			{
				return null;
			}
			if (dBToDataTable2.Rows.Count == 0)
			{
				return null;
			}
			return dBToDataTable2;
		}

		public static int SetUserName(string string_0, string string_1, int int_0, byte[] byte_0)
		{
			byte[] array = new byte[73];
			byte[] array2 = new byte[1095];
			byte[] array3 = new byte[2628];
			byte[] array4 = new byte[381];
			byte[] bytes = Buffer.GetBytes(GetDBItmeId());
			byte[] src = new byte[4];
			byte[] bytes2 = Buffer.GetBytes(1);
			switch (int_0)
			{
			case 1:
				src = Buffer.GetBytes(100200002);
				break;
			case 2:
				src = Buffer.GetBytes(200200002);
				break;
			case 3:
				src = Buffer.GetBytes(300200002);
				break;
			case 4:
				src = Buffer.GetBytes(400200002);
				break;
			case 5:
				src = Buffer.GetBytes(500200002);
				break;
			case 6:
				src = Buffer.GetBytes(700200002);
				break;
			case 7:
				src = Buffer.GetBytes(800200001);
				break;
			case 8:
				src = Buffer.GetBytes(100204001);
				break;
			case 9:
				src = Buffer.GetBytes(200204001);
				break;
			case 10:
				src = Buffer.GetBytes(900200001);
				break;
			case 11:
				src = Buffer.GetBytes(400204001);
				break;
			case 12:
				src = Buffer.GetBytes(300204001);
				break;
			case 13:
				src = Buffer.GetBytes(500204001);
				break;
			}
			System.Buffer.BlockCopy(bytes, 0, array, 0, 4);
			System.Buffer.BlockCopy(src, 0, array, 8, 4);
			System.Buffer.BlockCopy(bytes2, 0, array, 12, 4);
			System.Buffer.BlockCopy(array, 0, array3, 0, 73);
			byte[] bytes3 = Buffer.GetBytes(1);
			System.Buffer.BlockCopy(Buffer.GetBytes(GetDBItmeId()), 0, array4, 0, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(1008000006), 0, array4, 8, 4);
			System.Buffer.BlockCopy(bytes3, 0, array4, 12, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(2016000000), 0, array4, 20, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(GetDBItmeId()), 0, array4, 73, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(1008000003), 0, array4, 81, 4);
			System.Buffer.BlockCopy(bytes3, 0, array4, 85, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(2019990000), 0, array4, 93, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(GetDBItmeId()), 0, array4, 150, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(1008000055), 0, array4, 158, 4);
			System.Buffer.BlockCopy(bytes3, 0, array4, 162, 4);
			array4[214] = 1;
			System.Buffer.BlockCopy(Buffer.GetBytes(GetDBItmeId()), 0, array4, 227, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(1008000027), 0, array4, 235, 4);
			System.Buffer.BlockCopy(bytes3, 0, array4, 239, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(GetDBItmeId()), 0, array4, 304, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(1007000006), 0, array4, 312, 4);
			System.Buffer.BlockCopy(bytes3, 0, array4, 316, 4);
			System.Buffer.BlockCopy(Buffer.GetBytes(2000000007), 0, array4, 320, 4);
			System.Buffer.BlockCopy(array4, 0, array3, 73, 381);
			int num = 0;
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("Select FLD_INDEX FROM TBL_XWWL_Char Where FLD_ID=@FLD_ID"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable.Rows.Count >= 4)
			{
				dBToDataTable.Dispose();
				return -1;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				num = 0;
			}
			else
			{
				List<int> list = new List<int>();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					int item = (int)dBToDataTable.Rows[i]["FLD_INDEX"];
					list.Add(item);
				}
				for (int j = 0; j < 4; j++)
				{
					if (!list.Contains(j))
					{
						num = j;
						break;
					}
				}
			}
			dBToDataTable.Dispose();
			int num2 = 0;
			int num3 = 0;
			switch (int_0)
			{
			case 4:
				num2 = 124;
				num3 = 116;
				break;
			case 6:
				num2 = 130;
				num3 = 114;
				break;
			case 7:
				num2 = 124;
				num3 = 136;
				break;
			case 1:
			case 8:
				num2 = 145;
				num3 = 116;
				break;
			case 10:
				num2 = 145;
				num3 = 116;
				break;
			case 11:
				num2 = 124;
				num3 = 116;
				break;
			case 2:
			case 3:
			case 5:
			case 9:
			case 12:
				num2 = 133;
				num3 = 118;
				break;
			case 13:
				num2 = 118;
				num3 = 136;
				break;
			}
			if (DBA.ExeSqlCommand(string.Format("EXEC XWWL_INT_USER_DATA @FLD_ID,@name,@rwid,@zy,@hp,@mp,@coue,@xrwhex,@xrwhex2"), new SqlParameter[9]
			{
				SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_1),
				SqlDBA.MakeInParam("@rwid", SqlDbType.Int, 0, num),
				SqlDBA.MakeInParam("@zy", SqlDbType.Int, 0, int_0),
				SqlDBA.MakeInParam("@hp", SqlDbType.Int, 0, num2),
				SqlDBA.MakeInParam("@mp", SqlDbType.Int, 0, num3),
				SqlDBA.MakeInParam("@coue", SqlDbType.VarBinary, 10, byte_0),
				SqlDBA.MakeInParam("@xrwhex", SqlDbType.VarBinary, array2.Length, array2),
				SqlDBA.MakeInParam("@xrwhex2", SqlDbType.VarBinary, array3.Length, array3)
			}) == -1)
			{
				return -1;
			}
			return 1;
		}

		public static int GetCwUserName(string string_0, string string_1, int int_0, long long_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  Name  FROM  TBL_XWWL_Cw  WHERE  Name=@name", string_0), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return -1;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				dBToDataTable.Dispose();
				if (DBA.ExeSqlCommand(string.Format("EXEC  XWWL_INT_Cw_DATA  @zrname,@name,@id,@type,@zb1,@zb2", string_1, string_0, long_0, int_0, Converter.ToString(new byte[292]), Converter.ToString(new byte[1168])), new SqlParameter[6]
				{
					SqlDBA.MakeInParam("@zrname", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@id", SqlDbType.Int, 0, long_0),
					SqlDBA.MakeInParam("@type", SqlDbType.Int, 0, int_0),
					SqlDBA.MakeInParam("@zb1", SqlDbType.VarBinary, 5 * World.数据库单个物品大小, new byte[5 * World.数据库单个物品大小]),
					SqlDBA.MakeInParam("@zb2", SqlDbType.VarBinary, 16 * World.数据库单个物品大小, new byte[16 * World.数据库单个物品大小])
				}) != -1)
				{
					return 1;
				}
				return -1;
			}
			dBToDataTable.Dispose();
			return -1;
		}

		public static void 更新门派荣誉(string string_0, string string_1, int int_0, int int_1, int int_2, int int_3, int int_4, string string_2)
		{
			try
			{
				SqlParameter[] prams = new SqlParameter[8]
				{
					SqlDBA.MakeInParam("@rwname", SqlDbType.VarChar, 50, string_0),
					SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 50, string_1),
					SqlDBA.MakeInParam("@zx", SqlDbType.Int, 0, int_0),
					SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, int_1),
					SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, int_2),
					SqlDBA.MakeInParam("@jobleve", SqlDbType.Int, 0, int_3),
					SqlDBA.MakeInParam("@rongyu", SqlDbType.Int, 0, int_4),
					SqlDBA.MakeInParam("@fq", SqlDbType.VarChar, 50, string_2)
				};
				DbPoolClass obj = new DbPoolClass
				{
					Conn = DBA.getstrConnection(null),
					Prams = prams,
					Sql = "UPDATE_menpai_DATA_New"
				};
				World.SqlPool.Enqueue(obj);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存门派排行数据出错" + ex.Message);
			}
		}

		public static int Set个人荣誉数据(int int_0, string string_0, int int_1, int int_2, int int_3, string string_1, string string_2, int int_4)
		{
			DataTable dataTable = 得到帮派数据(string_1);
			if (dataTable != null)
			{
				if (dataTable.Rows.Count > 0)
				{
					string_2 = dataTable.Rows[0]["G_Master"].ToString();
				}
				dataTable.Dispose();
			}
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  FLD_人物名  FROM  TBL_荣誉系统  WHERE  FLD_人物名=@name  and  FLD_类型=@lx", string_0, int_0), new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@lx", SqlDbType.Int, 0, int_0)
			});
			if (dBToDataTable == null)
			{
				return -1;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				dBToDataTable.Dispose();
				if (DBA.ExeSqlCommand(string.Format("EXEC  XWWL_INT_RY_DATA  @lx,@name,@job,@level,@zx,@bpname,@mzname,@jf", int_0, string_0, int_1, int_2, int_3, string_1, string_2, int_4), new SqlParameter[8]
				{
					SqlDBA.MakeInParam("@lx", SqlDbType.Int, 0, int_0),
					SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, int_1),
					SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, int_2),
					SqlDBA.MakeInParam("@zx", SqlDbType.Int, 0, int_3),
					SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@mzname", SqlDbType.VarChar, 30, string_2),
					SqlDBA.MakeInParam("@jf", SqlDbType.Int, 0, int_4)
				}) != -1)
				{
					return 1;
				}
				return -1;
			}
			dBToDataTable.Dispose();
			if (DBA.ExeSqlCommand(string.Format("UPDATE  TBL_荣誉系统  SET  FLD_分数  =FLD_分数+{0}  WHERE  FLD_人物名='{1}'  and    FLD_类型={2}", int_4, string_0, int_0), "GameServer") != -1)
			{
				return 1;
			}
			return -1;
		}

		public static int Set帮派荣誉数据(string string_0, string string_1, int int_0, int int_1, int int_2, int int_3)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_荣誉系统  WHERE  FLD_类型  =  3  and  FLD_帮派=@mpname", string_0), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@mpname", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return -1;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				dBToDataTable.Dispose();
				string empty = string.Empty;
				if (DBA.ExeSqlCommand(string.Format("EXEC  XWWL_INT_RY_DATA  @lx,@name,@job,@level,@zx,@bpname,@mzname,@jf", 3, empty, int_1, int_0, int_2, string_0, string_1, int_3), new SqlParameter[8]
				{
					SqlDBA.MakeInParam("@lx", SqlDbType.Int, 0, 3),
					SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, empty),
					SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, int_1),
					SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, int_0),
					SqlDBA.MakeInParam("@zx", SqlDbType.Int, 0, int_2),
					SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@mzname", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@jf", SqlDbType.Int, 0, int_3)
				}) != -1)
				{
					return 1;
				}
				return -1;
			}
			dBToDataTable.Dispose();
			if (DBA.ExeSqlCommand(string.Format("UPDATE  TBL_荣誉系统  SET  FLD_分数  =FLD_分数+1  WHERE  FLD_帮派='{0}'  and  FLD_类型=      3", string_0), "GameServer") != -1)
			{
				return 1;
			}
			return -1;
		}

		public static DataTable 得到传书列表(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_传书系统  WHERE  接收人物名  =@name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			dBToDataTable.Dispose();
			return null;
		}

		public static void 设置传书已读(int int_0, int int_1)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE  TBL_传书系统  SET  阅读标识=@rd  WHERE  ID=@id"), new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@rd", SqlDbType.Int, 0, int_1),
				SqlDBA.MakeInParam("@id", SqlDbType.Int, 30, int_0)
			});
		}

		public static void 变更婚姻状态(string string_0, int int_0)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Char  SET  FLD_MARITAL_STATUS={1}  WHERE  FLD_NAME='{0}'", string_0, int_0));
		}

		public static void 解除情侣关系(string string_0)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE  TBL_XWWL_Char  SET  FLD_QlNAME='{1}',FLD_QlDu={2},FLD_LOVE_WORD='{3}',FLD_MARITAL_STATUS={4},FLD_MARRIED={5}  WHERE  FLD_NAME='{0}'", string_0, string.Empty, 0, string.Empty, 0, 0));
		}

		public static void 创建传书(string string_0, string string_1, int int_0, string string_2, int int_1)
		{
			DBA.GetDBValue_3(string.Format("EXEC  INT_CS_DATA_New  @fname,  @sname,  @msg,  @npcid,@type"), new SqlParameter[5]
			{
				SqlDBA.MakeInParam("@fname", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@sname", SqlDbType.VarChar, 30, string_1),
				SqlDBA.MakeInParam("@msg", SqlDbType.VarChar, 2000, string_2),
				SqlDBA.MakeInParam("@npcid", SqlDbType.Int, 0, int_0),
				SqlDBA.MakeInParam("@type", SqlDbType.Int, 0, int_1)
			});
		}

		public static DataTable 得到人物名字(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_XWWL_Char  WHERE  FLD_NAME  =  @name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			return null;
		}

		public static void 创建门派荣誉(string string_0, string string_1, int int_0, int int_1, int int_2, int int_3, int int_4, string string_2)
		{
			DBA.ExeSqlCommand(string.Format("EXEC  INT_menpai_DATA_New  @rwname,  @bpname,@zx,  @leve,@job,@jobleve,@rongyu,@fq"), new SqlParameter[8]
			{
				SqlDBA.MakeInParam("@rwname", SqlDbType.VarChar, 50, string_0),
				SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 50, string_1),
				SqlDBA.MakeInParam("@zx", SqlDbType.Int, 0, int_0),
				SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, int_1),
				SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, int_2),
				SqlDBA.MakeInParam("@jobleve", SqlDbType.Int, 0, int_3),
				SqlDBA.MakeInParam("@rongyu", SqlDbType.Int, 0, int_4),
				SqlDBA.MakeInParam("@fq", SqlDbType.VarChar, 50, string_2)
			});
		}

		public static DataTable 得到门派荣誉数据(string string_0, string string_1)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  荣誉门派排行  WHERE  FLD_BP  =  @name  and  FLD_FQ=@fq"), new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0),
				SqlDBA.MakeInParam("@fq", SqlDbType.VarChar, 30, string_1)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			return null;
		}

		public static DataTable 得到师傅数据(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_师徒数据  WHERE  FLD_TNAME  =@name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			return null;
		}

		public static DataTable 得到徒弟数据(string string_0)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  *  FROM  TBL_师徒数据  WHERE  FLD_SNAME  =@name"), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			return null;
		}

		public static int 创建师徒关系(string string_0, string string_1, int int_0, int int_1)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  FLD_TNAME  FROM  TBL_师徒数据  WHERE  FLD_TNAME=@name", string_0), new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string_0)
			});
			if (dBToDataTable == null)
			{
				return -1;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				dBToDataTable.Dispose();
				if (DBA.ExeSqlCommand(string.Format("EXEC  INT_St_DATA  @sname,@tname,@tlevel,@index", string_1, string_0, int_0, int_1), new SqlParameter[4]
				{
					SqlDBA.MakeInParam("@sname", SqlDbType.VarChar, 30, string_1),
					SqlDBA.MakeInParam("@tname", SqlDbType.VarChar, 30, string_0),
					SqlDBA.MakeInParam("@tlevel", SqlDbType.Int, 0, int_0),
					SqlDBA.MakeInParam("@index", SqlDbType.Int, 0, int_1)
				}) != -1)
				{
					return 1;
				}
				return -1;
			}
			dBToDataTable.Dispose();
			return -1;
		}

		public static int 解除师徒关系(string string_0, string string_1)
		{
			if (DBA.ExeSqlCommand(string.Format("delete  [TBL_师徒数据]  WHERE  FLD_TNAME  ='{0}'  and  FLD_SNAME='{1}'", string_0, string_1), "GameServer") != -1)
			{
				return 1;
			}
			return -1;
		}

		public static int 取得贡献经验(string string_0, string string_1)
		{
			int num = 0;
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT  FLD_师傅  from  [TBL_XWWL_Char]  where  FLD_NAME  ='{0}'", string_1));
				if (dBToDataTable == null)
				{
					return num;
				}
				if (dBToDataTable.Rows.Count > 0)
				{
					byte[] array = new byte[28];
					byte[] array2 = (byte[])dBToDataTable.Rows[0]["FLD_师傅"];
					System.Buffer.BlockCopy(array2, 0, array, 0, array2.Length);
					byte[] array3 = new byte[16];
					System.Buffer.BlockCopy(array, 0, array3, 0, 16);
					if (Encoding.Default.GetString(array3).Replace("\0", string.Empty).Trim() == string_0)
					{
						int num2 = Buffer.ToInt32(array, 18);
						if (num2 <= 0)
						{
							dBToDataTable.Dispose();
							return 0;
						}
						num += num2;
						array[18] = 0;
						array[19] = 0;
						array[20] = 0;
						array[21] = 0;
						DBA.ExeSqlCommand(string.Format("UPDATE  [TBL_XWWL_Char]  set  FLD_师傅=@sf  where  FLD_NAME  =@name"), new SqlParameter[2]
						{
							SqlDBA.MakeInParam("@sf", SqlDbType.VarBinary, 28, array),
							SqlDBA.MakeInParam("@name", SqlDbType.VarChar, string_1.Length, string_1)
						});
					}
				}
				dBToDataTable.Dispose();
				return num;
			}
			catch
			{
				return 0;
			}
		}
	}
}
