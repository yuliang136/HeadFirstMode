using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            // 具体编程.

            // 把行为设定为具体的类

            // 可以在运行时 指定不同的实例化对象
            m_FlyBehavior = new FlyWithWings();
            m_QuackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("MallardDuck");
        }
    }
}
