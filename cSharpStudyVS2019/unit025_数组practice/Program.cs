using System;

namespace unit025_数组practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ///声明⼀个int的数组，数组⼤⼩为9
            //int[] shuzu = new int[9];
            //Console.WriteLine(shuzu[2]);
            ///声明⼀个char数组，数组⻓度为20
            //char[] shuzuzu = new char[20];
            //int a= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(shuzuzu[a]);

            //遍历一个数组
            //for/foreach
            int[] arr1 = { 1, 4, 2, 4, 5, 23, 3 };
            //int a = 0;
            foreach (int a in arr1)//int的变量就是数组的索引;只能针对特定的数据集合使用;只能正序遍历。
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("for循环");

            for (int b = 6; b >=0; b--)
            {
                Console.WriteLine(arr1[b]);

            }
            Console.WriteLine("while循环");

            int c = 0;
            while (c<=6)
            {
                Console.WriteLine(arr1[c]);
                c++;
            }
            Console.WriteLine("数组末尾索引");

            //获取数组长度
            Console.WriteLine(arr1.Length-1);
            int[] arr2=new int[10];
        }
    }
}
