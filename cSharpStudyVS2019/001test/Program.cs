using System;

namespace _001test
{
    // 双反斜杠对特殊符号有转义作用
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            //
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");
            Console.WriteLine("   *");
            Console.WriteLine("   *");
            Console.WriteLine("   *");
            //
            Console.WriteLine("\\\"");
            Console.WriteLine("SIKI说：\"what is \\n\"");
            //
            int a = 4;
            int b = 3;
            int c = 0;
            //在上⾯的条件下 单独计算下⾯⾏的结果
            c = a;
            c = a + b;
            c = a * a;//16
            a = a * a;//16
            a = a * b;//48;b=3

            Console.WriteLine(a + "+" + b);
            Console.WriteLine("a+b" + (a + b));
            Console.WriteLine(c);

        }
    }
}
