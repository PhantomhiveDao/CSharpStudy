using System;

namespace unit7_数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /// %：取余数，使用小数时精度不够
            /// 整数/整数，只会得到整数；如果其中一个值为小数时，就会得到小数的结果。
            //int numA =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("个位数{0}，十位数{1},百位数{2}", numA % 10, (numA/10 )% 10,numA/100);
            //numA += 5;//a=a+5
            ///自增 自减运算符
            ///++ --
            int ba = 2;
            ba++;
            for (int ax=1; ax<=9;ax++)
            {
               Console.WriteLine(ax);
            }
            Console.WriteLine("jieshul");

            ///++a;和 a++; 在单独使用时 效果一致，
            int b = ba++;//先赋值给b再自增ba的值都会增加
            int b2 = ++ba;//先自增之后再赋值给b（放在前边，++重要，先自增。
        }
    }
}
