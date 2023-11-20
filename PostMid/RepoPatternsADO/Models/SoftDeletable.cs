using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPatternsADO.Models
{
    public class SoftDeletable : AuditInfo
    {
        public bool IsDeleted { get; set; }
    }
}
