using System;
using System.Collections.Generic;

namespace unit001_practice装水
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[10] {1,8,6,2,5,4,8,9,7 ,1};
            
            int left = 0;
            int right = list.Length - 1;
            int Result = 0;
            while (left < right&&left< list.Length)
            {
               
                int result = 0;
                
                if (list[left] < list[right])
                {
                    result = list[left] * (right - left);
                    left += 1;
                }
                else
                {
                    result = list[right] * (right - left);
                    right -= 1;
                }
                if (result > Result)
                {
                    Result = result;
                }

                              
            }
            Console.WriteLine(Result);

            //获得容量
            
        }
    }
}
