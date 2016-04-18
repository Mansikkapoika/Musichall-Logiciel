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
using MusicHall.Modeles;
using System.Net;
using System.IO;
using System.Drawing.Imaging;

namespace MusicHall
{
    public partial class GestionMat : Form
    {
        Collection<Materiel> CollectionMateriel;
        Collection<Categories> CollectionCategorie;
        Collection<SousCategories> CollectionSousCategories;
        int idMaterielCourant;
        OpenFileDialog open;
        String fichierSansExt;


        private void RemiseAZero()
        {
            // Vidage des champs de saisie
            t_nom.Clear();
            t_ht.Value = 0;
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
            t_description.Enabled = false;
            t_marque.Enabled = false;
            t_modele.Enabled = false;
            t_fournisseur.Enabled = false;
            b_validerAjout.Enabled = false;
            b_validerModification.Enabled = false;
            b_annuler.Enabled = false;
            list_categories.Enabled = false;
            list_souscategories.Enabled = false;
            b_ajoutPhoto.Enabled = false;
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
            t_description.Enabled = true;
            t_marque.Enabled = true;
            t_modele.Enabled = true;
            t_fournisseur.Enabled = true;
            list_categories.Enabled = true;
            list_souscategories.Enabled = true;
            b_ajoutPhoto.Enabled = true;
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
            list_materiels.Enabled = false;
            list_materiels.ResetText();
            b_ajouterMateriel.Enabled = false;
            b_modifierMateriel.Enabled = false;
            b_supprimerMateriel.Enabled = false;
            b_validerAjout.Enabled = true;
            b_ajoutPhoto.Enabled = true;
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
            b_ajoutPhoto.Enabled = false;
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
            idMaterielCourant = leMateriel.getId();
            t_nom.Text = leMateriel.getLibelle();
            t_ht.Value = leMateriel.getPrixAch();
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
            RemiseAZero();
            pic_materiel.Image = null;
            list_materiels.Enabled = true;
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
                    Modeles.M_Materiel.SupprimerMateriel(CollectionMateriel[list_materiels.SelectedIndex]);
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
            try
            {
                string filename = open.FileName;
                FileInfo objFile = new FileInfo(filename);

                // On créé un objet de matériel qui sera utilisé pour l'ajout de celui-ci dans la BDD
                Materiel unMateriel = null;
                int idMateriel = 1;
                unMateriel = new Materiel(idMateriel, t_nom.Text, t_description.Text, t_ht.Value, CollectionSousCategories[list_souscategories.SelectedIndex].getCode(), t_marque.Text, t_modele.Text, t_fournisseur.Text, "content/images/products/" + fichierSansExt);

                // On ajoute le matériel
                M_Materiel.ajouterMateriel(unMateriel);
                // On ajout la photo
                ajouterPhoto(open);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez compléter tous les champs.");
            }

            // On rebloque les boutons et on recharge la liste
            BloquerChampsSaisie();
            RemiseAZero();
            list_materiels.Enabled = true;
            b_ajouterMateriel.Enabled = true;
            b_modifierMateriel.Enabled = true;
            b_supprimerMateriel.Enabled = true;
            // Vide les items et les re-remplis -> Ne fonctionne pas
            list_materiels.Items.Clear();
            RemplirComboMateriel();
        }

        private void b_validerModification_Click(object sender, EventArgs e)
        {
            try
            {
                Materiel unMateriel = null;
                unMateriel = new Materiel(idMaterielCourant, t_nom.Text, t_description.Text, t_ht.Value, CollectionSousCategories[list_souscategories.SelectedIndex].getCode(), t_marque.Text, t_modele.Text, t_fournisseur.Text, "");
                M_Materiel.modifierMateriel(unMateriel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez selectionner un matériel.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // image file path
                if (open.CheckFileExists)
                {
                    if (MessageBox.Show("Enregistrer cette image ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // ligne pour récupérer seulement le nom de l'image et non le chemin
                        FileInfo objFile = new FileInfo(open.FileName);
                        // display image in picture box
                        pic_materiel.Image = new Bitmap(open.FileName);
                        // on garde l'objet
                        this.open = open;

                        try
                        {
                            // redimention de l'image, copie sur le pc local et attente de l'envoi sur le FTP
                            Image old = Image.FromFile(open.FileName); // ouverture
                            Bitmap img = new Bitmap(old, 500, 708); // redimension

                            // on récupère le nom du fichier sans l'extension
                            String fichierSansExt = System.IO.Path.GetFileNameWithoutExtension(objFile.Name);
                            img.Save(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fichierSansExt + ".png", ImageFormat.Png); // sauvegarde
                            MessageBox.Show("Image redimensionnée pour le site.");
                            this.fichierSansExt = fichierSansExt + ".png";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la redimention: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void ajouterPhoto(OpenFileDialog open)
        {
            // infos fichier local non redimensionné
            FileInfo objFileNRD = new FileInfo(open.FileName);
            String fichierSansExt = System.IO.Path.GetFileNameWithoutExtension(objFileNRD.Name);

            string filename = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fichierSansExt + ".png";
            string ftpServerIP = "192.168.1.17"; //string ftpServerIP = "btsinfo-rousseau53.fr:21017";
            string ftpUserName = "2014-musichall";
            string ftpPassword = "123456";

            FtpWebRequest objFTPRequest;

            FileInfo objFile = new FileInfo(filename);

            // Create FtpWebRequest object 
            objFTPRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/content/images/products/" + objFile.Name));

            // Set Credintials
            objFTPRequest.Credentials = new NetworkCredential(ftpUserName, ftpPassword);

            // By default KeepAlive is true, where the control connection is 
            // not closed after a command is executed.
            objFTPRequest.KeepAlive = false;

            // Set the data transfer type.
            objFTPRequest.UseBinary = true;

            // Set content length
            objFTPRequest.ContentLength = objFile.Length;

            // Set request method
            objFTPRequest.Method = WebRequestMethods.Ftp.UploadFile;

            // Set buffer size
            int intBufferLength = 16 * 1024;
            byte[] objBuffer = new byte[intBufferLength];

            // Opens a file to read
            FileStream objFileStream = objFile.OpenRead();

            try
            {
                // Get Stream of the file
                Stream objStream = objFTPRequest.GetRequestStream();
                int len = 0;
                while ((len = objFileStream.Read(objBuffer, 0, intBufferLength)) != 0)
                {
                    // Write file Content 
                    objStream.Write(objBuffer, 0, len);
                }
                objStream.Close();
                objFileStream.Close();
                MessageBox.Show("Photo enregistrée avec succès.");
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur:" + ex.Message);
            }
        }

    }
}