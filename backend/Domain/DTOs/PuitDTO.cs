using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PuitDTO:SourceDeauDTO
    {
        public Double Profondeur { get; set; }
        public string NomPuit { get; set; }
        public string AmortissementType { get; set; }
    }
}
