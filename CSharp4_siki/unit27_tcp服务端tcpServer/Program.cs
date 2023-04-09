using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace unit26_TCP服务器端TCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//插口使用ip4，数据使用流的形式，协议使用tcp协议。
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 101, 47 });
            //IP+Port
            IPEndPoint ipEndPoint = new IPEndPoint(iPAddress, 2345);
            //ip终端
            tcpServer.Bind(ipEndPoint);

            tcpServer.Listen(100);
            //最大连接数
            //上半部分：用来连接
            //下半部分：用来通信
            Console.WriteLine("开始服务...");

            Socket client = tcpServer.Accept();
            Console.WriteLine("一个客户端链接过来了。");

            byte[] data=new byte[2048];
            int length=client.Receive(data);
            string message=Encoding.UTF8.GetString(data, 0, length);
            Console.WriteLine("接收到了客户端的消息："+message);


         
            client.Send(Encoding.UTF8.GetBytes("收到了收到了，快来玩"));//通过utf8编码，将字符串转成byte类型。

            //先打开的后关闭
            client.Close();
            tcpServer.Close();
        }
    }
}
