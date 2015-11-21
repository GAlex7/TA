namespace SuperSum
{
    using System;
    using System.Linq;

    public class Program
    {

        public static void Main()
        {
            const int Max = 14;
            var kn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = kn[0];
            var n = kn[1];

            var dp = new int[Max+1, Max+1];
            for (int i = 0; i <= Max; i++)
            {
                dp[0, i] = i;
            }

            for (int r = 1; r <= Max; r++)
            {
                for (int c = 0; c <= Max; c++)
                {
                    if (r == c)
                    {
                        dp[r, c] = r;
                    }

                    if (c > r)
                    {
                        dp[r, c] = dp[r, c - 1] + c;
                    }
                }
            }

            var superSum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (k - 1 > i)
                {
                    superSum += dp[i, k - 1];
                    // Console.WriteLine("[{0}, {1}] + {2}", i, k - 1, dp[i, k - 1]);
                }
                else
                {
                    superSum += dp[k - 1, i];
                    // Console.WriteLine("[{0}, {1}] + {2}", k - 1, i, dp[k - 1, i]);

                }
            }

            Console.WriteLine(superSum);
        }
    }
}
