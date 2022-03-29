using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Compte
    {
        public Compte()
        {
            Solde = 0;
        }
        public Compte(Client client, double solde, string typeCompte) // lire l'info du compte
        { 
            this.client = client;
            this.Solde = solde;
            this.typeCompte = typeCompte;
        }

        private Client client;
        private double Solde;
        private DateTime dateDepot;
        private DateTime dateRetrait;
        public string typeCompte { get; }

        public void Deposer(double montant)
        {
            Solde += montant; //solde = solde + montant
            dateDepot = DateTime.Now;
        }

        public void Retrait(double montant)
        { 
            Solde -= montant; //solde = solde - montant
            dateRetrait = DateTime.Now;
        }

        public double RetourneSolde()
        {
            return Solde;
        }
    }
}
