using System;

namespace unit023_字符串获取
{
    //数字和字符混合在⼀起了，作为⼀个优秀的挖掘⼈员，把输⼊的数字挖出来，并计算这些数字的和，并输出。输⼊以 @作为结束。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.Read();//只读取一个字符
    //        //缓冲区：【代码】-【缓冲区】（空）-【控制台】-【缓冲区】-【代码】-【缓冲区】（？）
    //        char inputC;//'0'-55'9'--64
    //        int RESULT = 0;
    //        do
    //        {
    //            inputC = Convert.ToChar(Console.Read());
    //            if ('0'<=inputC &&inputC<='9')
    //            {
    //                int num = inputC - '0';
    //                RESULT += num;
    //                Console.WriteLine(RESULT);
    //            }
    //        }
    //        while (inputC!='@');//满足条件则跳出
    //        Console.WriteLine("addResult=" +RESULT);
    //    }
    //}


    //假设有个隧道，隧道以字符 ‘#’ 结束，挖矿的过程中，会遇到钻⽯ ‘*’ 和美⾦ ‘1’ ~ ‘9’ ，让矿⼯⼩六挖到隧道的尽头，假设每个钻⽯价值500美⾦，统计⼩六挖到了价值多少美⾦的收获？
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.Read();//只读取一个字符
    //        //缓冲区：【代码】-【缓冲区】（空）-【控制台】-【缓冲区】-【代码】-【缓冲区】（？）
    //        char inputC;//'0'-55'9'--64
    //        int RESULT = 0;
    //        do
    //        {
    //            inputC = Convert.ToChar(Console.Read());
    //            if ('0' <= inputC && inputC <= '9')
    //            {
    //                int num = inputC - '0';
    //                RESULT += num;
    //                Console.WriteLine(RESULT);
    //            }
    //        }
    //        while (inputC != '@');//满足条件则跳出
    //        Console.WriteLine("addResult=" + RESULT);
    //    }
    //}


    //数字和字符混合在⼀起了，作为⼀个优秀的挖掘⼈员，把输⼊的数字挖出来，并计算这些数字的和，并输出。输⼊以 @作为结束。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.Read();//只读取一个字符
    //        //缓冲区：【代码】-【缓冲区】（空）-【控制台】-【缓冲区】-【代码】-【缓冲区】（？）
    //        char inputC;//'0'-55'9'--64
    //        int RESULT = 0;
    //        do
    //        {
    //            inputC = Convert.ToChar(Console.Read());
    //            if ('0'<=inputC &&inputC<='9')
    //            {
    //                int num = inputC - '0';
    //                RESULT += num;
    //                Console.WriteLine(RESULT);
    //            }
    //        }
    //        while (inputC!='@');//满足条件则跳出
    //        Console.WriteLine("addResult=" +RESULT);
    //    }
    //}



    ///假设有个隧道，隧道以字符 ‘#’ 结束，挖矿的过程中，会遇到钻⽯ ‘*’ 和美⾦ ‘1’ ~ ‘9’ ，让矿⼯⼩六挖到隧道的尽头，假设每个钻⽯价值500美⾦，统计⼩六挖到了价值多少美⾦的收获？
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.Read();//只读取一个字符
    //        //缓冲区：【代码】-【缓冲区】（空）-【控制台】-【缓冲区】-【代码】-【缓冲区】（？）
    //        char inputC;//'0'-55'9'--64
    //        //int RESULT = 0;
    //        int money = 0;

    //        do
    //        {
    //            inputC = Convert.ToChar(Console.Read());
    //            if (inputC == '*')
    //            {
    //                money += 500;
    //                Console.WriteLine(money);
    //            }
    //            else if ('0'<=inputC&&inputC<='9')
    //            {
    //                money += Convert.ToInt32(inputC-'0');
    //            }
    //        }
    //        while (inputC != '#');//满足条件则跳出
    //        Console.WriteLine("addResult=" + money);
    //    }
    //}

    ///输⼊⼀个整数，输出该整数的因数个数和所有因数。输⼊的整数⼤于0，⼩于100000
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.Read();//只读取一个字符
    //       //缓冲区：【代码】-【缓冲区】（空）-【控制台】-【缓冲区】-【代码】-【缓冲区】（？）
    //        string outputC="";//'0'-55'9'--64
    //        int input =Convert.ToInt32(Console.ReadLine());
    //        int num = 0;

    //        for (int i = 1; i <= input; i++)
    //        {
    //            if (input % i == 0)
    //            {
    //                outputC += i+" ";
    //                num += 1;
    //            }
    //        }

    //        Console.WriteLine("addResult=" + num);
    //        Console.WriteLine(outputC);

    //    }
    //}

    ///输⼊整数n，输出n层的三⾓形的斜边。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        //int k = Convert.ToInt32(Console.ReadLine());
    //        for (int i=1;i<=n;i++)
    //        {

    //            //for (int j=0;j<=i;j++)
    //            //{
    //            //}
    //            for (int j=1; j != i; j++)
    //            {
    //                Console.Write(" ");
    //            }
    //            Console.Write("*");
    //            Console.WriteLine("");
    //            //Console.WriteLine(i);

    //        }

    //    }
    //}

    ///输⼊整数n，输出n层的三⾓的反斜边。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        for (int i = 1; i <= n; i++)
    //        {
    //            for (int j = n; j != i; j--)
    //            {
    //                Console.Write(" ");
    //            }
    //            Console.Write("*");
    //            Console.WriteLine("");
    //            //Console.WriteLine(i);

    //        }

    //    }
    //}

    ///输⼊正整数n，输出n⾏，每⾏n个*的平⾏四边形。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //现有空格，再有文字=行数，再有换行
    //        int line = Convert.ToInt32(Console.ReadLine());
    //        for (int i = 1; i <= line; i++)
    //        {
    //            for (int j = 1; j < i; j++)
    //            {
    //                Console.Write(" ");
    //            }
    //            for (int k = 1; k <= line; k++)
    //            {
    //                Console.Write("*");
    //            }
    //            Console.WriteLine();
    //        }

    //    }
    //}

    ///输⼊⼀个正整数n，输出n层的右三⾓形。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //现有空格，再有文字=行数，再有换行
    //        int line = Convert.ToInt32(Console.ReadLine());
    //        for (int i = 1; i <= line; i++)
    //        {
    //            for (int j = 0; j < line - i; j++)
    //            {
    //                Console.Write(" ");
    //            }
    //            for (int k = 1; k <= i; k++)
    //            {
    //                Console.Write("*");
    //            }
    //            Console.WriteLine();
    //        }

    //    }
    //}


    ///输⼊⼀个正整数n，输出n层的等腰三⾓形
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //现有空格，再有文字=行数，再有换行
    //        int line = Convert.ToInt32(Console.ReadLine());
    //        for (int i = 1; i <= line; i++)
    //        {
    //            for (int j = 0; j < line-i; j++)
    //            {
    //                Console.Write(" ");                   
    //            }
    //            for (int k = 1; k <= (2*i-1); k++)
    //            {
    //                Console.Write("*");
    //            }
    //            Console.WriteLine();
    //        }

    //    }
    //}


    ///输⼊⼀个正整数n，输出n层的菱形。

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //现有空格，再有文字=行数，再有换行
    //        int line = Convert.ToInt32(Console.ReadLine());
    //        for (int i = 1; i <= line; i++)
    //        {
    //            for (int j = 0; j < line - i; j++)
    //            {
    //                Console.Write(" ");
    //            }
    //            for (int k = 1; k <= (2 * i - 1); k++)
    //            {
    //                Console.Write("*");
    //            }
    //            Console.WriteLine();

    //        }
    //        for (int i = 1; i<=line; i++)
    //        {
    //            for (int j = 0; j < i; j++)
    //            {
    //                Console.Write(" ");
    //            }
    //            for (int k = 0; k < (2*(line - i) - 1); k++)
    //            {
    //                Console.Write("*");
    //            }
    //            Console.WriteLine();
    //        }


    //    }
    //}


    ///输出9x9乘法表。

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //现有空格，再有文字=行数，再有换行
    //        int line = 9;
    //        for (int i = 1; i <= line; i++)
    //        {
    //            for (int j = 1; j <= i; j++)
    //            {
    //                //Console.Write(j + "x" + i + "=" + j * i+" ");
    //                Console.Write("{0}*{1}={2}{3}", j, i, j * i," ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}


    ///⽤100⽂，其中公鸡，⺟鸡，⼩鸡，都必须要有，公鸡3⽂⼀只，⺟鸡5⽂⼀只，⼩鸡2⽂⼀只，请问公鸡、⺟鸡、⼩鸡要买多少只刚好凑⾜100⽂。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //int x;//公鸡数
    //        //int y;//母鸡数
    //        //int z;//小鸡数

    //        for (int x = 1; x <= 100 / 3; x++)
    //        {
    //            for (int y = 1; y <= 100 / 5; y++)
    //            {
    //                for (int z = 1; z <= 100 / 2; z++)
    //                {
    //                    if ((x * 3 + y * 5 + z * 2) == 100)
    //                    {
    //                        Console.WriteLine("公鸡:{0},母鸡:{1},小鸡:{2}", x, y, z);
    //                    }
    //                }
    //            }
    //        }

    //    }
    //}


    ///
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个随机数
            Random rd = new Random();
            //伪随机数random
            //真随机数
            int number=rd.Next(1, 101);
        }
    }

}
