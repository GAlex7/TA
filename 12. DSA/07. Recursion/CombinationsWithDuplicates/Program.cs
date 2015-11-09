namespace CombinationsWithDuplicates
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
            Loops(0);
        }

        private static void Loops(int currentLoop)
        {
            if (currentLoop == k)
            {
                PrintLoops();
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                loops[currentLoop] = i;
                Loops(currentLoop + 1);
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
