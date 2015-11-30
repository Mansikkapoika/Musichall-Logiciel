using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHall.Classes
{
    class Commande
    {
        private int idCommande;
        private int idUtilisateur;
        private String date;
        private String status;
        private int montant;

        public Commande(int idCommande, int idUtilisateur, String date, String status, int montant)
        {
            this.idCommande = idCommande;
            this.idUtilisateur = idUtilisateur;
            this.date = date;
            this.status = status;
            this.montant = montant;
        }

        // Accesseurs

        public int IdCommande
        {
            get
            {
                return idCommande;
            }

            set
            {
                idCommande = value;
            }
        }

        public int IdUtilisateur
        {
            get
            {
                return idUtilisateur;
            }

            set
            {
                idUtilisateur = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }
    }
}
