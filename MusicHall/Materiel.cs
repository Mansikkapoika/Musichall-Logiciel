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
        private int idMarque;
        private int idModele;
        private int idFournisseur;

        public Materiel(int idMateriel, String libelle, String description, int prixAchHT, int prixLoca, int idSousCategorie, int idMarque, int idModele, int idFournisseur)
        {
            this.idMateriel = idMateriel;
            this.libelle = libelle;
            this.description = description;
            this.prixAchHT = prixAchHT;
            this.prixLoca = prixLoca;
            this.idSousCategorie = idSousCategorie;
            this.idMarque = idMarque;
            this.idModele = idModele;
            this.idFournisseur = idFournisseur;
        }

        // Accesseurs à écrire
        // ... Test Git plugin for Visual Studio 15 :)

    }
}
