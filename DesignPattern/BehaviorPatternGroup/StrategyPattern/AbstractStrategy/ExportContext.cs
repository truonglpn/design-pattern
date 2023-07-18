using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.StrategyPattern.AbstractStrategy
{
    class ExportContext 
    {
        private IExport export;

        public ExportContext(IExport export)
        {
            this.export = export;
        }

        public void SetStrategy(IExport export)
        {
            this.export = export;
        }

        public void CreateArchive(string fileName)
        {
            export.ExportFile(fileName);
        }
    }
}
