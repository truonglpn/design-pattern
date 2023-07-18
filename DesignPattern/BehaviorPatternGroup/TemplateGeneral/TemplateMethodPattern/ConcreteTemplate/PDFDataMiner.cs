using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.TemplateMethodPattern.ConcreteTemplate
{
    class PDFDataMiner : DataMiner
    {
        public override void ExtractData()
        {
            Console.WriteLine("Extract Data CSV");
        }

        public override void ParseData()
        {
            Console.WriteLine("Parse Data CSV");
        }
    }
}
