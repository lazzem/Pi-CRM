using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Categorie
    {
        [Key]
        public int id_categorie { get; set; }
        public string nom { get; set; }

        public virtual ICollection<Produit> Prouits { get; set; }


    }
}
