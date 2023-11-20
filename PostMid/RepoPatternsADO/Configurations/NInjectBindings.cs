using Ninject.Modules;
using RepoPatternsADO.Interfaces;
using RepoPatternsADO.Models;
using RepoPatternsADO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Configurations
{
    public class NInjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<User>>().To<UserRepository>();
        }
    }
}
