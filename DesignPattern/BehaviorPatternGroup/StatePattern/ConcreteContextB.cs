using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.StatePattern
{
    class ConcreteContextB : State
    {
        public override void HandlerRequest1()
        {
            Console.WriteLine("Concrete handler request 1");
        }

        public override void HandlerRequest2()
        {
            Console.WriteLine("COncretecontext B handle request 2");
            Console.WriteLine("COncretecontext B was wan't change context A");
            this.context.TransionTo(new ConcreteContextA());
        
        }
    }
}
