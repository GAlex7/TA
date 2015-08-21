// Problem 5. Sort by string length

// You are given an array of strings. 
// Write a method that sorts the array by the length of its elements 
// (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Please enter an arrray of strings on one row (elements separated by space):");
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        SortByStrLength(elements);
        Console.WriteLine("Sorted array by length is:");
        Console.WriteLine(String.Join(", ", elements));
    }

    private static void SortByStrLength(string[] elements)
    {
        Array.Sort(elements, (x, y) => x.Length.CompareTo(y.Length));
    }
}