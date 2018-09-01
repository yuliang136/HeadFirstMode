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
            //Console.WriteLine("Strategy");

            //Duck duck = new RubberDuck();
            //duck.PerformFly();
            //duck.Display();

            //Duck duck = new MallardDuck();
            //duck.PerformFly();
            //duck.PerformQuack();
            //duck.Display();

            Duck model = new ModelDuck();
            model.PerformFly();

            model.SetFlyBehavior(new FlyRocketPowered());

            model.PerformFly();

        }
    }
}
