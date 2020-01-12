using System;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Bitte geben Sie a ein.");
        var erstezahl = Console.ReadLine();
        System.Console.WriteLine("Bitte geben Sie b ein.");
        var zweitezahl = Console.ReadLine();
        var zahl1 = Int32.Parse(erstezahl);
        var zahl2 = Int32.Parse(zweitezahl);
        var addiere = Rekursiv.addieren(zahl1, zahl2);
        var multipliziere = Rekursiv.multiplizieren(zahl1,zahl2);
        System.Console.WriteLine($"Das Ergebnis vom addieren ist: {addiere} Das Ergebnis vom multiplizieren ist: {multipliziere}");
        }
    }
}
