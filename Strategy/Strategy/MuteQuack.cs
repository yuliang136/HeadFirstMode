using System;

namespace Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<Silence>");
        }
    }
}