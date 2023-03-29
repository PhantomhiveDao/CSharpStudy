using System;

namespace unit015_练习题13
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();//用父类：虚方法声明了一个对象a用子类b进行了构造
            a.Fun();
        }
    }
}
