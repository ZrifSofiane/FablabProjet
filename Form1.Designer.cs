namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.NomTexte = new System.Windows.Forms.TextBox();
            this.PrenomTexte = new System.Windows.Forms.TextBox();
            this.Ecole = new System.Windows.Forms.Label();
            this.ESILV = new System.Windows.Forms.RadioButton();
            this.IIM = new System.Windows.Forms.RadioButton();
            this.EMLV = new System.Windows.Forms.RadioButton();
            this.ButImpression = new System.Windows.Forms.Label();
            this.ImpressionText = new System.Windows.Forms.TextBox();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.DateListe = new System.Windows.Forms.DateTimePicker();
            this.Quantite = new System.Windows.Forms.Label();
            this.QuantiteNombre = new System.Windows.Forms.NumericUpDown();
            this.FichierSource = new System.Windows.Forms.Label();
            this.Informations = new System.Windows.Forms.GroupBox();
            this.EmailTexte = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Projet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texteNomFichier = new System.Windows.Forms.TextBox();
            this.NomFichier = new System.Windows.Forms.Label();
            this.Ouvrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteNombre)).BeginInit();
            this.Informations.SuspendLayout();
            this.Projet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(6, 35);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(6, 70);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 1;
            this.Prenom.Text = "Prenom";
            this.Prenom.Click += new System.EventHandler(this.Prenom_Click);
            // 
            // NomTexte
            // 
            this.NomTexte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomTexte.Location = new System.Drawing.Point(64, 33);
            this.NomTexte.Name = "NomTexte";
            this.NomTexte.Size = new System.Drawing.Size(135, 20);
            this.NomTexte.TabIndex = 2;
            this.NomTexte.TextChanged += new System.EventHandler(this.NomTexte_TextChanged);
            this.NomTexte.Leave += new System.EventHandler(this.NomTexte_Leave);
            // 
            // PrenomTexte
            // 
            this.PrenomTexte.Location = new System.Drawing.Point(64, 67);
            this.PrenomTexte.Name = "PrenomTexte";
            this.PrenomTexte.Size = new System.Drawing.Size(135, 20);
            this.PrenomTexte.TabIndex = 3;
            this.PrenomTexte.Leave += new System.EventHandler(this.PrenomTexte_Leave);
            // 
            // Ecole
            // 
            this.Ecole.AutoSize = true;
            this.Ecole.Location = new System.Drawing.Point(6, 139);
            this.Ecole.Name = "Ecole";
            this.Ecole.Size = new System.Drawing.Size(34, 13);
            this.Ecole.TabIndex = 4;
            this.Ecole.Text = "Ecole";
            // 
            // ESILV
            // 
            this.ESILV.AutoSize = true;
            this.ESILV.Location = new System.Drawing.Point(64, 139);
            this.ESILV.Name = "ESILV";
            this.ESILV.Size = new System.Drawing.Size(55, 17);
            this.ESILV.TabIndex = 5;
            this.ESILV.TabStop = true;
            this.ESILV.Text = "ESILV";
            this.ESILV.UseVisualStyleBackColor = true;
            this.ESILV.CheckedChanged += new System.EventHandler(this.ESILV_CheckedChanged);
            this.ESILV.Leave += new System.EventHandler(this.ESILV_Leave);
            // 
            // IIM
            // 
            this.IIM.AutoSize = true;
            this.IIM.Location = new System.Drawing.Point(125, 140);
            this.IIM.Name = "IIM";
            this.IIM.Size = new System.Drawing.Size(40, 17);
            this.IIM.TabIndex = 6;
            this.IIM.TabStop = true;
            this.IIM.Text = "IIM";
            this.IIM.UseVisualStyleBackColor = true;
            this.IIM.CheckedChanged += new System.EventHandler(this.IIM_CheckedChanged);
            this.IIM.Leave += new System.EventHandler(this.IIM_Leave);
            // 
            // EMLV
            // 
            this.EMLV.AutoSize = true;
            this.EMLV.Location = new System.Drawing.Point(171, 140);
            this.EMLV.Name = "EMLV";
            this.EMLV.Size = new System.Drawing.Size(54, 17);
            this.EMLV.TabIndex = 7;
            this.EMLV.TabStop = true;
            this.EMLV.Text = "EMLV";
            this.EMLV.UseVisualStyleBackColor = true;
            this.EMLV.CheckedChanged += new System.EventHandler(this.EMLV_CheckedChanged);
            this.EMLV.Leave += new System.EventHandler(this.EMLV_Leave);
            // 
            // ButImpression
            // 
            this.ButImpression.AutoSize = true;
            this.ButImpression.Location = new System.Drawing.Point(15, 51);
            this.ButImpression.Name = "ButImpression";
            this.ButImpression.Size = new System.Drawing.Size(94, 13);
            this.ButImpression.TabIndex = 8;
            this.ButImpression.Text = "But de l\'impression";
            // 
            // ImpressionText
            // 
            this.ImpressionText.Location = new System.Drawing.Point(32, 67);
            this.ImpressionText.Multiline = true;
            this.ImpressionText.Name = "ImpressionText";
            this.ImpressionText.Size = new System.Drawing.Size(263, 77);
            this.ImpressionText.TabIndex = 9;
            this.ImpressionText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.ImpressionText.Leave += new System.EventHandler(this.ImpressionText_Leave);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(578, 248);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.Enregistrer.TabIndex = 12;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(578, 277);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 13;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(6, 169);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 14;
            this.Date.Text = "Date";
            // 
            // DateListe
            // 
            this.DateListe.Location = new System.Drawing.Point(64, 163);
            this.DateListe.Name = "DateListe";
            this.DateListe.Size = new System.Drawing.Size(200, 20);
            this.DateListe.TabIndex = 15;
            // 
            // Quantite
            // 
            this.Quantite.AutoSize = true;
            this.Quantite.Location = new System.Drawing.Point(15, 155);
            this.Quantite.Name = "Quantite";
            this.Quantite.Size = new System.Drawing.Size(47, 13);
            this.Quantite.TabIndex = 16;
            this.Quantite.Text = "Quantité";
            // 
            // QuantiteNombre
            // 
            this.QuantiteNombre.Location = new System.Drawing.Point(94, 153);
            this.QuantiteNombre.Name = "QuantiteNombre";
            this.QuantiteNombre.Size = new System.Drawing.Size(120, 20);
            this.QuantiteNombre.TabIndex = 17;
            this.QuantiteNombre.Leave += new System.EventHandler(this.QuantiteNombre_Leave);
            // 
            // FichierSource
            // 
            this.FichierSource.AutoSize = true;
            this.FichierSource.Location = new System.Drawing.Point(15, 184);
            this.FichierSource.Name = "FichierSource";
            this.FichierSource.Size = new System.Drawing.Size(60, 13);
            this.FichierSource.TabIndex = 18;
            this.FichierSource.Text = "Fichier (.stl)";
            // 
            // Informations
            // 
            this.Informations.Controls.Add(this.EmailTexte);
            this.Informations.Controls.Add(this.Email);
            this.Informations.Controls.Add(this.Nom);
            this.Informations.Controls.Add(this.NomTexte);
            this.Informations.Controls.Add(this.Prenom);
            this.Informations.Controls.Add(this.PrenomTexte);
            this.Informations.Controls.Add(this.DateListe);
            this.Informations.Controls.Add(this.Ecole);
            this.Informations.Controls.Add(this.Date);
            this.Informations.Controls.Add(this.ESILV);
            this.Informations.Controls.Add(this.IIM);
            this.Informations.Controls.Add(this.EMLV);
            this.Informations.Location = new System.Drawing.Point(12, 12);
            this.Informations.Name = "Informations";
            this.Informations.Size = new System.Drawing.Size(281, 211);
            this.Informations.TabIndex = 19;
            this.Informations.TabStop = false;
            this.Informations.Text = "Informations";
            // 
            // EmailTexte
            // 
            this.EmailTexte.Location = new System.Drawing.Point(64, 101);
            this.EmailTexte.Name = "EmailTexte";
            this.EmailTexte.Size = new System.Drawing.Size(135, 20);
            this.EmailTexte.TabIndex = 17;
            this.EmailTexte.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 104);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email";
            // 
            // Projet
            // 
            this.Projet.Controls.Add(this.label1);
            this.Projet.Controls.Add(this.texteNomFichier);
            this.Projet.Controls.Add(this.NomFichier);
            this.Projet.Controls.Add(this.Ouvrir);
            this.Projet.Controls.Add(this.ButImpression);
            this.Projet.Controls.Add(this.ImpressionText);
            this.Projet.Controls.Add(this.FichierSource);
            this.Projet.Controls.Add(this.Quantite);
            this.Projet.Controls.Add(this.QuantiteNombre);
            this.Projet.Location = new System.Drawing.Point(358, 12);
            this.Projet.Name = "Projet";
            this.Projet.Size = new System.Drawing.Size(315, 211);
            this.Projet.TabIndex = 20;
            this.Projet.TabStop = false;
            this.Projet.Text = "Projet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = ".stl";
            // 
            // texteNomFichier
            // 
            this.texteNomFichier.Location = new System.Drawing.Point(101, 25);
            this.texteNomFichier.Name = "texteNomFichier";
            this.texteNomFichier.Size = new System.Drawing.Size(144, 20);
            this.texteNomFichier.TabIndex = 21;
            // 
            // NomFichier
            // 
            this.NomFichier.AutoSize = true;
            this.NomFichier.Location = new System.Drawing.Point(15, 28);
            this.NomFichier.Name = "NomFichier";
            this.NomFichier.Size = new System.Drawing.Size(75, 13);
            this.NomFichier.TabIndex = 20;
            this.NomFichier.Text = "Nom du fichier";
            // 
            // Ouvrir
            // 
            this.Ouvrir.Location = new System.Drawing.Point(126, 179);
            this.Ouvrir.Name = "Ouvrir";
            this.Ouvrir.Size = new System.Drawing.Size(75, 23);
            this.Ouvrir.TabIndex = 19;
            this.Ouvrir.Text = "Ouvrir";
            this.Ouvrir.UseVisualStyleBackColor = true;
            this.Ouvrir.Click += new System.EventHandler(this.Ouvrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 313);
            this.Controls.Add(this.Projet);
            this.Controls.Add(this.Informations);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Enregistrer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteNombre)).EndInit();
            this.Informations.ResumeLayout(false);
            this.Informations.PerformLayout();
            this.Projet.ResumeLayout(false);
            this.Projet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.TextBox NomTexte;
        private System.Windows.Forms.TextBox PrenomTexte;
        private System.Windows.Forms.Label Ecole;
        private System.Windows.Forms.RadioButton ESILV;
        private System.Windows.Forms.RadioButton IIM;
        private System.Windows.Forms.RadioButton EMLV;
        private System.Windows.Forms.Label ButImpression;
        private System.Windows.Forms.TextBox ImpressionText;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker DateListe;
        private System.Windows.Forms.Label Quantite;
        private System.Windows.Forms.NumericUpDown QuantiteNombre;
        private System.Windows.Forms.Label FichierSource;
        private System.Windows.Forms.GroupBox Informations;
        private System.Windows.Forms.GroupBox Projet;
        private System.Windows.Forms.TextBox EmailTexte;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button Ouvrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texteNomFichier;
        private System.Windows.Forms.Label NomFichier;
    }
}

