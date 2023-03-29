using System;
using System.Collections.Generic;
using System.Text;

namespace unit007_继承
{
    class Boss:Enemy
    {
        private int attack;

        public Boss(int attack,int hp,int speed)
        {
            this.attack = attack;
            this.hp = hp;
            this.speed = speed;
            //this.//当前的变量。
            base.hp=hp;//只能访问父类里的成员

        }

        public void Skill()
        {
            Console.WriteLine("BossSkill");
        }
        public void Print()
        {
            Console.WriteLine("Hp:" + hp);
            Console.WriteLine("base.Hp" + base.hp);
            Console.WriteLine("Speed:" + speed);
            Console.WriteLine("Attack:" + attack);
        }
    }
}
