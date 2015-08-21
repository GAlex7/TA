// Problem 14. Quick sort

// Write a program that sorts an array of strings using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    static void Main(string[] args)
    {
        Console.Write("Please enter array dimension: ");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Arr[{0}]: ", i);
            A[i] = int.Parse(Console.ReadLine());
        }
        quickSort(A, 0, n - 1);
        Console.WriteLine("After quick sort, array is:");
        Console.Write(String.Join(", ", A));
        Console.WriteLine();
    }

    static public int partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
                left++;

            while (arr[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void quickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = partition(arr, left, right);

            if (pivot > 1)
                quickSort(arr, left, pivot - 1);

            if (pivot + 1 < right)
                quickSort(arr, pivot + 1, right);
        }
    }
}