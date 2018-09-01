using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy");

            Duck duck = new RubberDuck();
            duck.Quack();
            duck.Swim();
            duck.Display();
            duck.Fly();
        }
    }
}
