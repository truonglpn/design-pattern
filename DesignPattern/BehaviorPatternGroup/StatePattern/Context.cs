using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.StatePattern
{
    class Context
    {
        private State _state = null;
        public Context(State state)
        {
            this.TransionTo(state);
        }

        public void TransionTo(State state)
        {
            Console.WriteLine($"Context : Transion To {state.GetType().Name}");
            this._state = state;
            this._state.SetContext(this);
        }

        public void Request1()
        {
            this._state.HandlerRequest1();
        }

        public void Request2()
        {
            this._state.HandlerRequest2();
        }
    }
}
