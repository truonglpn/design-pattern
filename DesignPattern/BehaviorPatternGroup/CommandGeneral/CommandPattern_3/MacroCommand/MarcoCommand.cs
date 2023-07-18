using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.BehaviorPatternGroup.CommandPattern_3.Command;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_3.MacroCommand
{
    class MarcoCommand : ICommand
    {
        ICommand[] commands;
        public MarcoCommand(ICommand[] commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            for (int i = 0; i < commands.Count(); i++)
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < commands.Count(); i++)
            {
                commands[i].Undo();
            }
        }
    }
}
