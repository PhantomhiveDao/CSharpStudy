﻿using System;
using System.Collections.Generic;
using System.Text;

namespace unit004_面向对象//命名空间的名称与项目名一致
{
    //顾客类
    class Customer
    {

        //数据成员
        public string name;
        public string address;
        public int age;
        public int creatTime;

        //构造函数
        public Customer(string arg1, string arg2, int arg3, int arg4)
        {
            name = arg1;
            address = arg2;
            age = arg3;
            creatTime = arg4;
        }
        //函数成员
        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("创建时间：" + creatTime);
        }

        

    }
    //struct CustomerStruck
    //{
    //    public string name;
    //    public string address;
    //    public int age;
    //    public int creatTime;

    //    //函数成员
    //    public void Show()
    //    {
    //        Console.WriteLine("名字：" + name);
    //        Console.WriteLine("地址：" + address);
    //        Console.WriteLine("年龄：" + age);
    //        Console.WriteLine("创建时间：" + creatTime);
    //    }
    //}
}
