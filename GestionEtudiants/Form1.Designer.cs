
namespace GestionEtudiants
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NouvelEtudiant = new System.Windows.Forms.Label();
            this.NumeroEtudiant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNumCours = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.TxtCodeCours = new System.Windows.Forms.TextBox();
            this.Titre = new System.Windows.Forms.Label();
            this.TxtTitreCours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNumEtudiantNote = new System.Windows.Forms.TextBox();
            this.TxtNumCoursNote = new System.Windows.Forms.TextBox();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.btnEtudiant = new System.Windows.Forms.Button();
            this.bntCours = new System.Windows.Forms.Button();
            this.bntNote = new System.Windows.Forms.Button();
            this.listBoxToString = new System.Windows.Forms.ListBox();
            this.btnAfficherEtudiants = new System.Windows.Forms.Button();
            this.TextNumNoteEt = new System.Windows.Forms.TextBox();
            this.bntNotesParEtudiant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NouvelEtudiant
            // 
            this.NouvelEtudiant.AutoSize = true;
            this.NouvelEtudiant.BackColor = System.Drawing.SystemColors.Highlight;
            this.NouvelEtudiant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NouvelEtudiant.Location = new System.Drawing.Point(38, 13);
            this.NouvelEtudiant.Name = "NouvelEtudiant";
            this.NouvelEtudiant.Size = new System.Drawing.Size(175, 20);
            this.NouvelEtudiant.TabIndex = 0;
            this.NouvelEtudiant.Text = "Création Nouvel Etudiant";
            this.NouvelEtudiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumeroEtudiant
            // 
            this.NumeroEtudiant.Location = new System.Drawing.Point(125, 35);
            this.NumeroEtudiant.Name = "NumeroEtudiant";
            this.NumeroEtudiant.Size = new System.Drawing.Size(125, 27);
            this.NumeroEtudiant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "N°Etudiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(125, 68);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(125, 27);
            this.Nom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prénom";
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(125, 104);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(125, 27);
            this.Prenom.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(38, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Création Nouveau Cours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "N°Cours";
            // 
            // TxtNumCours
            // 
            this.TxtNumCours.Location = new System.Drawing.Point(107, 221);
            this.TxtNumCours.Name = "TxtNumCours";
            this.TxtNumCours.Size = new System.Drawing.Size(125, 27);
            this.TxtNumCours.TabIndex = 15;
            this.TxtNumCours.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(38, 254);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(63, 20);
            this.Code.TabIndex = 16;
            this.Code.Text = "N°Cours";
            // 
            // TxtCodeCours
            // 
            this.TxtCodeCours.Location = new System.Drawing.Point(107, 251);
            this.TxtCodeCours.Name = "TxtCodeCours";
            this.TxtCodeCours.Size = new System.Drawing.Size(125, 27);
            this.TxtCodeCours.TabIndex = 17;
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Location = new System.Drawing.Point(38, 283);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(43, 20);
            this.Titre.TabIndex = 18;
            this.Titre.Text = "Titre ";
            // 
            // TxtTitreCours
            // 
            this.TxtTitreCours.Location = new System.Drawing.Point(107, 283);
            this.TxtTitreCours.Name = "TxtTitreCours";
            this.TxtTitreCours.Size = new System.Drawing.Size(125, 27);
            this.TxtTitreCours.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(286, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Saisie des Notes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "N°Etudiant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Note";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "N°Cours";
            // 
            // TxtNumEtudiantNote
            // 
            this.TxtNumEtudiantNote.Location = new System.Drawing.Point(363, 39);
            this.TxtNumEtudiantNote.Name = "TxtNumEtudiantNote";
            this.TxtNumEtudiantNote.Size = new System.Drawing.Size(125, 27);
            this.TxtNumEtudiantNote.TabIndex = 26;
            // 
            // TxtNumCoursNote
            // 
            this.TxtNumCoursNote.Location = new System.Drawing.Point(363, 72);
            this.TxtNumCoursNote.Name = "TxtNumCoursNote";
            this.TxtNumCoursNote.Size = new System.Drawing.Size(125, 27);
            this.TxtNumCoursNote.TabIndex = 27;
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(363, 107);
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(125, 27);
            this.TxtNote.TabIndex = 28;
            // 
            // btnEtudiant
            // 
            this.btnEtudiant.Location = new System.Drawing.Point(38, 144);
            this.btnEtudiant.Name = "btnEtudiant";
            this.btnEtudiant.Size = new System.Drawing.Size(115, 29);
            this.btnEtudiant.TabIndex = 29;
            this.btnEtudiant.Text = "Saisie Etudiant";
            this.btnEtudiant.UseVisualStyleBackColor = true;
            this.btnEtudiant.Click += new System.EventHandler(this.btnEtudiant_Click);
            // 
            // bntCours
            // 
            this.bntCours.Location = new System.Drawing.Point(38, 316);
            this.bntCours.Name = "bntCours";
            this.bntCours.Size = new System.Drawing.Size(147, 29);
            this.bntCours.TabIndex = 30;
            this.bntCours.Text = "Saisie/Affichage";
            this.bntCours.UseVisualStyleBackColor = true;
            this.bntCours.Click += new System.EventHandler(this.bntCours_Click);
            // 
            // bntNote
            // 
            this.bntNote.Location = new System.Drawing.Point(286, 144);
            this.bntNote.Name = "bntNote";
            this.bntNote.Size = new System.Drawing.Size(134, 29);
            this.bntNote.TabIndex = 31;
            this.bntNote.Text = "Saisie/Affichage";
            this.bntNote.UseVisualStyleBackColor = true;
            this.bntNote.Click += new System.EventHandler(this.bntNote_Click);
            // 
            // listBoxToString
            // 
            this.listBoxToString.FormattingEnabled = true;
            this.listBoxToString.ItemHeight = 20;
            this.listBoxToString.Location = new System.Drawing.Point(567, 13);
            this.listBoxToString.Name = "listBoxToString";
            this.listBoxToString.Size = new System.Drawing.Size(404, 464);
            this.listBoxToString.TabIndex = 33;
            // 
            // btnAfficherEtudiants
            // 
            this.btnAfficherEtudiants.Location = new System.Drawing.Point(159, 143);
            this.btnAfficherEtudiants.Name = "btnAfficherEtudiants";
            this.btnAfficherEtudiants.Size = new System.Drawing.Size(115, 29);
            this.btnAfficherEtudiants.TabIndex = 34;
            this.btnAfficherEtudiants.Text = "Saisie/Afficher";
            this.btnAfficherEtudiants.UseVisualStyleBackColor = true;
            this.btnAfficherEtudiants.Click += new System.EventHandler(this.btnAfficherEtudiants_Click);
            // 
            // TextNumNoteEt
            // 
            this.TextNumNoteEt.Location = new System.Drawing.Point(425, 184);
            this.TextNumNoteEt.Name = "TextNumNoteEt";
            this.TextNumNoteEt.PlaceholderText = "Saisir N° Etudiant";
            this.TextNumNoteEt.Size = new System.Drawing.Size(125, 27);
            this.TextNumNoteEt.TabIndex = 36;
            // 
            // bntNotesParEtudiant
            // 
            this.bntNotesParEtudiant.Location = new System.Drawing.Point(287, 184);
            this.bntNotesParEtudiant.Name = "bntNotesParEtudiant";
            this.bntNotesParEtudiant.Size = new System.Drawing.Size(133, 29);
            this.bntNotesParEtudiant.TabIndex = 37;
            this.bntNotesParEtudiant.Text = "Notes/Etudiant";
            this.bntNotesParEtudiant.UseVisualStyleBackColor = true;
            this.bntNotesParEtudiant.Click += new System.EventHandler(this.bntNotesParEtudiant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 487);
            this.Controls.Add(this.bntNotesParEtudiant);
            this.Controls.Add(this.TextNumNoteEt);
            this.Controls.Add(this.btnAfficherEtudiants);
            this.Controls.Add(this.listBoxToString);
            this.Controls.Add(this.bntNote);
            this.Controls.Add(this.bntCours);
            this.Controls.Add(this.btnEtudiant);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.TxtNumCoursNote);
            this.Controls.Add(this.TxtNumEtudiantNote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtTitreCours);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.TxtCodeCours);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.TxtNumCours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroEtudiant);
            this.Controls.Add(this.NouvelEtudiant);
            this.Name = "Form1";
            this.Text = "N°Etudiant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NouvelEtudiant;
        private System.Windows.Forms.TextBox NumeroEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNumCours;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox TxtCodeCours;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.TextBox TxtTitreCours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNumEtudiantNote;
        private System.Windows.Forms.TextBox TxtNumCoursNote;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.Button btnEtudiant;
        private System.Windows.Forms.Button bntCours;
        private System.Windows.Forms.Button bntNote;
        private System.Windows.Forms.ListBox listBoxToString;
        private System.Windows.Forms.Button btnAfficherEtudiants;
        private System.Windows.Forms.TextBox TextNumNoteEt;
        private System.Windows.Forms.Button bntNotesParEtudiant;
    }
}

