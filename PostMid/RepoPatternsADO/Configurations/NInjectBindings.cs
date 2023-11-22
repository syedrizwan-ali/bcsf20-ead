using Ninject.Modules;
using RepoPatternsADO.Interfaces;
using RepoPatternsADO.Models;
using RepoPatternsADO.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Configurations
{
    public class NInjectBindings : NinjectModule
    {
        public override void Load()
        {
            var fruit = ConfigurationManager.AppSettings["Fruit"];
            if (fruit.Equals("Apple"))
            {
                Bind<IFruit>().To<Apple>();
            }
            else if (fruit.Equals("Orange"))
            {
                Bind<IFruit>().To<Orange>();
            }

            Bind<IFruitBasket>().To<FruitBasket>();
        }
    }
}
