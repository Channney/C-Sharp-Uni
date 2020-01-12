using System;

namespace Aufgabe_3
{

    public class Pruefziffer
    {
        public static int getPruefziffer(char[] seriennummer)
        {
            int land = seriennummer[0] - 'A' + 1;
            int quersumme = land % 10 + land / 10;
            int pruefziffer = 0;

            for (int i = 1; i <= 10; i++)
            {
                quersumme += seriennummer[i] - '0';
            }

            pruefziffer = 8 - quersumme % 9;

            if (pruefziffer == 0)
            {
                pruefziffer = 9;
            }

            return pruefziffer;
        }
    }

}

