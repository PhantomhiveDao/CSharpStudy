using System;

namespace unit006_值类型引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            ///stack栈 heap堆 hoop静态存储区
            //值类型：直接存在栈里stack
            int a = 123;
            float b = 2.34f;
            bool c = true;
            //引用类型 栈里存name（字符串）的地址，内容放在静态存储区
            //字符串都存在静态存储区内。
            string name = "test";
            //引用类型中的数据放进堆中（heap；栈里存储内存地址
            //对于字符串数组而言，堆中储存字符串在静态存储区中的地址。
            int[] intArr = { 1, 2, 3, 4 };
            string[] strArr = { "123", "ddfs", "0wklcz" };

            Customer c1 = new Customer("人类","江苏",4,20160312);
            Customer c2 = new Customer("不是人类","西安",12,20230312);
            c1.name = "shayebushi";
            Console.WriteLine(c1.name);
            //算是一种引用。将c3内存数据地址修改为与c1一样。
            //引用指向内存区域。
            Customer c3 = c1;
            c3.name = "4434";
            Console.WriteLine(c3.name);
            Console.WriteLine("这是C1："+c1.name);

            Console.WriteLine("-------");

            c1 = null;//空 空引用 空对象。

        }
    }
}
