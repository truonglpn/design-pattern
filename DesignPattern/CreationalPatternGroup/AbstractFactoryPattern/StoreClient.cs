using DesignPattern.AbstractFactoryPattern.AbstractFactory;
using DesignPattern.AbstractFactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    class PhoneClient
    {
        IVietNam vietName;
        ILao lao;
        public PhoneClient(IPhoneFactory phoneFactory)
        {
            vietName = phoneFactory.PhoneVietNamHere();
            lao = phoneFactory.PhoneLaoHere();
        }

        public string GetDetailLaoPhoneNumber()
        {
            return lao.GetDetailModel();
        }
        public string GetDetailVNPhoneNumber()
        {
            return vietName.GetDetailModel();
        }
    }
}

