using System;

namespace unit026_数组字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "test";
            name = "test" + "over";
            Console.WriteLine(name);
            //获取字符串长度 str.length;字符串 相当于一个 字符数组。
            for (int a = 0; a < name.Length; a++)
            {
                Console.WriteLine(name[a]);
            }
            //字符串操作的常用方法
            ///1.ToLower();2.ToUpper();//变成小写字母or大写字母
            //方法：可以通过字符串+."方法名"+()
            string test = name.ToUpper();//执行了toupper方法之后不会对原变量产生影响。
            Console.WriteLine(test);
            ///.Trim() 去除字符串前后的空格。.TrimStart();.TrimEnd();
            string name2 = " 234 444 -=  ";
            string test2=name2.Trim();
            Console.WriteLine(test2+"|");
            ///.Split();分割方法
            ///
            string chuan = "23,4,3,6,4";
            string[] name3 = chuan.Split(",");
            for (int a=0;a<name3.Length;a++)
            {
                Console.WriteLine(name3[a]);
            }
        }
    }
}
