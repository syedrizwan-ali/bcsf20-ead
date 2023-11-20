using RepoPatternsADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Helpers
{
    public class PagedList<T> where T : AuditInfo
    {
        public IEnumerable<T> Source { get; }
        public int NumberOfRows { get; }
        public int NumberOfPages { get; }

        public PagedList(IEnumerable<T> source, int numOfRows, int pageSize)
        {
            Source = source;
            NumberOfRows = numOfRows;
            NumberOfPages = numOfRows / pageSize <= 0 ? 1 : pageSize;
        }
    }
}
