using System;

namespace unit019_泛型类
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ClassA<int> a = new ClassA<int>(12,43);
            Console.WriteLine(a.GetSum());
            Program h = new Program();
            Console.WriteLine(h.ToString()+"???");
            GetSum<int>(12, 4);
        }
        public static T GetSum<T>(T A, T B)
        {
            dynamic num1 = A;
            dynamic num2 = B;
            dynamic resut = num1 + num2;
            return resut;
        }
    }
    class ClassA<T> //一个泛型用T;Type=->int string double
    {
        private T a;
        private T b;

        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public T GetSum()
        {
            //声明一个动态类型-dynamic
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic result = num1 + num2;
            return (T)result;
        }
    }
}
