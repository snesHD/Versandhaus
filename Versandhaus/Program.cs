using System;

namespace Versandhaus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double Gesamtkosten; // nur die Kosten eines Artikels mit der Anzahl nicht des Gesamt
            double EinkaufsWagenPreis = 0;
            int Kaufmenge;
            double Versandkosten; // zuerst war hier 3.5 aber nun unten deklariert da es dann besser verständllich ist 
            ConsoleKeyInfo weitere;

            do
            {
                Console.WriteLine("\nBitte geben Sie den Preis des Ausgewählten Artikels ein, mit einem Komma für Cent Beträge!: ");
                double ArtikelPreis = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nGeben Sie nun die Stückzahl ein die Sie haben möchten: ");
                Kaufmenge = Convert.ToInt32(Console.ReadLine());

                Gesamtkosten = Math.Round(ArtikelPreis * Kaufmenge,2);
                EinkaufsWagenPreis = Math.Round(EinkaufsWagenPreis + Gesamtkosten,2);

                Console.WriteLine("Möchten Sie noch weitere Artikel hinzufügen?:\t[Y/N]");
                weitere = Console.ReadKey();
                Console.Clear();
            } while (weitere.Key == ConsoleKey.Y);

            if(Gesamtkosten > 20)
            {
                Versandkosten = 0;
                // Nicht nötig Gesamtkosten nochmal neu zu Deklarieren da sich am Wert nichts ändert
                Console.WriteLine("Ihre Gesamtkosten betragen " + Math.Round(EinkaufsWagenPreis,2) + " Euro inklusive Versand");
            }
            else
            {
                Versandkosten = 3.5;
                Gesamtkosten = Gesamtkosten + Versandkosten;
                Console.WriteLine("Ihre Gesamtkosten betragen " + Math.Round(EinkaufsWagenPreis,2) + " Euro inklusive Versand");
            }
            
        }
    }
}
