// Problem 4. Compare text files

// Write a program that compares two text files line by line and prints the number of lines
// that are the same and the number of lines that are different.
// Assume the files have equal number of lines.

namespace P04_CompareTextFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class CompareTextFiles
    {
        static void Main()
        {
            List<string> text = new List<string>();
            using (StreamReader reader = new StreamReader(@"..\..\TextOne.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    text.Add(line);
                    line = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(@"..\..\TextTwo.txt"))
            {
                int lineNumb = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine("Lines {0} are {1}.", lineNumb, text[lineNumb - 1].ToString() == line ? "the same" : "different");
                    line = reader.ReadLine();
                    lineNumb++;
                }
            }
        }
    }
}
