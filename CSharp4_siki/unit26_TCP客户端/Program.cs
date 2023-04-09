using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace unit26_TCP客户端
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 101, 47 });
            //IP+Port
            IPEndPoint ipEndPoint = new IPEndPoint(iPAddress, 2345);
            //ip终端

            tcpClient.Connect(ipEndPoint);
            Console.WriteLine("连上了！！");

            //发送消息到服务器
            string message = "我来了我来了！";
            tcpClient.Send(Encoding.UTF8.GetBytes(message));//通过utf8编码，将字符串转成byte类型。

            //接收服务器来的消息
            byte[] data2 = new byte[2048];
            int length = tcpClient.Receive(data2);
            Console.WriteLine("接收到了客户端的消息：" + Encoding.UTF8.GetString(data2, 0, length));


            //关闭客户端
            tcpClient.Close();
        }
    }
}
