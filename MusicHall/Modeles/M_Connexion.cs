using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHall.Modeles
{
    class M_Connexion
    {
        // Chaine de connexion à la DB
        // ! Mettre des infos fausses pour l'instant !

        static public String ChaineConnexion = "server=reherbtsinfo-rousseau53.fr;port=21017;username=2014-musichall;password=123456;database=2014-musichall_musichall";

        static public MySqlConnection GestionMateriel = new MySqlConnection(ChaineConnexion);
    }
}
