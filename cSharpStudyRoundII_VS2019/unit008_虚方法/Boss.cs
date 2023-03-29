using System;
using System.Collections.Generic;
using System.Text;

namespace unit008_虚方法
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
        public override void Move()
        {
            Console.WriteLine("boss独有移动");
        }
        //boss的移动方式和父类的方法不一样
        //使用虚方法的方式：在父类中将方法声明为 virtual


        public new void AI()
        {
            Console.WriteLine("BOSS独有AI");
        }


    }
}
