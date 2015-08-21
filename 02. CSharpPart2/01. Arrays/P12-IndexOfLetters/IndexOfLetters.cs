// Problem 12. Index of letters

// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('A' + i);
        }
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine().ToUpper();
        foreach (char letter in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter==alphabet[i])
                {
                    Console.Write("{0,3}",i);
                }
            }
        }
        Console.WriteLine();
    }
}