using System;

namespace unit08_Function委托
{
    //Function：指向有返回值的方法
    internal class Program
    {
        private static string TestFunction( ) 
        {

            return "23234";   
        }
        private static string Test2( int x,double y) 
        {
            return "test2!" + x+y;
        }
        static void Main(string[] args)
        {
            Func<string> fc1 = TestFunction;
            Console.WriteLine(fc1());
            Func<int, double, string> fc2 = Test2;
            Console.WriteLine(fc2(1,33));
        }
    }
}
