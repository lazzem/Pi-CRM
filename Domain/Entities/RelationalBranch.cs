using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Complaint
{
    class RelationalBranch: Complaint
    {
        public int idAgent { get; set; }
    }
}
