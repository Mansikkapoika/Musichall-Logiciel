using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicHall.Classes;
using System.Data;

namespace MusicHall.Modeles
{
    class M_Materiel
    {
        public static Collection<Materiel> GetMateriel()
        {

            Collection<Materiel> CollectionMateriel = new Collection<Materiel>();

            try
            {
                CollectionMateriel.Clear();

                // Ouverture de la connexion
                M_Connexion.Gestion.Open()
                    ;
                // Requête SQL
                String ReqSQL = "SELECT * FROM materiel";

                // Déclaration du curseur et execution de la requête
                MySqlDataReader MonReaderMateriel;
                MySqlCommand Command1 = new MySqlCommand(ReqSQL, M_Connexion.Gestion);
                MonReaderMateriel = Command1.ExecuteReader();

                Materiel nouveauMateriel;

                while (MonReaderMateriel.Read())
                {
                    nouveauMateriel = new Materiel(int.Parse(MonReaderMateriel[0].ToString()), MonReaderMateriel[1].ToString(), MonReaderMateriel[2].ToString(), decimal.Parse(MonReaderMateriel[3].ToString()), int.Parse(MonReaderMateriel[4].ToString()), MonReaderMateriel[5].ToString(), MonReaderMateriel[6].ToString(), MonReaderMateriel[7].ToString(), MonReaderMateriel[8].ToString());
                    CollectionMateriel.Add(nouveauMateriel);
                }
                // Fermeture de la connexion
                M_Connexion.Gestion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                M_Connexion.Gestion.Close();
            }

            return CollectionMateriel;
        }

        public static DataTable getMaterielDt()
        {

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            try
            {
                // Ouverture de la connexion
                M_Connexion.Gestion.Open();
                // Requête SQL
                String ReqSQL = "SELECT * FROM Materiel";

                MySqlDataAdapter da = new MySqlDataAdapter(ReqSQL, M_Connexion.Gestion);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                da.Fill(ds, "materiel");
                dt = ds.Tables[0];
                // Fermeture de la connexion
                M_Connexion.Gestion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                M_Connexion.Gestion.Close();
            }
            return dt;
        }

        // Fonction d'ajout de matériel
        public static void ajouterMateriel(Materiel unMateriel)
        {
            try
            {
                // Ouverture de la connexion
                M_Connexion.Gestion.Open();

                // Requête SQL
                string reqSQL = "INSERT INTO materiel VALUES (NULL,?,?,?,?,?,?,?,?)";

                // Execution de la requête
                MySqlCommand Command1 = new MySqlCommand(reqSQL, M_Connexion.Gestion);

                // Création des paramètres correspondants aux ?
                //MySqlParameter Param1 = Command1.Parameters.Add("@idMateriel", MySqlDbType.Int16);
                MySqlParameter Param2 = Command1.Parameters.Add("@libelle", MySqlDbType.VarChar);
                MySqlParameter Param3 = Command1.Parameters.Add("@description", MySqlDbType.VarChar);
                MySqlParameter Param4 = Command1.Parameters.Add("@prixAchHT", MySqlDbType.Decimal);
                MySqlParameter Param6 = Command1.Parameters.Add("@iSousCategorie", MySqlDbType.Int16);
                MySqlParameter Param7 = Command1.Parameters.Add("@Marque", MySqlDbType.VarChar);
                MySqlParameter Param8 = Command1.Parameters.Add("@Modele", MySqlDbType.VarChar);
                MySqlParameter Param9 = Command1.Parameters.Add("@Fournisseur", MySqlDbType.VarChar);
                MySqlParameter Param10 = Command1.Parameters.Add("@cheminImage", MySqlDbType.VarChar);

                // Affectation des valeurs
                // On abandonne le faux paramètre 1 car l'ID est auto-incrémenté
                Param2.Value = unMateriel.getLibelle();
                Param3.Value = unMateriel.getDescription();
                Param4.Value = unMateriel.getPrixAch();
                Param6.Value = unMateriel.getIdSousCategorie();
                Param7.Value = unMateriel.getMarque();
                Param8.Value = unMateriel.getModele();
                Param9.Value = unMateriel.getFournisseur();
                Param10.Value = unMateriel.getCheminImage();

                Command1.ExecuteNonQuery();
                M_Connexion.Gestion.Close();
                MessageBox.Show("Matériel ajouté.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                M_Connexion.Gestion.Close();
            }
        }

        // Fonction d'ajout de matériel
        public static void modifierMateriel(Materiel unMateriel)
        {
            try
            {
                // Ouverture de la connexion
                M_Connexion.Gestion.Open();

                // Requête SQL
                string reqSQL = "UPDATE materiel SET libelle = ?, description = ?, prixAchHT = ?, idSousCategorie = ?, Marque = ?, Modele = ?, Fournisseur = ? WHERE idMateriel = ?";

                // Execution de la requête
                MySqlCommand Command1 = new MySqlCommand(reqSQL, M_Connexion.Gestion);

                // Création des paramètres correspondants aux ?
                //MySqlParameter Param1 = Command1.Parameters.Add("@idMateriel", MySqlDbType.Int16);
                MySqlParameter Param1 = Command1.Parameters.Add("@libelle", MySqlDbType.VarChar);
                MySqlParameter Param2 = Command1.Parameters.Add("@description", MySqlDbType.VarChar);
                MySqlParameter Param3 = Command1.Parameters.Add("@prixAchHT", MySqlDbType.Decimal);
                MySqlParameter Param5 = Command1.Parameters.Add("@iSousCategorie", MySqlDbType.Int16);
                MySqlParameter Param6 = Command1.Parameters.Add("@Marque", MySqlDbType.VarChar);
                MySqlParameter Param7 = Command1.Parameters.Add("@Modele", MySqlDbType.VarChar);
                MySqlParameter Param8 = Command1.Parameters.Add("@Fournisseur", MySqlDbType.VarChar);
                MySqlParameter Param9 = Command1.Parameters.Add("@idMateriel", MySqlDbType.Int16);


                // Affectation des valeurs
                // Le param1 est auto-incrémenté
                Param1.Value = unMateriel.getLibelle();
                Param2.Value = unMateriel.getDescription();
                Param3.Value = unMateriel.getPrixAch();
                Param5.Value = unMateriel.getIdSousCategorie();
                Param6.Value = unMateriel.getMarque();
                Param7.Value = unMateriel.getModele();
                Param8.Value = unMateriel.getFournisseur();
                Param9.Value = unMateriel.getId();

                Command1.ExecuteNonQuery();
                M_Connexion.Gestion.Close();
                MessageBox.Show("Matériel modifié.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                M_Connexion.Gestion.Close();
            }
        }

        public static void SupprimerMateriel(Materiel unMateriel)
        {

            try
            {
                // Ouverture de la connexion
                M_Connexion.Gestion.Open();

                // Requête SQL
                string reqSQL = "DELETE FROM materiel WHERE idMateriel = ?";

                // Execution de la requête
                MySqlCommand Command1 = new MySqlCommand(reqSQL, M_Connexion.Gestion);

                // Création des paramètres correspondants aux ?
                MySqlParameter Param1 = Command1.Parameters.Add("@idMateriel", MySqlDbType.Int16);

                // Affectation des valeurs
                Param1.Value = unMateriel.getId();

                Command1.ExecuteNonQuery();
                M_Connexion.Gestion.Close();
                MessageBox.Show("Matériel supprimé.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                M_Connexion.Gestion.Close();
            }
        }

    }
}