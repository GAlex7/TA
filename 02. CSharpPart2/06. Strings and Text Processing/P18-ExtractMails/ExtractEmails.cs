// Problem 18. Extract e-mails

// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace P18_ExtractMails
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ExtractEmails
    {
        static void Main()
        {
            Console.WriteLine("Enter some text with e-mails (or without ☺...):");
            string input = Console.ReadLine();

            input = (input + " ").Replace(". ", " ");
            string[] words = input.Split(new char[] { ' ', ',', '!', '?', ':', ';', '\t', '(', ')', '{', '}', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> mails = new List<string>();
            bool mailFound = false;
            int mailMinLength = 5;

            foreach (var item in words)
            {
                if (item.Contains("@") &&
                    item.Contains(".") &&
                    item.Length > mailMinLength)
                {
                    mails.Add(item);
                    mailFound = true;
                }
            }

            if (mailFound)
            {
                Console.WriteLine("\nAll e-mails in text are:");
                Console.WriteLine(string.Join("\n", mails));
            }
            else
                Console.WriteLine("\nThere isn't any e-mail");
        }
    }
}