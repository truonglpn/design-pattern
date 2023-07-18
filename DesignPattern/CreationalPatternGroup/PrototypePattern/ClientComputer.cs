using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern.AbstractPrototype
{
    class ClientComputer
    {
        private Dictionary<string, SettingComputerPrototype> computers = new Dictionary<string, SettingComputerPrototype>();

        // INDEX
        public SettingComputerPrototype this[string key]
        {
            get { return computers[key]; }
            set { computers.Add(key, value); }
        }
    }
}
