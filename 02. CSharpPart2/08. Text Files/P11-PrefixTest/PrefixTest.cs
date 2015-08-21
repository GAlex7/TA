// Problem 11. Prefix "test"

// Write a program that deletes from a text file all words that start with the prefix test.
// Words contain only the symbols 0…9, a…z, A…Z, _.

namespace P11_PrefixTest
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
 
    class PrefixTest
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] words = line
                            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(x => !x.StartsWith("test",StringComparison.OrdinalIgnoreCase))
                            .ToArray();
                    text.AppendLine(string.Join(" ",words));
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(text.ToString());
            }
            Console.WriteLine("The problem is solved and result is in new file -> output.txt .");
            
        }
    }
}
