using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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

        public bool checkCourse(ref int numeroLine)
        {
            bool isIn = false;
            try
            {
               const string  FICHIER = "../../../file/numeroCours.txt";
                StreamReader lecture = new StreamReader(FICHIER);
                String line = lecture.ReadLine();
                int compteur = 0;

                while (line != null)
                {
                    compteur++;

                    if(this.NumCours + "" == line)
                    {
                        numeroLine = compteur;
                        isIn = true;
                    }

                    lecture.ReadLine();
                }
                lecture.Close();

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return isIn;
        }
        public bool checkStudent()
        {
            bool isIn = false;
            try
            {
                string fichier = "../../../file/"+ this.NumEtudiant +".txt";
               

                if (File.Exists(fichier))
                {
                    isIn = true;
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return isIn;
        }

        public bool isValide(ref int numeroLine)
        {
            return (checkCourse(ref numeroLine) == true && checkStudent()==true)?
                true:false;
        }

        public string getLineFile(int numberLine)
        {
            String line = "";
            int compteur = 0;
            try
            {
                String fichier = "../../../file/listeCours.txt";
                StreamReader lecture = new StreamReader(fichier);
                String laLigne = lecture.ReadLine();

                while (laLigne != null)
                {
                    compteur++;

                    if (compteur == numberLine)
                    {
                        line = laLigne;
                    }
                    lecture.ReadLine();
                }
                lecture.Close();

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return line;

        }

        public string imprimerEtudiant()
        {
            string line;
            string text = "";
            try
            {
                StreamReader lecture = new StreamReader("../../../file/"+ this.NumEtudiant +".txt");
                line = lecture.ReadLine();
                while (line != null)
                {
                    text += line + "\n";
                    line = lecture.ReadLine();
                }


                lecture.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return text;
        }

        public bool ajouterNote()
        {
            bool isSaved = false;
            try
            {
                int numeroLigne = 0;
                if (this.isValide(ref numeroLigne) == true)
                {
                    string oldText = this.imprimerEtudiant();
                    string line = this.getLineFile(numeroLigne);
                    string fichier = "../../../file/" + this.NumEtudiant + ".txt";
                    StreamWriter ecrire = new StreamWriter(fichier);

                    ecrire.WriteLine(oldText + "\n" +  line);
                    isSaved = true;
                    ecrire.Close();

                }

               

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return isSaved;
        }
                
    }
}
