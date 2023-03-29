using System;

namespace unit020Mylist列表
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            
            list.Insert(1, 999);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(list[1]);
            
        }
    }
}
