//using DesignPattern.BehaviorPatternGroup.StrategyPattern.AbstractStrategy;
//using DesignPattern.BehaviorPatternGroup.StrategyPattern.ConcreteStrategy;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.BehaviorPatternGroup.StrategyPattern
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ExportContext export = new ExportContext(new ExportPDF());
//            export.CreateArchive("readBook");

//            // set export
//            export.SetStrategy(new ExportPNG());
//            export.CreateArchive("readDataJSON");

//            // set export
//            export.SetStrategy(new ExportWord());
//            export.CreateArchive("readFileTHomeson");

//            Console.ReadLine(); // wait  for user
//        }
//    }
//}
