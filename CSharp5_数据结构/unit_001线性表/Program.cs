using System;
using System.Collections;
using System.Collections.Generic;

namespace unit_001线性表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList:动态数组，在索引越界的时候会自动扩容。需要引入命名空间
            ArrayList a=new ArrayList(10);

            //List<T>:需要指定数据类型;声明时括号里的内容为初始容量。可以不填写但是会默认以2为单位扩容
            List<int> intList = new List<int>(10);

            //在装箱和拆箱中会讲解两者性能上的区别
        }
    }
}
