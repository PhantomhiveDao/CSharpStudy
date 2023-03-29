using System;

namespace unit016_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine()); 
            //break;//---
            for (int i = Convert.ToInt32(Console.ReadLine()); i < m; i++)//(初始化代码)；循环执行的条件判断；满足条件后执行的代码
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);

                }

            }
        }
    }
}
