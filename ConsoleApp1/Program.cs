// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables définies dans le debug (valeurs d'exemple)
        double salaireAnnuelBrut = 30000;
        double tauxImposition = 0.25; // 25%

        // Afficher le salaire brut annuel
        Console.WriteLine($"Le salaire brut annuel est : {salaireAnnuelBrut} €");

        // Calcul du salaire net annuel
        double salaireAnnuelNet = salaireAnnuelBrut * (1 - tauxImposition);

        // Calcul du salaire net mensuel
        double salaireNetMensuel = salaireAnnuelNet / 12;

        // Afficher le salaire net mensuel
        Console.WriteLine($"Le salaire net mensuel est : {salaireNetMensuel:N2} €");
    }
}
