using System;
using System.Threading;

namespace unit21_线程池
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(DowloadA);
                //用线程池启用的线程默认为后台线程
            }
            Thread.Sleep(5000);
        }
        static void DowloadA(Object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dowloading..."+Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
        }
    }
}
