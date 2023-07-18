using DesignPattern.BehaviorPatternGroup.Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.Composite.Composite
{
    class CompositeGift : BaseGift, IGiftOperation
    {
        private List<BaseGift> baseGifts;
        public CompositeGift(string name, int price) : base(name, price)
        {
            baseGifts = new List<BaseGift>();
        }

        public void Add(BaseGift baseGift)
        {
            baseGifts.Add(baseGift);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;
            Console.WriteLine($"{name} contains the following product with prices");

            foreach (var gift in baseGifts)
            {
                total += gift.CalculateTotalPrice();
            }
            return total;
        }

        public void Remove(BaseGift baseGift)
        {
            baseGifts.Remove(baseGift);
        }
    }
}
