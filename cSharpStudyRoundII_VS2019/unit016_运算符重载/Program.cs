using System;

namespace unit016_运算符重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //函数重载--相当于把函数进行重写。
            //运算符重载--运算符重写

            //Student st1 = new Student(20,"ZhangDan",112311);
            //Student st2 = new Student(20,"ZhangDan",112311);



            //Console.WriteLine(st1==st2);
            //输出false=》因为只有数据一样，内存地址不同。此时比较的是内存地址。
            B b = new B();
            A a = new A();
            a.Fun2(b);
            b.Fun2(a);
            Console.WriteLine("b:" + b);
        }
    }
}
