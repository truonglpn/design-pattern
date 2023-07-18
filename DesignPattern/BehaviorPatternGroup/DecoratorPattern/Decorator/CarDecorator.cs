﻿using DesignPattern.BehaviorPatternGroup.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.DecoratorPattern.Decorator
{
    class CarDecorator : ICar
    {

        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}
