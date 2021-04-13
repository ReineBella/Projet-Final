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
            List<Notes> NotesEtudiant=null;
            foreach(Notes n in ListeNotes)
            {
                if (n.NumeroEtudiant == num) NotesEtudiant.Add(n);
            }
            return NotesEtudiant;
        }

        // Méthode AfficheNotesEtudiants
        public void AfficheNotesEtudiants(int num)
        {
            List<Notes> ListeET= this.NotesEtudiants(num);
            int NumEt = ListeET[0].NumeroEtudiant;
            String Nom = Classe.NomEtudiant(NumEt);
            String Prenom = Classe.PrenomEtudiant(NumEt);
            
            Console.WriteLine("Notes pour Etudiant: "+ NumEt
                    +" "+ Nom +" "+Prenom+"\n");
            
            for (int i=0; i < ListeET.Count; i++)
            {
                Console.WriteLine(ListeET[i].NumCours+" "+ ListeET[i].Note+"\n");
            }
        }

    }
}
