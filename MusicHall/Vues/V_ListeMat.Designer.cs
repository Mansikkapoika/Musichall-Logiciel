namespace MusicHall.Vues
{
    partial class V_ListeMat
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
            this.tableauMateriel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_rech_aff = new System.Windows.Forms.Button();
            this.b_rech = new System.Windows.Forms.Button();
            this.t_rech_filtre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_rech_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableauMateriel
            // 
            this.tableauMateriel.AllowUserToAddRows = false;
            this.tableauMateriel.AllowUserToDeleteRows = false;
            this.tableauMateriel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauMateriel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMateriel.Location = new System.Drawing.Point(12, 122);
            this.tableauMateriel.Name = "tableauMateriel";
            this.tableauMateriel.ReadOnly = true;
            this.tableauMateriel.Size = new System.Drawing.Size(1260, 455);
            this.tableauMateriel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des matériels";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_rech_aff);
            this.groupBox1.Controls.Add(this.b_rech);
            this.groupBox1.Controls.Add(this.t_rech_filtre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.t_rech_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher un produit";
            // 
            // b_rech_aff
            // 
            this.b_rech_aff.Location = new System.Drawing.Point(353, 28);
            this.b_rech_aff.Name = "b_rech_aff";
            this.b_rech_aff.Size = new System.Drawing.Size(75, 23);
            this.b_rech_aff.TabIndex = 10;
            this.b_rech_aff.Text = "Tout afficher";
            this.b_rech_aff.UseVisualStyleBackColor = true;
            this.b_rech_aff.Click += new System.EventHandler(this.b_rech_aff_Click);
            // 
            // b_rech
            // 
            this.b_rech.Location = new System.Drawing.Point(353, 60);
            this.b_rech.Name = "b_rech";
            this.b_rech.Size = new System.Drawing.Size(75, 23);
            this.b_rech.TabIndex = 9;
            this.b_rech.Text = "Rechercher";
            this.b_rech.UseVisualStyleBackColor = true;
            this.b_rech.Click += new System.EventHandler(this.b_rech_Click);
            // 
            // t_rech_filtre
            // 
            this.t_rech_filtre.Location = new System.Drawing.Point(166, 46);
            this.t_rech_filtre.Name = "t_rech_filtre";
            this.t_rech_filtre.Size = new System.Drawing.Size(149, 20);
            this.t_rech_filtre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filtre :";
            // 
            // t_rech_type
            // 
            this.t_rech_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_rech_type.FormattingEnabled = true;
            this.t_rech_type.Location = new System.Drawing.Point(21, 46);
            this.t_rech_type.Name = "t_rech_type";
            this.t_rech_type.Size = new System.Drawing.Size(111, 21);
            this.t_rech_type.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Par nom / description :";
            // 
            // V_ListeMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableauMateriel);
            this.Name = "V_ListeMat";
            this.Text = "V_ListeMat";
            this.Load += new System.EventHandler(this.V_ListeMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauMateriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_rech_aff;
        private System.Windows.Forms.Button b_rech;
        private System.Windows.Forms.TextBox t_rech_filtre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox t_rech_type;
        private System.Windows.Forms.Label label4;
    }
}