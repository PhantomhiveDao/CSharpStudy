using System;

namespace unit017_结构体和类的不同
{
    class Program
    {
        static void Main(string[] args)
        {
            //    student stu1 = new student(18, "小芳");
            //    student stu2 = new student(20, "小刚");

            //    stu2 = stu1;
            //    //引用的赋值

            //    stu1.age= 30;
            //    stu1.name = "小燕";
            //    Console.WriteLine(stu2.age);
            //    Console.WriteLine(stu2.name);

            StudentSt st1 = new StudentSt(178, "消防");
            StudentSt st2 = new StudentSt(18, "立方");

        }
        //数据量少的时候适合结构体.
        struct StudentSt
        {
            public int age;
            public string name;

            public StudentSt(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
        }
    }
}
