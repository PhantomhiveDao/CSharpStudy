using System;

namespace unit10_多播委托
{
    //委托也可以包含多个方法，这种委托就叫做多播委托。
    //可以按照顺序调用多个方法。
    //多播委托只能得到调用的最后一个方法的结果
    //一般我们把多播委托的返回类型声明为void
    //【多播委托】包含一个逐个调用的委托集合
    //如果通过委托调用的其中一个方法抛出异常，则整个迭代就会停止。
    ///如何得到多播委托的集合？
    internal class Program
    {
        private static void Test1() 
        {
            Console.WriteLine("tset1");
        } 
        private static void Test2() 
        {
            Console.WriteLine("tset1");
        }

        static void Main(string[] args)
        {
            Action ac1=Test1;
            ac1 += Test2;
            //等价于：ac1=ac1+Test2;
            //得到多播委托的集合
            Delegate[] dels=ac1.GetInvocationList();//返回的是Delegate类这个类型的数组
            foreach(Delegate de in dels) 
            {
                de.DynamicInvoke();//动态调用
            }
        }
    }
}
