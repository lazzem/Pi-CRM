using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Complaint
{
    class TechnicalBranch:Complaint
    {
        public int idProduct { get; set; }
        public int BillNumber { get; set; }
    }
}
