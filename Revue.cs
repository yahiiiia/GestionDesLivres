using AppConsoleLivres;
using System;

// Classe Revue qui herite de Livre
class Revue : Livre
{
    // proprietes suplementaire pour Revue
    public int numeroRev; // numero de la revue
    public int anneeRev;  // l'annee de la revue

    // Constrecteur pour inisialiser les propriete
    public Revue(string titre, string auteur, double prix, int numRev, int anneRev)
        : base(titre, auteur, prix) // Apel le constrecteur de la classe mere
    {
        numeroRev = numRev;
        anneeRev = anneRev;
    }

    // Methode pour aficher les info de la revue
    public override void Afficher()
    {
        base.Afficher(); // Apeler la methode Afficher() de la classe mere
        Console.WriteLine("Numéro : " + numeroRev);
        Console.WriteLine("Annee : " + anneeRev);
    }
}
