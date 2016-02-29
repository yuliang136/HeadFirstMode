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
        SOLD        = 3
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
    }
}
