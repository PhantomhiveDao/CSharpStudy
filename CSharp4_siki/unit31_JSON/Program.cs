using Newtonsoft.Json;
using System;
using System.IO;

namespace unit31_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //serialize序列化：将对象转换成字符串
            skillJson[] skillArray=JsonConvert.DeserializeObject<skillJson[]>(File.ReadAllText("TextFile1.txt"));
            foreach(skillJson skill in skillArray)
            {
                Console.WriteLine(skill.id+","+skill.name+","+skill.damage);
            }
        }
    }
}
