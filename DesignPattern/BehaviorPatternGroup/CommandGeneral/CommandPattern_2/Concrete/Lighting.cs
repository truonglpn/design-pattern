using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete
{
    class Lighting
    {
        string location = "";
        public Lighting(string location)
        {
            this.location = location;
        }
        public string On()
        {
            return location + "lighting is on";
        }

        public string Off()
        {
            return location + "lighting is off";
        }
    }
}
