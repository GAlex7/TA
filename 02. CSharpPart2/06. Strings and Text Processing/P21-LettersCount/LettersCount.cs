// Problem 21. Letters count

// Write a program that reads a string from the console and prints all different letters in the string 
// along with information how many times each letter is found.

namespace P21_LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LettersCount
    {
        static Dictionary<char, int> chars = new Dictionary<char, int>();
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine();
            string temp = input;
            

            while (temp.Length > 0)
            {
                temp = countFirstCharInTextAndRemove(temp);
            }

            Console.WriteLine();
            foreach (var key in chars)
            {
                Console.WriteLine("{0} -> {1}", key.Key, key.Value);
            }

        }

        private static string countFirstCharInTextAndRemove(string text)
        {
            char ch = text[0];
            int counter = 1;
            StringBuilder newText = new StringBuilder();
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == ch)
                    counter++;
                else
                    newText.Append(text[i]);
            }
            chars.Add(ch, counter);
            return newText.ToString();
        }
    }
}
