//using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete;
//using DesignPattern.BehaviorPatternGroup.CommandPattern_2.ConcreteCommand;
//using DesignPattern.BehaviorPatternGroup.CommandPattern_2.Invoker;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2
//{
//    class Program
//    {
//        static void Main(string [] args)
//        {
//            RemoteControl remote = new RemoteControl();

//            Lighting light = new Lighting("Light PE");

//            LightingTurnOffCommand lightingOff = new LightingTurnOffCommand(light);

//            LightingTurnOnCommand lightingOn = new LightingTurnOnCommand(light);

//            remote.SetCommand(0, lightingOn, lightingOff);

//            Console.WriteLine(remote.OnButtonPushed(0));
//            // remote.OffBttonPushed(0);

//            Console.WriteLine(remote.ToStringBuilder());

//            Console.WriteLine(remote.UndoBtnPushed());
//            Console.WriteLine($"undo {remote.ToStringBuilder()}");

//            Console.ReadLine();
//        }
//    }
//}
