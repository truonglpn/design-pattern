using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.TemplateMethodPattern_2
{
    abstract class CaffeinBevarage
    {
        public string Type { get; set; }
        public virtual void BoilWater(string type)
        {
            Console.WriteLine($"Boil Water.... {type}");
        }
        public abstract void Brew();

        public virtual void PourInCup(string type)
        {
            Console.WriteLine($"Pour in Cup {type}");
        }

        public abstract void AddCondiment();

        public void PrepareRecipe(string type)
        {
            BoilWater(type);
            Brew();
            PourInCup(type);
            AddCondiment();
        }

    }
}
