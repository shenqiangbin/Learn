using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SqlGenerator;

namespace GenerateSql
{
    class Program
    {
        static void Main(string[] args)
        {
            //test();
            //BuildPrintLogRecords();
            BuildSysLogRecords();

            Console.ReadKey();
        }

        private static void BuildSysLogRecords()
        {
            string format = "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}";
            RandomSql randomSql = new RandomSql(format);
            randomSql.WithQuotation = true;

            randomSql.Values.Add(new IdentityRandomValue(1, 1, IdentityRandomValueFormat.String));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Machine));
            randomSql.Values.Add(new NumberRandomValue(1, 30));
            randomSql.Values.Add(new NumberRandomValue(1, 4));
            randomSql.Values.Add(new StringRandomValue(new string[] { "描述信息" }));
            randomSql.Values.Add(new DateTimeRandomValue(DateTime.Now, new DateTime(2010, 1, 1)));
            randomSql.Values.Add(new StringRandomValue(new string[] { "操作描述" }));
            randomSql.Values.Add(new NumberRandomValue(1, 4));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.SecurityLevel));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Department));
            randomSql.Values.Add(new IdentityRandomValue(1, 1, IdentityRandomValueFormat.String));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.PersonName));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Duty));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Numberic));
            randomSql.Values.Add(new BoolRandomValue(true));
            randomSql.Values.Add(new BoolRandomValue(true));
            randomSql.Values.Add(new BoolRandomValue(true));
            randomSql.Values.Add(new NumberRandomValue(1, 10));
            randomSql.Values.Add(new DateTimeRandomValue(DateTime.Now, new DateTime(2014, 11, 20)));
            randomSql.Values.Add(new NumberRandomValue(1, 3));

            randomSql.Generated += new EventHandler(randomSql_Generated);
            randomSql.Generating += randomSql_Generating;
            //randomSql.GenerateRecordsToFile(10000, "c:\\syslog.txt");
            randomSql.GenerateRecords(5);
        }       

        private static void BuildPrintLogRecords()
        {
            string format = @"insert into T_PrintLog values(
                                {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},
                                {18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},
                                {34},{35},{36},{37});";
            format = "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37}";
            RandomSql randomSql = new RandomSql(format);
            randomSql.WithQuotation = false;

            randomSql.Values.Add(new IdentityRandomValue(1000, 1, IdentityRandomValueFormat.String));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Machine));
            randomSql.Values.Add(new IdentityRandomValue(1, 1, IdentityRandomValueFormat.Numberic));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Printer));
            randomSql.Values.Add(new NumberRandomValue(1, 30));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Book));
            randomSql.Values.Add(new StringRandomValue(new string[] { "李强：审批通过" }));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.SecurityLevel));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Purpose));
            randomSql.Values.Add(new NumberRandomValue(1, 30));
            randomSql.Values.Add(new NumberRandomValue(1, 30));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.PagerType));
            randomSql.Values.Add(new NumberRandomValue(0, 1));
            randomSql.Values.Add(new NumberRandomValue(10, 20));
            randomSql.Values.Add(new NumberRandomValue(1, 10));
            randomSql.Values.Add(new NumberRandomValue(400, 500));
            randomSql.Values.Add(new NumberRandomValue(60, 70));
            randomSql.Values.Add(new NumberRandomValue(60, 70));
            randomSql.Values.Add(new DateTimeRandomValue(DateTime.Now, new DateTime(2010, 1, 1)));
            randomSql.Values.Add(new DateTimeRandomValue(DateTime.Now, new DateTime(2010, 1, 1)));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Numberic));
            randomSql.Values.Add(new NumberRandomValue(1, 10));
            randomSql.Values.Add(new BoolRandomValue());
            randomSql.Values.Add(new BoolRandomValue());
            randomSql.Values.Add(new BoolRandomValue());
            randomSql.Values.Add(new StringRandomValue(new string[] { "无" }));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.SecurityLevel));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Department));
            randomSql.Values.Add(new IdentityRandomValue(1, 20, IdentityRandomValueFormat.String));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.PersonName));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Duty));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Numberic));
            randomSql.Values.Add(new BoolRandomValue(true));
            randomSql.Values.Add(new BoolRandomValue(true));
            randomSql.Values.Add(new BoolRandomValue(true));
            randomSql.Values.Add(new NumberRandomValue(1, 10));
            randomSql.Values.Add(new DateTimeRandomValue(DateTime.Now, new DateTime(2014, 11, 20)));
            randomSql.Values.Add(new NumberRandomValue(1, 3));

            randomSql.Generated += new EventHandler(randomSql_Generated);
            randomSql.GenerateRecordsToFile(1000000, @"c:\sql.txt");

        }

        private static void test()
        {
            string format = "insert [User] values({0},{1},{2},{3},{4},{5},{6},{7})";
            RandomSql randomSql = new RandomSql(format);

            randomSql.Values.Add(new IdentityRandomValue(1, 1, IdentityRandomValueFormat.Numberic));
            randomSql.Values.Add(new IdentityRandomValue(201002010201, 2, IdentityRandomValueFormat.String));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Numberic));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.Department));
            randomSql.Values.Add(new StringRandomValue(StringRandomValueFormat.PersonName));
            randomSql.Values.Add(new DateTimeRandomValue(DateTime.Now, new DateTime(2013, 1, 1)));
            randomSql.Values.Add(new BoolRandomValue());
            randomSql.Values.Add(new GUIDRandomValue());

            //randomSql.Generating += new MyRandomEventHandler(randomSql_Generating);
            randomSql.Generated += new EventHandler(randomSql_Generated);
            //randomSql.GenerateRecords(1000);
            randomSql.GenerateRecordsToFile(10, @"c:\sql.txt");
        }

        static void randomSql_Generated(object sender, EventArgs e)
        {
            Console.WriteLine("completed");
        }

        static void randomSql_Generating(object sender, RandomGenerateEventArgs e)
        {
            Console.WriteLine(e.RandomRecords);
        }
    }
}
