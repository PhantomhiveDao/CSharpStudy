using System;
using System.Collections.Generic;
using System.Text;

namespace unit09_用委托升级冒泡
{
    internal class Employe
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }
        public Employe(string name,double salary) 
        {
            Name = name;
            Salary = salary;
        }
        public static bool CompareSalary(Employe e1, Employe e2)
        {
            return e1.Salary > e2.Salary;
        }
    }
}
