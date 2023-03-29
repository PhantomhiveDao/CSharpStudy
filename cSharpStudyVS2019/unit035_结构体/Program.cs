using System;

namespace unit035_结构体
{
    class Program
    {
        ///结构体的作用：吧某一类的变量进行整合，组成一个新的数据类型。
        ///结构体的使用：先定义一个结构体，再进行调用
        ///
        struct StudentInfo
        {
            public int age;
            public String name;
            public int grade;
            public int id;//public:公开的

        }
        static void Main(string[] args)
        {
            StudentInfo studenti;
            studenti.grade = 2;
            studenti.id = 202392;

            Console.WriteLine(studenti.id);
            //十个学生
            //结构体类型的数组，长度为10；十个有详细信息的学生
            StudentInfo[] students = new StudentInfo[10];
            students[1].age = 10;
            Console.WriteLine(students[1].age+"??");
        }
    }
}
