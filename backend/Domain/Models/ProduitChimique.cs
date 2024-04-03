using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsmoseProject.Models
{
    public class ProduitChimique
    {
        public Guid IdProduitChimique { get; set; }
        public string ProduitChimiqueLabel { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public Guid FK_CategorieProduitChimique { get; set; }
        public virtual CategorieProduitChimique CategorieproduitChimique { get; set; }
    }
}
