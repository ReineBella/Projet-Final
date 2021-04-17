using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GestionEtudiants
{
    public class Etudiant
    {
      /*  private TextBox numeroEtudiant;
        private TextBox nom;
        private TextBox prenom;
    */ 

        // Attribut et propriétés
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
       

        // Contructeur
        public Etudiant (int num, string nom, string prenom)
        {
            this.NumeroEtudiant = num;
            this.Nom = nom;
            this.Prenom = prenom;
            
        }

      
        public override string ToString()
        {
            string str = "    AFFICHAGE ETUDIANT  "+"\n";
            return str+="N° Etudiant: "+this.NumeroEtudiant+"\n"
                       +"Nom:         "+this.Nom+"\n"
                       +"Prénom:      "+this.Prenom;
        }
    }
}
