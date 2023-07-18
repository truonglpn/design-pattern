using DesignPattern.BehaviorPatternGroup.DecoratorPattern.Component;
using DesignPattern.BehaviorPatternGroup.DecoratorPattern.ConcreteComponent;
using DesignPattern.BehaviorPatternGroup.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.DecoratorPattern.ConcreteDecorator
{
    class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Deiesel Engine";
                Console.WriteLine("DeieselCarDecorator add deiesel car to car" + car);
            }
        }
    }
}
