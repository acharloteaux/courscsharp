using System;

class Program
{
    static void Main(string[] args)
    {
        string[] mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };

        Console.Write("Entrez votre salaire mensuel : ");
        double salaireMensuel = double.Parse(Console.ReadLine());
        
        Console.Write("Entrez le pourcentage de votre prime de Noël (exemple : 10 pour 10%) : ");
        int pourcentagePrime = int.Parse(Console.ReadLine());


        for (int i = 0; i < mois.Length; i++)
        {
            if (mois[i] == "Aout")
            {
                Console.WriteLine($"{mois[i]} : Entreprise fermée");
                continue;
            }

            double salaireAffiche = salaireMensuel;

            if (mois[i] == "Décembre")
            {
                double prime = salaireMensuel * 11 * 0.10;  
                salaireAffiche += prime;

                Console.WriteLine($"{mois[i]} : {salaireAffiche} € (+ 10% du salaire annuel : {prime} €)");
            }
            else
            {
                Console.WriteLine($"{mois[i]} : {salaireAffiche} €");
            }
        }
    }
}