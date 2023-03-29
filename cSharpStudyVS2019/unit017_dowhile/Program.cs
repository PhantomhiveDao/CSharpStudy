using System;

namespace unit017_dowhile
{
    /// <summary>
    /// ⽤户输⼊整数，如果⽤户输⼊的不是0，就继续输⼊，如果输⼊的是0，结束整数，并输出所有整数的和。
    /// </summary>
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //先执行一次循环体 再进行判断
    //        int i = Convert.ToInt32(Console.ReadLine());
    //        int sum = 0;

    //        while (i!=0)
    //        {
    //            int m = Convert.ToInt32(Console.ReadLine());
    //            i = m;
    //            sum += i;

    //        };
    //        Console.WriteLine(sum);

    //    }
    //}

    ///⼀个球从某⼀⾼度落下来，每次落地后反跳回原来⾼度的⼀半，再落下。
    ///编程计算球第10次反弹多⾼？在第10次落地时，共经过多少⽶？
    ///输⼊球的初始⾼度，输出反弹多⾼，和经过了多少⽶。

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double height = Convert.ToDouble(Console.ReadLine());
    //       // double height = 0;
    //        double longth = height;
    //        for (int time = 0; time < 10; time++)
    //        {
    //            height = (0.5) * height;
    //            longth += 2*height;

    //        }
    //        Console.WriteLine(height+"m");
    //        Console.WriteLine(longth+"m总高度");
    //    }
    //}

    ///输⼊q和n，求下⾯公式的结果。。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //int a = Convert.ToInt32(Console.ReadLine());
    //        int q = Convert.ToInt32(Console.ReadLine());
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int sum_result=1;//总和
    //       // int temp;//当前次方数
    //        int temp = 1;

    //        for (int i = 1; i <= n; i++)
    //        {
    //            temp *= q;
    //            sum_result += temp;
    //        }
    //        Console.WriteLine(sum_result);











    //    }
    //}


    ///：Sn = 1 + 1/2 + 1/3 + ... + 1/n。 显然对于任意⼀个整数k，当n⾜够⼤的时候，Sn⼤于K。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int k = Convert.ToInt32(Console.ReadLine());
    //        int n=0;
    //        double Sn = 0;

    //        while (Sn <= k) 
    //        {
    //            n++;
    //            Sn += 1.0 / n;


    //            //n++;
    //            //Console.WriteLine(Sn+"总和");
    //        }
    //        Console.WriteLine(n);










    //    }
    //}


    ///我国现有x亿⼈⼝，按照每年0.1%的增⻓速度，n年后将有多少⼈？
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double x = Convert.ToDouble(Console.ReadLine());
    //        int n = Convert.ToInt32(Console.ReadLine());

    //        //double Sn = x;

    //        for (int i = 0; i < n; i++)
    //        {
    //           x*=1.001;
    //        }
    //        Console.WriteLine(x);

    //    }
    //}

    ///随机输⼊⼀个位数未知的整数，去除这个整数各个位上的0，形成新的数，并输出。输⼊的数字n⼤于0，⼩于1000000。

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            int num = Convert.ToInt32(Console.ReadLine());
    //            int outputA;
    //            while (num!=0)
    //            {
    //                int i = 0;
    //                outputA = num%10;
    //                if (outputA != 0)
    //                {
    //                    outputA *=Convert.ToInt32( Math.Pow(10, i));
    //                    Console.Write(outputA);                   
    //                }
    //                i++;
    //                num /= 10;
    //            }



    //        }
    //    }
    //}
    ///随机输⼊⼀个整数num，输出⼀个新的数，新数恰好与原数每⼀位上的数字相反。（如果原数末尾有多个零，输出的新数⾼位不含0）

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        int outputA;
    //        while (num != 0)
    //        {
    //            int i = 0;
    //            outputA = num % 10;
    //            if (outputA != 0)
    //            {
    //                //outputA *= Convert.ToInt32(Math.Pow(10, i));
    //                Console.Write(outputA);
    //            }
    //            i++;
    //            num /= 10;
    //        }
    //    }
    //}

    ///回⽂数指正序（从左到右）和倒序（从右到左）读都是⼀样的整数。
    ///输⼊⼀个数，判断是否是回⽂数。输⼊的整数⼤于0，⼩于1000000。如果是回⽂输出yes，不是输出no。
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        int outputa=num;
    //        int a=0;
    //        int i = 0;
    //        while (num != 0)
    //        {               
    //            a = a* 10+ (num % 10);               
    //            Console.WriteLine(a);
    //            num = num/10;
    //            //i++;
    //        }
    //        if (a == outputa)
    //        {
    //            Console.WriteLine("yes");
    //            Console.WriteLine(a);
    //        }
    //        else
    //        {
    //            Console.WriteLine("no");
    //            Console.WriteLine(a);

    //        }

    //    }
    //}

    ///数字和字符混合在⼀起了，作为⼀个优秀的挖掘⼈员，把输⼊的数字挖出来，并计算这些数字的和，并输出。输⼊以 @作为结束。
    class program
    {
        static void Main(string[] args)
        {
            string num =Console.ReadLine();
            

        }
    }
}


