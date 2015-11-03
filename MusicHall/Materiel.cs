﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHall
{
    public class Materiel
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

        public int getPrixAch()
        {
            return this.prixAchHT;
        }

        public int getPrixLoca()
        {
            return this.prixLoca;
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

    }
}
