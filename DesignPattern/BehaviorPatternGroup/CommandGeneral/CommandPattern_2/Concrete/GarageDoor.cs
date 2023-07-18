using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.CommandPattern_2.Concrete
{
    class GarageDoor
    {
        string location;
        public GarageDoor(string location)
        {
            this.location = location;
        }

        public string Up()
        {
            return "Garage Up";
        }

        public string Down()
        {
            return "Garage Down";
        }
        public string Stop()
        {
            return "Garage door movement is stopped";
        }

        public string LightOn()
        {
            return "Garage door light is on";
        }

        public string LightOff()
        {
            return "Garage door light is off";
        }
    }
}
