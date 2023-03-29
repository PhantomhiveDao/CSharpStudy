using System;
using System.Collections.Generic;
using System.Text;

namespace unit12_工具人下楼事件
{
    internal class LazyMan
    {
        public string Name { get; private set; }

        public LazyMan(string name)
        {
            Name = name;
        }
        public void TakeFood()
        {
            Console.WriteLine("給"+Name+"拿外卖");
        }
        public void TakePacage()
        {
            Console.WriteLine("給" + Name + "拿快递");

        }
    }
}
