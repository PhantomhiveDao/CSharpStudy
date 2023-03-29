using System;
using System.Text.RegularExpressions;

namespace unit05_正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "235nnn235";
            string str2 = "235 235";

            Regex.IsMatch(str1, "");
            Console.WriteLine(Regex.IsMatch(str1, @"\d*"));
            //@字符：令特殊字符失效；元字符
            //\n换行；\t制表符；\d任意一个数字;* 前边的包含零个或多个
            //\w大小写字母，0-9
            //\D;\W补集；反义字符。
            //[]中的任意字符的集合只要字符串中包含则为true ；可以用“-”添加连续的；；[^A-D]：A-D以外的字符
            Console.WriteLine(Regex.IsMatch(str1, @"si*"));//s si sii siiiii
            Console.WriteLine(Regex.IsMatch(str1, @"^4"));//^以^之后的字符开头；对开始位置进行匹配；$匹配结尾
            //判断是否为合法标识符。
            //替换符合规则的字符
            Console.WriteLine(Regex.Replace("88382asdf34235", @"[0-9]", "!"));
            //限制字符长度{n,m}闭区间
            //择一匹配，匹配左边或者右边 “|”
            Console.WriteLine(Regex.IsMatch("88382asdf34235", @"\d|a"));
            //重复的字符串{n}；重复分组（）
            Console.WriteLine(Regex.IsMatch("abab",@"(ab){2}"));//abab
            Console.WriteLine(Regex.IsMatch("abab",@"(abc){2}"));//abcabc
        }
    }
}
