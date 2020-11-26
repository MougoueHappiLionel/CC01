using System;
using CC01.BO;
using CC01.DAL;
using CC01.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace CC01
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "y";
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------Ajoutez des étudiants----------------------------");
                Console.Write("Entrer le nom  \t:");
                string nom = Console.ReadLine();
                Console.Write("Entrer le prenom \t:");
                string prenom = Console.ReadLine();
                Console.Write("Entrer l'identifiant \t:");
                string identifiant = Console.ReadLine();
                Console.Write("Entrer votre contact \t:");
                int contact = int.Parse(Console.ReadLine());
                Console.Write("Entrer l'email \t:");
                string email = Console.ReadLine();

                Etudiant etudiant = new Etudiant(nom, prenom, identifiant, contact, email);
                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                etudiantBLO.CreateProduct(etudiant);

                IEnumerable<Etudiant> etudiants = etudiantBLO.GetAllEtudiant();
                foreach (Etudiant p in etudiants)
                {
                    Console.WriteLine($"{p.Nom}\t{p.Prenom}\t{p.Email}\t{p.Contact}");
                }

                Console.Write("Create another product ?[y/n]:");
                choice = Console.ReadLine();
            }
            while (choice.ToLower() != "n");
            Console.WriteLine("Program end !");

            Console.ReadKey();
        }
    }
    
}
