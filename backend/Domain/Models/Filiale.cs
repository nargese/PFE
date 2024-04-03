using OsmoseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
   public class Filiale
    {
        [Key]
        public Guid IdFiliale { get; set; }
        public string Labelle { get; set; }
        public virtual ICollection<Atelier> Ateliers { get; set; }
        public virtual ICollection<Compte> Comptes { get; set; }

    }
}
