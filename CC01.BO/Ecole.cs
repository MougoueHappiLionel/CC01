using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {
        public string Nom { get; set; }
        public string SiteWeb { get; set; }
        public int Telephone { get; set; }

        public Ecole()
        {

        }

        public Ecole(string nom, string site, int telephone)
        {
            Nom = nom;
            SiteWeb = site;
            Telephone = telephone;
        }
    }
}
