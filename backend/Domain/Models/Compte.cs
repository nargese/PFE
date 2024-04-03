using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OsmoseProject.Models
{
    public class Compte
    {
        [Required]
        [Key]
        public Guid IdCompte { get; set; }
        public string Motdepasse { get; set; }
        [Required]
        [StringLength(8)]
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool access { get; set; }
        public Guid FK_Role { get; set; }
        public virtual Role Role { get; set; }
        public Guid FK_Filiale { get; set; }
        public virtual Filiale Filiale { get; set; }
    }
}
