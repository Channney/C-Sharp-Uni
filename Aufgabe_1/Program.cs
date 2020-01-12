using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var wallissches = new WallisschesProdukt();
            for(int i=1; i <= 1000; i++) {
                var produkt = wallissches.berechne(i);
                var diff = Math.PI - produkt;

                System.Console.WriteLine($"{i}:\t{produkt} \tdiff: {diff}");
            }
      
        }

        
        }

}
