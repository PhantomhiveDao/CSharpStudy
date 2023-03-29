using System;
using System.Collections.Generic;
using System.Text;

namespace unit007_继承
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
        public void Move()
        {
            Console.WriteLine("Move");

        }
        

    }
}
