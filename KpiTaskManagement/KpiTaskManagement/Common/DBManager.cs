using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace KpiTaskManagement.Common
{
    public class DBManager
    {
        private static readonly Lazy<DBManager> lazyDBManager = new Lazy<DBManager>(() => new DBManager());
        public static DBManager InstantDBManger { get { return lazyDBManager.Value; } }
        private string ConnectString = "Server=172.16.99.122; database=TaskManagement; UID=root; password=123456";

        private DBManager()
        {
        }

        public SqlConnection GetConnect()
        {
            return new SqlConnection(ConnectString);
        }
        //datatable - string
        public DataTable GetData(string sql)
        {
            SqlConnection con = GetConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        public void QueryExecutionWithTransaction(string sql)
        {
            SqlConnection con = GetConnect();
            con.Open();

            SqlCommand command = con.CreateCommand();
            SqlTransaction transaction = con.BeginTransaction();
            command.Connection = con;
            command.Transaction = transaction;
            try
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception ex)
            {
              //  LogService.LogError("Query Execution With Transaction", ex);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex1)
                {
              //      LogService.LogError("Query Execution With Transaction roll back", ex1);
                }
            }
        }
        public void QueryExecutionWithTransaction(string[] ArrSql)
        {
            SqlConnection con = GetConnect();
            con.Open();

            SqlCommand command = con.CreateCommand();
            SqlTransaction transaction = con.BeginTransaction();
            command.Connection = con;
            command.Transaction = transaction;
            try
            {
                foreach (string sql in ArrSql)
                {
                    if ((sql != string.Empty) && (sql != null))
                    {
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }

                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
              //  LogService.LogError("Query Execution With Transaction", ex);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex1)
                {
              //      LogService.LogError("Query Execution With Transaction roll back", ex1);
                }
            }
        }

        public void StoredProcedureExecution(string SqlCommand, Dictionary<string, object> SqlParameterList)
        {
            SqlConnection con = GetConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(SqlCommand, con) { CommandType = CommandType.StoredProcedure };
                foreach (KeyValuePair<string, object> SqlParameter in SqlParameterList)
                {
                    cmd.Parameters.AddWithValue(SqlParameter.Key, SqlParameter.Value);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
               // LogService.LogError("Stored Procedure Execution", ex);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }      
    }
}
