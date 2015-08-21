// Problem 12. Parse URL

// Write a program that parses an URL address given in the format: 
// [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// Example:

// URL	                                                    Information
// http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
//                                                          [server] = telerikacademy.com 
//                                                          [resource] = /Courses/Courses/Details/212

namespace P12_ParseURL
{
    using System;
    using System.Text;

    class ParseURL
    {
        static void Main()
        {
            Console.Write("Enter an URL: ");
            string input = Console.ReadLine();

            Uri url = new Uri(input);
            string pr = url.Scheme;
            string sr = url.Host;
            string res = url.AbsolutePath;

            Console.WriteLine("[protocol] = {0}",pr);
            Console.WriteLine("[server] = {0}",sr);
            Console.WriteLine("[resource] = {0}",res);
        }
    }
}
