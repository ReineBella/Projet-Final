using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
    public class ListCours
    {
        //Attributs et Propriétés
        public List<Cours> ListeCours = new List<Cours>();

        // Méthode FindCours
        public bool FindCours(int num)
        {
            foreach(Cours c in ListeCours)
            {
                if (c.NumCours == num) return true;
            }
            return false;
        }

        // TrouverCours : Retoune toute l'objet Cours
        public Cours TrouverCours(int num)
        {
            foreach (Cours c in ListeCours)
            {
                if (c.NumCours == num) return c;
            }

            return null;
        }
       

        // Méthode AddCours
        public void AddCours(Cours c)
        {
            if (!FindCours(c.NumCours))
                ListeCours.Add(c);
            
        }

        // Méthode AddCours
        public void AddCours(int num, int code, String titre)
        {
            if (!FindCours(num))
                ListeCours.Add(new Cours(num, code, titre));
            
        }

    }
}
