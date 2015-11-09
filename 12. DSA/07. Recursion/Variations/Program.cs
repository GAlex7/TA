namespace Variations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int k = 2;
            var array = new string[k];
            var strings = new string[] { "hi", "a", "b" };

            GenerateSubsets(array, strings, 0);
            Console.WriteLine();
        }

        private static void GenerateSubsets<T>(T[] subset, T[] original, int index)
        {
            if (index >= subset.Length)
            {
                Console.Write("(" + string.Join(" ", subset) + "), ");
            }
            else
            {
                for (int i = 0; i < original.Length; i++)
                {
                    subset[index] = original[i];
                    GenerateSubsets(subset, original, index + 1);
                }
            }
        }
    }
}
