using System;
using System.Collections.Generic;
using System.Text;

namespace unit008_虚方法
{
    class Enemy
    {
        protected int hp;
        protected int speed;
        //protected//在子类里可以访问

        public void AI()
        {
            Console.WriteLine("AI");
        }
        public virtual void Move()
        {
            Console.WriteLine("敌人正在Move");

        }
        

    }
}
