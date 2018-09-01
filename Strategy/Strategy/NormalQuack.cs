using System;

namespace Strategy
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Normal Quack");
        }
    }
}