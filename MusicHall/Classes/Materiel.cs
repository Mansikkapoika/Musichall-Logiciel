using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHall.Classes
{
    public class Materiel
    {
        private int idMateriel;
        private String libelle;
        private String description;
        private decimal prixAchHT;
        private int idSousCategorie;
        private String Marque;
        private String Modele;
        private String Fournisseur;
        private int nbstock;
        private String cheminImage;

        public Materiel(int idMateriel, String libelle, String description, decimal prixAchHT, int idSousCategorie, String Marque, String Modele, String Fournisseur, int nbstock, String cheminImage)
        {
            this.idMateriel = idMateriel;
            this.libelle = libelle;
            this.description = description;
            this.prixAchHT = prixAchHT;
            this.idSousCategorie = idSousCategorie;
            this.Marque = Marque;
            this.Modele = Modele;
            this.Fournisseur = Fournisseur;
            this.nbstock = nbstock;
            this.cheminImage = cheminImage;
        }

        // Accesseurs

        public int getId()
        {
            return this.idMateriel;
        }

        public String getLibelle()
        {
            return this.libelle;
        }

        public String getDescription()
        {
            return this.description;
        }

        public decimal getPrixAch()
        {
            return this.prixAchHT;
        }

        public String getMarque()
        {
            return this.Marque;
        }

        public String getModele()
        {
            return this.Modele;
        }

        public String getFournisseur()
        {
            return this.Fournisseur;
        }

        public int getIdSousCategorie()
        {
            return this.idSousCategorie;
        }

        public int getNbStock()
        {
            return this.nbstock;
        }

        public String getCheminImage()
        {
            return this.cheminImage;
        }
    }
}
