using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gm = new GumballMachine(5);

            Console.WriteLine(gm);
            gm.InsertQuarter();
            gm.TurnCrank();

            Console.WriteLine();
            gm.InsertQuarter();
            gm.EjectQuarter();
            gm.TurnCrank();

            Console.WriteLine();
            gm.InsertQuarter();
            gm.TurnCrank();
            gm.InsertQuarter();
            gm.TurnCrank();
            gm.EjectQuarter();

            Console.WriteLine();
            gm.InsertQuarter();
            gm.InsertQuarter();
            gm.TurnCrank();
            gm.InsertQuarter();
            gm.TurnCrank();
            gm.InsertQuarter();
            gm.TurnCrank();
            
        }
    }
}
