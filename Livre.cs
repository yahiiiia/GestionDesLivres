using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        // Varaibles pour les info du livre
        public string tittre; // nom du livre
        public string auteur; // auteur du livre
        public double prix;   // le prix en CAD

        // Constrecteur pour cree un livre
        public Livre(string t, string a, double p)
        {
            // Initilisation des varaibles
            tittre = t;
            auteur = a;
            prix = p;
        }

        // Methode pour aficher les info du livre
        public void Afficher()
        {
            Console.WriteLine("Titre : " + tittre);
            Console.WriteLine("Auteur : " + auteur);
            Console.WriteLine("Prix : " + prix + " CAD");
        }

    }
}
