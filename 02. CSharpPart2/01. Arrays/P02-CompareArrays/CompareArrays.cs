// Problem 2. Compare arrays
// Write a program that reads two integer arrays from the console and compares them element by element.
 
using System;
class CompareArrays
{
    static void Main(string[] args)
    {
        bool isEqual = true;
        Console.Write("Please enter arrays dimension (int): ");
        int br = int.Parse(Console.ReadLine());
        int[] arr1 = new int[br];
        int[] arr2 = new int[br];
        for (int i = 0; i < br; i++)
        {
            Console.Write("ArrayOne[{0}] = ",i);
            arr1[i] = int.Parse(Console.ReadLine());
            Console.Write("                 ArrayTwo[{0}] = ",i);
            arr2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i]==arr2[i])
            {
                Console.WriteLine("[{0}] elements are equal.",i);
            }
            else
            {
                Console.WriteLine("[{0}] elements are diferent!!!", i);
                isEqual = false;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The arrays are equal is {0}.",isEqual);
    }
}