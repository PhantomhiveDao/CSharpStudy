using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace unit29_udp客户端
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket udpclient = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);

            byte[] data=Encoding.UTF8.GetBytes("你好，udp客户端开了");
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 101, 47 });
            //IP+Port
            IPEndPoint ipEndPoint = new IPEndPoint(iPAddress, 2345);
            //ip终端

            udpclient.SendTo(data,ipEndPoint);


        }
    }
}
