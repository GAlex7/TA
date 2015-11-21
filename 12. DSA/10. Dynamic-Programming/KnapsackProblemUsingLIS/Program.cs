namespace KnapsackProblemUsingLIS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Input:
            var n = 6;                                  // Number of distinct items (n)
            var v = new int[6] { 2, 12, 5, 4, 3, 13 };  // Values (stored in array v)
            var w = new int[6] { 3, 8, 4, 1, 2, 8 };    // Weights (stored in array w)
            var q = 13;                                 // Knapsack capacity (W)

            var unsortedProducts = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                unsortedProducts.Add(new Product("Name" + i + 1, w[i], v[i]));
            }

            var pr = unsortedProducts
                .OrderByDescending(p => p.V)
                .ThenByDescending(p => p.W).ToArray();

            var calc = new int[4, n];
            calc[0, 0] = 1;         // Length   calc[0, x]
            calc[1, 0] = -1;        // Prev     calc[1, x]
            calc[2, 0] = pr[0].W;   // Weight   calc[2, x]
            calc[3, 0] = pr[0].V;   // Cost     calc[3, x]

            var result = CalculateLongestIncreasingSubsequence(pr, calc, q);

            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("{0,-5}", calc[r, c]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Best value is {0}", result);
        }

        private static int CalculateLongestIncreasingSubsequence(Product[] sequence, int[,] m, int q)
        {
            var bestChoice = 0;
            for (var i = 1; i < sequence.Length; i++)
            {
                m[0, i] = 1;                 // Length   m[0, x]
                m[1, i] = -1;                // Prev     m[1, x]
                m[2, i] = sequence[i].W;     // Weight   m[2, x]
                m[3, i] = sequence[i].V;     // Cost     m[3, x]

                var bestCost = 0;
                var bestIndex = 0;
                var isFind = false;

                for (var k = 0; k <= i - 1; k++)
                {
                    if ((m[2, k] + m[2, i]) <= q)
                    {
                        if (m[3, k] + m[3, i] > bestCost)
                        {
                            bestCost = m[3, k] + m[3, i];
                            bestIndex = k;
                            isFind = true;
                        }
                    }
                }

                if (isFind)
                {
                    m[0, i] = m[0, bestIndex] + 1;
                    m[1, i] = bestIndex;
                    m[2, i] += m[2, bestIndex];
                    m[3, i] += m[3, bestIndex];
                }

                bestChoice = bestChoice < m[3, i] ? m[3, i] : bestChoice;
            }

            return bestChoice;
        }

        internal class Product
        {
            public Product(string name, int weight, int cost)
            {
                this.Name = name;
                this.W = weight;
                this.V = cost;
            }

            public string Name { get; set; }

            public int W { get; set; }

            public int V { get; set; }
        }
    }
}
