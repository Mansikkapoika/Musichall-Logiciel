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

namespace MusicHall.Vues
{
    public partial class V_GestionCom : Form
    {
        private DataTable dt;

        public V_GestionCom()
        {
            InitializeComponent();
        }

        private void V_GestionCom_Load(object sender, EventArgs e)
        {
            try
            {
                remplirTableau();
                // Changement des noms des colonnes
                tableauCommande.Columns[0].HeaderText = "Numéro de commande";
                tableauCommande.Columns[1].HeaderText = "Libellé d'utilisateur";
                tableauCommande.Columns[2].HeaderText = "Date";
                tableauCommande.Columns[3].HeaderText = "Status";
                tableauCommande.Columns[4].HeaderText = "Montant";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }

        }

        private void b_validerModification_Click(object sender, EventArgs e)
        {
            String textId = t_idCommande.Text;
            int idCommande = int.Parse(textId);
            M_Commande.modifierStatus(idCommande, "Terminée");
        }

        private void b_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableauCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tableauCommande = sender as DataGridView;
            int rowIndex = e.RowIndex;

            if (tableauCommande == null)
            {
                return;
            }
            if (tableauCommande.CurrentRow.Selected)
            {
                try
                {
                    t_idCommande.Text = tableauCommande.Rows[rowIndex].Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
        }

        public void remplirTableau()
        {
            dt = M_Commande.getCommand();
            tableauCommande.DataSource = dt;
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            remplirTableau();
        }
    }
}
