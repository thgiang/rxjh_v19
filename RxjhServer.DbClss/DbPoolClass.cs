using System;
using System.Data.SqlClient;

namespace RxjhServer.DbClss
{
	public class DbPoolClass
	{
		private string string_0;

		private SqlParameter[] prams;

		private int int_0;

		private string string_1;

		public string Conn
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public SqlParameter[] Prams
		{
			get
			{
				return prams;
			}
			set
			{
				prams = value;
			}
		}

		public int Type
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

		public string Sql
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public static int DbPoolClassRun(string string_2, string string_3, SqlParameter[] sqlParameter_0, int int_1)
		{
			try
			{
				SqlConnection sqlConnection_ = new SqlConnection(string_2);
				return (int_1 != 1) ? ((SqlDBA.RunProc(sqlConnection_, string_3, sqlParameter_0) == -1) ? (-1) : 0) : ((SqlDBA.RunProcSql(sqlConnection_, string_3, sqlParameter_0) == -1) ? (-1) : 0);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "DbPoolClassRun出错" + ((ex != null) ? ex.ToString() : null));
				return -1;
			}
		}
	}
}
