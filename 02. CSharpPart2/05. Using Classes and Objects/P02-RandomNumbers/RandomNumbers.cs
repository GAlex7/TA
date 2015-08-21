// Problem 2. Random numbers

// Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace P02_RandomNumbers
{
    using System;

    class RandomNumbers
    {
        static Random rnd = new Random();
        static void Main()
        {
            int minValue = 100;
            int maxValue = 200;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}", rnd.Next(minValue, maxValue + 1));
                if (i != 9)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
