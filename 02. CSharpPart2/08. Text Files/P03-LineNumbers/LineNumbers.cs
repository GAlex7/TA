// Problem 3. Line numbers

// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

namespace P03_LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    class LineNumbers
    {
        static void Main()
        {
            int lineNumb = 1;
            StringBuilder text = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"..\..\Text.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    text.AppendFormat("{0,3}. {1}", lineNumb, line);
                    text.AppendLine();
                    lineNumb++;
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\NewText.txt"))
            {
                writer.Write(text.ToString());
            }
            Console.WriteLine("The new file Text.txt was created.");
        }
    }
}
