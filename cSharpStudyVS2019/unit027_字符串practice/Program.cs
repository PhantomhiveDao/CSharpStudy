using System;

namespace unit027_字符串practice
{

    ///3个可乐瓶可以换⼀瓶可乐，现在有364瓶可乐，问⼀共可以喝多少瓶可乐，剩下⼏个空瓶。

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int ColaBottle = 364;
    //        int allCola = 364;
    //        while (ColaBottle >2)
    //        {
    //            allCola += ColaBottle / 3;
    //            ColaBottle = ColaBottle / 3 + ColaBottle % 3;
    //        }
    //        Console.WriteLine("drike"+allCola+"shengxia"+ColaBottle);
    //    }
    //}

    ///编写⼀个应⽤程序⽤来输⼊的字符串进⾏加密，对于字⺟字符串加密规则如下：‘a’→’d’ ‘b’→’e’ ‘w’→’z’ …… ‘x’→’a’ ‘y’→’b’ ‘z’→’c’‘A’→’D’ ‘B’→’E’ ‘W’→’Z’ …… ‘X’→’A’ ‘Y’→’B’ ‘Z’→’C’? 对于其他字符，不进⾏加密。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string input1= Convert.ToString( Console.ReadLine());
    //        char[]input2= input1.ToCharArray();
    //        for (int  i=0; i<input2.Length;i++)
    //        {
    //            if (('a'<=input2[i]&& input2[i] <= 'z') || ('A' <= input2[i] && input2[i] <= 'Z'))
    //            {
    //                input2[i] = (char)(input2[i] + 3);
    //                if ('z'<input2[i] && input2[i]<'z'+4)
    //                {
    //                    input2[i] = (char)(input2[i] - 26);
    //                }
    //                else if ('Z' < input2[i] && input2[i] < 'Z' + 4)
    //                {
    //                    input2[i] = (char)(input2[i] - 26);
    //                }
    //            }              
    //        }
    //        foreach (char a in input2)
    //        {
    //            Console.Write(a);
    //        }

    //    }
    //}

    ///输⼊n(n<100)个数，找出其中最⼩的数，将它与最前⾯的数交换后输出这些数。
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string strNum = Console.ReadLine();
    //        string[] strArr = strNum.Split(" ");//Split分割
    //        int[] intArry = new int[strArr.Length];
    //        for (int i = 0; i < strArr.Length; i++)
    //        {
    //            int number = Convert.ToInt32(strArr[i]);
    //            intArry[i] = number;
    //        }
    //        foreach (int a in intArry)
    //        {
    //            Console.Write(a + "|");
    //        }
    //        //完成输入数据的处理↑
    //        int min = intArry[0];
    //        int minIndex=0;
    //        for (int i=1;i<intArry.Length;i++)
    //        {
    //            if (min > intArry[i])
    //            {
    //                min = intArry[i];
    //                minIndex = i;
    //            }
    //        }
    //        int temp = intArry[0];
    //        intArry[0] = intArry[minIndex];
    //        intArry[minIndex] = temp;
    //        foreach (int a in intArry)
    //        {
    //            Console.Write(a + " ");
    //        }
           

    //    }
    //}

    ///编写⼀个控制台程序，要求⽤户输⼊⼀组数字⽤空格间隔，对⽤户输⼊的数字从⼩到⼤输出。(Array.Sort⽅法和冒泡排序)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //处理输入的一串数字，将数字存入数组
    //        string str = Console.ReadLine();
    //        string[] strArray = str.Split(" ");
    //        int[] intArray = new int[strArray.Length];
    //        for (int i=0; i<strArray.Length;i++)
    //        {
    //            int a=Convert.ToInt32(strArray[i]);
    //            intArray[i] = a;
    //        }
    //        //对数组内容进行排序
    //        Array.Sort(intArray);
    //        foreach (int a in intArray)
    //        {
    //            Console.Write(a + " ");
    //        }

    //    }
    //}

    ///冒泡排序-经典暴力排序
    ///对两个数进行比较，然后再交换。
    class Program
    {
        static void Main(string[] args)
        {
            //处理输入的一串数字，将数字存入数组
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int a = Convert.ToInt32(strArray[i]);
                intArray[i] = a;
            }
            ///对数组内容进行排序：使用Array.sort()方法
            //Array.Sort(intArray);
            //foreach (int a in intArray)
            //{
            //    Console.Write(a + " ");
            //}
            ///通过冒泡排序来进行排序。
            bool isChange = false;
            for (int i = 0; i < intArray.Length-1; i++)//进行i轮比较
            {
                for (int j = 0; j < intArray.Length - 1-i; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        isChange = true;
                    }
                }
                if (isChange == false)
                {
                    break;
                }
            }
            
            foreach (int a in intArray)
            {
                Console.Write(a + " ");
            }
        }
    }

}
