using System;
using System.Collections.Generic;
using System.Text;

namespace unit016_运算符重载
{
    public class B : A
    {
        public override void Fun1(int i)
        {
            Console.WriteLine("iB:"+i);
            base.Fun1(i + 1);

        }
    }
}