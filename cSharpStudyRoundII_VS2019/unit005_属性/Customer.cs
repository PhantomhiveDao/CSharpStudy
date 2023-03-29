using System;
using System.Collections.Generic;
using System.Text;

namespace unit005_属性//命名空间的名称与项目名一致
{
    //顾客类
    class Customer
    {

        //数据成员
        private string name;
        private string address;
        private int age;
        private int creatTime;
        //private int phonenumber;

        //获取数据成员的值：get方法，set方法。
        //public void SetAge(int age)
        //{
        //    this.age = age;//this可以区分参数还是成员

        //}
        //public int GetAge()
        //{
        //    return age;


        //是个属性，使用时等同普通的成员，可以直接设置值和取得值
        //get{}set{}相当于一个简写的public void SetAge(int age)和public int GetAge()
        public int Age
        {
            get//相当于一个返回方法//getset也称为访问器，可以设置访问权限
            {
                return age;
            }
            set//vaule默认的参数
            {
                age = value;
            }
        }
        public string Name
        {
            get//相当于一个返回方法
            {
                return name;
            }
            set//vaule默认的参数
            {
                name = value;
            }
        }

        //只读
        public string CreatTime
        {
            get//相当于一个只读
            {
                return address;
            }
            
        }
        //只写
        public int Address
        {
            get;set;

        }
        //自动创建private int phonenumber;

        public int phonenomber
        {get;set;
        }

        //public Customer(string arg1, string arg2, int arg3, int arg4)
        //{
        //    name = arg1;
        //    address = arg2;
        //    age = arg3;
        //    creatTime = arg4;
        //}
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
