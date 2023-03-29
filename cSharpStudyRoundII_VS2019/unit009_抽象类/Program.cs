using System;

namespace unit009_抽象类
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy test ;
            test = new Boss();
            test.Attack();
            Console.WriteLine("Hello World!");
        }
    }
}
