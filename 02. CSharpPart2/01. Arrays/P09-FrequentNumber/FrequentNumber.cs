// Problem 9. Frequent number

// Write a program that finds the most frequent number in an array.
// Example:

// input	                                result
// 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter array dimension: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n]; // { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }; // 
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<int> elem = new List<int>();

        elem.Add(arr[0]);

        for (int i = 0; i < arr.Length; i++)
        {
            if (!elem.Contains(arr[i]))
            {
                elem.Add(arr[i]);
            }
        }
        // Console.WriteLine(String.Join(" ", elem));

        int[] count = new int[elem.Count];
        for (int i = 0; i < count.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (elem[i] == arr[j])
                {
                    count[i]++;
                }
            }
        }
        int max = count[0];
        int maxPos = 0;
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > max)
            {
                max = count[i];
                maxPos = i;
            }
        }
        Console.WriteLine("{0} ({1} times)", elem[maxPos], count[maxPos]);
    }
}