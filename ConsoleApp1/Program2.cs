using System;

class Program2
{
    public static void Run()
    {
        // Demande à l'utilisateur son salaire brut annuel
        Console.Write("Entrez votre salaire brut annuel (€) : ");
        double salaireAnnuelBrut = Convert.ToDouble(Console.ReadLine());

        // Demande à l'utilisateur le taux d'imposition
        Console.Write("Entrez votre taux d'imposition (en %) : ");
        double tauxImpositionPourcentage = Convert.ToDouble(Console.ReadLine());

        // Conversion du pourcentage en décimal
        double tauxImposition = tauxImpositionPourcentage / 100;

        // Calcul du salaire net annuel
        double salaireAnnuelNet = salaireAnnuelBrut * (1 - tauxImposition);

        // Calcul du salaire net mensuel
        double salaireNetMensuel = salaireAnnuelNet / 12;

        // Affichages
        Console.WriteLine($"\nLe salaire brut annuel est : {salaireAnnuelBrut} €");
        Console.WriteLine($"Le salaire net mensuel est : {salaireNetMensuel:N2} €");
    }
}