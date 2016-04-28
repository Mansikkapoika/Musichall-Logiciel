using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicHall.Modeles;
using MusicHall.Classes;
using System.Drawing.Printing;

namespace MusicHall.Vues
{
    public partial class V_GestionStock : Form
    {
        private DataTable dt;

        public V_GestionStock()
        {
            InitializeComponent();
        }

        private void V_GestionStock_Load(object sender, EventArgs e)
        {
            // On affecte les titres des onglets
            tabPage1.Text = "Stock";
            tabPage2.Text = "Entrées";
            tabPage3.Text = "Sorties";
            tabPage4.Text = "Liste des fournisseurs | catégories";

            // On remplit le combobox de recherche de produit pour seulement deux colonnes (noms et types)
            remplirComboboxOnglet_Rech(t_rech_type);
            remplirComboboxOnglet_Rech(t_rech_type1);
            remplirComboboxOnglet_Rech(t_rech_type2);

            try
            {
                // Fonction de chargement et d'actualisation : charge les tableaux et les calculs
                func_refresh();

                // On trie les produits à la limite du stock
                trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);

                // Ensuite on colorie les produits à la limite du stock
                limiteStock(tableauMateriel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
        }

        private void remplirComboboxOnglet_Rech(ComboBox unCombobox)
        {
            // Remplissage manuelle des combobox de recherche (3 onglets)
            unCombobox.Items.Add("idMateriel");
            unCombobox.Items.Add("libelle");
            unCombobox.Items.Add("description");
        }

        // Fonction de chargement et d'actualisation
        private void func_refresh()
        {
            // On remplit les tableaux
            remplirTableau(tableauMateriel);
            remplirTableau(tableauMateriel1);
            remplirTableau(tableauMateriel2);
            remplirTableau_CatFour(tableauCategories, tableauFournisseurs);

            // On vérifie les stocks
            t_nbReapprovisionnement.Text = getReapprovisionnement().ToString();
        }

        // Fonction de remplissage des tableaux et de calculs des valeurs initiales
        public void remplirTableau(DataGridView unTableau)
        {
            dt = M_Materiel.getMaterielDt();
            // On remplit le tableau
            unTableau.DataSource = dt;

            tableauMateriel.Columns[0].HeaderText = "Numéro";
            tableauMateriel.Columns[1].HeaderText = "Nom";
            tableauMateriel.Columns[2].HeaderText = "Description";
            tableauMateriel.Columns[3].HeaderText = "Prix";
            tableauMateriel.Columns[4].Visible = false;
            tableauMateriel.Columns[5].HeaderText = "Marque";
            tableauMateriel.Columns[6].HeaderText = "Modèle";
            tableauMateriel.Columns[7].HeaderText = "Fournisseur";
            tableauMateriel.Columns[8].HeaderText = "Quantité du stock";
            tableauMateriel.Columns[9].HeaderText = "Chemin de l'image";
        }

        // Fonction qui trie les produits de chaque tableaux en fonction de la quantité
        private void trierColonneQte(DataGridView unTableau, DataGridView unTableau1, DataGridView unTableau2)
        {
            unTableau.Sort(unTableau.Columns["nbstock"], ListSortDirection.Ascending);
            unTableau1.Sort(unTableau1.Columns["nbstock"], ListSortDirection.Ascending);
            unTableau2.Sort(unTableau2.Columns["nbstock"], ListSortDirection.Ascending);

            // Affichage contenu des 2 dernières colonnes de fournisseurs et catégories des datagridview
            //getContenuDerColonnes(tableauMateriel, tableauMateriel1, tableauMateriel2);
        }

        // Fonction qui colorie la ligne d'un produit à ré-approvisionner
        private void limiteStock(DataGridView unTableau)
        {
            for (int i = 0; i < unTableau.Rows.Count; i++)
            {
                if (Convert.ToInt32(unTableau.Rows[i].Cells[8].Value) <= 2)
                {
                    unTableau.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                }
            }
        }

        public void remplirTableau_CatFour(DataGridView tableauCategories, DataGridView tableauFournisseurs)
        {
            DataTable dtCat;
            dtCat = M_Categories.getCategoriesTab();
            tableauCategories.DataSource = dtCat;

            DataTable dtFour;
            dtFour = M_Materiel.getFournisseursDt();
            tableauFournisseurs.DataSource = dtFour;

            tableauCategories.Columns[0].HeaderText = "Catégorie numéro";
            tableauCategories.Columns[0].Visible = false;
            tableauCategories.Columns[1].HeaderText = "Nom de la catégorie";
            tableauFournisseurs.Columns[0].HeaderText = "Nom du fournisseur";
        }

        // Fonction qui permet de voir combien de produits sont à ré-approvisionner
        private int getReapprovisionnement()
        {
            int i;
            int rea = 0;
            for (i = 0; i < tableauMateriel.Rows.Count; i++)
            {
                if (Convert.ToInt32(tableauMateriel.Rows[i].Cells[3].Value) <= 2)
                {
                    rea++;
                }
            }
            return rea;
        }

        // Fonction de recherche pour un tableau donné
        public void b_RechercherProduit(DataGridView unTableau, ComboBox boutonType, TextBox boutonFiltre)
        {
            try
            {
                // Remplissage du tableau donné par les éléments de recherche via un dataadapter
                DataTable dt = M_Materiel.getMaterielDataAdapter(boutonType.Text, boutonFiltre.Text);
                unTableau.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Votre recherche ne renvoi aucun resultat.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void b_rech_Click(object sender, EventArgs e)
        {
            try
            {
                // Bouton rechercher avec tests
                if (t_rech_type.SelectedItem != null)
                {
                    if (t_rech_filtre.Text != "")
                    {
                        b_RechercherProduit(tableauMateriel, t_rech_type, t_rech_filtre);
                        trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
                        limiteStock(tableauMateriel);
                    }
                    else
                    {
                        throw new Exception("Un ou plusieurs champs de recherche est vide !");
                    }
                }
                else
                {
                    throw new Exception("Un ou plusieurs champs de recherche est vide !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void b_rech_aff_Click(object sender, EventArgs e)
        {
            // Bouton tout afficher
            func_refresh();
            t_rech_filtre.Clear();
            trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
            limiteStock(tableauMateriel);
        }

        private void b_refresh_load_Click(object sender, EventArgs e)
        {
            // Bouton actualiser
            func_refresh();
            t_rech_filtre.Clear();
            trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
            limiteStock(tableauMateriel);
        }

        private void b_rech_aff1_Click(object sender, EventArgs e)
        {
            // Bouton tout afficher
            func_refresh();
            t_rech_filtre.Clear();
            trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
            limiteStock(tableauMateriel1);
        }

        private void b_rech1_Click(object sender, EventArgs e)
        {
            try
            {
                // Bouton rechercher avec tests 
                if (t_rech_type1.SelectedItem != null)
                {
                    if (t_rech_filtre1.Text != "")
                    {
                        b_RechercherProduit(tableauMateriel1, t_rech_type1, t_rech_filtre1);
                        trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
                        limiteStock(tableauMateriel1);
                    }
                    else
                    {
                        throw new Exception("Un ou plusieurs champs de recherche est vide !");
                    }
                }
                else
                {
                    throw new Exception("Un ou plusieurs champs de recherche est vide !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void b_rech_aff2_Click(object sender, EventArgs e)
        {
            // Bouton tout afficher
            func_refresh();
            t_rech_filtre.Clear();
            trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
            limiteStock(tableauMateriel2);
        }

        private void b_rech2_Click(object sender, EventArgs e)
        {
            try
            {
                // Bouton rechercher avec tests
                if (t_rech_type2.SelectedItem != null)
                {
                    if (t_rech_filtre2.Text != "")
                    {
                        b_RechercherProduit(tableauMateriel2, t_rech_type2, t_rech_filtre2);
                        trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
                        limiteStock(tableauMateriel2);
                    }
                    else
                    {
                        throw new Exception("Un ou plusieurs champs de recherche est vide !");
                    }
                }
                else
                {
                    throw new Exception("Un ou plusieurs champs de recherche est vide !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void Stock_Selected(object sender, TabControlEventArgs e)
        {
            limiteStock(tableauMateriel);
            limiteStock(tableauMateriel1);
            limiteStock(tableauMateriel2);
        }

        private void Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            limiteStock(tableauMateriel);
            limiteStock(tableauMateriel1);
            limiteStock(tableauMateriel2);
        }

        private void b_valider_entrer_Click(object sender, EventArgs e)
        {
            try
            {
                M_Materiel.augmenterQuantite(Convert.ToInt32(t_prod_entrer.Text), Convert.ToInt32(num_qte_entrer.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void tableauMateriel1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tableauMateriel1 = sender as DataGridView;
            int rowIndex = e.RowIndex;

            if (tableauMateriel1 == null)
            {
                return;
            }
            if (tableauMateriel1.CurrentRow.Selected)
            {
                try
                {
                    t_prod_entrer.Text = tableauMateriel1.Rows[rowIndex].Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }

        private void b_refresh_load1_Click(object sender, EventArgs e)
        {
            // Bouton actualiser
            func_refresh();
            trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
            limiteStock(tableauMateriel1);
        }

        private void b_refresh_load2_Click(object sender, EventArgs e)
        {
            // Bouton actualiser
            func_refresh();
            trierColonneQte(tableauMateriel, tableauMateriel1, tableauMateriel2);
            limiteStock(tableauMateriel2);
        }

        private void b_valider_sortir_Click(object sender, EventArgs e)
        {
            try
            {
                M_Materiel.diminuerQuantite(Convert.ToInt32(t_prod_sortir.Text), Convert.ToInt32(num_qte_sortir.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void tableauMateriel_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limiteStock(tableauMateriel);
        }

        private void tableauMateriel1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limiteStock(tableauMateriel1);
        }

        private void tableauMateriel2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limiteStock(tableauMateriel2);
        }

        // Affectation des valeurs en fonction du clic sur une ligne
        private void tableauMateriel2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tableauMateriel2 = sender as DataGridView;
            int rowIndex = e.RowIndex;

            if (tableauMateriel2 == null)
            {
                return;
            }
            if (tableauMateriel2.CurrentRow.Selected)
            {
                try
                {
                    t_prod_sortir.Text = tableauMateriel2.Rows[rowIndex].Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }

        private void bImprimer_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.tableauMateriel.Width, this.tableauMateriel.Height);
            tableauMateriel.DrawToBitmap(bm, new Rectangle(0, 0, this.tableauMateriel.Width, this.tableauMateriel.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
