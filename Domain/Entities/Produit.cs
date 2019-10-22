using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Produit
    {
        [Key]
        public int id_produit { get; set; }
        public string libelle { get; set; }
        public string nom { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }


        public virtual Categorie categorie { get; set; }
        [ForeignKey("Category")]
        public int? id_categorie { get; set; }

        public virtual Boutique boutique { get; set; }
        [ForeignKey("Boutique")]
        public int? id_boutique { get; set; }


    }
}
