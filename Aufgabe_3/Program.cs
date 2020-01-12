using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bitte Geldscheinnummer eingeben:");
            var nummer = Console.ReadLine();
            var pruefziffer = Pruefziffer.getPruefziffer(nummer.ToCharArray());
            System.Console.WriteLine($"Die Prüfziffer ist {pruefziffer}");
        }
    }
}
