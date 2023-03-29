using System;
using System.Collections.Generic;
using System.Text;

namespace unit013_接口
{
    class Plane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("飞机在飞");
        }

        public void FlyAttack()
        {
            Console.WriteLine("飞机打人");
        }
    }
}
