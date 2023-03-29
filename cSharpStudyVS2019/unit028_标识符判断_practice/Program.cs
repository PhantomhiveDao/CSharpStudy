using System;

namespace unit028_标识符判断_practice
{
    /// <summary>
    /// 判断字符串是否为c#合法标识符
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //数字 字母 下划线
            //数字开头
            bool isRight = true;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] < '0' || str[i] > '9') && (str[i] < 'A' || str[i] > 'Z') && (str[i] < 'a' || str[i] > 'z'))
                {
                    isRight = false;
                    Console.WriteLine("false1");
                    break;
                }
                else if(str[0]>='0'&& str[0] <= '9') 
                {
                    isRight = false;
                    Console.WriteLine("false333");
                    break;

                }
                Console.WriteLine("666");

            }

        }
    }
}
