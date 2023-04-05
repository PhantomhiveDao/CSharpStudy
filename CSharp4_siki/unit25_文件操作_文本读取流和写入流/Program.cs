using System;
using System.IO;

namespace unit25_文件操作_文本读取流和写入流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testFile = @"E:\GitHubProjects\StudyC#\CSharpStudy\CSharp4_siki\unit25_文件操作_文本读取流和写入流\TextFile1.txt";

            StreamReader reader = new StreamReader(testFile);
            //FileStream fs = new FileStream(testFile, FileMode.Open);

            //StreamReader reader2 = new StreamReader(fs);

            //FileInfo myFile = new FileInfo(testFile);
            //myFile.OpenText();

            string line = null; 
            while ((line = reader.ReadLine()) != null) { 
                Console.WriteLine(line);
            }
            //Console.WriteLine(line);
            reader.Close();

            //reader.Read(); //读取一个字符

            
        }
    }
}
