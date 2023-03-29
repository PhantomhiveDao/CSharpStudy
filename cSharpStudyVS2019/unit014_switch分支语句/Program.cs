using System;

namespace unit014_switch分支语句
{
    /// <summary>
    /// 对输⼊的4个整数，求出其中的最⼤值和最⼩值，并显⽰出来。
    /// </summary>
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        int a = Convert.ToInt32(Console.ReadLine());
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        int c = Convert.ToInt32(Console.ReadLine());
    //        int d = Convert.ToInt32(Console.ReadLine());

    //        if (a > b)
    //        {
    //            int max = a;
    //            a = b;
    //            b = max;
    //        }
    //        if (b > c)
    //        {
    //            int max = b;
    //            b = c;
    //            c = max;
    //        }
    //        if (c > d)
    //        {
    //            int max = c;
    //            c = d;
    //            d = max;
    //        }
    //        if (a > b)
    //        {
    //            int max = a;
    //            a = b;
    //            b = max;
    //        }
    //        if (b > c)
    //        {
    //            int max = b;
    //            b = c;
    //            c = max;
    //        }
    //        if (a > b)
    //        {
    //            int max = a;
    //            a = b;
    //            b = max;
    //        }
    //        Console.WriteLine("{0}，{1}，{2}，{3} ",a,b,c,d);
    //    }
    //}

    /// <summary>
    ///让⽤户输⼊两个整数，然后再输⼊0-3之间的⼀个数，0代表加法，1代表减法，2代表乘法，3代表除法,计算这两个数字的结果
    /// </summary>
    class Program2
    {
        static void Main(string[] args)
        {

            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            switch (c1) {
                case 0:
                    Console.WriteLine(a1 + b1);
                    break;
                case 1:
                    Console.WriteLine(a1 - b1);
                    break;
                case 2:
                    Console.WriteLine(a1 * b1);
                    break;
                case 3:
                    Console.WriteLine(a1 / b1);
                    break;
            }
                
        }
    }

}
