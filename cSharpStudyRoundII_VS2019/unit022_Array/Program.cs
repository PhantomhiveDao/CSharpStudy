using System;
using System.Collections.Generic;

namespace unit022_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = { 2, 3, 4, 23, 34, 6, 2, 3, 4 };
            int[] list2 = { 3,5,7,9,5,56,7 };

            //list1.CopyTo(list2, 5);
            Array.Copy(list1, list2, 3);

            Array.Reverse(list1);//fanzhuan


            foreach (int a in list1)
            {
                Console.Write(a + "---");
            }

            Dictionary<int, string> studentDB = new Dictionary<int, string>();
            studentDB.ContainsKey(6);
            //判断key是否存在
            studentDB.Add(1,"879fa6");
            studentDB.Add(2,"adf8796");
            studentDB.Add(4,"879w6");
            studentDB.Add(5,"879r6");
            studentDB.Add(7,"8423596");
            studentDB.Add(3,"8796e");

            //集合类
            Dictionary<int,string>.KeyCollection keycollection= studentDB.Keys;

            //取得字典里的所有数据
            foreach (KeyValuePair<int, string> uhgv in studentDB)
            {
                Console.WriteLine(uhgv.Key + "-" + uhgv.Value);
            }

            Dictionary<int, Test> testDB = new Dictionary<int, Test>();
            testDB.Add(1001, new Test(1001, "3123", 333, 222, 3));
        }
        class Test
        { 
        
            public Test(int id, string name, int hp, int mp, int speed)
            {
                Id = id;
                Name = name;
                Hp = hp;
                Mp = mp;
                Speed = speed;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public int Hp { get; set; }
            public int Mp { get; set; }
            public int Speed { get; set; }
        }
    }
}
