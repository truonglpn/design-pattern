using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command;
using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand
{
    class GarageDoorDownCommand : ICommand
    {
        private GarageDoor garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public object Execute()
        {
            return garageDoor.Down();
        }

        public object Undo()
        {
            return garageDoor.Up();
        }
    }
}
