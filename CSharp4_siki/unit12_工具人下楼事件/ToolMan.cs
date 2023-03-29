using System;
using System.Collections.Generic;
using System.Text;

namespace unit12_工具人下楼事件
{
    delegate void DownStairDelegate();

    internal class ToolMan
    {
        public string Name { get; private set; }
        //加了event之后委托有了限制：该委托只能+=或者-=；并且只能在内部进行调用。
        //编译成 创建一个私有的委托示例，和施加在其上的add、remove方法
        //添加了event之后，只允许用add remove方法来操作，导致不匀速在类的外部被直接触发，只能在类的内部适合的世纪触发。
        //委托可以在外部被触发。但不建议这么使用
        //委托常用来表达回调（回调函数）；事件表达外发【消息订阅的一个机制】的接口。
        public event DownStairDelegate DownStairDelegate = null;

        public ToolMan(string name)
        {
            Name = name;
        }

        public void Dowstair()
        {
            Console.WriteLine("工具人"+Name+"下楼了");
            if (DownStairDelegate != null) { DownStairDelegate(); }
        }
    }
}
