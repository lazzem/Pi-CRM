using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Complaint
{
    class Complaint
    {
        public string ComplaintID { get; set; }
        public DateTime Creation_date { get; set; }
        public DateTime Processing_date { get; set; }
        public DateTime Clossing_date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
