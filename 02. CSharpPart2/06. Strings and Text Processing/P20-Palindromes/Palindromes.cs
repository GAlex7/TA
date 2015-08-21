// Problem 20. Palindromes

// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

namespace P20_Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Palindromes
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '\t', '(', ')', '{', '}', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();
            bool palindromesFound = false;

            foreach (string word in words)
            {
                if (isPalindromes(word))
                {
                    palindromes.Add(word);
                    palindromesFound = true;
                }
            }

            if (palindromesFound)
            {
                Console.WriteLine("\nAll palindromes in text are:");
                Console.WriteLine(string.Join("\n", palindromes));
            }
            else
                Console.WriteLine("\nThere isn't any palindrome");
        }

        private static bool isPalindromes(string word)
        {
            bool check = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    check = false;
                    break;
                }
            }

            return check;
        }

    }
}
