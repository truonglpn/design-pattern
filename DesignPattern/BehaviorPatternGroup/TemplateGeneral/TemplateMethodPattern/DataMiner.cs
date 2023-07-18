using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.TemplateMethodPattern
{
    abstract class DataMiner
    {
        public string File { get; set; }
        public string RawData { get; set; }

        public virtual void OpenFile(string path)
        {
            Console.WriteLine($"Open file {path}");
        }

        public virtual void CloseFile(string path)
        {
            Console.WriteLine($"Close File {path}");
        }

        public abstract void ExtractData();
        public abstract void ParseData();

        public void DataMine(string path)
        {
            OpenFile(path);
            ExtractData();
            ParseData();
            CloseFile(path);
        }
    }
}
