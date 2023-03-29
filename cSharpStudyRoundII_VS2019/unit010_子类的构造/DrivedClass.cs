using System;
using System.Collections.Generic;
using System.Text;

namespace unit010_子类的构造
{
    class DrivedClass:BaseClass
    {
        private int attack;



        public DrivedClass():base()//base()调用父类里的构造函数
            //不写也会默认添加
        {
            Console.WriteLine("构造函数：DrivedClass");
        }
        public DrivedClass(int attack,int hp,int age):base(hp,age)
            //指定了调用某个构造函数之后
        {
            this.attack = attack;
        }
    }
}
