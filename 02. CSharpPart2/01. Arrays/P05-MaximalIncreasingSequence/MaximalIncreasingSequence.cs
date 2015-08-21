// Problem 5. Maximal increasing sequence

// Write a program that finds the maximal increasing sequence in an array.
// Example:

// input	                result
// 3, 2, 3, 4, 2, 2, 4	    2, 3, 4

using System;
using System.Collections.Generic;
using System.Linq;
class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        Console.Write("Please enter arrays dimension (int): ");
        int br = int.Parse(Console.ReadLine());
        int[] arr = new int[br];
        // filling array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        // finding the length of longest sequence
        bool check;
        int[] len = new int[arr.Length];
        int max, prev = 0;
        for (int x = 0; x < arr.Length; x++)
        {
            check = false;
            max = 0;
            for (int i = 0; i < x; i++)
            {
                if (len[i] > max && arr[i] < arr[x])
                {
                    prev = i;
                    max = len[i];
                    check = true;
                }
            }
            if (check)
            {
                len[x] = 1 + len[prev];
            }
            else
            {
                len[x] = 1;
            }
        }

        // find max lenght position
        max = len[0];
        int pos = 0;
        for (int i = 1; i < len.Length; i++)
        {
            if (len[i] > max)
            {
                pos = i;
                max = len[i];
            }
        }

        // creating result array
        int[] result = new int[len[pos]];
        int nextPos = len[pos] - 1;
        result[nextPos] = arr[pos];
        nextPos--;
        prev = pos;
        for (int i = pos - 1; i >= 0; i--)
        {
            if (len[i] + 1 == len[prev])
            {
                result[nextPos] = arr[i];
                prev = i;
                nextPos--;
            }
        }

        // output 
        Console.WriteLine("The maximal increasing sequence from");
        Console.WriteLine(String.Join(", ", arr));
        Console.WriteLine("is:");
        Console.WriteLine(String.Join(", ", result));
    }
}