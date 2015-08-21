// Problem 17.* Subset K with sum S

// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
// Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Please enter array dimension. N= ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter count of elements. K= ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Please enter the sum. S= ");
        int s = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int variants = 2;
        for (int i = 0; i < n - 1; i++)
        {
            variants *= 2;
        }
        string mask;
        int sum;
        int bits;
        bool isSum = false;
        for (int i = 0; i < variants; i++)
        {
            mask = Convert.ToString(i, 2).PadLeft(n, '0');
            sum = 0;
            bits = 0;
            for (int j = 0; j < n; j++)
            {
                if (mask[j] == '1')
                {
                    sum += arr[j];
                    bits++;
                }
            }
            if (sum == s && k == bits)
            {
                Console.WriteLine("Yes! -> {0}", mask);
                isSum = true;
                break;
            }
        }

        if (!isSum)
        {
            Console.WriteLine("No...");
        }

    }
}