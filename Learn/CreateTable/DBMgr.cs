using System;

namespace CreateTable
{
    public abstract class DBMgr
    {
        public void IniDB()
        {
            string sqlText = GetSqlText();
            ExecuteTran(sqlText);
        }

        protected abstract string GetSqlText();
        protected abstract void ExecuteTran(string sqlText);
    }
}
