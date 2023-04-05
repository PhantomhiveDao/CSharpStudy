using System;
using System.IO;

namespace unit23_文件操作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////先创建一个对象。需要指定一个文件。
            //FileInfo myFile = new FileInfo(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\TextFile1.txt");
            ////实例方法
            //myFile.CopyTo(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\tset.txt");
            ////靜態方法
            //File.Copy(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\TextFile1.txt", @"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\888.txt");//("源文件","目标文件")

            //DirectoryInfo myFloder=new DirectoryInfo(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\creat");
            //myFloder.Create();//创建文件夹
            //myFloder.Exists;//判断文件夹是否存在
            //Directory.Exists

            //完整路径-绝对路径     相对路径(当前程序运行时所在目录；在vs中是debug文件夹下)
            //Directory.CreateDirectory("creat2");
            //获得路径的根部分Root
            //Console.WriteLine(myFloder.Root.FullName);

            string path=Path.Combine("E:", "vs WorkSpace");
            Console.WriteLine(path);
            string text=File.ReadAllText(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\TextFile1.txt");
            string[] txt=File.ReadAllLines(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\TextFile1.txt");
            foreach (var item in txt)
            {
                Console.Write(item);

            }
            byte[] bbb=File.ReadAllBytes(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\TextFile1.txt");//可以将文件的内容读取为字节数组，读取非文本文件内容用。
            foreach (var item in bbb)
            {
                Console.Write(item);

            }
            File.WriteAllText(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\TextFile1.txt","~~都是假象~~");
            //注意：此方法下，如果文件本身有内容则会覆盖文件的原内容。
            string text2 = File.ReadAllText(@"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit23_文件操作\TextFile1.txt");
            Console.WriteLine(text2);
        }
    }
}
