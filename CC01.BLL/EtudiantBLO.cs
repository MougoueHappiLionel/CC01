using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EtudiantBLO
    {
        EtudiantDAO etudiantRepo;

        public EtudiantBLO()
        {
        }

        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }
        public void CreateProduct(Etudiant etudiant)
        {
            etudiantRepo.Add(etudiant);
        }

        public void DeleteProduct(Etudiant etudiant)
        {
            etudiantRepo.Remove(etudiant);
        }


        public IEnumerable<Etudiant> GetAllEtudiant()
        {
            return etudiantRepo.Find();
        }
    }
}
