using System;

namespace unit07_Action委托1
{
    //Action委托：返回值为空，可以有任意多个的
    //Action只能指向没有返回值的方法，

    //Function：可指向有返回值的方法。
    internal class Program
    {
        delegate void Action1(int x);
        private static void Test1() 
        {
            Console.WriteLine("istest1");
        }
        private static void Test2(int x)
        {
            Console.WriteLine("test2:"+x);
        }
        private static void Test3(int x, double y)
        {
            Console.WriteLine(x+y+"!!!~");
        }
        static void Main(string[] args)
        {
            Action ceshi = Test1;
            ceshi();
            //指向有一个参数，且参数类型为int类型的方法
            Action<int> test2 = Test2;
            test2(3);
            Action<int,double> test3 = Test3;
            test3(12,34.23);
        }
       
    }
}
