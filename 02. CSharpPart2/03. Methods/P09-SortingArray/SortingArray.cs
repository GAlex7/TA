// Problem 9. Sorting array

// Write a method that return the maximal element in a portion of array of integers 
// starting at given index.
// Using it write another method that sorts an array in ascending / descending order.


namespace P09_SortingArray
{
    using System;
    using System.Text;

    class SortingArray
    {
        static int MaxFromPos(int[] arr, int pos)
        {
            int res = arr[pos];
            for (int i = pos; i < arr.Length; i++)
            {
                if (arr[i]>res)
                {
                    res = arr[i]; 
                }
            }
            return res;
        }
        static void SortByMaxFromPos(int[] arr)
        {
            int biggest = arr[0];
            for (int i = 0; i < arr.Length-2; i++)
            {
                biggest = MaxFromPos(arr, i);
                arr[Array.IndexOf(arr, biggest)]=arr[i];
                arr[i] = biggest;
            }
        }
        static void Main(string[] args)
        {
            int[] myArr = { 1, 8, 2, 4, 7, 3, 5, 6, 9 };
            Console.Write("Please enter position (between 0 and {0}): ", myArr.Length - 1);
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximal element from pos {0} is {1}.",p,MaxFromPos(myArr,p));

            Console.WriteLine("Sorted array in descending order is:");
            SortByMaxFromPos(myArr);
            Console.WriteLine(String.Join(", ",myArr));
            
            Console.WriteLine("Sorted array in ascending order is:");
            Array.Reverse(myArr);
            Console.WriteLine(String.Join(", ", myArr));
        
        }
    }
}
