using System;
using System.ComponentModel;

namespace unit09_用委托升级冒泡
{
    internal class Program
    {
        public static void Sort(int[]sortArry) 
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArry.Length-1; i++)
                {
                    if (sortArry[i] > sortArry[i + 1])
                    {
                        int temp = sortArry[i];
                        sortArry[i] = sortArry[i + 1];
                        sortArry[i + 1] = temp;
                        swapped = true;
                    }

                }

            }
            while (swapped);
        }

        public static void Sortnew<T>(T[] data,Func<T,T,bool>compare) 
        {

            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (compare(data[i], data[i+1]))
                    {
                        T temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                        swapped = true;
                    }

                }

            }
            while (swapped);
        }
        static void Main(string[] args)
        {
            //雇员类，包含姓名和薪水
            Employe[] employes =
            {
                new Employe("bonjeeny",56756),
                new Employe("bonjeeny2",2000),
                new Employe("bonjeeny3",2234),
                new Employe("bonjeeny4",4000),
                new Employe("bonjeeny5",502200)
            };
            Sortnew<Employe>(employes, Employe.CompareSalary);
            foreach (Employe e in employes)
            {
                Console.WriteLine(e.Salary);    
            }
        }
    }
}
