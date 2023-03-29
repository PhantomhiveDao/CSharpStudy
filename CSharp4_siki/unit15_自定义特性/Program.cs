using System;
using System.Runtime.Intrinsics;

namespace unit15_自定义特性
{
    [My("name","v1.1.1","测试练习")]
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            bool result=type.IsDefined(typeof(MyAttribute), false);
            Console.WriteLine(result);
            object[]attributeArry=type.GetCustomAttributes(false);
            foreach( object attribute in attributeArry ) {
                Console.WriteLine(attribute); 
                    }
            
        }
    }
}
