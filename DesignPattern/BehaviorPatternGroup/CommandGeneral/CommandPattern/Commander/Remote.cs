using DesignPattern.BehaviorPatternGroup.CommandPattern.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern.Commander
{
    class Remote
    {
        private readonly ICommand TurnOnCommand;
        private readonly ICommand TurnOffCommand;

        public Remote(ICommand TurnOnCommand, ICommand TurnOffCommand)
        {
            this.TurnOffCommand = TurnOffCommand;
            this.TurnOnCommand = TurnOnCommand;
        }

        public void TurnOnButtonClick()
        {
            TurnOnCommand.Execute();
        }

        public void TurnOffButtonClick()
        {
            TurnOffCommand.Execute();
        }
    }
}
