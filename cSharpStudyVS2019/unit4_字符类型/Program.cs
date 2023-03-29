using System;

namespace unit4_字符类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = 'g';//字符类型在底层有对应值，Ascii码表=>十进制对应字符
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            ///如何把整数转换成对应的字符
            int a = 99;//整数类型容器比字符类型大
            char b = (char)a;//强制类型转换 强塞；可能数据丢失?
            //赋值的时候，容器小的可以赋值给容器大的；反之 不可。
            Console.WriteLine(a);
            Console.WriteLine(b);

            //char a = '1';
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //转义字符
            //char a = '\n';//
            //char b = '\\';
            //char c = '\t';
            //char d = '\b';

            //Console.WriteLine("c:\\a\\b\\c");

            //Console.WriteLine(@"c:\a\b\c");//”@“可以使转义字符失效;使用@可以多行输入字符串。;可以使用两个引号表示一个引号

            //string str = @"a\b\c"+"141";//声明一个字符串
            //string str2 = str + "141";//声明一个字符串


            //Console.WriteLine(str2+"777");


        }
    }
}
