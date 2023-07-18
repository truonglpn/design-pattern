using DesignPattern.AbstractFactoryPattern.AbstractFactory;
using DesignPattern.AbstractFactoryPattern.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IPhoneFactory internetPICFPT = new FPTPhoneFactory();
    //        PhoneClient fptTelecom = new PhoneClient(internetPICFPT);

    //        IPhoneFactory internetPICVNPT = new VnptPhoneFactory();
    //        PhoneClient vnptVN = new PhoneClient(internetPICVNPT);
        
    //        Console.WriteLine("Region VietNam Model");
    //        Console.WriteLine(fptTelecom.GetDetailLaoPhoneNumber());
    //        Console.WriteLine(fptTelecom.GetDetailVNPhoneNumber());

    //        Console.WriteLine("Region Lao Model");
    //        Console.WriteLine(vnptVN.GetDetailLaoPhoneNumber());
    //        Console.WriteLine(vnptVN.GetDetailVNPhoneNumber());

    //        Console.ReadLine();
    //    }
    //}
}
