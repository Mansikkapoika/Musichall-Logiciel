using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHall
{
    class Materiel
    {
        private int idMateriel;
        private String libelle;
        private String description;
        private int prixAchHT;
        private int prixLoca;
        private int idSousCategorie;
        private String Marque;
        private String Modele;
        private String Fournisseur;

        public Materiel(int idMateriel, String libelle, String description, int prixAchHT, int prixLoca, int idSousCategorie, String Marque, String Modele, String Fournisseur)
        {
            this.idMateriel = idMateriel;
            this.libelle = libelle;
            this.description = description;
            this.prixAchHT = prixAchHT;
            this.prixLoca = prixLoca;
            this.idSousCategorie = idSousCategorie;
            this.Marque = Marque;
            this.Modele = Modele;
            this.Fournisseur = Fournisseur;
        }

        // Accesseurs à écrire


    }
}
