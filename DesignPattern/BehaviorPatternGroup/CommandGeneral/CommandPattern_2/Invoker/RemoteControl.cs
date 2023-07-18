using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command;
using DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.Invoker
{
    class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[3];
            offCommands = new ICommand[3];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 3; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this.onCommands[slot] = onCommand;
            this.offCommands[slot] = offCommand;
        }

        public object OnButtonPushed(int slot)
        {
            if (onCommands[slot] != null)
            {
                undoCommand = onCommands[slot];
                return this.onCommands[slot].Execute();
            }
            else
                return null;
        }

        public object OffBttonPushed(int slot)
        {
            if (onCommands[slot] != null)
            {
                undoCommand = offCommands[slot];
                return this.offCommands[slot].Execute();
            }
            else
                return null;
        }

        public object UndoBtnPushed()
        {
            return undoCommand.Undo();
        }

        public string ToStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                    + "    " + offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
