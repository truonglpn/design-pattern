//using DesignPattern.BehaviorPatternGroup.DecoratorPattern.Component;
//using DesignPattern.BehaviorPatternGroup.DecoratorPattern.ConcreteComponent;
//using DesignPattern.BehaviorPatternGroup.DecoratorPattern.ConcreteDecorator;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.BehaviorPatternGroup.DecoratorPattern
//{
//    class Program
//    {
//        static void Main(string [] args)
//        {
//            ICar BMWCarNo1 = new BMWCar();
//            BMWCarNo1.ManufactureCar();
//            Console.WriteLine(BMWCarNo1.ToString());

//            DieselCarDecorator dieselCar = new DieselCarDecorator(BMWCarNo1);
//            dieselCar.ManufactureCar();
//            Console.WriteLine(dieselCar.ToString());

//            ICar BMWCarNo2 = new BMWCar();
//            PetrolCarDecorator petrolCar = new PetrolCarDecorator(BMWCarNo2);
//            petrolCar.ManufactureCar();
//            Console.WriteLine(petrolCar.ToString());

//            Console.ReadLine();
//        }
//    }
//}
