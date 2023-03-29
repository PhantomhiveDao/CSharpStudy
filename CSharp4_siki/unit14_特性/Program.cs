#define ISshowMessage//定义一个宏
//宏
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace unit14_特性
{
    internal class Program
    {
        //[Obsolete("请用新的nwetest",false)]//特性：obsolete标记为弃用;
        //static void Test( ) 
        //{ Console.WriteLine("Hello World!"); }

        //static void newTest( )
        //{
        //}
        //[Conditional("ISshowMessage")]
        //static void ShowMessage(string str )
        //{
        //    Console.WriteLine(str);
        //}
        //调用者信息特性
        [DebuggerStepThrough]//会自动跳过这个方法。
        static void ShowMessage(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            Console.WriteLine(message);
            Console.WriteLine(lineNumber);
            Console.WriteLine(filePath);
            Console.WriteLine(memberName);
        }
        static void Main(string[] args)
        {
            //Test();
            //ShowMessage("qwq");
            //Console.WriteLine("---------");
            //ShowMessage("TaT");
            //Console.WriteLine("123");
            ShowMessage(">>?");
        }



    }
}
