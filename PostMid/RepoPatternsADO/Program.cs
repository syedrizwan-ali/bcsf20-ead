using RepoPatternsADO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new UserRepository();
            var roleRepo = new RoleRepository();
        }
    }
}
