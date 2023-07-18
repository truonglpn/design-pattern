using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatternGroup.BuilderPattern.Director
{
    class Product
    {
        private List<object> parts = new List<object>();
            
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public string ListPart()
        {
            string str = string.Empty;

            for (int i = 0; i < parts.Count; i++)
            {
                str += this.parts[i] + ", ";
            }

            str = str.Remove(str.Length - 1);

            return "Product Part " + str + "\n";
        }
    }
}
