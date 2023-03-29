using System;

namespace unit011_运算符优先级
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("请输入五位数的密码");
        //    double coad = (Convert.ToDouble(Console.ReadLine())) ;
        //    ///char a = (char)coad;//(char)数字：将数字转换为字母
        //    //先判断输入的字符是否为五位数，如果不是，输出语句提
        //    ///Console.WriteLine(coad / 10000);
        //    if ((coad / 10000) < 1||(coad/10000)>10)
        //    {
        //        Console.WriteLine("不是五位数");
        //    }
        //    else
        //    {
        //        Console.WriteLine("-正在解密-");
        //        int a = (int)coad % 10000 / 1000;
        //        int b = (int)coad % 100 / 10;
        //        Console.WriteLine((char)(a * 10 + b));
        //    }

        //}

        static void Main(string[] args)
        {
            Console.WriteLine("数学分数");
            int Mathnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("英语分数");
            int Engnum = Convert.ToInt32(Console.ReadLine());
            if ((Mathnum>=90)||(Engnum>=90))
            {
                Console.WriteLine("win!");
            }
        }
    }
}
