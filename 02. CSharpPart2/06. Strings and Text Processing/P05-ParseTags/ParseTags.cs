// Problem 5. Parse tags

// You are given a text. Write a program that changes the text in all regions
// surrounded by the tags <upcase> and </upcase> to upper-case.
// The tags cannot be nested.
// Example: We are living in a <upcase>yellow submarine</upcase>. 
//          We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace P05_ParseTags
{
    using System;
    using System.Text;

    class ParseTags
    {
        static void UpperTags(string text)
        {
            int upStart = 0;
            int upEnd = 0;
            
            while (upStart != -1)
            {
                var newString = new StringBuilder();
                upStart = text.IndexOf("<upcase>");
                upEnd = text.IndexOf("</upcase>");
                if (upStart == -1)
                    break;
                newString.Append(text.Substring(0, upStart));
                newString.Append(text.Substring(upStart + 8, upEnd - upStart - 8).ToUpper());
                newString.Append(text.Substring(upEnd + 9));
                text = newString.ToString();
            }
            Console.WriteLine(text);
        }
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string input = Console.ReadLine();
            UpperTags(input);
        }
    }
}
