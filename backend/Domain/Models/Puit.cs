using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsmoseProject.Models
{
    public class Puit:SourceDeau
    {
        public Double Profondeur { get; set; }
        public string NomPuit { get; set; }
        public string AmortissementType { get; set; }
    }
}
