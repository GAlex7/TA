// Problem 12. Remove words

// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

namespace P12_RemoveWords
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Text;

    class RemoveWords
    {
        static List<string> words = new List<string>();
        static StringBuilder text = new StringBuilder();

        static void Main()
        {
            ReadWordsFromFile(words);
            ReadTextFromFileAndRemoveWords();
            WriteResultToFile(text);

            Console.WriteLine("The problem is solved and result is in new file -> output.txt .");
        }

        private static void ReadTextFromFileAndRemoveWords()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        foreach (var word in words)
                        {
                            line = RemoveWord(line, word);
                        }
                        text.AppendLine(line);
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
                using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
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

        private static void ReadWordsFromFile(List<string> words)
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
                            words.Add(item.ToLower());
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

        private static string RemoveWord(string line, string word)
        {
            try
            {
                int startPos = line.IndexOf(word, StringComparison.OrdinalIgnoreCase);

                bool isFirstWord;
                bool isLastWord;
                bool isPrevCharLetter;
                bool isNextCharLeter;

                while (startPos != -1)
                {
                    isFirstWord = (startPos == 0);
                    isLastWord = (startPos + word.Length >= line.Length);
                    isNextCharLeter = !isLastWord ? (char.IsLetter(line[startPos + word.Length])) : false;
                    isPrevCharLetter = !isFirstWord ? (char.IsLetter(line[startPos - 1])) : false;

                    if ((isFirstWord && (isLastWord || !isNextCharLeter)) ||
                       (!isPrevCharLetter && (isLastWord || !isNextCharLeter)))
                    {
                        if (line.Length > startPos + word.Length)
                            line = line.Remove(startPos, word.Length + 1);
                        else line = line.Remove(startPos);

                    }
                    if (line.Length > startPos)
                        startPos = line.IndexOf(word, startPos + 1, StringComparison.OrdinalIgnoreCase);
                    else startPos = -1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Arguments are out of range.");
            }
            return line;
        }

    }
}
