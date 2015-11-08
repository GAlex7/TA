namespace Fibonacci
{
    using System;

    public class Program
    {
        private static int[] fib;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            fib = new int[n + 1];
            fib[1] = 1;
            fib[2] = 1;

            Console.WriteLine(Fib(n));
        }

        private static int Fib(int n)
        {
            if (fib[n] > 0)
            {
                return fib[n];
            }

            fib[n] = (Fib(n - 1) + Fib(n - 2)) % 1000000007;
            return fib[n];
        }
    }
}