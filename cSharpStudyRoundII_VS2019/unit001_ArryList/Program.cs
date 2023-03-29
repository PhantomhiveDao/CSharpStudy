using System;
using System.Collections;

namespace unit001_ArryList
{
    class Program
    {
        /// <summary>
        /// 学习
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    int[] testArr = { 1, 2, 34 };

        //    try
        //    {
        //        int temp = testArr[5];
        //    }
        //    catch (IndexOutOfRangeException e)// 声明一个异常类型的变量。
        //    {
        //        //出现这个异常的时候怎么处理。
        //        Console.WriteLine("出现了数组下标越界的异常");

        //    }
        //    catch (FieldAccessException e)
        //    {
        //        Console.WriteLine("出现了不知道是啥异常");

        //    }
        //    finally
        //    {
        //        Console.WriteLine("不管什么情况都会执行");

        //    }
        //    Console.WriteLine("43");

        //}

        static void Main(string[] args)
        {
            Console.WriteLine("输入两个数字，一行一个");
            int n1 = 0, n2 = 0;
            ////这一段只能检测一次。
            //try
            //{
            //    n1 = Convert.ToInt32(Console.ReadLine());
            //    n2 = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (FormatException e)// 声明一个异常类型的变量。
            //{
            //    //出现这个异常的时候怎么处理。
            //    Console.WriteLine("出现了数据类型不对的异常，重来");
            //    n1 = Convert.ToInt32(Console.ReadLine());
            //    n2 = Convert.ToInt32(Console.ReadLine());

            //}
            //bool input = false;
            while (true)
            {
                try//try中的语句当执行到出现异常的部分之后直接进入catch部分。
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch (FormatException e)// 声明一个异常类型的变量。
                {
                    //出现这个异常的时候怎么处理。
                    Console.WriteLine("出现了数据类型不对的异常，重来");
                 

                }
            }



            Console.WriteLine(n1+n2);

        }
    }
}
