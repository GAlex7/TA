namespace SubsetsOfStrings
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int k = 2;
            var strings = new string[] { "test", "rock", "fun" };
            var output = new string[k];

            GenerateCombinationsWithDuplicates(0, strings, output, 0);
            Console.WriteLine();
        }

        private static void GenerateCombinationsWithDuplicates<T>(int start, T[] input, T[] subset, int index)
        {
            if (index >= subset.Length)
            {
                Console.Write("(" + string.Join(" ", subset) + "), ");
            }
            else
            {
                for (int i = start; i < input.Length; i++)
                {
                    subset[index] = input[i];
                    GenerateCombinationsWithDuplicates(i + 1, input, subset, index + 1);
                }
            }
        }
    }
}
