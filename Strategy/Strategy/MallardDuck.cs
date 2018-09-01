using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("MallardDuck");
        }
    }
}
