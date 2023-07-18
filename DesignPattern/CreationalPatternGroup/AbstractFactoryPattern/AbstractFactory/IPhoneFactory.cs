using DesignPattern.AbstractFactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern.AbstractFactory
{
    interface IPhoneFactory
    {
        IVietNam PhoneVietNamHere();
        ILao PhoneLaoHere();
    }
}
