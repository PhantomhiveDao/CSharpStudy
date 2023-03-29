using System;

namespace unit4._1_输入输出
{
    class Program
    {
        static void Main(string[] args)
        {
            string hahaha = Console.ReadLine();//等待输入结束后才会执行下一步
            //赋值原则：1.类型一致2.右侧值需要的容器大小 小于左侧的容器
            //int a = ()Console.ReadLine();

            int test=Convert.ToInt32(hahaha);//将字符串 转换成数字--Convert.ToInt32（）

            //简洁写法
            int gogogo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入的值" + gogogo);

            
        }
    }
}
