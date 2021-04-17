using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEtudiants
{
   public  class ListNotes
    {
        // Attributs et propriétés
        public List<Notes> ListeNotes = new List<Notes>();

        // Méthode AddNotes
        public void AddNotes(Notes note)
        {            
            this.ListeNotes.Add(note);
            
        }
     
        // Surharge Méthode AddNotes
        public void AddNotes(int num, int code, double note)
        {
            this.ListeNotes.Add(new Notes(num, code, note));
        }

        // Méthode NotesEtudiant
        public List<Notes> NotesEtudiants(int num)
        {
            List<Notes> NotesparEtudiant = new List<Notes>();
            foreach(Notes n in this.ListeNotes)
            {
                if (n.NumEtudiant == num) NotesparEtudiant.Add(n);
            }
            return NotesparEtudiant;
        }

        // Méthode FindNotes; Cherche ou vérifie si ces notes sont déjà saisies
        public bool FindNotes(int num, int numcours)
        {
            foreach (Notes e in ListeNotes)
            {
                if (e.NumEtudiant == num && e.NumCours == numcours) return true;
            }
            return false;
        }
    }
}
