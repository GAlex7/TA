namespace ClassBiDictionary
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static int key1;
        private static byte key2;
        private static BiDictionary<int, byte, string> dictionary = new BiDictionary<int, byte, string>();

        public static void Main()
        {
            key1 = 1;
            key2 = 2;
            Console.WriteLine("Adding <1, 2, value 1>");
            dictionary.Add(key1, key2, "value 1");

            Console.WriteLine("Adding <1, 2, value 2>");
            dictionary.Add(key1, key2, "value 2");

            PrintResult(k1: key1);
            PrintResult(k2: key2);
            PrintResult(key1, key2);

            key1 = 1;
            key2 = 4;

            Console.WriteLine("Adding <1, 4, value 3>");
            dictionary.Add(key1, key2, "value 3");

            PrintResult(k1: key1);
            PrintResult(k2: key2);

            key1 = 2;
            key2 = 4;

            Console.WriteLine("Adding <2, 4, value 4>");
            dictionary.Add(key1, key2, "value 4");

            PrintResult(k1: 1);
            PrintResult(k1: 2);

            PrintResult(k2: 4);
            PrintResult(3, 2);
        }

        private static void PrintResult(int? k1 = null, byte? k2 = null)
        {
            var result = new List<string>();
            if (k1 == null)
            {
                if (dictionary.Find((byte)k2) != null)
                {
                    Console.Write("Found by key2 = {0}: ", k2);
                    Console.WriteLine(string.Join(", ", dictionary.Find((byte)k2)));
                }
                else
                {
                    Console.WriteLine("Nothing found by key2 = {0}!", k2);
                }
            }
            else if (k2 == null)
            {
                if (dictionary.Find((int)k1) != null)
                {
                    Console.Write("Found by key1 = {0}: ", k1);
                    Console.WriteLine(string.Join(", ", dictionary.Find((int)k1)));
                }
                else
                {
                    Console.WriteLine("Nothing found by key1 = {0}!", k1);
                }
            }
            else
            {
                if (dictionary.Find((int)k1, (byte)k2) != null)
                {
                    Console.Write("Found by key1 = {0} and key2 = {1}: ", k1, k2);
                    Console.WriteLine(string.Join(", ", dictionary.Find((int)k1, (byte)k2)));
                }
                else
                {
                    Console.WriteLine("Nothing found by key1 = {0} and key2 = {1}!", k1, k2);
                }
            }

            Console.WriteLine();
        }
    }
}
