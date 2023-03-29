using System;

namespace unit12_工具人下楼事件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToolMan man1=new ToolMan("小明");
            LazyMan lazyman2 = new LazyMan("123");
            LazyMan lazyman3 = new LazyMan("zzz");
            LazyMan lazyman4 = new LazyMan("???");

            man1.DownStairDelegate += lazyman2.TakeFood;
            man1.DownStairDelegate += lazyman3.TakePacage;
            man1.DownStairDelegate += lazyman4.TakeFood;
            man1.Dowstair();
            man1.DownStairDelegate -= lazyman2.TakeFood;
            man1.Dowstair();
            //downdtairDelegate可以在没下楼之前就能调用，这不合理
        }
    }
}
