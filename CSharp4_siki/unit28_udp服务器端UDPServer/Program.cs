using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace unit28_udp服务器端UDPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket udpServer = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            //电报，一次性的一个消息。
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 101, 47 });
            //IP+Port
            IPEndPoint ipEndPoint = new IPEndPoint(iPAddress, 2345);
            //ip终端
            udpServer.Bind(ipEndPoint);
            //
            //定义一个任意地址任意端口的终端
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);
            EndPoint ep = (EndPoint)ipep;
            byte[] data = new byte[2048]; 
            int length=udpServer.ReceiveFrom(data,ref ep);//此处等待数据包。只接收数据，不需要建立链接
            
            
            Console.WriteLine("接收到的数据"+ Encoding.UTF8.GetString(data));

        }
    }
}
