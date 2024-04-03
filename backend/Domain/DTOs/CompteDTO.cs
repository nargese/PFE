using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTOs
{
    public class CompteDTO
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
        public String RoleName { get; set; }
        public Guid FK_Filiale { get; set; }
        public string Labelle { get; set; }

    }
}
