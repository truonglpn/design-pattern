using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command;
using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand
{
    class LightingTurnOffCommand : ICommand
    {
        private Lighting lighting;
        public LightingTurnOffCommand(Lighting lighting)
        {
            this.lighting = lighting;
        }

        public object Execute()
        {
            return lighting.Off();
        }

        public object Undo()
        {
            return lighting.On();
        }
    }
}
