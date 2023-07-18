using DesignPattern.CreationalPatternGroup.BuilderPattern.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatternGroup.BuilderPattern.AbstractBuilder
{
    /// <summary>
    /// concrete builder corresponding interface builder provides method detail create product
    /// </summary>
    class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.product = new Product();
        }
        public void BuildPartA()
        {
            this.product.Add("Part1");
        }

        public void BuildPartB()
        {
            this.product.Add("Part2");
        }

        public void BuildPartC()
        {
            this.product.Add("Part3");
        }

        public Product GetProduct()
        {
            Product result = this.product;

            this.Reset();
                
            return result;
        }
    }
}
