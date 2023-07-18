using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.Command
{
    interface ICommand
    {
        object Execute();
        object Undo();
    }
}
