// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        // Étape 1 : calcul du salaire brut mensuel à partir de 30k annuel
        double salaireAnnuel = 30000;
        double salaireMensuel = salaireAnnuel / 12;

        Console.WriteLine($"Le salaire brut mensuel est : {salaireMensuel} €");
    }
}
