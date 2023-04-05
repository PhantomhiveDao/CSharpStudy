using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace unit22_多线程_资源访问冲突问题
{
    internal class StateObject
    {
        //解决资源冲突问题：使用lock
        private Object _lock1=new Object();  
        private Object _lock2=new Object();  
        //

        private int state1 = 5;
        private int state2 = 5;
        public void ChangeState1()
        {//死锁：导致程序无法运行
         //可以保证锁内的代码只被一个线程使用。但是会减少多线程的效率
            lock (_lock1)                       
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId+"state1中的lock111");
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "state1中的lock222");

                    if (state1 == 5)
                    {
                        state1++;
                        //读写操作
                        Console.WriteLine("state1的值：" + state1 + "：" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state1 = 5;
                    if (state2 == 5)
                    {
                        state2++;
                        //读写操作
                        Console.WriteLine("state2的值：" + state2 + "：" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state2 = 5;
                }    
            }         
        }
        public void ChangeState2()
        {//死锁：导致程序无法运行
         //可以保证锁内的代码只被一个线程使用。但是会减少多线程的效率
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "state2中的lock222");

                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "state2中的lock111");

                    if (state1 == 5)
                    {
                        state1++;
                        //读写操作
                        Console.WriteLine("state1的值：" + state1 + "：" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state1 = 5;
                    if (state2 == 5)
                    {
                        state2++;
                        //读写操作
                        Console.WriteLine("state2的值：" + state2 + "：" + Thread.CurrentThread.ManagedThreadId);
                    }
                    state2 = 5;
                }
            }
        }

    }
}
