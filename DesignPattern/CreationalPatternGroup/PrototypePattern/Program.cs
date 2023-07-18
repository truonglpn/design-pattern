//using DesignPattern.PrototypePattern.AbstractPrototype;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.PrototypePattern
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            ClientComputer client = new ClientComputer();

//            client["option1"] = new SettingComputer("BKAV", "Microsoft");
//            client["option2"] = new SettingComputer("JAV", "MSM");

//            // clone
//            SettingComputer option3 = client["option1"].Clone() as SettingComputer;
//            SettingComputer option4 = client["option2"].Clone() as SettingComputer;

//            // deep coppy
//            SettingComputer option5 = client["option1"].DeepCopy() as SettingComputer;
//            Console.WriteLine(option3);
//            Console.WriteLine(option4);
//            Console.WriteLine(option5);
//            Console.ReadLine();

//        }
//    }
//}
