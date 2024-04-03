using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class FournisseurDTO
    {
        public Guid IdFournisseur { get; set; }
        public string FournisseurNom { get; set; }
        public string FournisseurCode { get; set; }
        public int FournisseurPhoneNumber { get; set; }
        public int FournisseurFaxNumber { get; set; }
        public string FournisseurEmail { get; set; }
        public string ProviderAddress { get; set; }
    }
}
