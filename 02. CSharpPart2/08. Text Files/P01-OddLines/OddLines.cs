// Problem 1. Odd lines

// Write a program that reads a text file and prints on the console its odd lines.

namespace P01_OddLines
{
    using System;
    using System.IO;
  
    class OddLines
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Text.txt")) 
            {
                int counter = 1;
                string line = reader.ReadLine();
                while (line!=null)
                {
                    if (counter%2==1)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}