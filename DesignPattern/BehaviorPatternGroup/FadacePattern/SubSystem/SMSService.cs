using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.FadacePattern.SubSystem
{
    class SMSService
    {
        public void SendSMS(string mobilePhone)
        {
            Console.WriteLine($"Sending message to {mobilePhone}");
        }
    }
}
