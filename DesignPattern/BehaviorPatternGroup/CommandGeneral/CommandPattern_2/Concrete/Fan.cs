using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete
{
    class Fan
    {
        string location = "";
        int level;
        public const int HIGH = 2;
        public const int MEDIUM = 1;
        public const int LOW = 0;

        public Fan(string location)
        {
            this.location = location;
        }
        public string High()
        {
            level = HIGH;
            return location + "fan is on high";
        }
        public string Medium()
        {
            level = MEDIUM;
            return location + "fan is on medium";
        }

        public string Low()
        {
            level = LOW;
            return location + "fan is on low";
        }
        public int GetSpeed()
        {
            return level;
        }

        public object Off()
        {
            level = 0;
            return "fan turn off";
        }
    }
}
