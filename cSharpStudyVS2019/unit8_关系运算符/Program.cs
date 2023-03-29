using System;

namespace unit8_关系运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //布尔类型
            //bool a = true;      //yes真、满足条件、1
            //bool b = false;     //no假、不满足条件、0
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            ///== 判断左边是否大于右边
            ///<= 判断左边是否小于等于右边
            ///>= 判断左边是否大于等于右边
            ///！= -> !=
            ///


            /*逻辑运算符*/


            ///或|| 非! 与&&
            ///
            //bool x = (3 < 4) && (9 > 10);//ture&&false--与 一假则假
            //Console.WriteLine(x);

            //bool y = (3 > 8) || (9 > 10);//或 一真则真
            //Console.WriteLine(y);

            //bool z = !(3 > 9);//非：对逻辑结果进行转换；（！取反）
            //Console.WriteLine(z);
            Console.WriteLine("请输入年龄 ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (18 <= a && a <= 60)
            {
                Console.WriteLine("yongth");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
