using System;
using System.Threading;
using System.Threading.Tasks;

namespace unit21_多线程_任务
{
    internal class Program
    {
        static void Test()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+"test");
            }
        }

        static void Main(string[] args)
        {

            //法1
            TaskFactory tf=new TaskFactory();
            tf.StartNew(Test);//可以返回一个task对象。
            Task t=tf.StartNew(Test);
            //法2
            Task ta=new Task(Test);
            ta.Start();
            //A结束后紧接着执行B-注意：b方法中应该传入一个task类型的参数
            //ta.ContinueWith(B);

            Thread.Sleep(3000);
        }
    }
}
