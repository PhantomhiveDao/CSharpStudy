using System;
using System.Collections.Generic;
using System.Text;

namespace unit016_运算符重载
{
    class Student
    {
        private int age;
        private string name;
        private long id;
        //初始化
        public Student(int age, string name, long id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }
        //重载
        public static bool operator ==(Student s1, Student s2)
        {
            if (s1.age == s2.age && s1.id == s2.id && s1.name == s2.name)
                return true;
            return false;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            //相当于在这里调用上边判断相等的函数。
            bool result = s1 == s2;
            //结果取反。
            return !result;
        }
    }
}
