// Problem 8. Digit as Word
// Write a program that asks for a digit (0-9), and depending on the input, 
// shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

using System;
using System.Globalization;
using System.Threading;
class DigitAsWord
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        string[] numWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "not a digit" };
        float num = float.Parse(Console.ReadLine().Replace('.', ','));
        if (num * 10 % 10 != 0)
        {
            Console.WriteLine(numWords[10]);
        }
        else
        {
            switch ((byte)num)
            {
                case 0:
                    {
                        Console.WriteLine(numWords[0]);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine(numWords[1]);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(numWords[2]);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(numWords[3]);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(numWords[4]);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(numWords[5]);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(numWords[6]);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine(numWords[7]);
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine(numWords[8]);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine(numWords[9]);
                        break;
                    }

                default:
                    {
                        Console.WriteLine(numWords[10]);
                        break;
                    }
            }
        }

    }
}