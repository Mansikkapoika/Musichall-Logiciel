using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicHall.Classes;
using MusicHall.Modeles;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MusicHall.Modeles
{
    class M_Categories
    {
        public static Collection<Categories> getCategories()
        {
            Collection<Categories> CollectionCategorie = new Collection<Categories>();

            try
            {
                CollectionCategorie.Clear();

                // Ouverture de la connexion
                M_Connexion.Gestion.Open();

                // Requête SQL
                String ReqSQL = "SELECT * FROM categorie";

                // Déclaration du curseur
                MySqlDataReader MonReaderCategorie;

                // Execution de la requête
                MySqlCommand Command1 = new MySqlCommand(ReqSQL, M_Connexion.Gestion);
                MonReaderCategorie = Command1.ExecuteReader();

                Categories uneCategories;

                while (MonReaderCategorie.Read())
                {
                    uneCategories = new Categories(int.Parse(MonReaderCategorie[0].ToString()), MonReaderCategorie[1].ToString());
                    CollectionCategorie.Add(uneCategories);
                }
                // Fermeture de la connexion
                M_Connexion.Gestion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                M_Connexion.Gestion.Close();
            }

            return CollectionCategorie;
        }

        // A partir d'une catégorie on peut récupérer son code pour retirer ses sous-catégories
        public static Collection<SousCategories> getSousCategories(Categories uneCategorie)
        {
            Collection<SousCategories> CollectionSousCategorie = new Collection<SousCategories>();

            try
            {
                CollectionSousCategorie.Clear();

                M_Connexion.Gestion.Open();

                String ReqSQL = "SELECT * FROM souscategorie WHERE idCategorie = ?";

                MySqlDataReader MonReaderCategorie;

                MySqlCommand Command1 = new MySqlCommand(ReqSQL, M_Connexion.Gestion);
                MySqlParameter Param1 = Command1.Parameters.Add("@idSousCategorie", MySqlDbType.Int16);
                Param1.Value = uneCategorie.getCode();

                MonReaderCategorie = Command1.ExecuteReader();

                SousCategories uneCategories;

                while (MonReaderCategorie.Read())
                {
                    uneCategories = new SousCategories(int.Parse(MonReaderCategorie[0].ToString()), MonReaderCategorie[1].ToString(), int.Parse(MonReaderCategorie[2].ToString()));
                    CollectionSousCategorie.Add(uneCategories);
                }
                // Fermeture de la connexion
                M_Connexion.Gestion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                M_Connexion.Gestion.Close();
            }
            return CollectionSousCategorie;
        }

        public static DataTable getCategoriesTab()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            try
            {
                // Ouverture de la connexion
                M_Connexion.Gestion.Open();
                // Requête SQL
                String ReqSQL = "SELECT * FROM categorie";

                MySqlDataAdapter da = new MySqlDataAdapter(ReqSQL, M_Connexion.Gestion);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                da.Fill(ds, "categorie");
                dt = ds.Tables[0];
                // Fermeture de la connexion
                M_Connexion.Gestion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
            return dt;
        }
    }
}
