using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern.Concrete
{
    class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan turn On ....");
        }
        public void TurnOff()
        {
            Console.WriteLine("Fan turn Off ....");
        }
    }
}
