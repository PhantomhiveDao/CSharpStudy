using System;

namespace unit014_索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 2, 4, 6, 3, 45 };
            //array[1] = 100;

            //Console.WriteLine(array[1]);


            test t = new test();
            t[0] = "8848";
            t[1] = "9948";
            Console.WriteLine(t[0]);
            Console.WriteLine(t[1]);
            //
            string[] namme = new string[20];
            namme[0] = "2312";
            //

            Week wk = new Week();
            Console.WriteLine(wk[Console.ReadLine()]);
        }
    }
}
