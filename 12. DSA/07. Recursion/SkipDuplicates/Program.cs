namespace SkipDuplicates
{
    using System;

    public class Program
    {
        private static int n;
        private static int k;
        private static int[] loops;

        public static void Main()
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());

            loops = new int[k];
            Loops(1, 0);
        }

        private static void Loops(int start, int currentLoop)
        {
            if (currentLoop >= k)
            {
                PrintLoops();
                return;
            }

            for (int i = start; i <= n; i++)
            {
                loops[currentLoop] = i;
                Loops(i + 1, currentLoop + 1);
            }
        }

        private static void PrintLoops()
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
