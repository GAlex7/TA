// Problem 8. Maximal sum

// Write a program that finds the sequence of maximal sum in given array.
// Example:

// input	                                  result
// 2, 3, -6, -1, 2, -1, 6, 4, -8, 8	          2, -1, 6, 4
// Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter array dimension: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n]; //{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int firstPos = 0;
        int lastPos = 0;
        int maxEndingHere = 0;
        int maxSoFar = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (maxEndingHere + arr[i] > 0)
            {
                maxEndingHere += arr[i];
            }
            else
            {
                maxEndingHere = 0;
                firstPos = i + 1;
            }
            if (maxSoFar < maxEndingHere)
            {
                maxSoFar = maxEndingHere;
                lastPos = i;
            }
        }
        Console.WriteLine(String.Join(" ", arr));
        Console.WriteLine("Max sum is {0}", maxSoFar);
        Console.WriteLine("From [{0}] to [{1}]", firstPos, lastPos);
    }
}