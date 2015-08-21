// Problem 6. Maximal K sum

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Please enter array dimension: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter how many elements with max Sum to find: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] sortedArray = new int[n];
        Array.Copy(arr, sortedArray, n);
        Array.Sort(sortedArray);
        //Console.WriteLine(String.Join(", ", arr));
        //Console.WriteLine(String.Join(", ", sortedArray));
        int[] posArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            posArray[i] = Array.IndexOf(arr, sortedArray[i]);
        }
        //Console.WriteLine(String.Join(", ", posArray));
        int result = 0;
        Console.WriteLine();
        for (int i = 0; i < k; i++)
        {
            if (i < k - 1)
            {
                Console.Write("Arr[{0}] + ", posArray[n - i - 1]);
                result += sortedArray[n - i - 1];
            }
            else
            {
                result += sortedArray[n - i - 1];
                Console.WriteLine("Arr[{0}] = {1}", posArray[n - i - 1], result);
            }
        }
    }
}