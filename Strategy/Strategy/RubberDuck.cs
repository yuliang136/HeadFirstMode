using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            // 多态 接口保存特定对象.
            m_FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("RubberDuck");
        }

        //public override void Quack()
        //{
        //    Console.WriteLine("RubberDuck squeak");
        //}
    }
}
