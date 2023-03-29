using System;

namespace practice001
{
    class Program
    {
        static void Main(string[] args)
        {
            ///求和
            //Console.WriteLine("请输入数字A:");
            //int inputA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字B:");
            //int inputB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("两个数的和为：" + (inputA + inputB));

            ///求平均数
            //Console.WriteLine("请输入数字A:");
            //int inputA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数字B:");
            //int inputB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("两个数的平均数为：" + ((inputA + inputB)/2));

            ///将a元钱分给b个⼈，每个⼈可以分得多少，a、b都是整数。
            Console.WriteLine("请输入钱数A:");
            double inputA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入人数B:");
            double inputB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("每人可以分得钱数为：" + (inputA / inputB));
            Console.WriteLine("{0}+{1}={2}", inputA, inputB, (inputB + inputA));//字符串格式化输出
            //c#数据类型范围
        }
    }
}
