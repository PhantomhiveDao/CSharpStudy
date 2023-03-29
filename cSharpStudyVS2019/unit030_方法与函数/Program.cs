using System;

namespace unit030_方法与函数
{
    class Program
    {
        ///主函数-入口函数--主方法 入口方法
        ///static 静态-修饰符
        ///void:空的返回值
        ///Main方法名
        ///args参数
        ///{}方法体
        //方法的定义
       static bool VerfifyUserMane(string username)//变量名 小写开头，方法名 大写开头;()内写传递的形参-形式参数
       {
            Console.WriteLine("1");
            Console.WriteLine("HAHAHAHA");
            return true;
       }
        static int AddCout(string username,int a)//变量名 小写开头，方法名 大写开头;()内写传递的形参-形式参数
        {
            int b = 0;
            Console.WriteLine(username);
            b=a+10;
            return b;
        }
        static void Main(string[] args)
        {
            string username="asdf";
            //方法的调用
            VerfifyUserMane(username);//()内的username是实参
            VerfifyUserMane("2342");//()内的"2342"是实参

            Console.WriteLine(AddCout(username, 8));
        }
    }
}
