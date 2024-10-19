using AppConsoleLivres;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Création de trois objets Revue
        Revue revue1 = new Revue("Optique", "Ibn al-Haytham", 20.99, 1, 1573); // Kitab al-Manazir
        Revue revue2 = new Revue("La géographie", "Al-Idrisi", 18.50, 2, 1592); // Nuzhat al-mushtaq
        Revue revue3 = new Revue("Voyages", "Ibn Battuta", 12.99, 3, 1545); // Rihla

        // Création de trois objets Livre avec des titres réels
        Livre livre1 = new Livre("Le Livre de l'optique", "Ibn al-Haytham", 25.99); // Kitab al-Manazir
        Livre livre2 = new Livre("La Géographie", "Al-Idrisi", 22.75); // Nuzhat al-mushtaq fi ikhtiraq al-afaq
        Livre livre3 = new Livre("Les Voyages d'Ibn Battuta", "Ibn Battuta", 30.50); // Rihla

        // Affichage des informations des revues
        revue1.Afficher();
        revue2.Afficher();
        revue3.Afficher();

        // Affichage des informations des livres
        livre1.Afficher();
        livre2.Afficher();
        livre3.Afficher();

        // Garde la console ouverte jusqu'à ce que l'utilisateur appuie sur une touche
        Console.WriteLine("Appuyez sur une touche pour fermer...");
        Console.ReadKey();
    }
}
