using System;

namespace unit008_虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss BOSS1 = new Boss(1,2,3);
            BOSS1.Move();
            //父类声明，子类构造
            //只知道父类的东西
            //
            Enemy bos;
            bos = new Boss(3,3,3);
            //bos.Skill();
            //父类构造的对象不能传给子类。
            //new 相当于用模板构造对象。
            //BOSS1 b = new Enemy();

            Enemy bs = new Boss(1,2,3);
            //只要是子类构造的对象，在调用方法时都会查询是否为重构的方法。
            bs.Move();
            Enemy fu = new Enemy();
            fu.Move();
            //隐藏方法只有在声明的对象是Boss的时候才会调用重写之后的方法。
            bs.AI();
            BOSS1.AI();


        }

    }
}
