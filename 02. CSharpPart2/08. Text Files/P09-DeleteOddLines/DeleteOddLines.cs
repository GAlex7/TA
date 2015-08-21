// Problem 9. Delete odd lines

// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

namespace P09_DeleteOddLines
{
    using System;
    using System.IO;
    using System.Text;

    class DeleteOddLines
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"..\..\Text.txt"))
            {
                int counter = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        text.AppendLine(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter(@"..\..\Text.txt"))
            {
                writer.WriteLine(text.ToString());
            }
            Console.WriteLine("The problem is solved and result is in new file -> output.txt .");
        }
    }
}
