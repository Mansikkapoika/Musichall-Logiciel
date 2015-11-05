using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHall.Classes
{

    public class Categories
    {
        private int idCategorie;
        private String libelle;

        public Categories(int idCategorie, String libelle)
        {
            this.idCategorie = idCategorie;
            this.libelle = libelle;
        }

        // Accesseurs

        public int getCode()
        {
            return this.idCategorie;
        }

        public String getLibelle()
        {
            return this.libelle;
        }

    }

    public class SousCategories
    {
        private int idSousCategorie;
        private String libelle;
        private int idCatdeSousCat;

        public SousCategories(int idSousCategorie, String libelle, int idCatdeSousCat)
        {
            this.idSousCategorie = idSousCategorie;
            this.libelle = libelle;
            this.idCatdeSousCat = idCatdeSousCat;
        }

        // Accesseurs

        public int getCode()
        {
            return this.idSousCategorie;
        }

        public String getLibelle()
        {
            return this.libelle;
        }

        public int getIdCatSC()
        {
            return this.idCatdeSousCat;
        }

    }

}
