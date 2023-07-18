using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_3.Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
