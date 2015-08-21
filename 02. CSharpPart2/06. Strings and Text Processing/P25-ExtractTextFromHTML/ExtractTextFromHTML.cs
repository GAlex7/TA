// Problem 25. Extract text from HTML

// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

// Example input:
// <html>
//   <head><title>News</title></head>
//   <body><p><a href="http://academy.telerik.com">Telerik
//     Academy</a>aims to provide free real-world practical
//     training for young people who want to turn into
//     skilful .NET software engineers.</p></body>
// </html>

//Output:
//Title: News
//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main()
        {
            string title = string.Empty;
            string bodyText = string.Empty;

            Console.WriteLine("Enter a HTML text:");
            string text = Console.ReadLine();
            // get title

            int titleStartPos = text.IndexOf("<title>");
            if (titleStartPos != -1)
            {
                titleStartPos += "<title>".Length;
                title = text.Substring(titleStartPos, text.IndexOf("</title>") - titleStartPos);
            }
            Console.WriteLine("Title: {0}", title);

            //get body text
            int bodyStartPos = text.IndexOf("<body>");
            if (bodyStartPos != -1)
            {
                bodyStartPos += "<body>".Length;
                bodyText = text.Substring(bodyStartPos, text.IndexOf("</body>") - bodyStartPos);
            }

            // remove any tags
            int openTagsStartPos = bodyText.IndexOf('<');
            while (openTagsStartPos != -1)
            {
                bodyText = bodyText.Remove(openTagsStartPos, bodyText.IndexOf('>', openTagsStartPos) - openTagsStartPos + 1);
                bodyText = bodyText.Insert(openTagsStartPos, " ");
                openTagsStartPos = bodyText.IndexOf('<');
            }

            Console.WriteLine("Text: {0}", bodyText.Trim());
        }
    }
}
