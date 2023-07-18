using DesignPattern.CreationalPatternGroup.FactoryMethodPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatternGroup.FactoryMethodPattern.Model
{
    class BeefPizza : IPizza
    {
        private decimal Price = 2212;
        public decimal GetPrice()
        {
            return Price;
        }
    }
}
