using DesignPattern.AbstractFactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern.ConcreteProduct
{
    class FPTLaoPhone : ILao
    {
        public string GetDetailModel()
        {
            return "FPT +95...";
        }
    }
}
