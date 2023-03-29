using System;
using System.Collections.Generic;
using System.Text;

namespace unit15_自定义特性
{
    [AttributeUsage(AttributeTargets.Class)]

    //sealed：密封
    internal sealed class MyAttribute:Attribute
    {
        public string devloper;
        public string version;
        public string description;

        public MyAttribute(string devloper, string version, string description)
        {
            this.devloper = devloper;
            this.version = version;
            this.description = description;
        }
    }
}
