using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand
{
    class NoCommand : ICommand
    {
		public NoCommand()
        {

        }

        public object Execute()
        {
            return null;
        }

        public object Undo()
        {
            return null;
        }
    }
}
