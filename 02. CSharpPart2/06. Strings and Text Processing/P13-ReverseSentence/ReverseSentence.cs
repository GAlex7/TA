// Problem 13. Reverse sentence

// Write a program that reverses the words in given sentence.
// Example:

// input	                                output
// C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

namespace P13_ReverseSentence
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class ReverseSentence
    {
        static void Main()
        {
            string punctuation = ",.!?";
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            foreach (char ch in punctuation)
            {
                input = input.Replace(ch.ToString(), " " + ch);
            }
            string[] text = input.Split(' ');
            List<string> punctuationChar = new List<string>();
            List<int> punctuationPos = new List<int>();
            List<string> words = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!punctuation.Contains(text[i]))
                {
                    words.Add(text[i]);
                }
                else
                {
                    punctuationChar.Add(text[i]);
                    punctuationPos.Add(i);
                }
            }
            string[] reversedWords = words.ToArray();
            Array.Reverse(reversedWords);
            var result = new StringBuilder();
            int counter = 0;
            int tempPos = 0;
            foreach (var pos in punctuationPos)
            {
                for (int i = tempPos; i < pos - counter; i++)
                {
                    if (i > 0)
                    {
                        result.Append(' ');
                    }
                    result.Append(reversedWords[i]);
                }
                result.Append(punctuationChar[counter]);

                tempPos = pos;
                counter++;
            }
            string toPrint = result.ToString();
            Console.WriteLine(toPrint);
        }
    }
}