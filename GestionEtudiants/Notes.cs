using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
   public class Notes
    {
        // Attributs et Propriétés
        public int NumEtudiant { get; set; }
        public int NumCours { get; set; }
        public double Note { get; set; }
      

        // Constructeur
        public Notes(int num, int code, double note)
        {
            this.NumEtudiant = num;
            this.NumCours = code;
            this.Note = note;
        }
                
    }
}
