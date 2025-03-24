
using System;

class Program
{
    static void Main(string[] args)
    {
        // Demande le salaire brut annuel
        Console.Write("Entrez votre salaire brut annuel (€) : ");
        string saisieSalaire = Console.ReadLine();

        // Vérification : est-ce que la saisie contient uniquement des chiffres ?
        if (EstUnNombre(saisieSalaire))
        {
            Console.WriteLine($"Le salaire brut annuel est : {saisieSalaire} €");

            // Demande le taux d'imposition
            Console.Write("Entrez votre taux d'imposition (en %) : ");
            string saisieTaux = Console.ReadLine();

            // Vérification : est-ce que la saisie contient uniquement des chiffres ?
            if (EstUnNombre(saisieTaux))
            {
                // Si les deux sont des nombres, affiche le récap
                Console.WriteLine($"\nLe taux d'imposition est : {saisieTaux}%");
                Console.WriteLine($"Votre salaire brut annuel est : {saisieSalaire} €");

                // Exemple : une case pour réagir à un taux particulier
                switch (saisieTaux)
                {
                    case "0":
                        Console.WriteLine("Pas d'impôt ? Chanceux !");
                        break;

                    case "100":
                        Console.WriteLine("Tout est pris ! Ça fait mal...");
                        break;

                    default:
                        Console.WriteLine("Impôt normal.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ce n'est pas un nombre valide !");
            }
        }
        else
        {
            Console.WriteLine("Ce n'est pas un nombre valide !");
        }
    }

    // vérifier chaque string = chiffre
    static bool EstUnNombre(string saisie)
    {
        foreach (char c in saisie)
        {
            if (!char.IsDigit(c)) // Si ce n'est pas un chiffre
            {
                return false; // => Ce n'est PAS un nombre
            }
        }

        return true; // Si on a vérifié tous les caractères et que ce sont des chiffres, alors c'est un nombre
    }
}

