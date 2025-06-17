using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welkom bij de interactieve WriteAllText-demo!");
        Console.WriteLine("---------------------------------------------");

        // Stap 1: Gebruiker voert bestandsnaam in
        Console.WriteLine("\nStap 1: Geef een bestandsnaam op (bijv. mijntekst.txt):");
        string bestandsnaam = Console.ReadLine();

        // Zet het bestand in de huidige map van het programma
        string pad = Path.Combine(Directory.GetCurrentDirectory(), bestandsnaam);

        // Stap 2: Gebruiker voert tekst in
        Console.WriteLine("\nStap 2: Typ de tekst die je wilt opslaan in het bestand:");
        string tekst = Console.ReadLine();

        // Stap 3: Bevestigen
        Console.WriteLine($"\nJe staat op het punt om deze tekst te schrijven naar '{pad}':");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine(tekst);
        Console.WriteLine("----------------------------------------------------");
        Console.Write("Weet je het zeker? (J/N): ");
        string bevestiging = Console.ReadLine().Trim().ToLower();

        if (bevestiging == "j")
        {
            try
            {
                File.WriteAllText(pad, tekst);
                Console.WriteLine("\n✅ Bestand succesvol geschreven!");

                Console.WriteLine("\n🔍 Je kunt het bestand openen door te navigeren naar deze map:");
                Console.WriteLine($">>> {Directory.GetCurrentDirectory()}");
                Console.WriteLine($"En open het bestand: {bestandsnaam}");

                Console.WriteLine("\n📂 Tip: Open Verkenner (Windows) of de Finder (macOS) en plak dat pad.");

                Console.WriteLine("\nJe hebt nu een tekstbestand geschreven!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Er is een fout opgetreden: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("\n🚫 Actie geannuleerd door gebruiker.");
        }

        Console.WriteLine("\nDruk op een toets om af te sluiten.");
        Console.ReadKey();
    }
}
