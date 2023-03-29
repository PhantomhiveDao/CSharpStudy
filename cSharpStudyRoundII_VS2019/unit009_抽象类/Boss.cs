using System;
using System.Collections.Generic;
using System.Text;

namespace unit009_抽象类
{
    public class Boss:Enemy
    {
        public sealed override void Attack()
        {
            //throw new NotImplementedException();//抛出一个异常
            Console.WriteLine("boss攻击");
        }
    }
}
