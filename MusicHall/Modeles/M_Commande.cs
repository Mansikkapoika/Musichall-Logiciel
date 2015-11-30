using MusicHall.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicHall.Modeles
{
    class M_Commande
    {
        public static DataTable getCommand()
        {

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            try
            {
                // Ouverture de la connexion
                M_Connexion.Gestion.Open();
                // Requête SQL
                String ReqSQL = "SELECT * FROM commande WHERE status = ?";

                MySqlDataAdapter da = new MySqlDataAdapter(ReqSQL, M_Connexion.Gestion);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                da.SelectCommand.Parameters.AddWithValue("@status", "En cours");

                da.Fill(ds, "commande");
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

        public static void modifierStatus(int idCommande, String status)
        {
            try
            {
                // Ouverture de la connexion
                M_Connexion.Gestion.Open();

                // Requête SQL
                string reqSQL = "UPDATE commande SET status = ? WHERE idCommande = ?";

                // Execution de la requête
                MySqlCommand Command1 = new MySqlCommand(reqSQL, M_Connexion.Gestion);

                // Création des paramètres correspondants aux ?
                MySqlParameter Param1 = Command1.Parameters.Add("@status", MySqlDbType.String);
                MySqlParameter Param2 = Command1.Parameters.Add("@idCommande", MySqlDbType.Int16);


                // Affectation des valeurs
                Param1.Value = status;
                Param2.Value = idCommande;

                Command1.ExecuteNonQuery();
                M_Connexion.Gestion.Close();
                MessageBox.Show("Commande affectée.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
        }

    }
}
