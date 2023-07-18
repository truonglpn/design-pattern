﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.FadacePattern.SubSystem
{
    class AccountService
    {
        public void GetAccount(string email)
        {
            Console.WriteLine($"Getting the account of {email}");
        }
    }
}
