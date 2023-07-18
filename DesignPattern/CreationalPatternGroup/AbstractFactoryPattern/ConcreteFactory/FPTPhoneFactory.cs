using DesignPattern.AbstractFactoryPattern.AbstractFactory;
using DesignPattern.AbstractFactoryPattern.AbstractProduct;
using DesignPattern.AbstractFactoryPattern.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern.ConcreteFactory
{
    class FPTPhoneFactory : IPhoneFactory
    {
        public ILao PhoneLaoHere()
        {
            return new FPTLaoPhone();
        }

        public IVietNam PhoneVietNamHere()
        {
            return new FPTVNPhone();
        }
    }
}
