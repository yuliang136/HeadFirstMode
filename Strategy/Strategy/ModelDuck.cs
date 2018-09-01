using System;

namespace Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            m_FlyBehavior = new FlyNoWay();
            m_QuackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}