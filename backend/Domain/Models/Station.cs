using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Station
    {
        public Guid IdStation { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string NomStation { get; set; }
        public string Code { get; set; }
        public int Capacite { get; set; }
        public string TypeStation { get; set; }
        public Guid FK_Atelier { get; set; }
        public virtual Atelier Atelier { get; set; }
    }
}
