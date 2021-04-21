using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
    public class Classe
    {
        // Attributs
        public List<Etudiant> Etudiants = new List<Etudiant>();

        // Méthode FindEtudiant; Cherche ou vérifie si l'étudiant exist dans la liste
        public bool FindEtudiant(int num)
        {
            foreach (Etudiant e in Etudiants)
            {
                if (e.NumeroEtudiant == num) return true;
            }
            return false;
        }

        // Méthode TrouverEtudiant; Cherche ou vérifie si l'étudiant exist dans la liste
        public Etudiant TrouverEtudiant(int num)
        {
            foreach (Etudiant e in Etudiants)
            {
                if (e.NumeroEtudiant == num) return e;
            }
            return null;
        }


        // Methode Ajouter Etudiant
        public void AddEtudiant(Etudiant e)
        {
            if (!FindEtudiant(e.NumeroEtudiant))
                Etudiants.Add(e);

        }

        // Surcharge de la Méthode AddEtudiant
        public void AddEtudiant(int num, string nom, string prenom)
        {
            if (!FindEtudiant(num))
                Etudiants.Add(new Etudiant(num, nom, prenom));
            else Console.WriteLine("Cet étudiant existe déjà ");
        }

        public override string ToString()
        {
            string str = "   LISTE ETUDIANTS" + "\n";
            for (int i = 0; i < Etudiants.Count; i++)
            {
                str += "|" + Etudiants[i].NumeroEtudiant + "|" + Etudiants[i].Nom
                    + "|" + Etudiants[i].Prenom;
            }
            return str;
        }




    }
}
