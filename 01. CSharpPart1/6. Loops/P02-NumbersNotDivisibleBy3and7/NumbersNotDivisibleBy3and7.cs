// Problem 2. Numbers Not Divisible by 3 and 7
// Write a program that enters from the console a positive integer n and 
// prints all the numbers from 1 to n not divisible by 3 and 7, 
// on a single line, separated by a space.

using System;
class NumbersNotDivisibleBy3and7
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            bool IsNotDivisible= !((i + 1) % 3 == 0 || (i + 1) % 7 == 0);
            if (IsNotDivisible)
            {
                Console.Write("{0} ", i + 1);
            }
        }
    }
}