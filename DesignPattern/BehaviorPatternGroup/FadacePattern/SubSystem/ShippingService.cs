﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.FadacePattern.SubSystem
{
    class ShippingService
    {
        public void FreeShipping()
        {
            Console.WriteLine("Free Shipping");
        }
        public void StandardShipping()
        {
            Console.WriteLine("Standard Shipping");
        }
        public void ExpressShipping()
        {
            Console.WriteLine("Express Shipping");
        }
    }
}
