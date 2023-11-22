using Ninject;
using RepoPatternsADO.Configurations;
using RepoPatternsADO.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO
{
    class Program
    {
        static void Main(string[] args)
        {
            new ReferenceFinder();

            var fruitBasket = ReferenceFinder.Find<IFruitBasket>();
            fruitBasket.Display();
        }
    }

    public interface IFruitBasket
    {
        void Display();
    }

    public class FruitBasket : IFruitBasket
    {
        private readonly IFruit _fruit;
        public FruitBasket(IFruit fruit)
        {
            _fruit = fruit;
        }

        public void Display()
        {
            _fruit.Taste();
        }
    }

    public interface IFruit
    {
        void Taste();
    }

    public class Apple : IFruit
    {
        public Apple()
        {
            Console.WriteLine("Apple ctor");
        }

        public void Taste()
        {
            Console.WriteLine("Apple is sweet");
        }
    }

    public class Orange : IFruit
    {
        public Orange()
        {
            Console.WriteLine("Orange ctor");
        }

        public void Taste()
        {
            Console.WriteLine("Orange is sour");
        }
    }
}
