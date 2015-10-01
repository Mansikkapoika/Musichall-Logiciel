using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicHall
{
    public partial class GestionMat : Form
    {
        String ChaineConnexion;
        Collection<Materiel> CollectionMateriel;
        MySqlConnection GestionMateriel;

        private void RemiseAZero()
        {
            // Vidage des champs de saisie
            t_nom.Clear();
            t_ht.Value = 0;
            t_location.Value = 0;
            t_description.Clear();
            t_marque.Clear();
            t_modele.Clear();
            list_fournisseurs.Items.Clear();    // A changer
        }

        private void BloquerChampsSaisie()
        {
            // On bloque tous les champs de saisie
            t_nom.Enabled = false;
            t_ht.Enabled = false;
            t_location.Enabled = false;
            t_description.Enabled = false;
            t_marque.Enabled = false;
            t_modele.Enabled = false;
            list_fournisseurs.Enabled = false;
            b_validerAjout.Enabled = false;
            b_validerModification.Enabled = false;
            b_annuler.Enabled = false;
            list_materiels.Enabled = true;
        }

        private void DebloquerChampsSaisie()
        {
            // On débloque tous les champs de saisie
            t_nom.Enabled = true;
            t_ht.Enabled = true;
            t_location.Enabled = true;
            t_description.Enabled = true;
            t_marque.Enabled = true;
            t_modele.Enabled = true;
            list_fournisseurs.Enabled = true;
            list_materiels.Enabled = false;
            list_materiels.Items.Clear();       // A changer
        }

        public GestionMat()
        {
            InitializeComponent();

            // Chaine de connexion à la DB
            // ! Mettre des infos fausses pour l'instant !
            ChaineConnexion = "server=blabla_btsinfo-rousseau53.fr;port=21017;username=2014-musichall;password=123456;database=2014-musichall_musichall";

            // Blocage des champs de saisie par défaut
            BloquerChampsSaisie();
        }

        private void ChargementMateriel()
        {
            try
            {
                CollectionMateriel.Clear();
                GestionMateriel.Open();
                String ReqSQL = "SELECT * FROM materiel";

                MySqlDataReader MonReaderMateriel;
                MySqlCommand Command1 = new MySqlCommand(ReqSQL, GestionMateriel);
                MonReaderMateriel = Command1.ExecuteReader();

                Materiel nouveauMateriel;

                while (MonReaderMateriel.Read())
                {
                    nouveauMateriel = new Materiel(int.Parse(MonReaderMateriel[0].ToString()), MonReaderMateriel[1].ToString(), MonReaderMateriel[2].ToString(), int.Parse(MonReaderMateriel[3].ToString()), int.Parse(MonReaderMateriel[4].ToString()), int.Parse(MonReaderMateriel[5].ToString()), int.Parse(MonReaderMateriel[6].ToString()), int.Parse(MonReaderMateriel[7].ToString()), int.Parse(MonReaderMateriel[8].ToString()));
                    CollectionMateriel.Add(nouveauMateriel);
                }
                // Fermeture de la connexion
                GestionMateriel.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vidage des champs de saisie pour en ajouter un nouveau
            RemiseAZero();

            // On met le curseur sur le premier champ
            t_nom.Focus();

            // Blocage / Déblocage des boutons et champs
            b_ajouterMateriel.Enabled = false;
            b_modifierMateriel.Enabled = false;
            b_supprimerMateriel.Enabled = false;
            b_validerAjout.Enabled = true;
            b_annuler.Enabled = true;

            DebloquerChampsSaisie();

        }

        private void b_modifierMateriel_Click(object sender, EventArgs e)
        {
            // On met le curseur sur le nom
            t_nom.Focus();

            // Blocage / Déblocage des champs
            DebloquerChampsSaisie();
            b_validerModification.Enabled = true;
            b_ajouterMateriel.Enabled = false;
            b_modifierMateriel.Enabled = false;
            b_supprimerMateriel.Enabled = false;
            b_annuler.Enabled = true;
        }

        private void GestionMat_Load(object sender, EventArgs e)
        {
            try
            {
                // Ouverture de la connexion
                GestionMateriel = new MySqlConnection(ChaineConnexion);

                // Création de la collection et chargement
                CollectionMateriel = new Collection<Materiel>();
                ChargementMateriel();

                // Faire à ce que la collection aille ensuite dans le menu déroulant (du matériel) ?
                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_annuler_Click(object sender, EventArgs e)
        {
            BloquerChampsSaisie();
            b_validerAjout.Enabled = false;
            RemiseAZero();
            b_ajouterMateriel.Enabled = true;
            b_modifierMateriel.Enabled = true;
            b_supprimerMateriel.Enabled = true;
        }

        private void b_supprimerMateriel_Click(object sender, EventArgs e)
        {
            // Confirmation de la suppression
            if (MessageBox.Show("Voulez vous supprimer le matériel ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur :" + ex.Message);
                }
            }
            else
            {

            }
        }

        private void t_ht_ValueChanged(object sender, EventArgs e)
        {

        }

        private void t_location_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
