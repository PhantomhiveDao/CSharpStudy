using System;
using System.Collections.Generic;
using System.Text;

namespace unit016_运算符重载
{
    public class A
    {
        public virtual void Fun1(int i)
      {
            Console.WriteLine("Ai"+i);
        }
        public void Fun2(A a)
        {
            Console.WriteLine("A:a" + a);
            a.Fun1(1);
            Fun1(5);
        }
    }
}
