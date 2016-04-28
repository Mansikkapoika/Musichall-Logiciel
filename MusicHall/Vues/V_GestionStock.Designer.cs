namespace MusicHall.Vues
{
    partial class V_GestionStock
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableauFournisseurs = new System.Windows.Forms.DataGridView();
            this.tableauCategories = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.b_refresh_load2 = new System.Windows.Forms.Button();
            this.b_valider_sortir = new System.Windows.Forms.Button();
            this.num_qte_sortir = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.t_prod_sortir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_rech_aff2 = new System.Windows.Forms.Button();
            this.b_rech2 = new System.Windows.Forms.Button();
            this.t_rech_filtre2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_rech_type2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableauMateriel2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.b_refresh_load1 = new System.Windows.Forms.Button();
            this.b_valider_entrer = new System.Windows.Forms.Button();
            this.num_qte_entrer = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.t_prod_entrer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_rech_aff1 = new System.Windows.Forms.Button();
            this.b_rech1 = new System.Windows.Forms.Button();
            this.t_rech_filtre1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_rech_type1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableauMateriel1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bImprimer = new System.Windows.Forms.Button();
            this.b_refresh_load = new System.Windows.Forms.Button();
            this.t_nbReapprovisionnement = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_rech_aff = new System.Windows.Forms.Button();
            this.b_rech = new System.Windows.Forms.Button();
            this.t_rech_filtre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_rech_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableauMateriel = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.TabControl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauFournisseurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauCategories)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qte_sortir)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qte_entrer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel)).BeginInit();
            this.Stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1150, 363);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(732, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Liste des catégories";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Liste des fournisseurs";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableauFournisseurs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableauCategories);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 332);
            this.splitContainer1.SplitterDistance = 614;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableauFournisseurs
            // 
            this.tableauFournisseurs.AllowUserToAddRows = false;
            this.tableauFournisseurs.AllowUserToDeleteRows = false;
            this.tableauFournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauFournisseurs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauFournisseurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableauFournisseurs.Location = new System.Drawing.Point(0, 0);
            this.tableauFournisseurs.Name = "tableauFournisseurs";
            this.tableauFournisseurs.ReadOnly = true;
            this.tableauFournisseurs.Size = new System.Drawing.Size(614, 332);
            this.tableauFournisseurs.TabIndex = 0;
            // 
            // tableauCategories
            // 
            this.tableauCategories.AllowUserToAddRows = false;
            this.tableauCategories.AllowUserToDeleteRows = false;
            this.tableauCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauCategories.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableauCategories.Location = new System.Drawing.Point(0, 0);
            this.tableauCategories.Name = "tableauCategories";
            this.tableauCategories.ReadOnly = true;
            this.tableauCategories.Size = new System.Drawing.Size(526, 332);
            this.tableauCategories.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.b_refresh_load2);
            this.tabPage3.Controls.Add(this.b_valider_sortir);
            this.tabPage3.Controls.Add(this.num_qte_sortir);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.t_prod_sortir);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.tableauMateriel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1150, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // b_refresh_load2
            // 
            this.b_refresh_load2.Location = new System.Drawing.Point(287, 46);
            this.b_refresh_load2.Name = "b_refresh_load2";
            this.b_refresh_load2.Size = new System.Drawing.Size(75, 23);
            this.b_refresh_load2.TabIndex = 19;
            this.b_refresh_load2.Text = "Actualiser";
            this.b_refresh_load2.UseVisualStyleBackColor = true;
            this.b_refresh_load2.Click += new System.EventHandler(this.b_refresh_load2_Click);
            // 
            // b_valider_sortir
            // 
            this.b_valider_sortir.Location = new System.Drawing.Point(120, 63);
            this.b_valider_sortir.Name = "b_valider_sortir";
            this.b_valider_sortir.Size = new System.Drawing.Size(100, 23);
            this.b_valider_sortir.TabIndex = 18;
            this.b_valider_sortir.Text = "Valider";
            this.b_valider_sortir.UseVisualStyleBackColor = true;
            this.b_valider_sortir.Click += new System.EventHandler(this.b_valider_sortir_Click);
            // 
            // num_qte_sortir
            // 
            this.num_qte_sortir.Location = new System.Drawing.Point(120, 35);
            this.num_qte_sortir.Name = "num_qte_sortir";
            this.num_qte_sortir.Size = new System.Drawing.Size(100, 20);
            this.num_qte_sortir.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Quantité :";
            // 
            // t_prod_sortir
            // 
            this.t_prod_sortir.Location = new System.Drawing.Point(120, 9);
            this.t_prod_sortir.Name = "t_prod_sortir";
            this.t_prod_sortir.Size = new System.Drawing.Size(100, 20);
            this.t_prod_sortir.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Produit à sortir N° :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_rech_aff2);
            this.groupBox3.Controls.Add(this.b_rech2);
            this.groupBox3.Controls.Add(this.t_rech_filtre2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.t_rech_type2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(423, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 93);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechercher un produit";
            // 
            // b_rech_aff2
            // 
            this.b_rech_aff2.Location = new System.Drawing.Point(353, 28);
            this.b_rech_aff2.Name = "b_rech_aff2";
            this.b_rech_aff2.Size = new System.Drawing.Size(75, 23);
            this.b_rech_aff2.TabIndex = 10;
            this.b_rech_aff2.Text = "Tout afficher";
            this.b_rech_aff2.UseVisualStyleBackColor = true;
            this.b_rech_aff2.Click += new System.EventHandler(this.b_rech_aff2_Click);
            // 
            // b_rech2
            // 
            this.b_rech2.Location = new System.Drawing.Point(353, 60);
            this.b_rech2.Name = "b_rech2";
            this.b_rech2.Size = new System.Drawing.Size(75, 23);
            this.b_rech2.TabIndex = 9;
            this.b_rech2.Text = "Rechercher";
            this.b_rech2.UseVisualStyleBackColor = true;
            this.b_rech2.Click += new System.EventHandler(this.b_rech2_Click);
            // 
            // t_rech_filtre2
            // 
            this.t_rech_filtre2.Location = new System.Drawing.Point(166, 46);
            this.t_rech_filtre2.Name = "t_rech_filtre2";
            this.t_rech_filtre2.Size = new System.Drawing.Size(149, 20);
            this.t_rech_filtre2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Filtre :";
            // 
            // t_rech_type2
            // 
            this.t_rech_type2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_rech_type2.FormattingEnabled = true;
            this.t_rech_type2.Location = new System.Drawing.Point(21, 46);
            this.t_rech_type2.Name = "t_rech_type2";
            this.t_rech_type2.Size = new System.Drawing.Size(111, 21);
            this.t_rech_type2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Par nom / description :";
            // 
            // tableauMateriel2
            // 
            this.tableauMateriel2.AllowUserToAddRows = false;
            this.tableauMateriel2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauMateriel2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauMateriel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMateriel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableauMateriel2.Location = new System.Drawing.Point(3, 102);
            this.tableauMateriel2.Name = "tableauMateriel2";
            this.tableauMateriel2.ReadOnly = true;
            this.tableauMateriel2.Size = new System.Drawing.Size(1144, 258);
            this.tableauMateriel2.TabIndex = 1;
            this.tableauMateriel2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauMateriel2_CellClick);
            this.tableauMateriel2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableauMateriel2_ColumnHeaderMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.b_refresh_load1);
            this.tabPage2.Controls.Add(this.b_valider_entrer);
            this.tabPage2.Controls.Add(this.num_qte_entrer);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.t_prod_entrer);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.tableauMateriel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // b_refresh_load1
            // 
            this.b_refresh_load1.Location = new System.Drawing.Point(287, 46);
            this.b_refresh_load1.Name = "b_refresh_load1";
            this.b_refresh_load1.Size = new System.Drawing.Size(75, 23);
            this.b_refresh_load1.TabIndex = 14;
            this.b_refresh_load1.Text = "Actualiser";
            this.b_refresh_load1.UseVisualStyleBackColor = true;
            this.b_refresh_load1.Click += new System.EventHandler(this.b_refresh_load1_Click);
            // 
            // b_valider_entrer
            // 
            this.b_valider_entrer.Location = new System.Drawing.Point(120, 63);
            this.b_valider_entrer.Name = "b_valider_entrer";
            this.b_valider_entrer.Size = new System.Drawing.Size(100, 23);
            this.b_valider_entrer.TabIndex = 13;
            this.b_valider_entrer.Text = "Valider";
            this.b_valider_entrer.UseVisualStyleBackColor = true;
            this.b_valider_entrer.Click += new System.EventHandler(this.b_valider_entrer_Click);
            // 
            // num_qte_entrer
            // 
            this.num_qte_entrer.Location = new System.Drawing.Point(120, 35);
            this.num_qte_entrer.Name = "num_qte_entrer";
            this.num_qte_entrer.Size = new System.Drawing.Size(100, 20);
            this.num_qte_entrer.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Quantité :";
            // 
            // t_prod_entrer
            // 
            this.t_prod_entrer.Location = new System.Drawing.Point(120, 9);
            this.t_prod_entrer.Name = "t_prod_entrer";
            this.t_prod_entrer.Size = new System.Drawing.Size(100, 20);
            this.t_prod_entrer.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Produit à entrer N° :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_rech_aff1);
            this.groupBox2.Controls.Add(this.b_rech1);
            this.groupBox2.Controls.Add(this.t_rech_filtre1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.t_rech_type1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(423, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 93);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher un produit";
            // 
            // b_rech_aff1
            // 
            this.b_rech_aff1.Location = new System.Drawing.Point(353, 28);
            this.b_rech_aff1.Name = "b_rech_aff1";
            this.b_rech_aff1.Size = new System.Drawing.Size(75, 23);
            this.b_rech_aff1.TabIndex = 10;
            this.b_rech_aff1.Text = "Tout afficher";
            this.b_rech_aff1.UseVisualStyleBackColor = true;
            this.b_rech_aff1.Click += new System.EventHandler(this.b_rech_aff1_Click);
            // 
            // b_rech1
            // 
            this.b_rech1.Location = new System.Drawing.Point(353, 60);
            this.b_rech1.Name = "b_rech1";
            this.b_rech1.Size = new System.Drawing.Size(75, 23);
            this.b_rech1.TabIndex = 9;
            this.b_rech1.Text = "Rechercher";
            this.b_rech1.UseVisualStyleBackColor = true;
            this.b_rech1.Click += new System.EventHandler(this.b_rech1_Click);
            // 
            // t_rech_filtre1
            // 
            this.t_rech_filtre1.Location = new System.Drawing.Point(166, 46);
            this.t_rech_filtre1.Name = "t_rech_filtre1";
            this.t_rech_filtre1.Size = new System.Drawing.Size(149, 20);
            this.t_rech_filtre1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Filtre :";
            // 
            // t_rech_type1
            // 
            this.t_rech_type1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_rech_type1.FormattingEnabled = true;
            this.t_rech_type1.Location = new System.Drawing.Point(21, 46);
            this.t_rech_type1.Name = "t_rech_type1";
            this.t_rech_type1.Size = new System.Drawing.Size(111, 21);
            this.t_rech_type1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Par nom / description :";
            // 
            // tableauMateriel1
            // 
            this.tableauMateriel1.AllowUserToAddRows = false;
            this.tableauMateriel1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauMateriel1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauMateriel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMateriel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableauMateriel1.Location = new System.Drawing.Point(3, 102);
            this.tableauMateriel1.Name = "tableauMateriel1";
            this.tableauMateriel1.ReadOnly = true;
            this.tableauMateriel1.Size = new System.Drawing.Size(1144, 258);
            this.tableauMateriel1.TabIndex = 1;
            this.tableauMateriel1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableauMateriel1_CellClick);
            this.tableauMateriel1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableauMateriel1_ColumnHeaderMouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bImprimer);
            this.tabPage1.Controls.Add(this.b_refresh_load);
            this.tabPage1.Controls.Add(this.t_nbReapprovisionnement);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tableauMateriel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1150, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bImprimer
            // 
            this.bImprimer.Location = new System.Drawing.Point(110, 49);
            this.bImprimer.Name = "bImprimer";
            this.bImprimer.Size = new System.Drawing.Size(75, 23);
            this.bImprimer.TabIndex = 13;
            this.bImprimer.Text = "Imprimer";
            this.bImprimer.UseVisualStyleBackColor = true;
            this.bImprimer.Click += new System.EventHandler(this.bImprimer_Click);
            // 
            // b_refresh_load
            // 
            this.b_refresh_load.Location = new System.Drawing.Point(29, 49);
            this.b_refresh_load.Name = "b_refresh_load";
            this.b_refresh_load.Size = new System.Drawing.Size(75, 23);
            this.b_refresh_load.TabIndex = 10;
            this.b_refresh_load.Text = "Actualiser";
            this.b_refresh_load.UseVisualStyleBackColor = true;
            this.b_refresh_load.Click += new System.EventHandler(this.b_refresh_load_Click);
            // 
            // t_nbReapprovisionnement
            // 
            this.t_nbReapprovisionnement.AutoSize = true;
            this.t_nbReapprovisionnement.Location = new System.Drawing.Point(177, 28);
            this.t_nbReapprovisionnement.Name = "t_nbReapprovisionnement";
            this.t_nbReapprovisionnement.Size = new System.Drawing.Size(185, 13);
            this.t_nbReapprovisionnement.TabIndex = 9;
            this.t_nbReapprovisionnement.Text = "Nombre réapprovisionnement Matériel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_rech_aff);
            this.groupBox1.Controls.Add(this.b_rech);
            this.groupBox1.Controls.Add(this.t_rech_filtre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.t_rech_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(423, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 93);
            this.groupBox1.TabIndex = 6;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matériels à réapprovisionner :";
            // 
            // tableauMateriel
            // 
            this.tableauMateriel.AllowUserToAddRows = false;
            this.tableauMateriel.AllowUserToDeleteRows = false;
            this.tableauMateriel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauMateriel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauMateriel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableauMateriel.Location = new System.Drawing.Point(3, 102);
            this.tableauMateriel.Name = "tableauMateriel";
            this.tableauMateriel.ReadOnly = true;
            this.tableauMateriel.Size = new System.Drawing.Size(1144, 258);
            this.tableauMateriel.TabIndex = 0;
            this.tableauMateriel.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableauMateriel_ColumnHeaderMouseClick);
            // 
            // Stock
            // 
            this.Stock.Controls.Add(this.tabPage1);
            this.Stock.Controls.Add(this.tabPage2);
            this.Stock.Controls.Add(this.tabPage3);
            this.Stock.Controls.Add(this.tabPage4);
            this.Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stock.Location = new System.Drawing.Point(0, 0);
            this.Stock.Name = "Stock";
            this.Stock.SelectedIndex = 0;
            this.Stock.Size = new System.Drawing.Size(1158, 389);
            this.Stock.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Stock.TabIndex = 3;
            this.Stock.SelectedIndexChanged += new System.EventHandler(this.Stock_SelectedIndexChanged);
            this.Stock.Selected += new System.Windows.Forms.TabControlEventHandler(this.Stock_Selected);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // V_GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 610);
            this.Controls.Add(this.Stock);
            this.Name = "V_GestionStock";
            this.Text = "V_GestionStock";
            this.Load += new System.EventHandler(this.V_GestionStock_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableauFournisseurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauCategories)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qte_sortir)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qte_entrer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauMateriel)).EndInit();
            this.Stock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView tableauFournisseurs;
        private System.Windows.Forms.DataGridView tableauCategories;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button b_refresh_load2;
        private System.Windows.Forms.Button b_valider_sortir;
        private System.Windows.Forms.NumericUpDown num_qte_sortir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_prod_sortir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_rech_aff2;
        private System.Windows.Forms.Button b_rech2;
        private System.Windows.Forms.TextBox t_rech_filtre2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox t_rech_type2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView tableauMateriel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button b_refresh_load1;
        private System.Windows.Forms.Button b_valider_entrer;
        private System.Windows.Forms.NumericUpDown num_qte_entrer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox t_prod_entrer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_rech_aff1;
        private System.Windows.Forms.Button b_rech1;
        private System.Windows.Forms.TextBox t_rech_filtre1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox t_rech_type1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tableauMateriel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bImprimer;
        private System.Windows.Forms.Button b_refresh_load;
        private System.Windows.Forms.Label t_nbReapprovisionnement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_rech_aff;
        private System.Windows.Forms.Button b_rech;
        private System.Windows.Forms.TextBox t_rech_filtre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox t_rech_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tableauMateriel;
        private System.Windows.Forms.TabControl Stock;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}