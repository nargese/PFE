using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OsmoseProject.Models
{
    public class TypeCartouche
    {
        public Guid IdTypeCartouche { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string NomCartouche { get; set; }
    }
}
