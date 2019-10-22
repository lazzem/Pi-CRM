using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Complaint
{
    class Agent
    {
        public int idAgent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float salary { get; set; }
        public DateTime HiringDate { get; set; }
        public string address { get; set; }
        public string function { get; set; }
        public string email { get; set; }

        public virtual ICollection<Complaint> Complaints { get; set; }


    }
}
