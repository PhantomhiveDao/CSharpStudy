using System;
using System.Collections.Generic;
using System.Text;

namespace unit014_索引器
{
    class test
    {
        /// <summary>
        /// 间接的数组进行了包装
        /// </summary>
        //提前安排了一个长度为10的字符串数组。
        private string [] name = new string[10];
        //定义一个索引器
        public string this[int index]
        {
            get 
            {
                
                return name[index];
            }
            set
            {
                name[index] = value;
              
            }
        }
    }
}
