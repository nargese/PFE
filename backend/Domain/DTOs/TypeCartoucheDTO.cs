using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TypeCartoucheDTO
    {
        public Guid IdTypeCartouche { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Nom Cartouche")]
        public string NomCartouche { get; set; }
    }
}
