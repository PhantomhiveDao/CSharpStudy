using System;
using System.Threading;

namespace unit18_多线程自定义类传数据
{
    //把线程的方法放在一个类里，当作类的成员方法？
    internal class Program
    {
        static void Main(string[] args)
        {
            DowloadTool downloadTool = new DowloadTool("http://8848.com","test");
            Thread t = new Thread(downloadTool.Dowload);
            t.Start();
        }
    }
    //后台线程
    //前台线程：只要有一个前台线程在运行，应用程序的进程就在运行。
}

