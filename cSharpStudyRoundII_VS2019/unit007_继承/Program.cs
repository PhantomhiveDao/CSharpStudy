using System;

namespace unit007_继承
{
    class Program
    {
        //Object：没有指定继承自谁的时候，默认继承自Pbject//公共基类。
        static void Main(string[] args)
        {
            BaseClass bs = new BaseClass();
            bs.Function1();
            DrivedClass1 dc1 = new DrivedClass1();
            dc1.Function2();

            DrivedClass2 dc2 = new DrivedClass2();
            Boss boss1 = new Boss(12,23,44);
            boss1.Print();
        }
    }
}
