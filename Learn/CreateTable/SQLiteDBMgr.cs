using System;
using System.Data.SQLite;

namespace CreateTable
{
    public class SQLiteDBMgr : DBMgr
    {
        protected  override string GetSqlText()
        {
            return "CREATE TABLE IF NOT EXISTS T_User(account nvarchar(20) primary key,username varchar(20),password varchar(20))";
        }

        protected override void ExecuteTran(string sqlText)
        {
            string connStr = "Data Source = Tiger.db3";
            using (SQLiteConnection connection = new SQLiteConnection(connStr))
            {
                connection.Open();
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    using (SQLiteCommand command = connection.CreateCommand())
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
