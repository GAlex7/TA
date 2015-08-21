// Problem 4. Binary search

// Write a program, that reads from the console an array of N integers and an integer K,
// sorts the array and using the method Array.BinSearch() finds the largest number 
// in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int[] arr;
        Console.WriteLine("Please enter an arrray of integers on one row (elements separated by space:");
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        arr = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            arr[i] = int.Parse(elements[i]);
        }
        Array.Sort(arr);
        Console.Write("Please enter a number to search: ");
        int k = int.Parse(Console.ReadLine());
        int result = -1;
        do
        {
            result=Array.BinarySearch(arr, k);
            k--;
        } while (result<0);
        Console.WriteLine();
        Console.WriteLine("The biggest number wich is <=k is {0}.",arr[result]);
    }
}