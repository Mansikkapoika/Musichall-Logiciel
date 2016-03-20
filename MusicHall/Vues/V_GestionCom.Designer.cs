namespace MusicHall.Vues
{
    partial class V_GestionCom
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.b_quitter = new System.Windows.Forms.Button();
            this.b_validerModification = new System.Windows.Forms.Button();
            this.t_idCommande = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableauCommande = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.b_quitter);
            this.splitContainer1.Panel1.Controls.Add(this.b_validerModification);
            this.splitContainer1.Panel1.Controls.Add(this.t_idCommande);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableauCommande);
            this.splitContainer1.Size = new System.Drawing.Size(846, 602);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 0;
            // 
            // b_quitter
            // 
            this.b_quitter.Location = new System.Drawing.Point(128, 91);
            this.b_quitter.Name = "b_quitter";
            this.b_quitter.Size = new System.Drawing.Size(97, 46);
            this.b_quitter.TabIndex = 38;
            this.b_quitter.Text = "Quitter";
            this.b_quitter.UseVisualStyleBackColor = true;
            this.b_quitter.Click += new System.EventHandler(this.b_quitter_Click);
            // 
            // b_validerModification
            // 
            this.b_validerModification.Location = new System.Drawing.Point(25, 91);
            this.b_validerModification.Name = "b_validerModification";
            this.b_validerModification.Size = new System.Drawing.Size(97, 46);
            this.b_validerModification.TabIndex = 37;
            this.b_validerModification.Text = "Terminer la commande";
            this.b_validerModification.UseVisualStyleBackColor = true;
            this.b_validerModification.Click += new System.EventHandler(this.b_validerModification_Click);
            // 
            // t_idCommande
            // 
            this.t_idCommande.Location = new System.Drawing.Point(25, 56);
            this.t_idCommande.Name = "t_idCommande";
            this.t_idCommande.Size = new System.Drawing.Size(96, 20);
            this.t_idCommande.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Selectionner la commande n°";
            // 
            // tableauCommande
            // 
            this.tableauCommande.AllowUserToAddRows = false;
            this.tableauCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauCommande.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauCommande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableauCommande.Location = new System.Drawing.Point(0, 0);
            this.tableauCommande.Name = "tableauCommande";
            this.tableauCommande.ReadOnly = true;
            this.tableauCommande.Size = new System.Drawing.Size(602, 602);
            this.tableauCommande.TabIndex = 1;
            this.tableauCommande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauCommande_CellClick);
            // 
            // V_GestionCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 602);
            this.Controls.Add(this.splitContainer1);
            this.Name = "V_GestionCom";
            this.Text = "V_GestionCom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.V_GestionCom_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableauCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox t_idCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_validerModification;
        private System.Windows.Forms.DataGridView tableauCommande;
        private System.Windows.Forms.Button b_quitter;
    }
}