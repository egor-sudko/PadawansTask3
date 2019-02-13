using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a != b)
            {
                while (a != b)
                {
                    while (a > b)
                    {
                        a = a - b;
                    }
                    while (b > a)
                    {
                        b = b - a;
                    }
                }
            }
            return a;
        }
    }
}
