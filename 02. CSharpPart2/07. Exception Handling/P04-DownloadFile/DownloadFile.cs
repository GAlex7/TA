// Problem 4. Download file

// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

namespace P04_DownloadFile
{
    using System;
    using System.Net;
    //using System.IO;

    class DownloadFile
    {
        static void Main()
        {
            WebClient webClient = new WebClient();
            Console.WriteLine("Enter a file name along with its full URL: ");
            string fileURL = Console.ReadLine();

            string fileName = fileURL.Substring(fileURL.LastIndexOf('/') + 1);
            fileName = fileName.Insert(0, @"..\..\");

            try
            {
                webClient.DownloadFile(fileURL, fileName);
            }
            catch (WebException)
            {
                Console.WriteLine("Something wrong...");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("File not supported.");
            }
        }
    }
}
