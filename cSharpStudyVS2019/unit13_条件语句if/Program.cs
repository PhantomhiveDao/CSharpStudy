using System;

namespace unit13_条件语句if
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        /////判断输入的坐标象限
    //        //Console.WriteLine("输入x轴坐标");
    //        //int x = Convert.ToInt32(Console.ReadLine());
    //        //Console.WriteLine("输入Y轴坐标");
    //        //int Y= Convert.ToInt32(Console.ReadLine());
    //        //if ((x > 0) && (Y > 0))
    //        //{
    //        //    Console.WriteLine("第一象限");
    //        //}
    //        //else if ((x < 0) && (Y > 0))
    //        //{
    //        //    Console.WriteLine("第2象限");

    //        //}
    //        //else if ((x < 0) && (Y < 0))
    //        //{
    //        //    Console.WriteLine("第3象限");

    //        //}
    //        //else if (x < 0 && Y < 0)
    //        //{
    //        //    Console.WriteLine("第4象限");

    //        //}
    //        //else if ((0 == x) && (Y != 0))
    //        //{
    //        //    Console.WriteLine("在y轴上");
    //        //}
    //        //else if ((0 == Y) && x != 0)
    //        //{
    //        //    Console.WriteLine("在x轴上");
    //        //}
    //        //else {
    //        //    Console.WriteLine("原点");
    //        //}

    //        /////判断⼊三⾓形的三条边 a 、b 和c，判断是否可以组成三⾓形。
    //        //int a = Convert.ToInt32(Console.ReadLine());
    //        //int b = Convert.ToInt32(Console.ReadLine());
    //        //int c = Convert.ToInt32(Console.ReadLine());
    //        //if (a + b > c && b + c > a&& c + a > b)
    //        //{
    //        //    Console.WriteLine("是三角形");
    //        //}
    //        //else
    //        //{ Console.WriteLine("bu是三角形"); }


    //        ///输⼊⼀个年份，判断该年是不是闰年。是的话输出Yes，不是的话输出No。
    //        //int year = Convert.ToInt32(Console.ReadLine());
    //        //if ((year % 4 == 0&& year % 100 != 0)|| year % 400 == 0)
    //        //{

    //        //        Console.WriteLine("闰年");

    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("Nothing");
    //        //}


    //        /////输⼊⼀个⾮零整数，判断是正数还是负数，并输出它的绝对值
    //        //int num = Convert.ToInt32(Console.ReadLine());
    //        //if (num > 0)
    //        //{
    //        //    Console.WriteLine(num);
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine(-num);
    //        //}


    //        /////：输⼊三个整数，求这个三个数中最⼤值的平⽅。
    //        //int a = Convert.ToInt32(Console.ReadLine());
    //        //int b = Convert.ToInt32(Console.ReadLine());
    //        //int c = Convert.ToInt32(Console.ReadLine());
    //        //int max=a;
    //        //if (b > max)
    //        //{
    //        //    max = b;
    //        //}
    //        //if (c > max)
    //        //{
    //        //    max = c;
    //        //}
    //        //Console.WriteLine(max*max);


    //        /////任意给出两个⼤写英⽂字⺟，⽐较他们的⼤⼩。规定 A、B、C、....Z依次从⼩到⼤。
    //        //char a = Convert.ToChar(Console.ReadLine());
    //        //char b = Convert.ToChar(Console.ReadLine());
    //        //if (a < b)
    //        //{
    //        //    Console.WriteLine("{0},{1}",a,b);

    //        //}
    //        //else if (a == b)
    //        //{
    //        //    Console.WriteLine("{0},{1},{2}", a, b,"SHAYEBUSHI");
    //        //}else if (a > b)
    //        //{
    //        //    Console.WriteLine("{0},{1}", b, a);
    //        //}

    //        ///！每个⼈都需要测试两项项⽬。请输⼊你的性别和抽到的号码，输出你的测试项⽬


    //    }
    //}
    ///！每个⼈都需要测试两项项⽬。请输⼊你的性别和抽到的号码，输出你的测试项⽬
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        int num = Convert.ToInt32(Console.ReadLine());
    //        char sex = Convert.ToChar(Console.ReadLine());
    //        char taest='M';
    //        string project="800m changpao";

    //        if ((taest == sex) && (0==num % 2))
    //            //Console.WriteLine("1000m 俯卧撑");
    //                project+=" cheng";
    //        else if((taest == sex) && (1==num % 2))
    //            Console.WriteLine("1000m 跳远");
    //        else if(('F' == sex) && (0==num % 2))
    //            Console.WriteLine("800m 仰卧起坐");
    //        else if(('F' == sex) && (1==num % 2))
    //            Console.WriteLine("800m 跳绳");
    //    }
    //}

    ///输⼊三个整数，把这三个数，从⼩到⼤排序后输出。

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        int c = Convert.ToInt32(Console.ReadLine());
    //        if (a > b)
    //        {
    //            int temp = a;
    //            a = b;
    //            b = temp;
    //        }
    //        if (b > c)
    //        {
    //            int temp = b;
    //            b = c;
    //            c = temp;

    //        }
    //        if(a>b)
    //        {
    //            int temp = a;
    //            a = b;
    //            b = temp;
    //        }
    //        Console.WriteLine(a + " " + b + " " + c);
    //    }
    //}



    /// <summary>
    /// 输⼊⼀个⼩数m和整数k（k为0,1）如果k为0，则输出m保留整数部分。如果k为1，则输出m，四舍五⼊保留1为⼩数。样例输⼊ 4.65 0 输出 4输⼊ 4.65 1 输出4.7
    /// /// </summary>
    class Program23
    {
        static void Main(string[] args)
        {

            double m = Convert.ToDouble(Console.ReadLine());
            bool k = Convert.ToBoolean(Console.ReadLine());

            if (false == k)//如果k为0，则输出m保留整数部分。
            {
                Console.WriteLine((int)m);
            }
            else//则输出m，四舍五⼊保留1为⼩数
            {
                int temp;
                temp = (int)(m * 100 % 10);//697.8
                if (temp >= 5)
                {
                    m = (int)(m * 10) + 1;
                    m /= 10;
                    Console.WriteLine(m);
                }
                else//6.978
                {
                    m = (int)(m * 10);
                    m /= 10;
                    Console.WriteLine(m);
                }
            }

        }
    }
}






