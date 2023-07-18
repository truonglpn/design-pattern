using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.Composite.Component
{
    abstract class BaseGift
    {
        protected string name;
        protected int price;

        public BaseGift(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract int CalculateTotalPrice();  
    }
}
