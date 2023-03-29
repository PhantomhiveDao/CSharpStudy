using System;
using System.Collections.Generic;
using System.Text;

namespace unit008_虚方法
{
    class Type1:Enemy
    {
        public void Print()
        {
            Console.WriteLine("Hp:" + hp);
            Console.WriteLine("base.Hp" + base.hp);
            Console.WriteLine("Speed:" + speed);
        }
    }
}
