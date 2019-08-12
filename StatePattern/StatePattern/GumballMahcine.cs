using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class GumballMahcine
    {
        private const int SOLD_OUT = 0;         // 缺货状态
        private const int NO_QUARTER = 1;       // 没有投入Quarter的状态.
        private const int HAS_QUARTER = 2;      // 已经有Quarter的状态
        private const int SOLD = 3;             // 正在销售状态

        // 初始值设置默认为新机.
        private int state = SOLD_OUT;
        private int count = 0;

        
        public GumballMahcine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
            }
        }

        /// <summary>
        /// 插入Quarter.
        /// </summary>
        public void insertQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("You can’t insert another quarter");
            }
            else if (state == NO_QUARTER)
            {
                // 接受硬币 并转换状态.

                state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can’t insert a quarter, the machine is sold out");
            }
            else if (state == SOLD)
            {
                // Needs to wait until the transaction is complete before inserting another quarter.

                Console.WriteLine("Please wait, we’re already giving you a gumball");
            }
        }

        /// <summary>
        /// 退出Quarter 不同状态下 行为不一样.
        /// </summary>
        public void ejectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");
            }
            else if (state == SOLD)
            {
                // 正在贩卖时 想退币是不允许的
                Console.WriteLine("Sorry, you already turned the crank");
            }
        }

        /// <summary>
        /// 摇出Ball
        /// </summary>
        public void turnCrank()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                state = SOLD;

                dispense();
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You turned but there’s no quarter");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Turning twice doesn’t get you another gumball!");
            }
        }

        /// <summary>
        /// Called to dispense a gumball.
        /// </summary>
        private void dispense()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");

                count = count - 1;

                if (0 == count)
                {
                    // sold out.
                    Console.WriteLine("Oops, out of gumballs!");
                    state = SOLD_OUT;
                }
                else
                {
                    state = NO_QUARTER;
                }
            }
        }
    }
}
