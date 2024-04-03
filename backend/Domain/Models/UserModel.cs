using System;
using System.Collections.Generic;
using System.Text;

namespace OsmoseProject.Models
{
    public class UserModel
    {

        public Guid IdCompte { get; set; }
        public string Motdepasse { get; set; }
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool access { get; set; }


        public UserModel()
            {

                access = true;
            }
      
    }
}
