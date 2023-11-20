using RepoPatternsADO.Helpers;
using RepoPatternsADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Interfaces
{
    public interface IRepository<T> where T: AuditInfo
    {
        T Save(T dto);
        T Update(T dto);
        bool Delete(long id);
        T Get(long id);
        IEnumerable<T> Get();
        IEnumerable<T> Search(Predicate<T> criteria);
        PagedList<User> Page(Predicate<User> criteria, PagingInfo pagingInfo);
    }
}
