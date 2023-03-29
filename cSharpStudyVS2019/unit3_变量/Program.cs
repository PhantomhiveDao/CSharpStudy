using System;

namespace unit3_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建变量
            //创建了一个数据的容器，容器的名字叫做age，容器的类型是int
            //声明了一个变量，变量的名字是name
            int name;//int：变量类型；age：变量名

            //往容器里放东西，赋值
            name = 10;

            double name2;//存放小数

            char name3;//字符类型

            //命名规范：英文字母 数字 下划线构成；不能以数字开头
            name2 = 2.546;
            name3 = 'd';

            int a = 3, b = 8; 
            Console.WriteLine(a + b);//11
            Console.WriteLine("a+b");//a+b
            Console.WriteLine(a + "+" + b);//3+8
            Console.WriteLine("a+b" + a + b);//a+b38
            Console.WriteLine("a+b" + (a + b));//a+b11
            Console.WriteLine(name2);//a+b11


        }
    }
}
