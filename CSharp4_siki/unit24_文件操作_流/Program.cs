using System;
using System.IO;

namespace unit24_文件操作_流
{
    /// <summary>
    /// 什么是流：对数据进行分段传输以减小性能开销
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime before = DateTime.Now;

            //流A读取；流B写入
            FileStream readFileStream = new FileStream(@"E:\read.zip",FileMode.Open,FileAccess.Read);
            //readFileStream.ReadByte();

            FileStream writeFileStream = new FileStream(@"E:\newFile.zip", FileMode.Create,FileAccess.Write);

            //声明一个字节数组。
            int length = 1024;
            //数组越大对内存占用越大
            byte[] buffer=new byte[length];
            int count = -1;
            //int count=readFileStream.Read(buffer, 0, 1024);
            //writeFileStream.Write(buffer, 0, count);
            while((count = readFileStream.Read(buffer, 0, length))!=0)
            {
                Console.WriteLine("111");
                writeFileStream.Write(buffer, 0, count);
            }

            //int nextByte = -1;
            //while ((nextByte=readFileStream.ReadByte())!=-1)
            //{
            //    writeFileStream.WriteByte((byte)nextByte);
            //}
            writeFileStream.Close();
            readFileStream.Close();
            DateTime after = DateTime.Now;
            TimeSpan ts=after.Subtract(before);
            Console.WriteLine(ts.TotalSeconds);
        }
    }
}
