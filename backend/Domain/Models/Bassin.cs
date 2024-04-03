using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OsmoseProject.Models
{
    public class Bassin:SourceDeau
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string NomBassin { get; set; }


    }
}
