using System;

namespace unit06_委托
{
    //同一个类中的静态方法可以直接访问
    //委托本质上也是一个变量
    //委托可以指向静态方法，也可以指向一个实例方法。
    //委托必须指向一个方法。
    //实例方法：实例化的对象可以调用的方法。（大概？）
    //可以new一个委托
    class Program
    {
        delegate void Inttest(int x);

        delegate string GetAString();

        delegate double DoubleOpDelegate(double x);
        static void Main(string[] args)
        {
            Inttest test2 = Program.test;
            test2(3);
            //委托如果为空（null）时会出现异常。
            Program.test(333);
            int x = 8878;
            GetAString getit =new GetAString( x.ToString);
            //声明一个委托类型的数组
            //此处的MathOp是一个类。
            DoubleOpDelegate[] operations = { MathOp.MultiplayByTwo, MathOp.Spuare};
            foreach (DoubleOpDelegate op in operations)
            {
                // Console.WriteLine( op(3));
                ProcessAndDisplayRes(op,4);
            }
            //

        }
        private static  void test(int x)
        {
            Console.WriteLine("it is test void"+x);
        }
        //委托也可以当作一个参数传递。
        static void ProcessAndDisplayRes(DoubleOpDelegate op, double value)
        {
            double result = op(value);
            Console.WriteLine("result:" + result);
        }
    }
}
