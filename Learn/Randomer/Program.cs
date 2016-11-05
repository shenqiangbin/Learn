using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Randomer
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomHelper helper = new RandomHelper();
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine (helper.GetRandomLowerChar());
            //    Console.WriteLine (helper.GetRandomUpperChar());
            //    Console.WriteLine (helper.GetRandomNumber());
            //    Console.WriteLine (helper.GetRandomChineseChar());
            //    Console.WriteLine(helper.GetRandomSpecialChar());
            //    Console.WriteLine("--------------------------------------------");
            //}

            for (int i = 0; i < 10; i++)
            {
                var r = helper.GetRandomNumbers(8);
                Console.WriteLine(r);
            }


            Console.ReadKey();
        }
    }
}
