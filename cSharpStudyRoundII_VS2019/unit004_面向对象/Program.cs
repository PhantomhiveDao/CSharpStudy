using System;

namespace unit004_面向对象
{
    class Program//系统创建的默认类。类的名称和文件名一致。一个文件里可以包含多个类。
    {
        static void Main(string[] args)
        {
            //利用类创建变量，c1对象名
            Customer c1 = null;
            Customer c2;//声明对象
            c2 = new Customer("0", "5", 6, 7);//实例化一个对象。new的过程=实例化的过程。
            c2.address = "一个地址";
            c2.age = 34;
            c2.creatTime = 20230218;
            c2.name = "废物";
            c2.Show();
            //c1.name="342";//当声明的对象为空时，对象是无法使用的。
            Vector3 newv3;
            newv3 = new Vector3();
            newv3.set(23.3, 4.1, 5.5);
            Console.WriteLine("算完了吗" + newv3.Longth());
            Customer test = new Customer("0", "5", 6, 7);
            test.Show();
            //Console.WriteLine("算完了吗" + test);
        }
        //构造函数//类必须有构造函数。当没有给类添加构造函数时，系统会默认添加一个无参的构造函数
        //当我们实例化/创建对象的时候
        

    }
}
