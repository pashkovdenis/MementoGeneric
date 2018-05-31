using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExample
{
    public class MementoCareTaker<M>
                    : Stack<MementoObject<M>> where M : class
    { 
        private int _capacity;
        public MementoCareTaker(int capacity = 10)=> _capacity = capacity; 
        public void SaveState(M state)
        {
            if (Count > _capacity)
                Clear();
            if (Count < _capacity)
                Push(new MementoObject<M>(state));
        }
        public M GetPreviousState() => (Count > 0 ? Pop().GetState() : default(M));

    }
}
