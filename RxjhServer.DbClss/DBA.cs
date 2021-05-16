using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace RxjhServer.DbClss
{
	public class DBA
	{
		public static void serlog(string string_0)
		{
			string sqlJl = World.SqlJl;
			if (sqlJl.Length == 0)
			{
				return;
			}
			string text = sqlJl;
			char[] separator = new char[1]
			{
				'|'
			};
			string[] array = text.Split(separator);
			foreach (string text2 in array)
			{
				if (string_0.ToLower().IndexOf(text2.ToLower()) != -1)
				{
					Form1.WriteLine(99, string_0);
				}
			}
		}

		public static void serlog(string string_0, SqlParameter[] sqlParameter_0)
		{
			string sqlJl = World.SqlJl;
			if (sqlJl.Length == 0)
			{
				return;
			}
			string[] array = sqlJl.Split('|');
			for (int i = 0; i < array.Length; i++)
			{
				if (string_0.ToLower().IndexOf(array[i].ToLower()) != -1)
				{
					Form1.WriteLine(99, string_0);
				}
			}
			for (int j = 0; j < array.Length; j++)
			{
				foreach (SqlParameter sqlParameter in sqlParameter_0)
				{
					if (sqlParameter.SqlValue.ToString().ToLower().IndexOf(array[j].ToLower()) != -1)
					{
						Form1.WriteLine(99, string_0 + " " + sqlParameter.SqlValue.ToString());
					}
				}
			}
		}

		public static void Setlog(string string_0, SqlParameter[] sqlParameter_0, Exception exception_0)
		{
			Form1.WriteLine(100, "-----------DBA数据层_错误-----------");
			Form1.WriteLine(100, string_0);
			if (sqlParameter_0 != null)
			{
				foreach (SqlParameter sqlParameter in sqlParameter_0)
				{
					Form1.WriteLine(100, sqlParameter.SqlValue.ToString());
				}
			}
			Form1.WriteLine(100, exception_0.Message);
		}

		public static string getstrConnection(string string_0)
		{
			try
			{
				if (string_0 == null)
				{
					string_0 = "GameServer";
				}
				DbClass value;
				return World.Db.TryGetValue(string_0, out value) ? value.SqlConnect : null;
			}
			catch
			{
				return null;
			}
		}

		public static int ExeSqlCommand(string string_0, SqlParameter[] sqlParameter_0)
		{
			serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand = SqlDBA.CreateCommandSql(sqlConnection, string_0, sqlParameter_0))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception_)
					{
						Setlog(string_0, sqlParameter_0, exception_);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string string_0, SqlParameter[] sqlParameter_0, string string_1)
		{
			serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(string_1)))
			{
				using (SqlCommand sqlCommand = SqlDBA.CreateCommandSql(sqlConnection, string_0, sqlParameter_0))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception_)
					{
						Setlog(string_0, sqlParameter_0, exception_);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string string_0)
		{
			serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception_)
					{
						Setlog(string_0, null, exception_);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string string_0, string string_1)
		{
			serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(string_1)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand.ExecuteNonQuery();
					}
					catch (Exception exception_)
					{
						Setlog(string_0, null, exception_);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string string_0, ref Exception exception_0, string string_1)
		{
			serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch (Exception ex)
					{
						Exception ex2 = exception_0 = ex;
						return -1;
					}
					int result = sqlCommand.ExecuteNonQuery();
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static DataTable GetDBToDataTable(string string_0, SqlParameter[] sqlParameter_0)
		{
			serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand2 = sqlDataAdapter.SelectCommand = SqlDBA.CreateCommandSql(sqlConnection, string_0, sqlParameter_0);
					using (sqlCommand2)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception ex)
						{
							Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + string_0);
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception exception_)
						{
							Setlog(string_0, sqlParameter_0, exception_);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataTable GetDBToDataTable(string string_0, SqlParameter[] sqlParameter_0, string string_1)
		{
			serlog(string_0, sqlParameter_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(string_1)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand2 = sqlDataAdapter.SelectCommand = SqlDBA.CreateCommandSql(sqlConnection, string_0, sqlParameter_0);
					using (sqlCommand2)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception ex)
						{
							Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + string_0);
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception exception_)
						{
							Setlog(string_0, sqlParameter_0, exception_);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataTable GetDBToDataTable(string string_0)
		{
			serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand2 = sqlDataAdapter.SelectCommand = new SqlCommand(string_0, sqlConnection);
					using (sqlCommand2)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception ex)
						{
							Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + string_0);
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception exception_)
						{
							Setlog(string_0, null, exception_);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataTable GetDBToDataTable(string string_0, string string_1)
		{
			serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(string_1)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand2 = sqlDataAdapter.SelectCommand = new SqlCommand(string_0, sqlConnection);
					using (sqlCommand2)
					{
						try
						{
							sqlConnection.Open();
						}
						catch
						{
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception exception_)
						{
							Setlog(string_0, null, exception_);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataRowCollection GetDBValue(string string_0, string string_1)
		{
			return GetDBToDataTable(string_0).Rows;
		}

		public static ArrayList GetDBValue_1(string string_0, string string_1)
		{
			serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return null;
					}
					ArrayList arrayList = new ArrayList();
					if (sqlDataReader.Read())
					{
						for (int i = 0; i < sqlDataReader.FieldCount; i++)
						{
							arrayList.Add(sqlDataReader[i]);
						}
					}
					sqlDataReader.Close();
					sqlDataReader.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					sqlCommand.Dispose();
					return arrayList;
				}
			}
		}

		public static ArrayList GetDBValue_2(string string_0, string string_1)
		{
			serlog(string_0);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return null;
					}
					ArrayList arrayList = new ArrayList();
					while (sqlDataReader.Read())
					{
						arrayList.Add(sqlDataReader[0]);
					}
					sqlDataReader.Close();
					sqlDataReader.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					sqlCommand.Dispose();
					return arrayList;
				}
			}
		}

		public static object GetDBValue_3(string string_0)
		{
			serlog(string_0);
			object result = null;
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					try
					{
						result = sqlCommand.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + string_0);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static object GetDBValue_3(string string_0, SqlParameter[] sqlParameter_0)
		{
			serlog(string_0, sqlParameter_0);
			object result = null;
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand = SqlDBA.CreateCommandSql(sqlConnection, string_0, sqlParameter_0))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					try
					{
						result = sqlCommand.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + string_0);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static object GetDBValue_3(string string_0, string string_1)
		{
			serlog(string_0);
			object result = null;
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(string_1)))
			{
				using (SqlCommand sqlCommand = new SqlCommand(string_0, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					try
					{
						result = sqlCommand.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + string_0);
					}
					sqlCommand.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}
	}
}
