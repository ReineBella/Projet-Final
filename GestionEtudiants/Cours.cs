using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GestionEtudiants
{
    public class Cours
    {
        
        // Attributs et propriétés
        public int NumCours { get; set; }
        public int CodeCours { get; set; }
        public string TitreCours { get; set; }
       
        // Constructeur
        public Cours(int num, int code, String titre)
        {
            this.NumCours = num;
            this.CodeCours = code;
            this.TitreCours = titre;
           
        }



    }
}
