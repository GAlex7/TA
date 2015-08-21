// Problem 5. Third Digit is 7?
// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class IsThirdDigit7
{
    static void Main()
    {
        Console.Write("Please enter an integer : ");
        int num = int.Parse(Console.ReadLine());
        bool isSeven3Digit = (num / 100) % 10 == 7;
        Console.WriteLine("Its third digit from right-to-left is 7  --> {0}.", isSeven3Digit);
    }
}