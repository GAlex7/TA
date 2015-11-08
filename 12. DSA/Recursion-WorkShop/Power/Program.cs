namespace Power
{
    using System;

    public class Program
    {
        private const int Mod = 1000000007;

        public static void Main()
        {
            Console.WriteLine(PowMod(2,5));
        }

        private static long PowMod(long a, long p)
        {
            if (p == 0)
            {
                return 1;
            }

            if (p % 2 == 1)
            {
                return PowMod(a, p - 1) * a % Mod;
            }

            var b = PowMod(a, p / 2);

            return b * b % Mod;
        }
    }
}
