// Problem 7. Selection sort

// Sorting an array means to arrange its elements in increasing order.
// Write a program to sort an array.
// Use the Selection sort algorithm:
// Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
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
        int posOfMin;
        int swap;
        for (int i = 0; i < n; i++)
        {
            posOfMin = i;
            for (int j = i; j < n; j++)
            {
                if (arr[posOfMin] > arr[j])
                {
                    posOfMin = j;
                }
            }
            if (i != posOfMin)
            {
                swap = arr[i];
                arr[i] = arr[posOfMin];
                arr[posOfMin] = swap;
            }
        }
        Console.WriteLine(String.Join(", ", arr));
    }
}