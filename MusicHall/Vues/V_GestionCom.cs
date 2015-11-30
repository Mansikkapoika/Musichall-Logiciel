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
            list_status.Items.Add("En cours");
            list_status.Items.Add("Terminée");
            dt = M_Commande.getCommand();
            try
            {
                tableauCommande.DataSource = dt;
                tableauCommande.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tableauCommande.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tableauCommande.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tableauCommande.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tableauCommande.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b_validerModification_Click(object sender, EventArgs e)
        {
            String textId = t_idCommande.Text;
            int idCommande = int.Parse(textId);
            M_Commande.modifierStatus(idCommande, list_status.Text);
        }

        private void tableauCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
