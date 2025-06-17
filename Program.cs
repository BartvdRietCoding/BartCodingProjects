using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welkom bij de interactieve File.ReadAllText-demo!");
        Console.WriteLine("---------------------------------------------------");

        // Stap 1: Bestandsnaam opvragen
        Console.WriteLine("\nStap 1: Voer de naam van het bestand in dat je wilt lezen (bijv. mijntekst.txt):");
        string bestandsnaam = Console.ReadLine();

        // Pad bepalen in de huidige directory
        string pad = Path.Combine(Directory.GetCurrentDirectory(), bestandsnaam);

        // Stap 2: Probeer het bestand te lezen
        if (File.Exists(pad))
        {
            try
            {
                string inhoud = File.ReadAllText(pad);
                Console.WriteLine("\nInhoud van het bestand:");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(inhoud);
                Console.WriteLine("---------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOeps, er ging iets mis bij het lezen van het bestand: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"\nBestand '{bestandsnaam}' bestaat niet in de huidige directory: {Directory.GetCurrentDirectory()}");
        }

        Console.WriteLine("\nDruk op een toets om af te sluiten...");
        Console.ReadKey();
    }
}
