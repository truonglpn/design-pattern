//using DesignPattern.BehaviorPatternGroup.Composite.Composite;
//using DesignPattern.BehaviorPatternGroup.Composite.Leaf;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.BehaviorPatternGroup.Composite
//{
//    class Program
//    {
//        static void Main(string [] args)
//        {
//            var iphone = new SingleGift("IPhone X", 123);
//            iphone.CalculateTotalPrice();

//            // composite gift
//            var rootBox = new CompositeGift("RootBox", 0);
//            var TruckToy = new SingleGift("Truck", 2000);
//            var SharkToy = new SingleGift("Shark", 3000);

//            rootBox.Add(TruckToy);
//            rootBox.Add(SharkToy);

//            var ChildBox = new CompositeGift("ChildBox", 0);
//            var soldierToy = new SingleGift("Soldier", 2300);

//            ChildBox.Add(soldierToy);

//            rootBox.Add(ChildBox);

//            Console.WriteLine($"Total price composite present is = {rootBox.CalculateTotalPrice()}");

//            Console.ReadLine();
//        }
//    }
//}
