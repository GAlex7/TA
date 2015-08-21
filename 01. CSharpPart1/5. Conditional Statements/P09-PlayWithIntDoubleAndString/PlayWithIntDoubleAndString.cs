// Problem 9. Play with Int, Double and String
// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;
class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.Write("Please enter an int:");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1);
                    break;
                }
            case 2:
                {
                    Console.Write("Please enter a double:");
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter a string:");
                    string word = Console.ReadLine();
                    Console.WriteLine(word + "*");
                    break;
                }
            default:
                {
                    Console.WriteLine("This is not a correct choice!");
                    break;
                }
        }


    }
}