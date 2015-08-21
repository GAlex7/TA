// Problem 4. Sub-string in text

// Write a program that finds how many times a sub-string is 
// contained in a given text (perform case insensitive search).
// Example:

// The target sub-string is     in

// The text is as follows: 
// We are living in an yellow submarine. We don't have anything else. 
// inside the submarine is very tight. So we are drinking all the day. 
// We will move out of it in 5 days.

//The result is: 9

namespace P04_SubstringInText
{
    using System;
    using System.Text;

    class SubstringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string input = Console.ReadLine();
            Console.Write("The target sub-string is: ");
            string target = Console.ReadLine();
            int counter = 0;
            int nextPos = input.IndexOf(target);
            while (nextPos!=-1)
            {
                counter++;
                nextPos = input.IndexOf(target, nextPos + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
