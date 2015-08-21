// Problem 6. Four-Digit Number
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// -Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// -Prints on the console the number in reversed order: dcba (in our example 1102).
// -Puts the last digit in the first position: dabc (in our example 1201).
// -Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter a four-digit number in format abcd (e.g. 2011) : ");
        string input = Console.ReadLine();
        short sum = 0;
        short[] nums = new short[4];
        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = short.Parse(input[i].ToString());
            sum += nums[i];
        }
        Console.WriteLine("\nThe sum of the digits is {0}", sum);
        Console.WriteLine("The number in reversed order             : {0}{1}{2}{3}", nums[3], nums[2], nums[1], nums[0]);
        Console.WriteLine("Last digit in the first position         : {0}{1}{2}{3}", nums[3], nums[0], nums[1], nums[2]);
        Console.WriteLine("Exchanged the second and the third digits: {0}{1}{2}{3}", nums[0], nums[2], nums[1], nums[3]);
    }
}