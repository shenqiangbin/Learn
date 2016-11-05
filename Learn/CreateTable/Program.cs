
namespace CreateTable
{
    public class Program
    {
        public static void Main()
        {
            DBMgr dbMgr = new SQLiteDBMgr();
            dbMgr.IniDB();
        } 
    }
}
