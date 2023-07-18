using DesignPattern.BehaviorPatternGroup.BridgeGeneral.BridgePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.BridgeGeneral.BridgePattern.Concrete
{
    class Blue : IColor
    {
        public string GetColor()
        {
            return "Color = Blue";
        }
    }
}
