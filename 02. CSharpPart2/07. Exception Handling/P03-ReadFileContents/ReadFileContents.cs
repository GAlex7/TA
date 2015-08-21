// Problem 3. Read file contents

// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
// reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

namespace P03_ReadFileContents
{
    using System;
    using System.IO;

    class ReadFileContents
    {
        static void Main()
        {
            Console.WriteLine("Enter a file name along with its full file path: ");
            string fileName = Console.ReadLine();

            string text = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    text = reader.ReadToEnd();
                }
            }
            catch (ArgumentNullException)
            { }
            catch (ArgumentException)
            {
                Console.WriteLine("Incorect file name or path.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error.");
            }
            finally
            {
                Console.WriteLine(text);
            }
        }
    }
}