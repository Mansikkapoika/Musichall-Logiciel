namespace MusicHall
{
    partial class GestionMat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.b_ajouterMateriel = new System.Windows.Forms.Button();
            this.b_modifierMateriel = new System.Windows.Forms.Button();
            this.b_supprimerMateriel = new System.Windows.Forms.Button();
            this.b_validerAjout = new System.Windows.Forms.Button();
            this.b_validerModification = new System.Windows.Forms.Button();
            this.b_annuler = new System.Windows.Forms.Button();
            this.lab_nom = new System.Windows.Forms.Label();
            this.t_nom = new System.Windows.Forms.TextBox();
            this.lab_description = new System.Windows.Forms.Label();
            this.t_description = new System.Windows.Forms.RichTextBox();
            this.lab_ht = new System.Windows.Forms.Label();
            this.lab_location = new System.Windows.Forms.Label();
            this.lab_modele = new System.Windows.Forms.Label();
            this.t_marque = new System.Windows.Forms.TextBox();
            this.lab_marque = new System.Windows.Forms.Label();
            this.t_modele = new System.Windows.Forms.TextBox();
            this.lab_fournisseur = new System.Windows.Forms.Label();
            this.pic_materiel = new System.Windows.Forms.PictureBox();
            this.t_ht = new System.Windows.Forms.NumericUpDown();
            this.t_location = new System.Windows.Forms.NumericUpDown();
            this.b_quitter = new System.Windows.Forms.Button();
            this.list_materiels = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_fournisseurs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_materiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_location)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // b_ajouterMateriel
            // 
            this.b_ajouterMateriel.Location = new System.Drawing.Point(51, 11);
            this.b_ajouterMateriel.Name = "b_ajouterMateriel";
            this.b_ajouterMateriel.Size = new System.Drawing.Size(124, 46);
            this.b_ajouterMateriel.TabIndex = 1;
            this.b_ajouterMateriel.Text = "Ajouter un matériel";
            this.b_ajouterMateriel.UseVisualStyleBackColor = true;
            this.b_ajouterMateriel.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_modifierMateriel
            // 
            this.b_modifierMateriel.Location = new System.Drawing.Point(213, 11);
            this.b_modifierMateriel.Name = "b_modifierMateriel";
            this.b_modifierMateriel.Size = new System.Drawing.Size(124, 46);
            this.b_modifierMateriel.TabIndex = 2;
            this.b_modifierMateriel.Text = "Modifier un matériel";
            this.b_modifierMateriel.UseVisualStyleBackColor = true;
            this.b_modifierMateriel.Click += new System.EventHandler(this.b_modifierMateriel_Click);
            // 
            // b_supprimerMateriel
            // 
            this.b_supprimerMateriel.Location = new System.Drawing.Point(371, 11);
            this.b_supprimerMateriel.Name = "b_supprimerMateriel";
            this.b_supprimerMateriel.Size = new System.Drawing.Size(124, 46);
            this.b_supprimerMateriel.TabIndex = 3;
            this.b_supprimerMateriel.Text = "Supprimer un matériel";
            this.b_supprimerMateriel.UseVisualStyleBackColor = true;
            this.b_supprimerMateriel.Click += new System.EventHandler(this.b_supprimerMateriel_Click);
            // 
            // b_validerAjout
            // 
            this.b_validerAjout.Location = new System.Drawing.Point(98, 432);
            this.b_validerAjout.Name = "b_validerAjout";
            this.b_validerAjout.Size = new System.Drawing.Size(91, 46);
            this.b_validerAjout.TabIndex = 4;
            this.b_validerAjout.Text = "Valider l\'ajout";
            this.b_validerAjout.UseVisualStyleBackColor = true;
            // 
            // b_validerModification
            // 
            this.b_validerModification.Location = new System.Drawing.Point(214, 432);
            this.b_validerModification.Name = "b_validerModification";
            this.b_validerModification.Size = new System.Drawing.Size(97, 46);
            this.b_validerModification.TabIndex = 5;
            this.b_validerModification.Text = "Valider modification";
            this.b_validerModification.UseVisualStyleBackColor = true;
            // 
            // b_annuler
            // 
            this.b_annuler.Location = new System.Drawing.Point(98, 498);
            this.b_annuler.Name = "b_annuler";
            this.b_annuler.Size = new System.Drawing.Size(213, 46);
            this.b_annuler.TabIndex = 6;
            this.b_annuler.Text = "Annuler";
            this.b_annuler.UseVisualStyleBackColor = true;
            this.b_annuler.Click += new System.EventHandler(this.b_annuler_Click);
            // 
            // lab_nom
            // 
            this.lab_nom.AutoSize = true;
            this.lab_nom.Location = new System.Drawing.Point(60, 107);
            this.lab_nom.Name = "lab_nom";
            this.lab_nom.Size = new System.Drawing.Size(29, 13);
            this.lab_nom.TabIndex = 7;
            this.lab_nom.Text = "Nom";
            // 
            // t_nom
            // 
            this.t_nom.Location = new System.Drawing.Point(98, 105);
            this.t_nom.Name = "t_nom";
            this.t_nom.Size = new System.Drawing.Size(213, 20);
            this.t_nom.TabIndex = 8;
            // 
            // lab_description
            // 
            this.lab_description.AutoSize = true;
            this.lab_description.Location = new System.Drawing.Point(28, 218);
            this.lab_description.Name = "lab_description";
            this.lab_description.Size = new System.Drawing.Size(60, 13);
            this.lab_description.TabIndex = 9;
            this.lab_description.Text = "Description";
            // 
            // t_description
            // 
            this.t_description.Location = new System.Drawing.Point(98, 218);
            this.t_description.Name = "t_description";
            this.t_description.Size = new System.Drawing.Size(213, 88);
            this.t_description.TabIndex = 10;
            this.t_description.Text = "";
            // 
            // lab_ht
            // 
            this.lab_ht.AutoSize = true;
            this.lab_ht.Location = new System.Drawing.Point(13, 141);
            this.lab_ht.Name = "lab_ht";
            this.lab_ht.Size = new System.Drawing.Size(76, 13);
            this.lab_ht.TabIndex = 11;
            this.lab_ht.Text = "Prix Hors Taxe";
            this.lab_ht.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab_location
            // 
            this.lab_location.AutoSize = true;
            this.lab_location.Location = new System.Drawing.Point(10, 176);
            this.lab_location.Name = "lab_location";
            this.lab_location.Size = new System.Drawing.Size(79, 13);
            this.lab_location.TabIndex = 14;
            this.lab_location.Text = "Prix de location";
            // 
            // lab_modele
            // 
            this.lab_modele.AutoSize = true;
            this.lab_modele.Location = new System.Drawing.Point(49, 358);
            this.lab_modele.Name = "lab_modele";
            this.lab_modele.Size = new System.Drawing.Size(42, 13);
            this.lab_modele.TabIndex = 17;
            this.lab_modele.Text = "Modèle";
            // 
            // t_marque
            // 
            this.t_marque.Location = new System.Drawing.Point(98, 323);
            this.t_marque.Name = "t_marque";
            this.t_marque.Size = new System.Drawing.Size(213, 20);
            this.t_marque.TabIndex = 16;
            // 
            // lab_marque
            // 
            this.lab_marque.AutoSize = true;
            this.lab_marque.Location = new System.Drawing.Point(49, 326);
            this.lab_marque.Name = "lab_marque";
            this.lab_marque.Size = new System.Drawing.Size(43, 13);
            this.lab_marque.TabIndex = 15;
            this.lab_marque.Text = "Marque";
            this.lab_marque.Click += new System.EventHandler(this.label7_Click);
            // 
            // t_modele
            // 
            this.t_modele.Location = new System.Drawing.Point(97, 358);
            this.t_modele.Name = "t_modele";
            this.t_modele.Size = new System.Drawing.Size(214, 20);
            this.t_modele.TabIndex = 18;
            // 
            // lab_fournisseur
            // 
            this.lab_fournisseur.AutoSize = true;
            this.lab_fournisseur.Location = new System.Drawing.Point(32, 395);
            this.lab_fournisseur.Name = "lab_fournisseur";
            this.lab_fournisseur.Size = new System.Drawing.Size(61, 13);
            this.lab_fournisseur.TabIndex = 19;
            this.lab_fournisseur.Text = "Fournisseur";
            // 
            // pic_materiel
            // 
            this.pic_materiel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_materiel.Location = new System.Drawing.Point(568, 105);
            this.pic_materiel.Name = "pic_materiel";
            this.pic_materiel.Size = new System.Drawing.Size(234, 200);
            this.pic_materiel.TabIndex = 22;
            this.pic_materiel.TabStop = false;
            // 
            // t_ht
            // 
            this.t_ht.Location = new System.Drawing.Point(98, 140);
            this.t_ht.Margin = new System.Windows.Forms.Padding(2);
            this.t_ht.Name = "t_ht";
            this.t_ht.Size = new System.Drawing.Size(90, 20);
            this.t_ht.TabIndex = 23;
            this.t_ht.ValueChanged += new System.EventHandler(this.t_ht_ValueChanged);
            // 
            // t_location
            // 
            this.t_location.Location = new System.Drawing.Point(98, 176);
            this.t_location.Margin = new System.Windows.Forms.Padding(2);
            this.t_location.Name = "t_location";
            this.t_location.Size = new System.Drawing.Size(90, 20);
            this.t_location.TabIndex = 24;
            this.t_location.ValueChanged += new System.EventHandler(this.t_location_ValueChanged);
            // 
            // b_quitter
            // 
            this.b_quitter.Location = new System.Drawing.Point(568, 11);
            this.b_quitter.Name = "b_quitter";
            this.b_quitter.Size = new System.Drawing.Size(124, 46);
            this.b_quitter.TabIndex = 25;
            this.b_quitter.Text = "Quitter";
            this.b_quitter.UseVisualStyleBackColor = true;
            this.b_quitter.Click += new System.EventHandler(this.button7_Click);
            // 
            // list_materiels
            // 
            this.list_materiels.FormattingEnabled = true;
            this.list_materiels.Location = new System.Drawing.Point(371, 141);
            this.list_materiels.Name = "list_materiels";
            this.list_materiels.Size = new System.Drawing.Size(125, 21);
            this.list_materiels.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Selectionner matériel";
            // 
            // list_fournisseurs
            // 
            this.list_fournisseurs.FormattingEnabled = true;
            this.list_fournisseurs.Location = new System.Drawing.Point(97, 392);
            this.list_fournisseurs.Name = "list_fournisseurs";
            this.list_fournisseurs.Size = new System.Drawing.Size(214, 21);
            this.list_fournisseurs.TabIndex = 28;
            // 
            // GestionMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 602);
            this.Controls.Add(this.list_fournisseurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_materiels);
            this.Controls.Add(this.b_quitter);
            this.Controls.Add(this.t_location);
            this.Controls.Add(this.t_ht);
            this.Controls.Add(this.pic_materiel);
            this.Controls.Add(this.lab_fournisseur);
            this.Controls.Add(this.t_modele);
            this.Controls.Add(this.lab_modele);
            this.Controls.Add(this.t_marque);
            this.Controls.Add(this.lab_marque);
            this.Controls.Add(this.lab_location);
            this.Controls.Add(this.lab_ht);
            this.Controls.Add(this.t_description);
            this.Controls.Add(this.lab_description);
            this.Controls.Add(this.t_nom);
            this.Controls.Add(this.lab_nom);
            this.Controls.Add(this.b_annuler);
            this.Controls.Add(this.b_validerModification);
            this.Controls.Add(this.b_validerAjout);
            this.Controls.Add(this.b_supprimerMateriel);
            this.Controls.Add(this.b_modifierMateriel);
            this.Controls.Add(this.b_ajouterMateriel);
            this.Controls.Add(this.label1);
            this.Name = "GestionMat";
            this.Text = "Gestion matériel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_materiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_location)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_ajouterMateriel;
        private System.Windows.Forms.Button b_modifierMateriel;
        private System.Windows.Forms.Button b_supprimerMateriel;
        private System.Windows.Forms.Button b_validerAjout;
        private System.Windows.Forms.Button b_validerModification;
        private System.Windows.Forms.Button b_annuler;
        private System.Windows.Forms.Label lab_nom;
        private System.Windows.Forms.TextBox t_nom;
        private System.Windows.Forms.Label lab_description;
        private System.Windows.Forms.RichTextBox t_description;
        private System.Windows.Forms.Label lab_ht;
        private System.Windows.Forms.Label lab_location;
        private System.Windows.Forms.Label lab_modele;
        private System.Windows.Forms.TextBox t_marque;
        private System.Windows.Forms.Label lab_marque;
        private System.Windows.Forms.TextBox t_modele;
        private System.Windows.Forms.Label lab_fournisseur;
        private System.Windows.Forms.PictureBox pic_materiel;
        private System.Windows.Forms.NumericUpDown t_ht;
        private System.Windows.Forms.NumericUpDown t_location;
        private System.Windows.Forms.Button b_quitter;
        private System.Windows.Forms.ComboBox list_materiels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list_fournisseurs;
    }
}