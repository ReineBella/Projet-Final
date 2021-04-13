using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
    public class Etudiant
    {
        // Attribut et propriétés
        public int NumeroEtudiant { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }

        // Contructeur
        public Etudiant (int num, String nom, String prenom)
        {
            this.NumeroEtudiant = num;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        //
    }
}
