using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.TemplateMethodPattern_2.Concrete
{
    class Coffee : CaffeinBevarage
    {
        public override void BoilWater(string type)
        {
            base.BoilWater(type);
            this.Type = "Coffe";
        }
        public override void AddCondiment()
        {
            Console.WriteLine("added sugar");

        }

        public override void Brew()
        {
            Console.WriteLine($"Brew {Type}");
        }

 
    }
}
