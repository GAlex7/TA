﻿// Problem 15. Replace tags

// Write a program that replaces in a HTML document given as string all the 
// tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
// Example:

// input	
// <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
// Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

// output
// <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
// Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace P15_ReplaceTags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine("Enter a HTML text:");
            string line = Console.ReadLine();
            line = line.Replace("<a href=\"", "[URL=");
            line = line.Replace("</a>", "/URL");
            line = line.Replace("\">", "]");
            Console.WriteLine("The same text with new tags:");
            Console.WriteLine(line);
        }
    }
}
