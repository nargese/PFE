using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class StationDTO
    {
        public Guid IdStation { get; set; }
        public string NomStation { get; set; }
        public string Code { get; set; }
        public int Capacite { get; set; }
        public string TypeStation { get; set; }
        public bool isActif { get; set; }
        public string typeAmmortissement { get; set; }

        public Guid FK_Atelier { get; set; }
        public string LabelAtelier { get; set; }
       
    }
}
