using System;
using System.Net;
using System.Net.Sockets;

namespace unit26_TCP服务器端TCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp) ;//插口使用ip4，数据使用流的形式，协议使用tcp协议。
            IPAddress iPAddress = new IPAddress(new byte[] { 192,168,101,47 });
            //IP+Port
            IPEndPoint ipEndPoint = new IPEndPoint(iPAddress,2345);
            //ip终端
            tcpServer.Bind(ipEndPoint);

            tcpServer.Listen(100);
            //最大连接数
            //上半部分：用来连接
            //下半部分：用来通信
            Console.WriteLine("开始服务...");

            Socket client = tcpServer.Accept();
            Console.WriteLine("一个客户端链接过来了。");
        }
    }
}
