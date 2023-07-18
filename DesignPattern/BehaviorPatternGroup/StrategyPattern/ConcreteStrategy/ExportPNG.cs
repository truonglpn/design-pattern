using DesignPattern.BehaviorPatternGroup.StrategyPattern.AbstractStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.StrategyPattern.ConcreteStrategy
{
    class ExportPNG : IExport
    {
        public void ExportFile(string fileName)
        {
            Console.WriteLine($"Export file {fileName}.PNG successfully");
        }
    }
}
