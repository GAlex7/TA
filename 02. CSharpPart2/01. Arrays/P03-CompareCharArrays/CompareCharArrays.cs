// Problem 3. Compare char arrays

// Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class CompareCharArrays
{
    static void Main(string[] args)
    {
        bool isEqual = true;
        Console.Write("Please enter char arrays dimension (int): ");
        int br = int.Parse(Console.ReadLine());
        char[] arr1 = new char[br];
        char[] arr2 = new char[br];
        for (int i = 0; i < br; i++)
        {
            Console.Write("ArrayOne[{0}] = ",i);
            arr1[i] = char.Parse(Console.ReadLine());
            Console.Write("         ArrayTwo[{0}] = ",i);
            arr2[i] = char.Parse(Console.ReadLine());
            Console.WriteLine();
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