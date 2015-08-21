// Problem 5. Larger than neighbours

// Write a method that checks if the element at given position
// in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        public static bool IsLargerThanNeighbours(int[] arr, int p)
        {
            bool check = false;
            if (p < 1 && p > arr.Length - 2)
            {
                Console.WriteLine("There isn't neighbours!");
            }
            else if (arr[p] > arr[p - 1] && arr[p] > arr[p + 1])
            {
                check = true;
            }
            return check;
        }
        static void Main(string[] args)
        {
            int pos = 1;
            int[] myArr = { 1, 2, -2, 2, 6, 2, 3, 4, 2, 5 };
            Console.WriteLine("Is {0} larger than neighbours? -> {1}.", myArr[pos], IsLargerThanNeighbours(myArr, pos));
        }
    }
}
