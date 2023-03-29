using System;

namespace unit021_Epuals判断相等
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 435;
            int b = 435;
            Console.WriteLine(a.Equals(b));
            String str = "3e3e423";
            String str2 = "3e3e423";
            Console.WriteLine(str.Equals(str2));
            Student dt1 = new Student(12,"ddfsd");
            Student dt2 = new Student(12,"ddfsd");
            Student dt3 = dt2;
            Console.WriteLine(dt1.Equals(dt2));
            Console.WriteLine(dt2==dt3);

        }
    }
}
