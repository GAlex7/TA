// Problem 13. Count words

// Write a program that reads a list of words from the file words.txt and 
// finds how many times each of the words is contained in another file test.txt.
// The result should be written in the file result.txt and the words should be 
// sorted by the number of their occurrences in descending order.
// Handle all possible exceptions in your methods.

namespace P13_CountWords
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountWords
    {
        static Dictionary<string, int> wordsCollection = new Dictionary<string, int>();
        static StringBuilder text = new StringBuilder();
        static void Main()
        {
            ReadWordsFromFile(wordsCollection);
            ReadTextFromFileAndCountWords();

            // build sorted stringBuilder
            foreach (var word in wordsCollection.OrderByDescending(x => x.Value))
            {
                text.AppendLine(String.Format("{0}: {1}", word.Key, word.Value));
            }

            WriteResultToFile(text);

            Console.WriteLine("The problem is solved and result is in new file -> result.txt .");
        }

        private static void ReadTextFromFileAndCountWords()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] words = line
                            .ToLower()
                            .Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '-', '+', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(x => wordsCollection.ContainsKey(x.ToLower()))
                            .ToArray();

                        foreach (var word in words)
                        {
                            wordsCollection[word]++;
                        }

                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error.");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("File is too big for RAM...");
            }
        }

        private static void ReadWordsFromFile(Dictionary<string, int> words)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\words.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] temp = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in temp)
                        {
                            words.Add(item.ToLower(), 0);
                        }

                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error.");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("File is too big for RAM...");
            }
        }

        private static void WriteResultToFile(StringBuilder text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
                {
                    writer.WriteLine(text.ToString());
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You haven't permission to access the file.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path is too long...");
            }
        }

    }
}
