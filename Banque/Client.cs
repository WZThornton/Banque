using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Client
    {
        public Client(uint ClientID)
        {
        }

        public Client(uint ClinetID, string Name, string Prenom, string Adresse, string Telephone, DateTime DateNaissance)
        {
            this.ClientID = ClientID;
            this.Name = Name;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.Telephone = Telephone;
            this.DateNaissance = DateNaissance;
        }

        public uint ClientID { get; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public DateTime DateNaissance { get; set; }

    }
}
