using System;

namespace unit005_属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer();

            newCustomer.Name = "madezhizhang";
            newCustomer.Address = 345;
            newCustomer.phonenomber = 116263123;
            Console.WriteLine(newCustomer.phonenomber);
            
        }
    }
}
