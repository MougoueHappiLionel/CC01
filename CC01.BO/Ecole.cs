using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {
        public string NomEcole { get; set; }
        public string SiteEcole { get; set; }
        public int Telephone { get; set; }

        public Ecole()
        {

        }

        public Ecole(string nomecole, string siteecole, int telephone)
        {
            NomEcole = nomecole;
            SiteEcole = siteecole;
            Telephone = telephone;
        }
    }
}
