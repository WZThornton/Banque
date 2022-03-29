using System;
using static System.Console;

namespace Banque
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(1);
            client1.Name = "Thornton";
            client1.Prenom = "William";


            Client client2 = new Client(2, "Claude", "Julien", "Montreal", "514-123-4567", new DateTime(2002,07,01));

            WriteLine($"Le nom du client est : {0}", client2.Name);

            Client client3 = new Client(3, "Paul", "LeChat", "Villeray", "514-987-6543", new DateTime(2012,08,09));
            Client client4 = new Client(4,"Naim", "Himrane", "Villeray", "514-123-4678", new DateTime(2020,08,29));

            client1.Adresse = "Rosemere";
            client1.Telephone = "438-654-6543";
            client1.DateNaissance = new DateTime(2020, 01, 02);

            Compte compte1 = new Compte(client1, 0 , "Cheque");
            Compte compte2 = new Compte(client2, 0 , "cheque");
            Compte compte3 = new Compte(client3, 0 , "Epargne");



            //clientID = 4; Naim, Himrane, 2022-02-02, Laval, 514-123-4567, solde = $1000
            Compte compte4 = new Compte(client3, 1000, "Cheque");

            compte4.Deposer(100);
            WriteLine($"Le montant dans le compte est {0}",compte4.RetourneSolde());
        }
    }
}
