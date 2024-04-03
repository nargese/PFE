using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class SourceDeauDTO
    {
        public Guid IdSourceDeau { get; set; }
        public Double QuantiteDeau { get; set; }
        public Guid FK_Filiale { get; set; }
        public String LabelleFiliale { get; set; }
    }
}
