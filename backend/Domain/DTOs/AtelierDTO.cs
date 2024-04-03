using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class AtelierDTO
    {
        public Guid IdAtelier { get; set; }
        public string NomAtelier { get; set; }
        public string Labelle { get; set; }
        public Guid FK_Filiale { get; set; }
        public string LabelFiliale { get; set; }
       
    }
}
