using System;

namespace unit033_常量
{
    class Program
    {
        /// <summary>
        /// 定义一个枚举类型
        /// </summary>
        enum Jueseleixing//枚举类型的名字
        {
            Mage, Archer, Assassin, Tank, Support, Warrior//枚举类型的值
        }
        static void Main(string[] args)
        {
            //const:将变量声明为常量。
            //声明常量时所有字母为大写。
            const int I = 10;

            Console.WriteLine("Hello World!");

            ///枚举类型
            ///游戏⾓⾊有法师（Mage）、射⼿（Archer）、刺客（Assassin）、坦克（Tank）、辅助（Support）、战⼠（Warrior）
            Jueseleixing jueseleix = Jueseleixing.Tank;
            //创建一个变量，将枚举类型里的值赋值给新声明的变量


        }
    }
}
