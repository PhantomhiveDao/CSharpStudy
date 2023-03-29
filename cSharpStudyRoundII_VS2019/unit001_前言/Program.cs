using System;

namespace unit001_前言
{
    //复习委托。
    delegate int plus(int a, int b);

    class Program
    {
        struct Persion 
        {
            public int[] num;
        }
        static int plus23(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            plus plus1;
            plus1 = plus23;
            plus1(1, 3);
            Console.WriteLine(plus1(1, 3));
        }
    }
}
