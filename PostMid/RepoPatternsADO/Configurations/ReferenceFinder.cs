using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Configurations
{
    public class ReferenceFinder
    {
        private static IKernel _kernel;
        static ReferenceFinder()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static T Find<T>()
        {
            return _kernel.Get<T>();
        }
    }
}
