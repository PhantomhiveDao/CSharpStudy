using System;

namespace unit024_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明int类型的数组-先声明；再赋值
            int[] test;
            int[] ages0= { 4,347,3,1,4,6,7,23,45,12,3,5};//[]代表是数组;数组有长度;当前数组长度为12
            //数组有下标【索引】0，1，2，3，4，5，6，7...
            Console.WriteLine(ages0[1]);

            //对数组赋值的方式
            //方法【1】
            int[] ages1 = { 4, 347, 3, 1, 4, 6, 7, 23, 45, 12, 3, 5 };//[]代表是数组;数组有长度;当前数组长度为12
            //方法【2】
            int[] ages3;
            ages3 = new int[10];//没有指定值的时候，会给一个默认值，只要是数字的话默认值全为0
            Console.WriteLine(ages3[3]);
            //方法【3】
            int[] ages4;//声明一个数组
            ages4 = new int[] { 1, 3, 5, 6, 2, 43, 6, 4, 3, 5 }; //new：向系统声明内存的过程。数组本身是一个引用类型的。引用类型和基础类型在系统中存储的方式不同。
            //方法【4】
            int[] ages2;
            ages2 = new int[6] { 1, 6,4,6,2,3};

            ages2[4] = 100;
            Console.WriteLine(ages2[4]);


        }
    }
}
