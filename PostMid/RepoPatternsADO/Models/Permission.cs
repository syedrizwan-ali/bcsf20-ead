using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Models
{
    public class Permission : AuditInfo
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
