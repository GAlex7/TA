// Problem 9. Forbidden words

// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.
// Example text: Microsoft announced its next generation PHP compiler today. 
//                      It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

// Forbidden words: PHP, CLR, Microsoft

// The expected result: ********* announced its next generation *** compiler today.
//                      It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace P09_ForbiddenWordsC
{
    using System;
    using System.Text;

    class ForbiddenWords
    {
        static void Main()
        {
            Console.Write("Enter forbidden words, separated by space: ");
            string input = Console.ReadLine();
            string[] forbiddenWords =  { "PHP", "CLR", "Microsoft" };//input.Split(' ');
            Console.Write("Enter text: ");
            input = Console.ReadLine();
            foreach (var item in forbiddenWords)
            {
                input = input.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine("New text without forbidden words id:");
            Console.WriteLine(input);
        }
    }
}
