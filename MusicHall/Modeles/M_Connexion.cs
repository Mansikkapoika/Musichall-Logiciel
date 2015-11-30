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

        static public String ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;username=2014-musichall;password=123456;database=2014-musichall_musichall";
        //static public String ChaineConnexion = "server=localhost;port=3306;username=root;password=mangos;database=musichall;";

        static public MySqlConnection Gestion = new MySqlConnection(ChaineConnexion);
    }
}
