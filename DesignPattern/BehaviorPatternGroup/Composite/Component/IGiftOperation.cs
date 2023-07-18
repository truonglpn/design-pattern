using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.Composite.Component
{
    interface IGiftOperation
    {
        void Add(BaseGift baseGift);
        void Remove(BaseGift baseGift);
    }
}
