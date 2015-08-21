// Problem 2. Concatenate text files

// Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

namespace P02_ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"..\..\TextOne.txt"))
            {
                text.AppendLine(reader.ReadToEnd());
            }

            using (StreamReader reader = new StreamReader(@"..\..\TextTwo.txt"))
            {
                text.Append(reader.ReadToEnd());
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\Text.txt"))
            {
                writer.Write(text.ToString());
            }
            Console.WriteLine("The new file Text.txt was created.");
        }
    }
}
