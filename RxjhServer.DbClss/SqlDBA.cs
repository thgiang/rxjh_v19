using System;
using System.Data;
using System.Data.SqlClient;

namespace RxjhServer.DbClss
{
	public class SqlDBA
	{
		public static int RunProc(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			try
			{
				sqlConnection_0.Open();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "SqlDBA数据层_错误1" + ex.Message);
				return -1;
			}
			SqlCommand sqlCommand = CreateCommand(sqlConnection_0, string_0, sqlParameter_0);
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(100, "SqlDBA数据层_错误2" + ex2.Message);
				sqlCommand.Parameters.Clear();
				return -1;
			}
			finally
			{
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
			}
			return (int)sqlCommand.Parameters["ReturnValue"].Value;
		}

		public static int RunProcSql(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			int result = -1;
			try
			{
				sqlConnection_0.Open();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "SqlDBA数据层_错误3" + ex.Message);
				return result;
			}
			SqlCommand sqlCommand = CreateCommandSql(sqlConnection_0, string_0, sqlParameter_0);
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(100, "SqlDBA数据层_错误4" + ex2.Message);
				sqlCommand.Parameters.Clear();
				return result;
			}
			finally
			{
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
			}
		}

		public static void RunProc(SqlConnection sqlConnection_0, string string_0, out SqlDataReader sqlDataReader_0)
		{
			SqlCommand sqlCommand = CreateCommand(sqlConnection_0, string_0, null);
			sqlDataReader_0 = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
		}

		public static void RunProc(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0, out SqlDataReader sqlDataReader_0)
		{
			SqlCommand sqlCommand = CreateCommand(sqlConnection_0, string_0, sqlParameter_0);
			sqlDataReader_0 = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
		}

		public static void RunProc(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0, out DataSet dataSet_0)
		{
			SqlCommand sqlCommand = CreateCommand(sqlConnection_0, string_0, sqlParameter_0);
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
			{
				DataSet dataSet = new DataSet();
				sqlDataAdapter.Fill(dataSet);
				sqlCommand.Parameters.Clear();
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
				dataSet_0 = dataSet;
				sqlDataAdapter.Dispose();
			}
		}

		public static DataTable RunProcc(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			DataTable dataTable = new DataTable();
			SqlCommand sqlCommand = CreateCommand(sqlConnection_0, string_0, sqlParameter_0);
			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
			{
				try
				{
					sqlDataAdapter.Fill(dataTable);
				}
				catch
				{
				}
				sqlCommand.Parameters.Clear();
				sqlDataAdapter.Dispose();
				sqlConnection_0.Close();
				sqlConnection_0.Dispose();
				return dataTable;
			}
		}

		public static SqlCommand CreateCommand(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection_0);
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandTimeout = 180;
			if (sqlParameter_0 != null)
			{
				foreach (SqlParameter value in sqlParameter_0)
				{
					sqlCommand.Parameters.Add(value);
				}
			}
			sqlCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
			return sqlCommand;
		}

		public static SqlCommand CreateCommandSql(SqlConnection sqlConnection_0, string string_0, SqlParameter[] sqlParameter_0)
		{
			SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection_0);
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandTimeout = 180;
			if (sqlParameter_0 != null)
			{
				foreach (SqlParameter value in sqlParameter_0)
				{
					sqlCommand.Parameters.Add(value);
				}
			}
			sqlCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
			return sqlCommand;
		}

		public static SqlParameter MakeInParam(string string_0, SqlDbType sqlDbType_0, int int_0, object object_0)
		{
			return MakeParam(string_0, sqlDbType_0, int_0, ParameterDirection.Input, object_0);
		}

		public static SqlParameter MakeOutParam(string string_0, SqlDbType sqlDbType_0, int int_0)
		{
			return MakeParam(string_0, sqlDbType_0, int_0, ParameterDirection.Output, null);
		}

		public static SqlParameter MakeParam(string string_0, SqlDbType sqlDbType_0, int int_0, ParameterDirection parameterDirection_0, object object_0)
		{
			SqlParameter sqlParameter = (int_0 <= 0) ? new SqlParameter(string_0, sqlDbType_0) : new SqlParameter(string_0, sqlDbType_0, int_0);
			sqlParameter.Direction = parameterDirection_0;
			if (parameterDirection_0 != ParameterDirection.Output || object_0 != null)
			{
				sqlParameter.Value = object_0;
			}
			return sqlParameter;
		}
	}
}
