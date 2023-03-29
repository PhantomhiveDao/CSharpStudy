using System;

namespace unit11_匿名方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int,int,int>puls=delegate(int a,int b){ return a + b; };

            //lambda表达式：一种语法规则；可以对复杂一些的匿名方法进行简化
            Func<int, int, int> puls = (a, b) => { return a + b; };
            //当lambda表达式中只有一条语句时，可以进一步简化
            Func<int, int, int> test = (x, y) => x - y;
            //Func<传递参数类型，传递参数类型，返回参数类型>匿名方法名称=（参数1，参数2）=>
            int res = puls(3 ,4);
            Console.WriteLine(res);
            //lambda可以访问外部变量;但是容易结果不可控，容易出现编程问题
            int a = 90;
            Func<int, int, int> F = (x, y) => x - y+a;


        }

    }
}
