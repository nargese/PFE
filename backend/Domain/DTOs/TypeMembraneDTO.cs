using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TypeMembraneDTO
    {
        public Guid IdTypeMembrane { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string NomMembrane { get; set; }
        public string TypeMembraneLabel { get; set; }
        public double TypeMembraneSize { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
    }
}
