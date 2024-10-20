using System;

namespace AppConsoleLivres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de trois objets Roman avec des titres de la littérature franco-marocaine
            Roman roman1 = new Roman("Le Pain nu", "Mohamed Choukri", 152, "Autobiographie");
            Roman roman2 = new Roman("L'Enfant de sable", "Tahar Ben Jelloun", 198, "Fiction");
            Roman roman3 = new Roman("La Boîte à merveilles", "Ahmed Sefrioui", 245, "Roman autobiographique");

            // Affichage des informations des romans
            roman1.Afficher();
            roman2.Afficher();
            roman3.Afficher();

            // Garde la console ouverte jusqu'à ce que l'utilisateur appuie sur une touche
            Console.WriteLine("Appuyez sur une touche pour fermer...");
            Console.ReadKey();
        }
    }
}
