using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Complaint
{
    class View
    {
        public int idView { get; set; }
        public int ComplaintID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }
}
