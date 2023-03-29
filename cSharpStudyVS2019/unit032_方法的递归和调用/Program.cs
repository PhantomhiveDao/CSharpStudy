using System;

namespace unit032_方法的递归和调用
{
    class Program
    {
        /// 
        /// 调用函数的时候，会创建一个栈，内存会分配一个单独的空间，调用完之后会回收。
        /// 内存用完啦 栈溢出！
        /// 递归会每次调用函数，相对for循环会更慢
        /// 
        static int F(int n)
        {
            //int end;
            if (n==0 ) 
            {
                return 2;
            }
            if (n==1 ) 
            {
                return 3;
            }
            int res = F(n - 1) + F(n - 2);
            return res;


        }
        static long JieCheng(long n)
        {
            //10! =10*(10-1)...1
            if (n ==1){
                return 1;
            }
            long result = n * JieCheng(n - 1);
            return result;//n*JieCheng(n-1);//递归：我返回我自己
        }
        static long Pluss(long n)
        {
            if (n == 1){
                return 1;
            }
            long result = JieCheng( n) + Pluss(n - 1);
            return result;
        }

        static long F1(long n)
        {
            if (n == 1)
            {
                return 1;
            }
            long result = n*n + F1(n-1);
            return result;
        }
        static long Square2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            long result = Square2(n) * Square2(n);
            return result;
        }
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    result += k * k;
            //    if (result >= 2000)
            //    {
            //        break; 
            //    }
            //    k ++;

            //}
            int i = 1;
            while (true)
            {
                if (F1(i) >=2000)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i-1);
        }
    }
}
