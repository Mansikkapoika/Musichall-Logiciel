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
using MusicHall.Classes;

namespace MusicHall
{
    public partial class GestionMat : Form
    {
        Collection<Materiel> CollectionMateriel;
        Collection<Categories> CollectionCategorie;
        Collection<SousCategories> CollectionSousCategories;

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
            list_categories.Enabled = false;
            list_souscategories.Enabled = false;
            // On empeche l'utilisateur d'écrire dans les combobox
            list_materiels.DropDownStyle = ComboBoxStyle.DropDownList;
            list_categories.DropDownStyle = ComboBoxStyle.DropDownList;
            list_souscategories.DropDownStyle = ComboBoxStyle.DropDownList;
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
            list_categories.Enabled = true;
            list_souscategories.Enabled = true;
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

            // Ajout des infos au combobox de catégories
            RemplirComboCategorie();

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

            // Ajout des infos au combobox de catégories
            RemplirComboCategorie();

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
                // On rempli la collection de matériels
                CollectionMateriel = Modeles.M_Materiel.GetMateriel();

                // On rempli la collection de catégories
                CollectionCategorie = Modeles.M_Categories.getCategories();

                // Blocage des champs de saisie par défaut
                BloquerChampsSaisie();

                // Ajout des infos au combobox de matériels
                RemplirComboMateriel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
        }

        private void RemplirComboMateriel()
        {
            // On rempli le menu déroulant de produits via la collection
            foreach (Materiel leMateriel in CollectionMateriel)
            {
                list_materiels.Items.Add(leMateriel.getLibelle());
            }
        }

        private void RemplirComboCategorie()
        {
            // On rempli le menu déroulant de catégories via la collection
            foreach (Categories uneCategorie in CollectionCategorie)
            {
                list_categories.Items.Add(uneCategorie.getLibelle());
            }
        }

        private void RemplirComboSousCategorie()
        {
            list_souscategories.Items.Clear();
            // On rempli le menu déroulant de sous-catégories via la collection
            foreach (SousCategories uneSousCategorie in CollectionSousCategories)
            {
                list_souscategories.Items.Add(uneSousCategorie.getLibelle());
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
            list_categories.Items.Clear();
            list_souscategories.Items.Clear();
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
            // On rempli les champs en fonction du matériel selectionné
            AffecterValeurs(CollectionMateriel[list_materiels.SelectedIndex]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_fournisseur_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On rempli la collection de sous-catégories au clic de la catégorie (qui remplira sa combobox)
            CollectionSousCategories = Modeles.M_Categories.getSousCategories(CollectionCategorie[list_categories.SelectedIndex]);
            RemplirComboSousCategorie();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void b_validerAjout_Click(object sender, EventArgs e)
        {
            // On créé un objet de matériel qui sera utilisé pour l'ajout de celui-ci dans la BDD
            Materiel unMateriel = null;
            int idMateriel = 1;
            unMateriel = new Materiel(idMateriel, t_nom.Text, t_description.Text, t_ht.Value, t_location.Value, CollectionSousCategories[list_souscategories.SelectedIndex].getCode(), t_marque.Text, t_modele.Text, t_fournisseur.Text);
            M_Materiel.ajouterMateriel(unMateriel);
        }
    }
}
