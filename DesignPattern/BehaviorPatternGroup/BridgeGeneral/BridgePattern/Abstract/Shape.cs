using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.BridgeGeneral.BridgePattern.Abstract
{
    abstract class Shape
    {
        public IColor color { get; set; }
        
        public string GetColor()
        {
            return color.GetColor();
        }
    }
}
