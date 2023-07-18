using DesignPattern.AbstractFactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern.ConcreteProduct
{
    class VNPTVNPhone : IVietNam
    {
        public string GetDetailModel()
        {
            return "VNPT +84....";
        }
    }
}
