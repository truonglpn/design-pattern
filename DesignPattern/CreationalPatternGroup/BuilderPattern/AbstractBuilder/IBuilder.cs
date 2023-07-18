using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatternGroup.BuilderPattern.AbstractBuilder
{
    /// <summary>
    /// abstract builder or interface contain all method support create Product
    /// </summary>
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();

    }
}
