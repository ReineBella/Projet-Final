using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
    public static class ListCours
    {
        //Attributs et Propriétés
        public static List<Cours> ListeCours = new List<Cours>();

        // Méthode FindCours
        public static bool FindCours(int num)
        {
            foreach(Cours c in ListeCours)
            {
                if (c.NumCours == num) return true;
            }
            return false;
        }

        // Méthode AddCours
        public static void AddCours(Cours c)
        {
            if (!FindCours(c.NumCours))
                ListeCours.Add(c);
            else Console.WriteLine("Ce cours existe déjà");
        }

        // Méthode AddCours
        public static void AddCours(int num, int code, String titre)
        {
            if (!FindCours(num))
                ListeCours.Add(new Cours(num, code, titre);
            else Console.WriteLine("Ce cours existe déjà");
        }

    }
}
