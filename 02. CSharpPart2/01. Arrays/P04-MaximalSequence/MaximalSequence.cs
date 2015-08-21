//Problem 4. Maximal sequence

// Write a program that finds the maximal sequence of equal elements in an array.
// Example:
// input	                         result
// 2, 1, 1, 2, 3, 3, 2, 2, 2, 1	     2, 2, 2

using System;
using System.Collections.Generic;
using System.Linq;
class MaximalSequence
{
    static void Main(string[] args)
    {
        int counter = 1;
        Console.Write("Please enter arrays dimension (int): ");
        int br = int.Parse(Console.ReadLine());
        int[] arr1 = new int[br];
        int[] result = new int[br - 1];
        for (int i = 0; i < br; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr1.Length - 1; i++)
        {
            if (arr1[i] == arr1[i + 1])
            {
                counter++;
                result[i] = counter;
            }
            else
            {
                counter = 1;
            }
        }
        counter = result.Max();
        Console.WriteLine("The maximal sequence is:");
        for (int i = 0; i < counter; i++)
        {
            if (i == counter - 1)
            {
                Console.WriteLine(arr1[Array.IndexOf(result, counter) - 1]);
            }
            else
            {
                Console.Write("{0}, ", arr1[Array.IndexOf(result, counter) - 1]);
            }
        }

    }
}