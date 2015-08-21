// Problem 10. Find sum in array

// Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:

// array	                S	    result
// 4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5

using System;
using System.Collections.Generic;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Please enter array dimension: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n]; 
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter the sum: ");
        int sum = int.Parse(Console.ReadLine());

        

        // Initialize currSum as value of first element and starting position as 0
        int currSum = arr[0];
        int firstPos = 0;

        // Add elements one by one to currSum and 
        // if the currSum exceeds the sum, then remove starting elements
        
        for (int i = 1; i <= n; i++)
        {
            // If currSum exceeds the sum, then remove the starting elements
            while (currSum > sum && firstPos < i - 1)
            {
                currSum = currSum - arr[firstPos];
                firstPos++;
            }

            // If currSum becomes equal to sum, then return answer
            if (currSum == sum)
            {
                Console.WriteLine("Sum found between indexes [{0}] and [{1}]", firstPos, i - 1);
                return;
            }

            // Add this element to currSum
            if (i < n)
                currSum = currSum + arr[i];
        }

        // If we reach here, then no subarray
        Console.WriteLine("There isn't sequence with sum {0}.", sum);

    }
}