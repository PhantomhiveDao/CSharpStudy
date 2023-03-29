using System;
using System.Collections.Generic;
using System.Text;

namespace unit010_子类的构造
{
    class BaseClass
    {
        private int hp;
        private int age;

        public BaseClass(int hp, int age)
        {
            this.hp = hp;
            this.age = age;
        }

        public BaseClass()
        {
            Console.WriteLine("baseclass");
        }
    }
}
