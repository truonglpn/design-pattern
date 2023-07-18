using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.FadacePattern.SubSystem
{
    class EmaiService
    {
        public void SendEmail(string emailTo)
        {
            Console.WriteLine($"Sending an email to {emailTo}");
        }
    }
}
