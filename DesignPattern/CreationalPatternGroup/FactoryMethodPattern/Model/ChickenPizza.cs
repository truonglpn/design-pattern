using DesignPattern.CreationalPatternGroup.FactoryMethodPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatternGroup.FactoryMethodPattern.Model
{
    class ChickenPizza : IPizza
    {
        private decimal Price = 1222;
        public decimal GetPrice()
        {
            return Price;
        }
    }
}
