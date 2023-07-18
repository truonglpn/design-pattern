using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command;
using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand
{
    class FanTurnOnCammand : ICommand
    {
        private Fan fan;
        public FanTurnOnCammand(Fan fan)
        {
            this.fan = fan;
        }

        public object Execute()
        {
            return fan.Medium(); // default
        }

        public object Undo()
        {
            return fan.Off();
        }
    }
}
