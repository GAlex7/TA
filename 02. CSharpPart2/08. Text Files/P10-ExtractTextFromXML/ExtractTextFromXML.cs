// Problem 10. Extract text from XML

// Write a program that extracts from given XML file all the text without the tags.
// Example:

// <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
// <interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

namespace P10_ExtractTextFromXML
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Text;

    class ExtractTextFromXML
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    text.AppendLine(RemoveTags(line));
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(text.ToString());
            }
            Console.WriteLine("The problem is solved and result is in new file -> output.txt .");
        }

        private static string RemoveTags(string line)
        {
            int startPos = line.IndexOf('<');
            int len = line.IndexOf('>', startPos + 1) - startPos + 1;
            while (startPos != -1)
            {
                line = line.Remove(startPos, len);
                line = line.Insert(startPos, " ");
                startPos = line.IndexOf('<');
                if (startPos != -1)
                {
                    len = line.IndexOf('>', startPos + 1) - startPos + 1;
                }
            }
            return string.Join("\r\n",line.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries));
        }
    }
}