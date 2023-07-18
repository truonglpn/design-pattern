using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command;
using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand
{
    class LightingTurnOnCommand : ICommand
    {
        private Lighting lighting;
        public LightingTurnOnCommand(Lighting lighting)
        {
            this.lighting = lighting;
        }

        public object Execute()
        {
            return lighting.On();
        }

        public object Undo()
        {
            return lighting.Off();
        }
    }
}
