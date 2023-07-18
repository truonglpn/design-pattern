using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.StatePattern
{
    abstract class State
    {
        protected Context context;
        public void SetContext(Context context)
        {
            this.context = context;
        }

        public abstract void HandlerRequest1();
        public abstract void HandlerRequest2();
    }
}
