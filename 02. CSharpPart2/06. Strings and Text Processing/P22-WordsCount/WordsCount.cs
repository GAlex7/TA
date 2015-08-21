// Problem 22. Words count

// Write a program that reads a string from the console and lists all different words in 
// the string along with information how many times each word is found.

namespace P22_WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class WordsCount
    {

        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '\t', '(', ')', '{', '}', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            
            Dictionary<string, int> wordDict = new Dictionary<string, int>();

            CountWords(words, wordDict);
            if (wordDict.Count == 0)
            {
                Console.WriteLine("There's no words!");
            }
            else
            {
                foreach (var word in wordDict)
                {
                    Console.WriteLine("{0} -> {1}", word.Key, word.Value);
                }
            }
        }

        private static void CountWords(string[] text, Dictionary<string, int> words)
        {
            foreach (var item in text)
            {
                if (!words.ContainsKey(item))
                    words.Add(item, 1);
                else
                    words[item] += 1;
            }
        }

    }
}
