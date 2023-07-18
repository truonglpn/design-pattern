using DesignPattern.BehaviorPatternGroup.Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.Composite.Leaf
{
    class SingleGift : BaseGift
    {
        public SingleGift(string name, int price) : base(name, price)
        {

        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{name} with the {price}");
            return price;
        }
    }
}
