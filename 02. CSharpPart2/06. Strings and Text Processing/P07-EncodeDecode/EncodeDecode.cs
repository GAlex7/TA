// Problem 7. Encode/decode

// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter
// of the string with the first of the key, the second – with the second, etc. 
// When the last key character is reached, the next is the first.

namespace P07_EncodeDecode
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class EncodeDecode
    {
        static string Coding(string text, string cypher)
        {
            Queue<char> code = new Queue<char>(cypher);
            StringBuilder output = new StringBuilder();
            char codeKey;
            foreach (char ch in text)
            {
                codeKey = code.Dequeue();
                code.Enqueue(codeKey);
                output.Append((char)(ch ^ codeKey));
            }
            return output.ToString();
        }
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.Write("The cypher: ");
            string cypher = Console.ReadLine();
            input = Coding(input, cypher);
            Console.WriteLine("The encoded text is:\n {0}.", input);
            Console.WriteLine("The decoded text is:\n {0}.", Coding(input, cypher));
        }
    }
}
