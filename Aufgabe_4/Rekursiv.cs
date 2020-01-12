using System;

namespace Aufgabe_4
{

    public class Rekursiv
    {
        public static int addieren(int a, int b)
        {
            if (b == 0 && a == 0)
            {
                return 0;
            }
            else if (a == 0)
            {
                return 1 + addieren(0, b - 1);
            }
            else
            {
                return 1 + addieren(a - 1, b);
            }
        }


        public static int multiplizieren(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            else
            {
                return addieren(a, multiplizieren(a, b - 1));
            }
        }
    }
}



