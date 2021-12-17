using System;

namespace Versandhaus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double Gesamtkosten; // nur die Kosten eines Artikels mit der Anzahl 
            double EinkaufsWagenPreis = 0; //Kompletter Preis am Ende
            double Versandkosten; // zuerst war hier 3.5 aber nun unten deklariert da es dann besser verständllich ist 
            string Warenkorb = "";
            string ArtikelName = "Artikel";
            int i = 1;
            ConsoleKeyInfo weitere;

            do
            {
                Console.WriteLine("\nBitte geben Sie den Preis des Ausgewählten Artikels ein, mit einem Komma für Cent Beträge!: ");
                double ArtikelPreis = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nGeben Sie nun die Stückzahl ein die Sie haben möchten: ");
                int Kaufmenge = Convert.ToInt32(Console.ReadLine());

                Gesamtkosten = Math.Round(ArtikelPreis * Kaufmenge,2);
                EinkaufsWagenPreis = Math.Round(EinkaufsWagenPreis + Gesamtkosten,2);
                Warenkorb += String.Format("{0}x {1}; Stückpreis: {2}; Gesamtpreis: {3}\n", Kaufmenge, ArtikelName+i++, ArtikelPreis, Gesamtkosten);
                Console.WriteLine("Möchten Sie noch weitere Artikel hinzufügen?:\t[Y/N]");
                weitere = Console.ReadKey();
                Console.Clear();
            } while (weitere.Key == ConsoleKey.Y);

            Console.WriteLine(Warenkorb);

            if(EinkaufsWagenPreis >= 20)
            {
                Versandkosten = 0;
            }
            else
            {
                Versandkosten = 3.5;    
            }
            EinkaufsWagenPreis = EinkaufsWagenPreis + Versandkosten;
            Console.WriteLine("Ihre Gesamtkosten betragen " + Math.Round(EinkaufsWagenPreis, 2) + " Euro inklusive Versand");
        }
    }
}
