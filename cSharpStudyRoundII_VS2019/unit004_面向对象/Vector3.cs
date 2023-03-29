using System;
using System.Collections.Generic;
using System.Text;

namespace unit004_面向对象
{
    class Vector3
    {
        private double x;
        private double y;
        private double z;

        public double Longth()
        {
            double longth = Math.Sqrt(x * x + y * y + z * z);
            
            return longth;
        }
        public void set(double x1,double y1,double z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }

    }
}
