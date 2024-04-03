using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Atelier
    {
        [Key]
        public Guid IdAtelier { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string NomAtelier { get; set; }
        public string Labelle { get; set; }
        public Guid FK_Filiale { get; set; }
        public virtual Filiale Filiale { get; set; }
        public virtual ICollection<Station> Stations { get; set; }
    }
}
