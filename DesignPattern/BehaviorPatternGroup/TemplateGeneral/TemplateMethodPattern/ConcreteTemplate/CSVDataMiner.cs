using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.TemplateMethodPattern.ConcreteTemplate
{
    class CSVDataMiner : DataMiner
    {
        public override void OpenFile(string path)
        {
            base.OpenFile(path);
            this.File = "CSV";
        }
        public override void ExtractData()
        {
            Console.WriteLine($"Extract Data {this.File}");
            this.RawData = "CSV";
        }

        public override void ParseData()
        {
            Console.WriteLine($"Parse Data {this.RawData}");
        }
    }
}
