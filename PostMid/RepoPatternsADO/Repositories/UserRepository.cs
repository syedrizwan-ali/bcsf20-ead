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
    public class UserRepository : IRepository<User>
    {
        public User Save(User user) => null;

        public User Update(User user) => null;

        public bool Delete(long id) => false;

        public User Get(long id) => null;

        public IEnumerable<User> Get() => null;

        public IEnumerable<User> Search(Predicate<User> criteria) => null;

        public PagedList<User> Page(Predicate<User> criteria, PagingInfo pagingInfo) => null;
    }
}
