using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplicationCore.Domain
{
    public class Membre
    {
        public DateTime DateNaissance { get; set; }
        public int Identifiant { get; set; }

        public String Nom { get; set; }

        public String Prenom { get; set; }

        public ICollection<Contrat> Contrats { get; set; }
    }
}
