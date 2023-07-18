//using DesignPattern.BehaviorPatternGroup.CommandPattern.Command;
//using DesignPattern.BehaviorPatternGroup.CommandPattern.Commander;
//using DesignPattern.BehaviorPatternGroup.CommandPattern.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.BehaviorPatternGroup.CommandPattern
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Fan fan = new Fan();
//            ICommand turnOnCommand = new TurnOnCommand(fan);
//            ICommand turnOffCommand = new TurnOffCommand(fan);

//            Remote remote = new Remote(turnOnCommand, turnOffCommand);
//            remote.TurnOnButtonClick();
//            remote.TurnOffButtonClick();

//            // wait for user
//            Console.ReadLine();
//        }
//    }
//}
