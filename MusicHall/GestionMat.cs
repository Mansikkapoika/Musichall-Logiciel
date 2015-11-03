using MusicHall.Modeles;
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
        Collection<Materiel> CollectionMateriel;
        int NumMaterielCourant = 1;

        private void RemiseAZero()
        {
            // Vidage des champs de saisie
            t_nom.Clear();
            t_ht.Value = 0;
            t_location.Value = 0;
            t_description.Clear();
            t_marque.Clear();
            t_modele.Clear();
            t_fournisseur.Clear();
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
            t_fournisseur.Enabled = false;
            b_validerAjout.Enabled = false;
            b_validerModification.Enabled = false;
            b_annuler.Enabled = false;
            // On empeche l'utilisateur d'écrire dans le combobox
            list_materiels.DropDownStyle = ComboBoxStyle.DropDownList;
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
            t_fournisseur.Enabled = true;
        }

        public GestionMat()
        {
            InitializeComponent();
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
                // ON rempli la collection
                CollectionMateriel = Modeles.M_Materiel.GetMateriel();

                // Blocage des champs de saisie par défaut
                BloquerChampsSaisie();

                // Ajout des infos au combobox
                RemplirComboMateriel(CollectionMateriel[NumMaterielCourant - 1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
        }

        private void RemplirComboMateriel(Materiel unMateriel)
        {
            // On rempli le menu déroulant de produits
            foreach (Materiel leMateriel in CollectionMateriel)
            {
                list_materiels.Items.Add(leMateriel.getLibelle());
            }
        }

        private void AffecterValeurs(Materiel unMateriel)
        {
            // On affecte les valeurs aux champs en fonction du clique dans le menu déroulant de produits
            Materiel leMateriel = unMateriel;
            t_nom.Text = leMateriel.getLibelle();
            t_ht.Value = leMateriel.getPrixAch();
            t_location.Value = leMateriel.getPrixLoca();
            t_description.Text = leMateriel.getDescription();
            t_marque.Text = leMateriel.getMarque();
            t_modele.Text = leMateriel.getModele();
            t_fournisseur.Text = leMateriel.getFournisseur();
            

        }

        private void label7_Click(object sender, EventArgs e)
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

        private void t_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_materiels_SelectedIndexChanged(object sender, EventArgs e)
        {
            AffecterValeurs(CollectionMateriel[list_materiels.SelectedIndex]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_fournisseur_Click(object sender, EventArgs e)
        {

        }
    }
}
