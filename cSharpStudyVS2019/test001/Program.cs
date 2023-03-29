using System;//引入命名空间

namespace test001//名字不能以数字开头，一般不使用中文
{
    //这个是program类
    class Program//类和类的名字
    {
        //mian方法
        static void Main(string[] args)
        {
            //colsole：一个类；“.”类里的方法
            //ctrl k c注释；ctrl k u取消控制
            Console.WriteLine("hello, world!");//这个是输出语句
            Console.Write("114514");//Write不会换行；“ ”内为字符串，字符串不能换行；方法可以换行
            //字符串内换行    “\n”转义字符   "\t"制表符 "\\"转义字符
            Console.WriteLine("hello \nworld！\twhat happend");
            int a;
            a = 5;
            if (a == 1)
            {
                Console.WriteLine('a');
            }

        }
    }
}

