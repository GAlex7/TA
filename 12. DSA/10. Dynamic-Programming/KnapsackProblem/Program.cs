namespace KnapsackProblem
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Input:
            var v = new int[6] { 2, 12, 5, 4, 3, 13 }; // Values (stored in array v)
            var w = new int[6] { 3, 8, 4, 1, 2, 8 };   // Weights (stored in array w)
            var n = 6;   // Number of distinct items (n)
            var q = 13;  // Knapsack capacity (W)
            var m = new int[n, q];

            for (int j = 0; j < q; j++)
            {
                m[0, j] = 0;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    if (w[i] <= j)
                    {
                        m[i, j] = Math.Max(m[i - 1, j], m[i - 1, j - w[i]] + v[i]);
                    }
                    else
                    {
                        m[i, j] = m[i - 1, j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(m[i, j] + "  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Best sum is {0}", m[n - 1, q - 1]);
        }
    }
}
