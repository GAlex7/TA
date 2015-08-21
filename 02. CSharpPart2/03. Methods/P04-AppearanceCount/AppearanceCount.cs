// Problem 4. Appearance count

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_AppearanceCount
{
    class AppearanceCount
    {
        public static int Appears(int[] arr, int x)
        {
            return Array.FindAll(arr, n => n == x).Length;
        }
        static void Main(string[] args)
        {
            int n = 2;
            int[] myArr = { 1, 2, -2, 2, 6, 2, 3, 4, 2, 5 };
            Console.WriteLine("{0} presents {1} times", n, Appears(myArr, n));
        }
    }
}
