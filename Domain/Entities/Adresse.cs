using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Adresse
    {
        public int id_adresse { get; set; }
        public string ville { get; set; }
        public string zone { get; set; }
        public string code_postal { get; set; }
        public int numero_boutique { get; set; }


}
}
