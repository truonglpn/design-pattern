using DesignPattern.CreationalPatternGroup.FactoryMethodPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatternGroup.FactoryMethodPattern.FactoryMethod
{
    /// <summary>
    /// the concrete creator (factory method)
    /// </summary>
    class PizzaFactory 
    {
        public enum PizzaType { Beef, Chicken }
        public IPizza CreatePizza(PizzaType type)
        {
            IPizza pizza = null;
            switch(type)
            {
                case PizzaType.Beef:
                    pizza = new BeefPizza();
                    break;
                case PizzaType.Chicken:
                    pizza = new ChickenPizza();
                    break;
            }
            return pizza;
        }
    }
}
