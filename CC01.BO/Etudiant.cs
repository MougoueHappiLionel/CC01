using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant : Ecole
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Identifiant { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string nom, string prenom, string identifiant, int contact, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Identifiant = identifiant;
            Contact = contact;
            Email = email;

        }
    }
}
