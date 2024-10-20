using System;
using System.Collections.Generic;

namespace AppConsoleLivres
{
    class Program
    {
        static void Main(string[] args)
        {
            // cree des objet Roman
            Roman roman1 = new Roman("Le Pain nu", "Mohamed Choukri", 152, "Autobiographie");
            Roman roman2 = new Roman("L'Enfant de sable", "Tahar Ben Jelloun", 198, "Fiction");
            Roman roman3 = new Roman("La Boîte à merveilles", "Ahmed Sefrioui", 245, "Roman autobiographique");

            // cree des objet Revue
            Revue revue1 = new Revue("Optique", "Ibn al-Haytham", 20.99, 1, 1573);
            Revue revue2 = new Revue("La géographie", "Al-Idrisi", 18.50, 2, 1592);
            Revue revue3 = new Revue("Voyages", "Ibn Battuta", 12.99, 3, 1545);

            // faire une list de type Livre
            List<Livre> listeLivres = new List<Livre>();

            // ajouter les objet a la liste
            listeLivres.Add(roman1);
            listeLivres.Add(roman2);
            listeLivres.Add(roman3);
            listeLivres.Add(revue1);
            listeLivres.Add(revue2);
            listeLivres.Add(revue3);

            // parcourir la liste pour montrer les info
            foreach (Livre livre in listeLivres)
            {
                livre.Afficher();
                Console.WriteLine(""); // laiss er une ligne vide
            }
        }
    }
}
