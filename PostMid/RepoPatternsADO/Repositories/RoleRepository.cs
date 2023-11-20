using RepoPatternsADO.Helpers;
using RepoPatternsADO.Interfaces;
using RepoPatternsADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Repositories
{
    public class RoleRepository : IRepository<Role>
    {
        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Role Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> Get()
        {
            throw new NotImplementedException();
        }

        public PagedList<User> Page(Predicate<User> criteria, PagingInfo pagingInfo)
        {
            throw new NotImplementedException();
        }

        public Role Save(Role dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> Search(Predicate<Role> criteria)
        {
            throw new NotImplementedException();
        }

        public Role Update(Role dto)
        {
            throw new NotImplementedException();
        }
    }
}
