using DesignPattern.CreationalPatternGroup.BuilderPattern.AbstractBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatternGroup.BuilderPattern.Director
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuilderMinimalProduct()
        {
            builder.BuildPartA();
        }

        public void BuilderFullProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
