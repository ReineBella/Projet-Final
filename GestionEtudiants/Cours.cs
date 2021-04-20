using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GestionEtudiants
{
    public class Cours
    {
        
        // Attributs et propriétés
        public int NumCours { get; set; }
        public string CodeCours { get; set; }
        public string TitreCours { get; set; }
       
        // Constructeur
        public Cours(int num, string code, String titre)
        {
            this.NumCours = num;
            this.CodeCours = code;
            this.TitreCours = titre;
           
        }

        private string printCourse()
        {
            
            string txt = "";

            try
            {

                string fichierCours = "../../../file/listeCours.txt";
                StreamReader lecture = new StreamReader(fichierCours);
                string line = lecture.ReadLine();

                while(line != null)
                {
                    txt += line + "\n";

                    line = lecture.ReadLine();
                }

                lecture.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return txt;
        }
        private string printCourseNumber()
        {

            string txt = "";

            try
            {

                string fichierNumeroCours = "../../../file/numeroCours.txt";
                StreamReader lecture = new StreamReader(fichierNumeroCours);
                string line = lecture.ReadLine();

                while (line != null)
                {
                    txt += line + "\n";

                    line = lecture.ReadLine();
                }

                lecture.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return txt;
        }
        public void creerCours()
        {
            try
            {
                string inialeText = this.printCourse();
                string inialeTextNum = this.printCourseNumber();
                string fichierCours = "../../../file/listeCours.txt";
                string fichierNumeroCours = "../../../file/numeroCours.txt";

                StreamWriter fichierCoursEcrire = new StreamWriter(fichierCours),
                    fichierNumeroCoursEcrire = new StreamWriter(fichierNumeroCours);

                string texte = this.NumCours + " " + this.CodeCours + " " + this.TitreCours;
                string textNum = this.NumCours + "";

                texte = inialeText + texte;
                textNum = inialeTextNum + textNum;

                fichierCoursEcrire.WriteLine(texte);
                fichierNumeroCoursEcrire.WriteLine(textNum);

                fichierCoursEcrire.Close();
                fichierNumeroCoursEcrire.Close();
                





            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



    }
}
