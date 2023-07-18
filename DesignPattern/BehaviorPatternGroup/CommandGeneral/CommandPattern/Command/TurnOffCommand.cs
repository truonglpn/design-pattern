using DesignPattern.BehaviorPatternGroup.CommandPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern.Command
{
    class TurnOffCommand : ICommand
    {
        private Fan fan;
        public TurnOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.TurnOff();
        }

        public void Undo()
        {
            fan.TurnOn();
        }
    }
}
