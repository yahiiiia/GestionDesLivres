using System;

namespace AppConsoleLivres
{
    // Classe Roman qui hérite de Livre
    class Roman : Livre
    {
        // varible pour le genre du roman
        public string genr;

        // constrecteur pour cree un nouvau roman
        public Roman(string t, string a, int pages, string g) : base(t, a, pages)
        {
            genr = g; // initilise le genre
        }

        // pour aficher les info du roman
        public override void Afficher()
        {
            // aficher d'abore les info du livre
            base.Afficher();
            // puis aficher le genre du roman
            Console.WriteLine("Le genre est : " + genr);
        }
    }
}
