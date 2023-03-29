using System;
using System.Collections.Generic;

namespace unit023_栈和队列
{
    class Program
    {
        static void Main(string[] args)
        {
            //栈后进先出。
            //push peek pop

            Stack<int> we = new Stack<int>();
            //存：入栈-push
            we.Push(231);
            we.Push(4);
            we.Push(2);
            we.Push(4);
            we.Push(9);

            foreach (int i in we)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("遍历完了");

            //取：
            int res1 = we.Peek();
            int res2 = we.Count;
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            //出栈：pop
            we.Contains(2);//判断是否包含 返回bool值

            //队列：队头-队尾
            //入队，出队
            //先进先出
            Queue<int> q = new Queue<int>();
            q.Enqueue(2);
            q.Enqueue(1);
            q.Enqueue(3);
            q.Enqueue(5);
            Console.WriteLine((int)q.Peek());



        }
    }
}
