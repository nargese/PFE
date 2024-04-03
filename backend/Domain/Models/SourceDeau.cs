using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsmoseProject.Models
{
    public class SourceDeau
    {
        public Guid IdSourceDeau { get; set; }
        public Double QuantiteDeau { get; set; }
     
        public Guid FK_Filiale { get; set; }
       
        public virtual Filiale Filiale { get; set; }
    }
}
