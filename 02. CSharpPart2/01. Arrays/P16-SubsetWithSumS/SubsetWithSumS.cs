// Problem 16.* Subset with sum S

// We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S.
// Example:

// input array	            S	result
// 2, 1, 2, 4, 3, 5, 2, 6	14	yes

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetWithSumS
{
    static void Main(string[] args)
    {
        Console.Write("Please enter array dimension: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr =new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter the sum S= ");
        int s = int.Parse(Console.ReadLine());

        int variants = 2;
        for (int i = 0; i < n - 1; i++)
        {
            variants *= 2;
        }
        string mask;
        int sum;
        bool isSum = false;
        for (int i = 0; i < variants; i++)
        {
            mask = Convert.ToString(i, 2).PadLeft(n, '0');
            sum = 0;
            for (int j = 0; j < n; j++)
            {
                if (mask[j] == '1')
                {
                    sum += arr[j];
                }
            }
            if (sum == s)
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