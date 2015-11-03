using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                M_Connexion.GestionMateriel.Open();
                String ReqSQL = "SELECT * FROM materiel";

                MySqlDataReader MonReaderMateriel;
                MySqlCommand Command1 = new MySqlCommand(ReqSQL, M_Connexion.GestionMateriel);
                MonReaderMateriel = Command1.ExecuteReader();

                Materiel nouveauMateriel;

                while (MonReaderMateriel.Read())
                {
                    nouveauMateriel = new Materiel(int.Parse(MonReaderMateriel[0].ToString()), MonReaderMateriel[1].ToString(), MonReaderMateriel[2].ToString(), int.Parse(MonReaderMateriel[3].ToString()), int.Parse(MonReaderMateriel[4].ToString()), int.Parse(MonReaderMateriel[5].ToString()), MonReaderMateriel[6].ToString(), MonReaderMateriel[7].ToString(), MonReaderMateriel[8].ToString());
                    CollectionMateriel.Add(nouveauMateriel);
                }
                // Fermeture de la connexion
                M_Connexion.GestionMateriel.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }

            return CollectionMateriel;
        }

        public static void SupperimerMateriel(Materiel unMateriel)
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
    }
}
