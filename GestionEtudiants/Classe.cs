using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
    public static  class Classe
    {
        // Attributs
        public static List<Etudiant> Etudiants = new List<Etudiant>();

        // Méthode FindEtudiant; Cherche ou vérifie si l'étudiant exist dans la liste
        public static bool  FindEtudiant(int num)
        {
            foreach (Etudiant e in Etudiants)
            {
                if (e.NumeroEtudiant == num) return true;
            }
            return false;
        }

        // Méthode NomEtudiant: Trouver le nom d'un étudant le num est passé en paramètres
        public static String NomEtudiant(int num)
        {
            foreach (Etudiant e in Etudiants)
            {
                if (e.NumeroEtudiant == num) return e.Nom;
            }
            return null;
        }

        // Méthode PrenomEtudiant: Trouver le prenom d'un étudant le num est passé en paramètres
        public static String PrenomEtudiant(int num)
        {
            foreach (Etudiant e in Etudiants)
            {
                if (e.NumeroEtudiant == num) return e.Prenom;
            }
            return null;
        }




        // Methode Ajouter Etudiant
        public static void AddEtudiant(Etudiant e)
        {
            if(!FindEtudiant(e.NumeroEtudiant))
            Etudiants.Add(e);
            else Console.WriteLine("Cet étudiant existe déjà ");
        }

        // Surcharge de la Méthode AddEtudiant
        public static void AddEtudiant(int num, String nom, String prenom)
        {
            if(!FindEtudiant(num))
            Etudiants.Add(new Etudiant(num, nom, prenom));
            else Console.WriteLine("Cet étudiant existe déjà ");
        }

          

     
    }
}
