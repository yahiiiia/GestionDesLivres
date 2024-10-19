using AppConsoleLivres;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Création d'un nouvel objet Livre
        Livre livre1 = new Livre("Programmation C#", "Youness Boukouchi", 49.99);

        // Affichage des informations du livre
        livre1.Afficher();

        // Attendre que l'utilisateur appuie sur une touche pour fermer
        Console.WriteLine("Appuyez sur une touche pour fermer...");
        Console.ReadKey();
    }
}
