// Problem 8. Extract sentences

// Write a program that extracts from a given text all sentences containing given word.
// Example:

// The word is: in

// The text is: 
// We are living in a yellow submarine. 
// We don't have anything else. Inside the submarine is very tight. 
// So we are drinking all the day. We will move out of it in 5 days.

// The expected result is: 
// We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

namespace P08_ExtractSentences
{
    using System;
    using System.Text;

    class ExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.Write("The word is: ");
            string key = Console.ReadLine();
            string keyProper = key[0].ToString().ToUpper() + key.Substring(1);
            string[] keys = new string[]
            {
                keyProper + ' ',
                ' ' + key + ' ',
                ' ' + key + '.',
                ' ' + key + ',',
                ' ' + key + '?',
                ' ' + key + '!'
            };

            string[] newText = input.Split('.');
            var output = new StringBuilder();
            foreach (var item in newText)
            {
                foreach (var keyitem in keys)
                {
                    if (item.Contains(keyitem))
                    {
                        output.Append(item);
                        output.Append('.');
                    }
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}
