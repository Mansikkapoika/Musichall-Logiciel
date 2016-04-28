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

namespace MusicHall.Vues
{
    public partial class V_ListeMat : Form
    {
        DataTable dtMat;

        public V_ListeMat()
        {
            InitializeComponent();
        }

        private void V_ListeMat_Load(object sender, EventArgs e)
        {
            remplirTableau();

            // Remplissage manuelle des combobox de recherche (3 onglets)
            t_rech_type.Items.Add("idMateriel");
            t_rech_type.Items.Add("libelle");
            t_rech_type.Items.Add("description");
        }

        public void remplirTableau()
        {
            dtMat = M_Materiel.getMaterielDt();
            tableauMateriel.DataSource = dtMat;

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

        private void b_rech_Click(object sender, EventArgs e)
        {
            try
            {
                // Bouton rechercher avec tests
                if (t_rech_type.SelectedItem != null)
                {
                    if (t_rech_filtre.Text != "")
                    {
                        b_RechercherProduit(t_rech_type, t_rech_filtre);
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
            remplirTableau();
            t_rech_filtre.Clear();
        }

        // Fonction de recherche pour un tableau donné
        public void b_RechercherProduit(ComboBox boutonType, TextBox boutonFiltre)
        {
            try
            {
                // Remplissage du tableau donné par les éléments de recherche via un dataadapter
                DataTable dt = M_Materiel.getMaterielDataAdapter(boutonType.Text, boutonFiltre.Text);
                tableauMateriel.DataSource = dt;

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

    }
}
