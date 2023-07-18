using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command;
using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand
{
    class FanTurnOffCommand : ICommand
    {
        private Fan fan;
        public FanTurnOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public object Execute()
        {
            return fan.Off();
        }

        public object Undo()
        {
            throw new NotImplementedException();
        }
    }
}
