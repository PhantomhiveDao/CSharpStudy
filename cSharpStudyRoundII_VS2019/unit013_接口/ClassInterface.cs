using System;
using System.Collections.Generic;
using System.Text;

namespace unit013_接口
{
    //接口之间的继承
    class ClassInterface : Bird, Interface1,  IFly
    {
        public ClassInterface()
        {
        }

        public void Interface1()
        {
            throw new NotImplementedException();
        }

        public void SetColor()
        {
            throw new NotImplementedException();
        }
    }
}
