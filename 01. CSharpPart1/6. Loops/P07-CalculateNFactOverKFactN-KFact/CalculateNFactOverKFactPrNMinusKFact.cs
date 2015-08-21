// Problem 7. Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements
// (also known as the number of combinations) is calculated by the following formula: 
// formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k 
// (1 < k < n < 100). Try to use only two loops.

using System;
class CalculateNFactOverKFactPrNMinusKFact
{

    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());
        double numerator = 1, denomerator = 1;

        for (int i = (numN - (numN - numK) + 1); i <= numN; i++)
        {
            numerator *= i;
        }
        for (int i = 1; i <= (numN - numK); i++)
        {
            denomerator *= i;
        }
        Console.WriteLine(numerator / denomerator);
    }
}