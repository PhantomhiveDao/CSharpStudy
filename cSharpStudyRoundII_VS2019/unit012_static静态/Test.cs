using System;
using System.Collections.Generic;
using System.Text;

namespace unit012_static静态
{
    class Test
    //静态类里只能有静态成员
    //静态类里的成员不能被实例化
    //项目中的公共数据可以放入静态类中进行存储，
    {
        public static int count;
        //静态变量/静态字段
        //被所有的对象”test“共享的字段
        //可以直接通过类访问，不能通过test的对象访问
    }
    //定义接口

}
