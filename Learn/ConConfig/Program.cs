using ConfigLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigCenter configCenter = new ConfigCenter();
            string doorUrl = configCenter.WebSite.Door;
            Console.WriteLine(doorUrl);

            Console.ReadLine();

        }
    }
}
