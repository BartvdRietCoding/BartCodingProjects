using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welkom bij de interactieve File.WriteAllText-demo!");
        Console.WriteLine("-----------------------------------------------------");

        // Stap 1: Bestandsnaam opvragen
        Console.WriteLine("\nStap 1: Voer een bestandsnaam in (bijv. output.txt):");
        string bestandsnaam = Console.ReadLine();

        // Pad bepalen in de huidige directory
        string pad = Path.Combine(Directory.GetCurrentDirectory(), bestandsnaam);

        // Stap 2: Meerdere regels tekst opvragen
        Console.WriteLine("\nStap 2: Typ de tekst die je wilt opslaan (typ 'STOP' op een nieuwe regel om af te sluiten):");
        string regel;
        string tekst = "";

        while (true)
        {
            regel = Console.ReadLine();
            if (regel.Trim().ToUpper() == "STOP")
                break;

            tekst += regel + Environment.NewLine;
        }

        // Stap 3: Preview & bevestiging
        Console.WriteLine("\nPreview van wat er geschreven wordt:");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(tekst);
        Console.WriteLine("---------------------------------------");

        Console.Write("Weet je zeker dat je dit wilt opslaan in '" + bestandsnaam + "'? (J/N): ");
        string keuze = Console.ReadLine().Trim().ToLower();

        // Stap 4: Schrijf naar bestand
        if (keuze == "j")
        {
            try
            {
                File.WriteAllText(pad, tekst);
                Console.WriteLine("\nBestand succesvol geschreven!");
                Console.WriteLine("Locatie: " + pad);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOeps, er ging iets mis: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("\nSchrijven geannuleerd door gebruiker.");
        }

        Console.WriteLine("\nDruk op een toets om af te sluiten...");
        Console.ReadKey();
    }
}