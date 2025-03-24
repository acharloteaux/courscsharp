// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
        
        Console.Write("Entrez votre salaire mensuel : ");
        double salaireMensuel = double.Parse(Console.ReadLine());

        for (int i = 0; i < mois.Length; i++)
        {
            if (mois[i] == "Aout")
            {
                Console.WriteLine($"{mois[i]} : Entreprise fermée");
                continue;
            }
            
            if (mois[i] == "Décembre")
            {
                double prime = salaireMensuel * 11 * 0.10;
                salaireMensuel += prime;
                Console.WriteLine($"{mois[i]} : {salaireMensuel} € (avec prime de {prime} € pour le mois de décembre)");
            }
            else
            {
                Console.WriteLine($"{mois[i]} : {salaireMensuel} €");
            }

         
        }
    }
}