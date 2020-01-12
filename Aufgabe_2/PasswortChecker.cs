using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Aufgabe_2 {

    public static class PasswortChecker {

        public static int isGutesPasswort (string password) {

            int score = 0;

            char[] charArr = password.ToCharArray ();

            char[] uppercase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ä', 'Ö', 'Ü' };

            char[] lowercase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ä', 'ö', 'ü' };

            char[] sonderzeichen = { '!', '@', '#', '$', '%', '^', '&', '*', '?', '_', '~', '-', '£', '(', ')', '.', ',' };

            char[] ziffern = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            int anzahlUppercase = 0;
            int anzahlLowercase = 0;
            int anzahlSonderzeichen = 0;
            int anzahlZiffern = 0;

            foreach (char buchstabe in charArr) {

                if (uppercase.Contains (buchstabe))
                    anzahlUppercase++;

                if (lowercase.Contains (buchstabe))
                    anzahlLowercase++;

                if (sonderzeichen.Contains (buchstabe))
                    anzahlSonderzeichen++;

                if (ziffern.Contains (buchstabe))
                    anzahlZiffern++;

            }

            if (password.Length >= 12) {
                score++;
            }

            if (anzahlLowercase >= 1) {
                score++;
            }

            if (anzahlSonderzeichen >= 2) {
                score++;
            }

            if (anzahlUppercase >= 2) {
                score++;
            }

            if (anzahlZiffern >= 2) {
                score++;
            }

            int bothcase = anzahlLowercase + anzahlUppercase;

            if (bothcase >= 2) {
                score++;
            }

            // var slicePassword = password.Skip (0);

            // foreach (char buchstabe in slicePassword) {

            //     if (sonderzeichen.Contains (buchstabe))
            //         score++;
            // }

            // foreach (char buchstabe in slicePassword) {

            //     if (ziffern.Contains (buchstabe))
            //         score++;
            // }

            return score;
        }

    }
}