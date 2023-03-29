using System;
using System.Threading;

namespace unit17_线程Thread
{
    internal class Program
    {
        public struct Data
        {
            public int Value;
            public string str;  
        }
        static void Test() 
        {
            Console.WriteLine("Stared");
            Thread.Sleep(1000);
            Console.WriteLine("end"+ Thread.CurrentThread.ManagedThreadId);
        }
        static void Dowload(object o) 
        {

            //string str =o as string;    //as:强制类型转换，不成功会返回null
            Data data = (Data)o;
            //结构体不能用as转化。
            Console.WriteLine(data.str);

        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Test);
            Thread t2 = new Thread(()=>Console.WriteLine("child Thread"+Thread.CurrentThread.ManagedThreadId));
            //也可以使用匿名方法
            Thread t3 = new Thread(delegate () { });
            //Thread.CurrentThread.ManagedThreadId=获取当前线程的对象。
            //线程id是唯一的
            t.Start();
            t2.Start(); 
            Console.WriteLine("mAIN"+ Thread.CurrentThread.ManagedThreadId);

            //
            Thread t4 = new Thread(Dowload);
            //t4.Start("http://???");
            //避免定义过多的静态变量。
            //上述方法适合传输一个数据
            //传输多个数据：1）声明一个结构体。2）定义数据
            Data data = new Data();
            data.Value = 999;
            data.str = "is Str";
            t4.Start(data);

        }
    }
}
