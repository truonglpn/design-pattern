using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.FadacePattern.SubSystem
{
    class PaymentService
    {
        public void PaymentByCash()
        {
            Console.WriteLine("Payment by cash");
        }

        public void PaymentByPaypal()
        {
            Console.WriteLine("Payment by paypal");
        }

        public void PaymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit card");
        }

        public void PaymentByEbanking()
        {
            Console.WriteLine("Payment by Ebanking");
        }
    }
}
