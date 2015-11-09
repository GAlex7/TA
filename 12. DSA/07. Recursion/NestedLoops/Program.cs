namespace NestedLoops
{
    using System;

    public class Program
    {
        private static int n;
        private static int[] loops;

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());

            loops = new int[n];
            Loops(0);
        }

        private static void Loops(int currentLoop)
        {
            if (currentLoop == n)
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
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
