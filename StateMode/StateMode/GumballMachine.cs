using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMode
{
    public enum GMState
    {
        SOLD_OUT    = 0,
        NO_QUARTER  = 1,
        HAS_QUARTER = 2,
        SOLD        = 3     // 正在出售糖果的状态.
    }

    class GumballMachine
    {
        public  GMState _state = GMState.SOLD_OUT;
        public int _count = 0;

        public GumballMachine(int count)
        {
            this._count = count;

            if (count > 0)
            {
                _state = GMState.NO_QUARTER;
            }
        }
        
        // 对糖果机的操作接口 来改变内部状态.


        /// <summary>
        /// 投入硬币时 检测当前什么状态 执行什么操作.
        /// </summary>
        public void InsertQuarter()
        {
            // 代码编写 针对当前状态，以及玩家操作接口做出响应.
            switch (_state)
            {
                case GMState.HAS_QUARTER:
                    Console.WriteLine("You can't insert another quarter");
                    break;
                case GMState.NO_QUARTER:
                    _state = GMState.HAS_QUARTER;
                    Console.WriteLine("You inserted a quarter");
                    break;
                case GMState.SOLD:
                    Console.WriteLine("Please wait,we are already giving you a gumball.");
                    break;
                case GMState.SOLD_OUT:
                    Console.WriteLine("You can't insert a quarter, the machine is sold out");
                    break;
            }
        }

        /// <summary>
        /// 当玩家执行退回钱的操作时,判断此时的状态
        /// </summary>
        public void EjectQuarter()
        {
            // 代码编写 针对当前状态，以及玩家操作接口做出响应.
            switch (_state)
            {
                case GMState.HAS_QUARTER:
                    _state = GMState.NO_QUARTER;
                    Console.WriteLine("Quarter returned");
                    break;
                case GMState.NO_QUARTER:
                    _state = GMState.HAS_QUARTER;
                    Console.WriteLine("You haven't inserted a quarter");
                    break;
                case GMState.SOLD:
                    // 正在出售时，不允许退钱
                    Console.WriteLine("Sorry, you already turned the crank.");
                    break;
                case GMState.SOLD_OUT:
                    // 理论上不会执行到这里，如果到达，说明程序有误.
                    Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
                    break;
            }
        }

        /// <summary>
        /// 转到扳手出糖果，只有在投入了钱后才有效果.
        /// </summary>
        public void TurnCrank()
        {
            // 代码编写 针对当前状态，以及玩家操作接口做出响应.
            switch (_state)
            {
                case GMState.HAS_QUARTER:                    
                    Console.WriteLine("You turned...");
                    // 切换到正在出糖果的状态.
                    _state = GMState.SOLD;
                    // 调用机器内部接口出糖果.
                    Dispense();
                    break;
                case GMState.NO_QUARTER:
                    Console.WriteLine("You turned,but there's no quarter");
                    break;
                case GMState.SOLD:
                    Console.WriteLine("Turning twice doesn't get you another gumball!");
                    break;
                case GMState.SOLD_OUT:
                    Console.WriteLine("You turned, but there are no gamballs");
                    break;
            }
        }

        /// <summary>
        /// 玩家投入硬币后，转动扳手 机器内部调用发送糖果函数. 此时状态是正在Sold的状态.
        /// </summary>
        private void Dispense()
        {

        }
    }

    

}
