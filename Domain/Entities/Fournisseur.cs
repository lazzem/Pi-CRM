using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fournisseur
    {
        [Key]
        public int id_fournisseur { get; set; };
        public string non { get; set; };
        public string prenon { get; set; };
        public string societe { get; set; };
        public string email { get; set; };
        public string numero { get; set; };
        public string adresse { get; set; };


    }
}
