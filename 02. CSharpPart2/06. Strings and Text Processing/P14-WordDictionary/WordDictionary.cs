// Problem 14. Word dictionary

// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.
// Sample dictionary:

// input	    output
// .NET	        platform for applications from Microsoft
// CLR	        managed execution environment for .NET
// namespace	hierarchical organization of classes

namespace P14_WordDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class WordDictionary
    {
        static Dictionary<string, string> myDict = new Dictionary<string, string>();
        static void Main()
        {
            ReadDictionary();

            Console.Write("Enter a word: ");
            string input = Console.ReadLine().TrimStart().TrimEnd();
            bool notFoud = true;
            foreach (var key in myDict.Keys)
            {
                if (key == input)
                {
                    Console.WriteLine("{0} -> {1}", key, myDict[key]);
                    notFoud = false;
                    break;
                }
            }
            if (notFoud)
            {
                Console.WriteLine("Sorry, there is no such word in the dictionary... Yet...");
            }
        }

        private static void ReadDictionary()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Dictionary.txt"))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    string[] temp = line.Split('~');
                    myDict.Add(temp[0], temp[1]);
                    line = reader.ReadLine();
                }
            }
        }

    }
}
