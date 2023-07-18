//using DesignPattern.CreationalPatternGroup.BuilderPattern.AbstractBuilder;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace DesignPattern.CreationalPatternGroup.BuilderPattern
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Director.Director director = new Director.Director();
//            var concreteBuilder = new ConcreteBuilder();

//            director.Builder = concreteBuilder;

//            Console.WriteLine("standard basic product");
//            director.BuilderMinimalProduct();
//            Console.WriteLine(concreteBuilder.GetProduct().ListPart());

//            Console.WriteLine("---------------");
//            Console.WriteLine("Full product");
//            director.BuilderFullProduct();
//            Console.WriteLine(concreteBuilder.GetProduct().ListPart());

//            Console.WriteLine("---------------");
//            Console.WriteLine("Custom Product");
//            concreteBuilder.BuildPartA();
//            concreteBuilder.BuildPartB();
//            Console.WriteLine(concreteBuilder.GetProduct().ListPart());

//            // Wait for user
//            Console.ReadLine();
//        }
//    }
//}
