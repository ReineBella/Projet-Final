using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GestionEtudiants
{
    public partial class Form1 : Form
    {
        private const int MIN = 1000;
        private const int MAX = 9999;
        // Création d'une et des étudiants
        public Classe cl1 = new Classe();
        public Etudiant et1 = new Etudiant(2694001, "Philippe  ", "Laurent  ");
        
        Etudiant et2 = new Etudiant(2694002, "Wikkie    ", "Jeanne   ");
        Etudiant et3 = new Etudiant(2694003, "Mohamed   ", "Salim    ");
        Etudiant et4 = new Etudiant(2694004, "Fatima    ", "Cisse    ");
        Etudiant et5 = new Etudiant(2694005, "Declerc   ", "Jacques  ");
        Etudiant et6 = new Etudiant(2694006, "Degaul    ", "Louise   ");
        Etudiant et7 = new Etudiant(2694007, "Mouhamoud ", "Josée    ");
        Etudiant et8 = new Etudiant(2694007, "Jacques   ", "Paul     ");

        // Création d'une listCours et des cours
        public ListCours lc1 = new ListCours();
        Cours c1 = new Cours(101, "25625", "Englis II");
        Cours c2 = new Cours(102, "25906", "Intro Base de données");
        Cours c3 = new Cours(103, "25769", "Statistique");
        Cours c4 = new Cours(104, "25907", "Application Android");
        Cours c5 = new Cours(105, "25914", "Assurance Qualité Logiciel");
        Cours c6 = new Cours(106, "25978", "Programmation C#");

        // Création d'une liste de notes
        public ListNotes lnotes = new ListNotes();
        Notes n1 = new Notes(2694001, 25906, 85.50);
        Notes n2 = new Notes(2694001, 25769, 95.50);
        Notes n3 = new Notes(2694002, 25914, 78.00);
        Notes n4 = new Notes(2694001, 25907, 98.50);
        Notes n5 = new Notes(2694002, 25906, 85.50);
        Notes n6 = new Notes(2694003, 25769, 95.50);
        Notes n7 = new Notes(2694002, 25914, 78.00);
        Notes n8 = new Notes(2694004, 25907, 98.50);

        public Form1()
        {
            InitializeComponent();
            
            this.Text = "Gestion des Etudiants";
            // Ajout des objets dans les listes
            cl1.AddEtudiant(et1);
            cl1.AddEtudiant(et2);
            cl1.AddEtudiant(et3);
            cl1.AddEtudiant(et4);
            cl1.AddEtudiant(et5);
            cl1.AddEtudiant(et6);
            cl1.AddEtudiant(et7);
            cl1.AddEtudiant(et8);

            lc1.AddCours(c1);
            lc1.AddCours(c2);
            lc1.AddCours(c3);
            lc1.AddCours(c4);
            lc1.AddCours(c5);
            lc1.AddCours(c6);

            lnotes.AddNotes(n1);
            lnotes.AddNotes(n2);
            lnotes.AddNotes(n3);
            lnotes.AddNotes(n4);
            lnotes.AddNotes(n5);
            lnotes.AddNotes(n6);
            lnotes.AddNotes(n7);
            lnotes.AddNotes(n8);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEtudiant_Click(object sender, EventArgs e)
        {
            
            // Initialisation du ListBox
            listBoxToString.Items.Clear();

            // Création de l'étudiant avec les attributs saisis
              
            if (!((String)(NumeroEtudiant.Text) == "" && (String)(Nom.Text) == ""
                 && (String)(Prenom.Text) == ""))
            {
                Random rand = new Random();

                int numeroEtudiant = rand.Next(MIN+99000, MAX+990000);
                Etudiant Et = new Etudiant(numeroEtudiant,
                (String)Nom.Text, (String)Prenom.Text);
                cl1.AddEtudiant(Et);
                Et.EnregisterEtudiant();
            }
           


            // Affichage de l'étudiant crée avec le format
            string str = "    AFFICHAGE ETUDIANT  ";
            listBoxToString.Items.Add(str);
            str = "----------------------------------";
            listBoxToString.Items.Add(str);

            str = "N° Etudiant: " + NumeroEtudiant.Text.ToString();
            listBoxToString.Items.Add(str);
            str = "Nom:         " + Nom.Text.ToString();
            listBoxToString.Items.Add(str);
            str =  "Prénom:     " + Prenom.Text.ToString();
            listBoxToString.Items.Add(str);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntCours_Click(object sender, EventArgs e)
        {             
            
            listBoxToString.Items.Clear();

            if (!((String)(TxtNumCours.Text) == "" && (String)(TxtCodeCours.Text) == ""
                && (String)(TxtTitreCours.Text) == ""))
            {
                Random rand = new Random();
                int numeroCours = rand.Next(MIN, MAX);
                Cours Co = new Cours(numeroCours,
               (TxtCodeCours.Text), (string)TxtTitreCours.Text);
                lc1.AddCours(Co);
                Co.creerCours();
            }
                
           
            string str = "   LISTE COURS  ";
            listBoxToString.Items.Add(str);
            str = "-----------------------------------------";
            listBoxToString.Items.Add(str);

            for (int i = 0; i < lc1.ListeCours.Count; i++)
            {
                str = "   | " + lc1.ListeCours[i].NumCours + " | " + lc1.ListeCours[i].CodeCours
                + "  " + lc1.ListeCours[i].TitreCours;
                listBoxToString.Items.Add(str);
                str = "    ----------------------------------------";
                listBoxToString.Items.Add(str);
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAfficherEtudiants_Click(object sender, EventArgs e)
        {
           
            listBoxToString.Items.Clear();

            if (!((String)(NumeroEtudiant.Text)=="" && (String)(Nom.Text)== ""
               && (String)(Prenom.Text)== ""))               
            {
                Etudiant Et = new Etudiant(int.Parse(NumeroEtudiant.Text),
                (String)Nom.Text, (String)Prenom.Text);
                cl1.AddEtudiant(Et);
            }
                  
                       
            string str = "   LISTE ETUDIANTS  ";
            listBoxToString.Items.Add(str);
            str = "----------------------------------";
            listBoxToString.Items.Add(str);
                        
            for (int i = 0; i < cl1.Etudiants.Count; i++)
            {
                str = "   | " + cl1.Etudiants[i].NumeroEtudiant + " | " + cl1.Etudiants[i].Nom
                +"  " + cl1.Etudiants[i].Prenom;
                listBoxToString.Items.Add(str);
                str = "    -----------------------------------";
                listBoxToString.Items.Add(str);
            }

            List<string> listStudent = new List<string>();

            listStudent = (new Etudiant().imprimerEtudiantListe());

            for (int i = 0; i < listStudent.Count; i++)
            {
                listBoxToString.Items.Add(listStudent[i]);
            }

            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bntNote_Click(object sender, EventArgs e)
        {
           
            listBoxToString.Items.Clear();

           


            try
            {
            if (!((String)(TxtNumEtudiantNote.Text) == "" && 
                    (String)(TxtNumCoursNote.Text) == ""&& (String)(TxtNote.Text) == ""))
            
            {
                if (!lnotes.FindNotes(int.Parse(TxtNumEtudiantNote.Text),
                int.Parse(TxtNumCoursNote.Text))) 
                {                 
                    Notes n = new Notes(int.Parse(TxtNumEtudiantNote.Text),
                    int.Parse(TxtNumCoursNote.Text), Double.Parse(TxtNote.Text));
                    lnotes.AddNotes(n);
                        int n1 = 0;
                        bool verification = n.checkCourse(ref n1);
                        string text = "";

                        if (verification)
                        {
                            text = "Note enregistrée! " +n1;
                        }
                        else
                        {
                            text = "Une erreur est survenue!";
                        }
                        listBoxToString.Items.Add(text);
               
                }
                else MessageBox.Show("Ces notes sont déjà saisies");
                 
            }
            } catch (System.FormatException)
            {
                MessageBox.Show("Bien saisir les notes ex: 95,50");
            }

            string str = "   LISTE DES NOTES  ";
            listBoxToString.Items.Add(str);
            str = "----------------------------------";
            listBoxToString.Items.Add(str);

            for (int i = 0; i < lnotes.ListeNotes.Count; i++)
            {
                str = "   | " + lnotes.ListeNotes[i].NumEtudiant + " | " 
                              + lnotes.ListeNotes[i].NumCours
                              + " | " + lnotes.ListeNotes[i].Note;

                listBoxToString.Items.Add(str);
                str = "    -----------------------------------";
                listBoxToString.Items.Add(str);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntNotesParEtudiant_Click(object sender, EventArgs e)
        {
          
            listBoxToString.Items.Clear();
            // Récupération du Numéro étudiant saisie sur l'écran
            int numEt = int.Parse(TextNumNoteEt.Text);

            List<string> releve = new List<string>();

            releve = (new Etudiant().afficherRelever(numEt));

            for(int i = 0; i < releve.Count; i++)
            {
                listBoxToString.Items.Add(releve[i]);
            }
            /*
            // Récupération de la liste des notes de l'étudiant
            List<Notes> listpEt = lnotes.NotesEtudiants(numEt);


            // Récupération du Nom et du Prénom de l'étudiant ayant le numéro saisie
            Etudiant Et = cl1.TrouverEtudiant(numEt);
            string nomEt = Et.Nom;
            string prenomEt = Et.Prenom;
            
            // Affichage Tête de page
            string str = "   RELEVE DE NOTES  ";
            listBoxToString.Items.Add(str);
            str = "----------------------------------";
            listBoxToString.Items.Add(str);
            str = " "+ numEt + "   "+ nomEt +"  "+ prenomEt;
            listBoxToString.Items.Add(str);
            str = "----------------------------------";
            listBoxToString.Items.Add(str);
            str = "";
                        
            
            // Affichage des notes de l'Etudiant
            foreach (Notes ne in listpEt)
            {
                int numCourEt = ne.NumCours;
                Cours cEt = lc1.TrouverCours(numCourEt);
                //string titreCe = cEt.TitreCours;

                str = "Matière:     " + ne.NumCours + " ";
                //+ titreCe;
                listBoxToString.Items.Add(str);
                str = "Note:        " + ne.Note;
                listBoxToString.Items.Add(str);
                str = "----------------------------------";
                listBoxToString.Items.Add(str);
            }  */     
        }
            
    }
}
  

