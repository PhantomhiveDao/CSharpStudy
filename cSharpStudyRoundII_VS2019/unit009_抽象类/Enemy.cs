using System;
using System.Collections.Generic;
using System.Text;

namespace unit009_抽象类
{
    public abstract class Enemy
    {

        //每个敌人都能攻击，但是攻击方法不一样，
        public abstract void Attack();//抽象函数/抽象方法
        public void eat()
        {
            Console.WriteLine("吃吃吃");
        }

    }
}
