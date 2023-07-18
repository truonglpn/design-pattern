using DesignPattern.BehaviorPatternGroup.StrategyPattern.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.StrategyPattern.ConcreteStrategy
{
    class ExportWord : IExport
    {
        public void ExportFile(string fileName)
        {
            Console.WriteLine($"Export file {fileName}.Word successfully");
        }
    }
}
