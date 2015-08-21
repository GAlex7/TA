// Problem 24. Order words

// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace P24_OrderWords
{
    using System;
    using System.Linq;

    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '\t', '(', ')', '{', '}', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
            }

            words = words.Distinct().ToArray();
            words = words.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
