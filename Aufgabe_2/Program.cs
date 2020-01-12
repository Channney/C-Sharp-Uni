using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;
using System.Text;


namespace Aufgabe_2
{
    public static class Passwort
    {
        public static void Main(string[] args)
        {
            //Eingabe und Ausgabe des Passworts
            Console.WriteLine("Bitte geben Sie ihr Passwort ein: ");
            string eingabePassword = Console.ReadLine();
            int result = PasswortChecker.isGutesPasswort(eingabePassword);
            Console.WriteLine($"Das Passwort hat die Stärke {result}");

        }


    }
}


