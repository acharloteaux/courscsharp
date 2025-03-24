using System; 

class Program 
{
    static void Main(string[] args) 
    {
        // Demande à l'utilisateur d'entrer son salaire brut annuel
        Console.Write("Entrez votre salaire brut annuel (€) : ");

        // Lit la réponse +entrée clavier, stockée sous string
        string saisieSalaire = Console.ReadLine();

        // Vérifie si la saisie = chiffres
        if (EstUnNombre(saisieSalaire))
        {
            // Affiche le salaire brut annuel 
            Console.WriteLine($"Le salaire brut annuel est : {saisieSalaire} €");

            // Convertit la saisie (string) en un entier pour pouvoir faire des calculs
            int salaireBrutAnnuel = int.Parse(saisieSalaire);

            // Calcule le salaire brut mensuel en divisant le salaire annuel par 12
            int salaireBrutMensuel = salaireBrutAnnuel / 12;

            // Demande à l'utilisateur d'entrer son taux d'imposition
            Console.Write("Entrez votre taux d'imposition (en %) : ");

            // Lit la réponse de l'utilisateur pour le taux d'imposition
            string saisieTaux = Console.ReadLine();

            // Vérifie si le taux d'imposition est uniquement composé de chiffres
            if (EstUnNombre(saisieTaux))
            {
                // Affiche le taux d'imposition saisi par l'utilisateur
                Console.WriteLine($"\nLe taux d'imposition est : {saisieTaux}%");

                // Switch pour afficher un message personnalisé selon le taux d'imposition saisi
                switch (saisieTaux)
                {
                    case "0": // Si le taux d'imposition est 0
                        Console.WriteLine("Pas d'impôt !");
                        break;

                    case "100": // Si le taux d'imposition est 100
                        Console.WriteLine("Tout est pris ! ");
                        break;

                    default: // Pour tous les autres taux
                        Console.WriteLine("Impôt normal.");
                        break;
                }

                // Étape 2 : Afficher un conseil en fonction du salaire brut annuel ou mensuel

                // Si le salaire brut annuel est supérieur à 50 000 €
                if (salaireBrutAnnuel > 50000)
                {
                    Console.WriteLine("Vous devriez faire des dons pour réduire vos impôts !");
                }

                // Si le salaire brut mensuel est inférieur à 1 500 €
                if (salaireBrutMensuel < 1500)
                {
                    Console.WriteLine("C'est normal pour un alternant :)");
                }

                // Si le salaire brut annuel est compris entre 30 000 € et 40 000 €
                if (salaireBrutAnnuel >= 30000 && salaireBrutAnnuel <= 40000)
                {
                    Console.WriteLine("Viens à CESI pour faire un bac+5 en dev !");
                }

            }
            else // Si le taux d'imposition saisi n'est pas un nombre
            {
                Console.WriteLine("Ce n'est pas un nombre valide !");
            }
        }
        else // Si le salaire brut saisi n'est pas un nombre
        {
            Console.WriteLine("Ce n'est pas un nombre valide !");
        }
    }

    // Méthode pour vérifier si une chaîne de caractères est composée uniquement de chiffres
    static bool EstUnNombre(string saisie)
    {
        // Parcours chaque caractère de la saisie
        foreach (char c in saisie)
        {
            // Si le caractère n'est pas un chiffre (de 0 à 9)
            if (!char.IsDigit(c))
            {
                return false; // Retourne faux : ce n'est pas un nombre valide
            }
        }

        return true; // Tous les caractères sont des chiffres => c'est un nombre valide
    }
}
