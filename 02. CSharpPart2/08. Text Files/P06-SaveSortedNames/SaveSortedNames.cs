// Problem 6. Save sorted names

// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
// Example:

// input.txt	output.txt
// Ivan         George 
// Peter        Ivan 
// Maria        Maria 
// George	    Peter

namespace P06_SaveSortedNames
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Text;
    
    class SaveSortedNames
    {
        static void Main()
        {
            List<string> text = new List<string>();
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    text.Add(line);
                    line = reader.ReadLine();
                }
            }

            text.Sort();
            
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                foreach (var str in text)
                {
                    writer.WriteLine(str.ToString());
                }
            }
            Console.WriteLine("The problem is solved and result is in new file -> output.txt .");
        }
    }
}
