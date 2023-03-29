using System;
using System.Collections.Generic;
using System.Text;

namespace unit014_索引器
{
    class Week
    {
        //输入星期几的英文，返回一个数字。
        private string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun"};
        private int GetDay(string day)
        {
            int i = 0;
            foreach (string temp in days)
            {
                if (temp == day)
                    return i+1;
                i++;
            }
            return -1;
        }
        public int this[string day]
        {
            get 
            {
                return GetDay(day);
            }
        }
    }
}
