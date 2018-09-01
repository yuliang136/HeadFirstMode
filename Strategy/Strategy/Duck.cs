using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior m_FlyBehavior;
        public IQuackBehavior m_QuackBehavior;

        public void PerformFly()
        {
            m_FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            m_QuackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            m_FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            m_QuackBehavior = qb;
        }

        public abstract void Display();
    }
}
