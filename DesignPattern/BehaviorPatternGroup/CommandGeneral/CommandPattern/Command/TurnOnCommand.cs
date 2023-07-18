using DesignPattern.BehaviorPatternGroup.CommandPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern.Command
{
    class TurnOnCommand : ICommand
    {
        private Fan fan; 

        public TurnOnCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.TurnOn();
        }

        public void Undo()
        {
            fan.TurnOff();
        }
    }
}
