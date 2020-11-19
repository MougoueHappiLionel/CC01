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
        public DateTime Date_Naissance { get; set; }
        public string Lieu { get; set; }
        public string Identifiant { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
        public byte[] Photo_profil { get; set; }
        public string Logo { get; set; }
        public string Code_barre { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string nom, string prenom, DateTime date_naissance, string lieu,
            string identifiant, int contact, string email, byte[] pp, string logo, string codebar)
        {
            Nom = nom;
            Prenom = prenom;
            Date_Naissance = date_naissance;
            Lieu = lieu;
            Identifiant = identifiant;
            Contact = contact;
            Email = email;
            Photo_profil = pp;
            Logo = logo;
            Code_barre = codebar;
        }
    }
}
