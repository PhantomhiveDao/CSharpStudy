using System;
using System.Threading;

namespace unit22_多线程_资源访问冲突问题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StateObject state = new StateObject();//类的实例化
            for (int i = 0; i < 200; i++)
            {
                Thread t1 = new Thread(state.ChangeState1);
                t1.Start();

                Thread t2 = new Thread(state.ChangeState2);
                t2.Start();
            }
        }
    }
}
