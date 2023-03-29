using System;
using System.Reflection;

namespace unit13_反射
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type
            Type type = typeof(MyClass1);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.Assembly);
            FieldInfo[] fis= type.GetFields();
            foreach (FieldInfo fi in fis) 
            { 
            Console.WriteLine(fi.Name);
            }
            PropertyInfo[] pis=type.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                Console.WriteLine(pi.Name);
            }
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (MethodInfo mi in methodInfos)
            {
                Console.WriteLine(mi.Name);
            }
            //
            MyClass1 myClass1 = new MyClass1(); 
            Type type1 = typeof(MyClass1);

        }
    }
}
