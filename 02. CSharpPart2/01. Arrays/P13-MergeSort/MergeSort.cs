// Problem 13.* Merge sort

// Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class MergeSort
{
    static void Main()
    {
        Console.Write("Please enter array dimension: ");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            A[i] = int.Parse(Console.ReadLine());
        }
        int[] B = new int[n];
        TopDownSplitMerge(A, 0, n, B);
        Console.WriteLine(String.Join(", ", A));
    }

    static void TopDownSplitMerge(int[] A, int iBegin, int iEnd, int[] B)
    {
        if (iEnd - iBegin < 2)                       // if run size == 1
            return;                                 //   consider it sorted
        // recursively split runs into two halves until run size == 1,
        // then merge them and return back up the call chain
        int iMiddle = (iEnd + iBegin) / 2;          // iMiddle = mid point
        TopDownSplitMerge(A, iBegin, iMiddle, B);  // split / merge left  half
        TopDownSplitMerge(A, iMiddle, iEnd, B);  // split / merge right half
        TopDownMerge(A, iBegin, iMiddle, iEnd, B);  // merge the two half runs
        CopyArray(B, iBegin, iEnd, A);              // copy the merged runs back to A
    }

    static void TopDownMerge(int[] A, int iBegin, int iMiddle, int iEnd, int[] B)
    {
        int i0 = iBegin, i1 = iMiddle;
        // While there are elements in the left or right runs
        for (int j = iBegin; j < iEnd; j++)
        {
            // If left run head exists and is <= existing right run head.
            if (i0 < iMiddle && (i1 >= iEnd || A[i0] <= A[i1]))
            {
                B[j] = A[i0];
                i0++;
            }
            else
            {
                B[j] = A[i1];
                i1++;
            }
        }
    }

    static void CopyArray(int[] B, int iBegin, int iEnd, int[] A)
    {
        for (int k = iBegin; k < iEnd; k++)
            A[k] = B[k];
    }
}