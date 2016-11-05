using System;
using System.Data.SqlClient;

namespace CreateTable
{
    public class SQLServerDBMgr : DBMgr
    {
        protected override string GetSqlText()
        {
            throw new NotImplementedException();
        }

        protected override void ExecuteTran(string sqlText)
        {
            string connStr = "";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlTransaction transaction  = connection.BeginTransaction())
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sqlText;
                        try
                        {
                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        }
    }
}
