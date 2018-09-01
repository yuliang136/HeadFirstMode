using System;

namespace Strategy
{
    public class Squeak:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}