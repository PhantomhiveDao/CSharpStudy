using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace unit28_udp客户端
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            byte[] data = Encoding.UTF8.GetBytes("你好，udp客户端上线了");

            IPAddress ipAddress = new IPAddress(new byte[] { 192, 168, 101, 47 });
            // IP + Port
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7788);

            udpClient.SendTo(data, ipEndPoint);


            udpClient.Close();
        }
    }
}
