using System;

namespace unit031_算法
{
    class Program
    {
        ///算法：解决一定的问题的计算方法
        ///数据结构 算法
        ///基础语法之后再数据结构与算法
        //函数的重载：OverLoad//c#中叫方法
        //函数名相同，参数不同（int类型或者double等）；编译器会根据传入的参数类型不同来决定调用的参数
        //方法名不能相同

        static int Maxvaule(int[] array)
        {
            int max = array[0];
            for(int i=1;i<array.Length;i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double Maxvaule(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Maxvaule(new int []  {112, 2, 4, 3, 5}));
            Console.WriteLine(Maxvaule(new double [] { 11.2, 2.4, 4.3, 3.11, 531.241 }));

        }
    }
}
