using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Duck quack");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swim");
        }

        public void Fly()
        {
            Console.WriteLine("Duck fly");
        }

        public abstract void Display();
    }
}
