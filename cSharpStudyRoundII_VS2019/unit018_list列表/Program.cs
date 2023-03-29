using System;
using System.Collections.Generic;

namespace unit018_list列表
{
    class Program
    {
        static void Showlist(List<int>list)
        {
            foreach (int a in list)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("----over----");
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,1};
            //需要定义放置什么类型的数据;用<>标识--泛型
            //用系统提供的一个类创建了一个对象
            //使用{}添加初始数据
            //list.Add(900);
            //list.Add(912314);
            //list[2] = 456458;
            //访问list里的数据
            //Console.WriteLine(list[3]);
            
            //插入数据Insert
            list.Insert(2, 678);
            //list.Remove(1);
            //Remove列表中的对应值只会移除第一个值
            list.RemoveAt(4);
            //移除对应的索引值
            Showlist(list);

            //增删改查-对数据的常见操作.
            Console.WriteLine(list.LastIndexOf(1));
            //查询数组所在的索引值.只取第一个
            //对列表进排序--默认从小到大排序
            list.Sort();
            Showlist(list);
        }
    }
}
