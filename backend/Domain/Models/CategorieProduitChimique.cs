using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OsmoseProject.Models
{
    public class CategorieProduitChimique
    {
        public Guid IdCategorie { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string NomCategorie { get; set; }
        public ICollection <ProduitChimique> produitsChimique { get; set; }
    }
}
