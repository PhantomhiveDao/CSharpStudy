using System;

namespace unit015_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            while (result< num)
            {
                result++;
                Console.Write(result+" ");

                
            }

        }
    }
}
