using System;
using System.Collections.Generic;
using System.Text;

namespace unit013_接口
{
    class Bird : IFly 
    {
        public void Fly()
        {
            Console.WriteLine("鸟飞");
        }

        public void FlyAttack()
        {
            Console.WriteLine("鸟打人");
        }
    }
}
