// Problem 6. First larger than neighbours

// Write a method that returns the index of the first element in array 
// that is larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.


namespace FirstLargerThanNeighbours
{
    using System;

    class Program
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
        static int IndexFirstElement(int[] arr)
        {
            int index = -1;
            int i = 1;
            while (i < arr.Length - 1)
            {
                if (IsLargerThanNeighbours(arr, i))
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 3, 2, 5, 6, 7, 8 };
            Console.WriteLine(IndexFirstElement(myArray));
        }
    }
}
