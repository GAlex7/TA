// Problem 7. Replace sub-string

// Write a program that replaces all occurrences of the sub-string "start" with the sub-string "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

namespace P07_ReplaceSubString
{
    using System;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    class ReplaceSubString
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = line.Replace("start","finish");
                    text.AppendLine(line);
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
