using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GestionEtudiants
{
    public class Etudiant
    {

        // Attribut et propriétés
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }


        // Contructeur
        public Etudiant() {

            this.NumeroEtudiant = 0;
            this.Nom = "inconnu";
            this.Prenom = "inconnu";
            } 
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

        public List<string> afficherRelever(int numero)
        {
            List<string> etudiantContener = new List<string>();
            string fichier = "../../../file/" + numero + ".txt";
            string line;

            try
            {
                if (File.Exists(fichier))
                {
                 StreamReader lecture = new StreamReader(fichier);
                   line = lecture.ReadLine();
                   while (line != null)
                     {
                          etudiantContener.Add(line);
                           line = lecture.ReadLine();
                       }
                    lecture.Close();
                }
                else {
                    
                        etudiantContener.Add("Numero d'etudiant invalide !!");
                    }
               


                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return etudiantContener;

        }

        private void creationFichierEtudiant()
        {
           
            
            try
            {
               
                
                StreamWriter write = new StreamWriter("../../../file/"+ this.NumeroEtudiant + ".txt");
             
                Console.ReadLine();
                String text = "N° Etudiant: " + this.NumeroEtudiant + "\n"
                       + "Nom:         " + this.Nom + "\n"
                       + "Prénom:      " + this.Prenom + "\n";

                
                write.WriteLine(text);
               

                write.Close();
            }
            catch (Exception e)


            {
                Console.WriteLine("Erreur: " + e.Message);
            }

            
        }
        public List<string> imprimerEtudiantListe()
        {
            string line;
            string text = "";
            List<string> etudiant = new List<string>();
            try
            {
                StreamReader lecture = new StreamReader("../../../file/FichierEtudiant.txt");
                line = lecture.ReadLine();
                while (line != null)
                {
                     etudiant.Add(line);
                    line = lecture.ReadLine();
                }


                lecture.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return etudiant;
        }
        public string imprimerEtudiant()
        {
            string line;
            string text = "";
            try
            {
                StreamReader lecture = new StreamReader("../../../file/FichierEtudiant.txt");
                line = lecture.ReadLine();
                while (line != null)
                {
                    text +=  line + "\n";
                    line = lecture.ReadLine();
                }

                
                lecture.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return text;
        }
        public bool EnregisterEtudiant()
        {
            bool res = false;
            try
            {
                //const String fichier = "FichierEtudiant.txt";
                string initialText = this.imprimerEtudiant();
                StreamWriter write = new StreamWriter("../../../file/FichierEtudiant.txt");
               // StreamReader read = new StreamReader(fichier);

               // String line;
                //String concat = "";

               // line = read.ReadLine();
               // while(line != null){
               //     concat = line + concat;
               // }
               // read.Close();
                Console.ReadLine();
                String text = "N° Etudiant: " + this.NumeroEtudiant + "\n"
                       + "Nom:         " + this.Nom + "\n"
                       + "Prénom:      " + this.Prenom + "\n";

                //  concat += text;
                text = initialText +  text ;
                write.WriteLine(text);
                res = true;

                write.Close();

                this.creationFichierEtudiant();
            } catch (Exception e)


            {
                Console.WriteLine("Erreur: "+e.Message);
            }

            return res; 
           
        }
    }
}
