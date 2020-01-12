using System;

namespace Aufgabe_1
{

    class WallisschesProdukt
    {

        public double berechne(int n)
        {
            int zähler = 0;
            int nenner = 1;
            double prod = 1;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    nenner = nenner + 2;
                }
                else
                {
                    zähler = zähler + 2;
                }
                prod = prod * zähler / nenner;
            }

            prod *= 2;
            return prod;
        }

    }


}


