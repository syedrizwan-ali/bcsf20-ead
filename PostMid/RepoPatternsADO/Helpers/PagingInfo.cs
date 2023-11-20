using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RepoPatternsADO.Constants;

namespace RepoPatternsADO.Helpers
{
    public class PagingInfo
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string OrderBy { get; set; }
        public OrderDirection OrderDirection { get; set; }
    }
}
