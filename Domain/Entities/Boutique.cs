using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Boutique
    {
        [Key]
        public int id_boutique { get; set; }
        public string nom { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }


        public virtual ICollection<Produit> Prduits { get; set; }


    }
}
