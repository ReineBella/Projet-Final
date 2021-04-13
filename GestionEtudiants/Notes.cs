using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
   public class Notes
    {
        // Attributs et Propriétés
        private int numeroetudiant;
        private int numCours;
        private double note;

        // Propriétés
        public int NumeroEtudiant
        {
            get { return numeroetudiant;}
            set
            {
                if (Classe.FindEtudiant(value)) NumeroEtudiant = value;
            }
        }

        public int NumCours
        {
            get { return numCours; }
            set
            {
                if (ListCours.FindCours(value)) NumCours = value;
            }
        }

        public double Note
        {
            get { return note; }
            set { Note = value; }
        }

        // Constructeur
        public Notes(int num, int code, double note)
        {
            this.NumeroEtudiant = num;
            this.NumCours = code;
            this.Note = note;
        }
    }
}
