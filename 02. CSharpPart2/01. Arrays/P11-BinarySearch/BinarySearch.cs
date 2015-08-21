// Problem 11. Binary search

// Write a program that finds the index of given element in a sorted array
// of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int[] array = { 1, 2, 4, 6, 7, 8, 9, 10, 13 };
        int key = 4;
        int numFind = binarySearch(array, key, 0, array.Length - 1);
        if (numFind == -1)
            Console.WriteLine("Not Found!");
        else
            Console.WriteLine("Found at pos [{0}].", numFind);
    }
    private static int binarySearch(int[] arr, int key, int iMin, int iMax)
    {
        int iMid;
        if (iMax < iMin)   // test if array is empty
            return -1;     // set is empty, so return value showing not found
        else
            iMid = iMin + (iMax - iMin) / 2;  // calculate midpoint to cut set in half
        // three-way comparison
        if (arr[iMid] > key)
            return binarySearch(arr, key, iMin, iMid - 1);  // key is in lower subset
        else if (arr[iMid] < key)
            return binarySearch(arr, key, iMid + 1, iMax);  // key is in upper subset
        else
            return iMid;   // key has been found
    }
}