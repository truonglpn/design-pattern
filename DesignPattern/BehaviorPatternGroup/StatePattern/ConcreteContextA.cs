using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.StatePattern
{
    class ConcreteContextA : State
    {
        public override void HandlerRequest1()
        {
            Console.WriteLine("COncrete Handler context 1");
            Console.WriteLine("Concrete COntext A handle request 1");
            this.context.TransionTo(new ConcreteContextB());
        }

        public override void HandlerRequest2()
        {
            Console.WriteLine("Concrete Context A handle request 2");
        }
    }
}
