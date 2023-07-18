//using DesignPattern.BehaviorPatternGroup.TemplateMethodPattern.ConcreteTemplate;
//using FileWorker;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace DesignPattern.BehaviorPatternGroup.TemplateMethodPattern
//{
//    class Program
//    {
//        static OpenFileDialog openFileDialog = null;
//        static void Main(string[] args)
//        {
//            //PDFDataMiner pdfMiner = new PDFDataMiner();
//            //pdfMiner.DataMine("file_test.pdf");

//            //CSVDataMiner csvMinder = new CSVDataMiner();
//            //csvMinder.DataMine("file_test.csv");
//            //FileTemplate excelMiner = new ExcelHandler();
//            DataTable dt = excelMiner.DataMiner(openFileDialog, "Open File Excel", "All", ".", "Deskop");

//            foreach (var item in dt.Rows)
//            {
//                Console.WriteLine(item);
//            }
//            // wait for user
//            Console.ReadLine();
//        }
//    }
//}
