using System;
using System.Collections.Generic;
using System.Text;

namespace unit18_多线程自定义类传数据
{
    internal class DowloadTool
    {
        public string URL { get; private set; }
        public string Message { get; private set; }

        public DowloadTool(string uRL, string message)
        {
            URL = uRL;
            Message = message;
        }
        public void Dowload() 
        {
            Console.WriteLine("从"+URL+ "下载中");
        }
    }
}
