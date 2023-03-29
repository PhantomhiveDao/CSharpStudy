using System;

namespace unit013_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFly fly;
            fly = new Plane();
            fly.FlyAttack();
            fly.Fly();

            fly = new Bird();
            fly.Fly();
            fly.FlyAttack();
            //上述使用方法为多态
        }
    }
    class test : IFly,IColor
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void FlyAttack()
        {
            throw new NotImplementedException();
        }

        public void SetColor()
        {
            throw new NotImplementedException();
        }
    }
}
