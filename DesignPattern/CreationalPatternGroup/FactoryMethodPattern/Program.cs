//using DesignPattern.CreationalPatternGroup.FactoryMethodPattern.FactoryMethod;
//using DesignPattern.CreationalPatternGroup.FactoryMethodPattern.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static DesignPattern.CreationalPatternGroup.FactoryMethodPattern.FactoryMethod.PizzaFactory;

//namespace DesignPattern.CreationalPatternGroup.FactoryMethodPattern
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            PizzaType type = PizzaType.Beef;
//            IPizza pizza = null;

//            //// normal create
//            //if (type == PizzaType.Beef)
//            //    pizza = new BeefPizza();
//            //else if (type == PizzaType.Chicken)
//            //    pizza = new ChickenPizza();

//            // factory method
//            PizzaFactory pizzaFactory = new PizzaFactory();
//            pizza = pizzaFactory.CreatePizza(type);


//            Console.WriteLine(pizza.GetPrice());

//            // wait for user
//            Console.Read();
//        } 
//    }
//}
