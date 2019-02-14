using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a != 0 && b != 0)
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
            else
            {
                throw new ArgumentException();
            }
            return a;
        }
    }
}
