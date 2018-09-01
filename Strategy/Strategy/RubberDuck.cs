using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("RubberDuck");
        }

        public override void Quack()
        {
            Console.WriteLine("RubberDuck squeak");
        }
    }
}
