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
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableauMateriel
            // 
            this.tableauMateriel.AllowUserToAddRows = false;
            this.tableauMateriel.AllowUserToDeleteRows = false;
            this.tableauMateriel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMateriel.Location = new System.Drawing.Point(12, 71);
            this.tableauMateriel.Name = "tableauMateriel";
            this.tableauMateriel.ReadOnly = true;
            this.tableauMateriel.Size = new System.Drawing.Size(1260, 506);
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
            // V_ListeMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableauMateriel);
            this.Name = "V_ListeMat";
            this.Text = "V_ListeMat";
            this.Load += new System.EventHandler(this.V_ListeMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauMateriel;
        private System.Windows.Forms.Label label1;
    }
}