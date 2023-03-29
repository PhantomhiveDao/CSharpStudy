using System;
using System.Threading;

namespace unit20_线程优先级
{
    internal class Program
    {
        static void A() 
        {
            while (true)
            {
                Console.Write("a");
            }
        }
        static void B() 
        {
            while (true)
            {
                Console.Write("b"); 
            }
        }
        static void Main(string[] args)
        {
            Thread a = new Thread(A);
            Thread b = new Thread(B);
            a.Priority = ThreadPriority.Lowest;
            b.Priority = ThreadPriority.Highest; 
            a.Start();
            b.Start();
        }
    }
}
