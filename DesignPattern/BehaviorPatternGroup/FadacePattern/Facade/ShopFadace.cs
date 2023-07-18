using DesignPattern.BehaviorPatternGroup.FadacePattern.SubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.FadacePattern.Facade
{
    class ShopFadace
    {
        private static ShopFadace instance;

        private AccountService accountService;
        private EmaiService emailService;
        private PaymentService paymentService;
        private ShippingService shippingService;
        private SMSService smsService;

        private ShopFadace()
        {
            accountService = new AccountService();
            emailService = new EmaiService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
            smsService = new SMSService();
        }
        public static ShopFadace GetInstance()
        {
            if (instance == null)
                instance = new ShopFadace();
            return instance;
        }

        public void BuyProductByCashWithFreeShipping(string email, string name, string mobilePhone)
        {
            accountService.GetAccount(name);
            emailService.SendEmail(email);
            paymentService.PaymentByCash();
            shippingService.FreeShipping();
            smsService.SendSMS(mobilePhone);
        }
     
    }
}
