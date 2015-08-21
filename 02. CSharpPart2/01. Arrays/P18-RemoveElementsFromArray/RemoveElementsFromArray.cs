// Problem 18.* Remove elements from array

// Write a program that reads an array of integers and removes from it 
// a minimal number of elements in such a way that the remaining array is 
// sorted in increasing order.
// Print the remaining sorted array.
// Example:

// input	                    result
// 6, 1, 4, 3, 0, 3, 6, 4, 5	1, 3, 3, 4, 5

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsFromArray
{
    static void Main()
    {
        //Console.WriteLine("Please enter an array of inetegers on a single line where elements are separated by space:");
        string input = " 6   1  4  3  0  3   6  4   5 "; // Console.ReadLine();
        string[] arrStr = input.Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries);
        //int[] arr = new int[arrStr.Length];
        int[] arr = new int[arrStr.Length];
        for (int i = 0; i < arrStr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
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
                if (len[i] > max && arr[i] <= arr[x])
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
        Console.WriteLine("The maximal sorted sequence from");
        Console.WriteLine(String.Join(", ", arr));
        Console.WriteLine("is:");
        Console.WriteLine(String.Join(", ", result));
    }
}